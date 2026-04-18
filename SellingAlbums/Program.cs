namespace SellingAlbums;

public class Program
{
    // Entry point of the application
    // It sets up and starts the ASP.NET Core application
    public static void Main(string[] args)
    {
        // Returns an object that implements the IHostBuilder interface
        CreateHostBuilder(args)
           .Build()
           .Run();
    }

    // Configures a host for the ASP.NET Core application using the default settings
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        // Static Class Host is used to create an IHostBuilder instance
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}
