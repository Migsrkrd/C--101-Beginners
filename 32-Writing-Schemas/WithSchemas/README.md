## Creating a Restful API with Schemas in C# and .NET Core 8.0

This is a simple example of how to create a Restful API with Schemas in C# and .NET Core 8.0.

## Prerequisites

- .NET Core 8.0
- Visual Studio Code
- C# for Visual Studio Code

## Getting Started

First we need to create a new project. Open a terminal and run the following command:

```bash
dotnet new webapi -n WithSchemas
```

This will create a new project called `WithSchemas` with the structure of a webapi.

Now we need to install the `Swashbuckle.AspNetCore` package. Run the following command:

```bash
dotnet add package Swashbuckle.AspNetCore
```

This will install the `Swashbuckle.AspNetCore` package and add it to the `WithSchemas.csproj` file.

You should have a `Startup.cs` file in the root of your project. It should look like this:

```csharp
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WithSchemas
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
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

We need to add the `Swashbuckle.AspNetCore` package to the `ConfigureServices` method. It should look like this:

```csharp
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace WithSchemas
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WithSchemas", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "WithSchemas v1");
                c.RoutePrefix = string.Empty;
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
```

Now we need to create a new folder called `Models` in the root of the project. Inside this folder we need to create a new file called `Person.cs`. It should look like this:

```csharp
namespace WithSchemas.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
```

lets make another model called `Address.cs`:

```csharp
namespace WithSchemas.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
```

Now we need to create a new folder called `Controllers` in the root of the project. Inside this folder we need to create a new file called `PersonController.cs`. It should look like this:

```csharp
using Microsoft.AspNetCore.Mvc;
using WithSchemas.Models;

namespace WithSchemas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Person> Get()
        {
            return new Person { Name = "John Doe", Age = 30 };
        }
    }
}
```

lets make another controller called `AddressController.cs`:

```csharp
using Microsoft.AspNetCore.Mvc;
using WithSchemas.Models;

namespace WithSchemas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Address> Get()
        {
            return new Address { Street = "123 Main St", City = "Anytown", State = "NY", Zip = "12345" };
        }
    }
}
```

Now we need to update our Program.cs file to use the `Startup` class. It should look like this:

```csharp
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace WithSchemas
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

Now lets change the endpoint for accessing the swagger index page. In the `Startup.cs` file, change the `c.RoutePrefix` to `/swagger`:

```csharp
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "WithSchemas v1");
    c.RoutePrefix = "swagger";
});
```

Now we can run the project. Open a terminal and run the following command:

```bash
dotnet run
```

Open a web browser and navigate to `https://localhost:5001/swagger`. You should see the swagger index page with the `Person` and `Address` schemas.

### Creating CRUD Operations

Now we need to create CRUD operations for the `Person` and `Address` schemas. We need to update the `PersonController.cs` file to look like this:

```csharp

using Microsoft.AspNetCore.Mvc;
using WithSchemas.Models;
using System.Collections.Generic;

namespace WithSchemas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private static List<Person> _people = new List<Person>
        {
            new Person { Name = "John Doe", Age = 30 },
            new Person { Name = "Jane Doe", Age = 25 }
        };

        [HttpGet]
        public ActionResult<List<Person>> Get()
        {
            return _people;
        }

        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            return _people[id];
        }

        [HttpPost]
        public ActionResult<Person> Post(Person person)
        {
            _people.Add(person);
            return person;
        }

        [HttpPut("{id}")]
        public ActionResult<Person> Put(int id, Person person)
        {
            _people[id] = person;
            return person;
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _people.RemoveAt(id);
            return Ok();
        }
    }
}
```

Now we need to update the `AddressController.cs` file to look like this:

```csharp
using Microsoft.AspNetCore.Mvc;
using WithSchemas.Models;
using System.Collections.Generic;

namespace WithSchemas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private static List<Address> _addresses = new List<Address>
        {
            new Address { Street = "123 Main St", City = "Anytown", State = "NY", Zip = "12345" },
            new Address { Street = "456 Elm St", City = "Othertown", State = "CA", Zip = "67890" }
        };

        [HttpGet]
        public ActionResult<List<Address>> Get()
        {
            return _addresses;
        }

        [HttpGet("{id}")]
        public ActionResult<Address> Get(int id)
        {
            return _addresses[id];
        }

        [HttpPost]
        public ActionResult<Address> Post(Address address)
        {
            _addresses.Add(address);
            return address;
        }

        [HttpPut("{id}")]
        public ActionResult<Address> Put(int id, Address address)
        {
            _addresses[id] = address;
            return address;
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _addresses.RemoveAt(id);
            return Ok();
        }
    }
}
```

Now we can run the project. Open a terminal and run the following command:

```bash
dotnet run
```

Open a web browser and navigate to `https://localhost:5001/swagger`. You should see the swagger index page with the `Person` and `Address` schemas and CRUD operations.

Test the CRUD operations and make sure they work as expected.

## Connecting an Address to a Person

Now we need to connect an `Address` to a `Person`. We need to update the `Person.cs` file to look like this:

```csharp
namespace WithSchemas.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
    }
}
```

in a Get request this will return the object like this:

```json
{
  "name": "John Doe",
  "age": 30,
  "address": {
    "street": "123 Main St",
    "city": "Anytown",
    "state": "NY",
    "zip": "12345"
  }
}
```

Now we need to update the `PersonController.cs` file to look like this:

```csharp
using Microsoft.AspNetCore.Mvc;
using WithSchemas.Models;
using System.Collections.Generic;

namespace WithSchemas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private static List<Person> _people = new List<Person>
        {
            new Person { Name = "John Doe", Age = 30, Address = new Address { Street = "123 Main St", City = "Anytown", State = "NY", Zip = "12345" } },
            new Person { Name = "Jane Doe", Age = 25, Address = new Address { Street = "456 Elm St", City = "Othertown", State = "CA", Zip = "67890" } }
        };

        [HttpGet]
        public ActionResult<List<Person>> Get()
        {
            return _people;
        }

        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            return _people[id];
        }

        [HttpPost]
        public ActionResult<Person> Post(Person person)
        {
            _people.Add(person);
            return person;
        }

        [HttpPut("{id}")]
        public ActionResult<Person> Put(int id, Person person)
        {
            _people[id] = person;
            return person;
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _people.RemoveAt(id);
            return Ok();
        }
    }
}
```

You'll notice there are CRUD actions using the `id` even though we do not declare the `id` in the `Person` class. This is because the `id` is automatically generated by the `List` class.

Now what if we wanted to connect this code to a front end? We could use a front end framework like Angular, React, or Vue.js. We could also use a mobile framework like React Native or Flutter. We could also use a desktop framework like Electron or WPF. This will all be covered in the next section.

## Conclusion

In this example we created a Restful API with Schemas in C# and .NET Core 8.0. We created a `Person` and `Address` schema and connected them to CRUD operations. We also connected an `Address` to a `Person`. We also discussed how to connect this code to a front end. This is a simple example of how to create a Restful API with Schemas in C# and .NET Core 8.0.



