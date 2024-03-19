## Using a MySQL Database with ASP.NET Core Web API Server

In this section, we will learn how to use a MySQL database with the server we just created.

### Create a new MySQL database

First, we need to create a new MySQL database. Open the MySQL Workbench and create a new database. For this example, we will create a database called `testdb`.

```sql
DROP DATABASE IF EXISTS testdb;
CREATE DATABASE testdb;
```

Then, create a new table called `users` in the `testdb` database.

```sql
USE testdb;

CREATE TABLE users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100),
    email VARCHAR(100)
);
```

### Step 1: Install the MySQL Connector

First, we need to install the MySQL Connector for .Net Core. Open the terminal under the project directory and run the following command:

```bash
dotnet add package MySql.Data
```

This command will install the MySQL Connector for .Net Core in the project.

### Step 2: Create a new class for the database

Since there is no `Data` directory in the project, we need to create one. Open the terminal and run the following command:

```bash
mkdir Data
```

Then, create a new file called `MySqlDatabase.cs` in the `Data` directory and add the following code:

```csharp
using System;
using MySql.Data.MySqlClient;

namespace MySql.Data
{
    public class MySqlDatabase
    {
        public MySqlConnection Connection { get; }

        public MySqlDatabase(string connectionString)
        {
            Connection = new MySqlConnection(connectionString ?? throw new ArgumentNullException(nameof(connectionString)));
        }

        public void Open()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public void Close()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}
```

### Step 3: Add the database connection string to the `appsettings.json` file

Open the `appsettings.json` file and add the following connection string:
(note if there is no `ConnectionStrings` section in the file, you will have to create one under the `Logging` section)

```json
{
  "ConnectionStrings": {
    "MySql": "Server=localhost;Database=your_database_name;Uid=your_username;Pwd=your_password;"
  }
}
```

Replace `your_database_name`, `your_username`, and `your_password` with the actual values for your MySQL database. You can find these values in the MySQL Workbench.

To find the `your_database_name`, `your_username`, and `your_password` values, open the MySQL Workbench and click on the `Local instance MySQL80` connection. Then, click on the `Users and Privileges` tab under the Administration section. You will find the `your_username` and `your_password` values there. The `your_database_name` value is the name of the database you created earlier.

If you are using the default settings, the `your_username` value is `root` and the `your_password` value is the password you set when you installed MySQL.

### Step 4: Create a new class for the user model

Create a new file called `User.cs` in the `Models` directory and add the following code:

```csharp
namespace MySql.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
    }
}
```

### Step 5: Create a new class for the user repository

Create a new file called `UserRepository.cs` in the `Data` directory and add the following code:

```csharp
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MySql.Data
{
    public class UserRepository
    {
        private readonly MySqlDatabase _database;

        public UserRepository(MySqlDatabase database)
        {
            _database = database;
        }

        public List<User> GetAll()
        {
            _database.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users", _database.Connection);
            MySqlDataReader reader = command.ExecuteReader();

            List<User> users = new List<User>();

            while (reader.Read())
            {
                User user = new User
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    Email = reader.GetString("email")
                };

                users.Add(user);
            }

            reader.Close();
            _database.Close();

            return users;
        }

        public User? GetById(int id)
        {
            _database.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE id = @id", _database.Connection);
            command.Parameters.AddWithValue("@id", id);

            MySqlDataReader reader = command.ExecuteReader();

            User? user = null;

            if (reader.Read())
            {
                user = new User
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    Email = reader.GetString("email")
                };
            }

            reader.Close();
            _database.Close();

            return user;
        }

        public void Add(User user)
        {
            _database.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO users (name, email) VALUES (@name, @email)", _database.Connection);
            command.Parameters.AddWithValue("@name", user.Name);
            command.Parameters.AddWithValue("@email", user.Email);

            command.ExecuteNonQuery();

            _database.Close();
        }

        public void Update(User user)
        {
            _database.Open();

            MySqlCommand command = new MySqlCommand("UPDATE users SET name = @name, email = @email WHERE id = @id", _database.Connection);
            command.Parameters.AddWithValue("@name", user.Name);
            command.Parameters.AddWithValue("@email", user.Email);
            command.Parameters.AddWithValue("@id", user.Id);

            command.ExecuteNonQuery();

            _database.Close();
        }

        public void Delete(int id)
        {
            _database.Open();

            MySqlCommand command = new MySqlCommand("DELETE FROM users WHERE id = @id", _database.Connection);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();

            _database.Close();
        }
    }
}
```

### Step 6: Use the user repository in the Controller Folder

This Controller file will be used to interact with the database. If you want a Controller for the front-end, that one will be separate from this one.

Create a new file called `UserController.cs` in the `Controllers` directory and add the following code:

```csharp

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data;

namespace MySql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserRepository _repository;

        public UsersController(MySqlDatabase database)
        {
            _repository = new UserRepository(database);
        }

        [HttpGet]
        public ActionResult<List<User>> GetAll()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            var user = _repository.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            _repository.Add(user);

            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _repository.Update(user);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);

            return NoContent();
        }
    }
}
```

### Step 7: Register the database and the user repository in the `Startup.cs` file

Open the `Startup.cs` file and add the following code to the `ConfigureServices` method:

```csharp
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MySql.Data;

namespace MySql
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<MySqlDatabase>(_ => new MySqlDatabase(Configuration.GetConnectionString("MySql")!));
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
```

### Step 8: Make sure your server is updated

Your Program.cs should look like this:

```csharp
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace MySql
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
```

### Step 9: Run the server

Run the server using the following command:

```bash
dotnet run
```

Now, you can use the server to interact with the MySQL database. For example, you can use insomnia like below to post a new user to the database:



![Insomnia Post](<MySql/assets/Screenshot 2024-03-18 150235.png>)