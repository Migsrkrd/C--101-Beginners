## Creating a Server Web API with .Net Core

In this section, we will create a simple web API server using .Net Core. We will use the `dotnet` command line tool to create a new project and then use Visual Studio Code to edit the code.

### Prerequisites

- .Net Core SDK
- Visual Studio Code

### Step 1: Create a new project

Open a terminal and navigate to the directory where you want to create the project. Then run the following command to create a new web API project:

```bash
dotnet new webapi -n YourProjectName
```

Replace `YourProjectName` with the name you want to give to your project.

### Step 2: Open the project in Visual Studio Code

Navigate to the project directory and open it in Visual Studio Code:

```bash
cd YourProjectName
code .
```

### Step 3: Run the project

Open a terminal in Visual Studio Code and run the following command to start the server:

```bash
dotnet run
```

You should see a message saying that the server is running on a specific port. Open a web browser and navigate to `http://localhost:5001/weatherforecast` to see the default response from the server.

### Step 4: Create a new endpoint

There is no Controller folder in the project. So, we will create a new folder called `Controllers` in the project directory. Then, create a new file called `HelloController.cs` inside the `Controllers` folder with the following content:

```csharp
using Microsoft.AspNetCore.Mvc;

namespace YourProjectName.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello, World!";
        }
    }
}
```

However this wont work because the `HelloController` class is not being used by the server. Since there is no `Startup.cs` file in the project, we will have to create one. Create a new file called `Startup.cs` in the project directory with the following content:

```csharp
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace YourProjectName
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

Now, we need to tell the server to use the `Startup` class. Open the `Program.cs` file in the project directory and replace the content with the following:

```csharp

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace YourProjectName
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

Now, the server should be able to use the `HelloController` class. Restart the server by pressing `Ctrl+C` in the terminal and then running `dotnet run` again. Open a web browser and navigate to `http://localhost:5001/hello` to see the response from the new endpoint.

### Step 5: Test the new endpoint

Restart the server by pressing `Ctrl+C` in the terminal and then running `dotnet run` again. Open a web browser and navigate to `http://localhost:5001/hello` to see the response from the new endpoint.

### Using a MySQL Database

In the next section, we will learn how to use a MySQL database with the server we just created.

---

## Summary

In this section, we created a simple web API server using .Net Core. We used the `dotnet` command line tool to create a new project and then used Visual Studio Code to edit the code. We also learned how to create a new endpoint and test it in a web browser.


