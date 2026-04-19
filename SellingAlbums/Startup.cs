using Microsoft.EntityFrameworkCore;
using SellingAlbums.Context;
using SellingAlbums.Models;
using SellingAlbums.Repositories;
using SellingAlbums.Repositories.Interfaces;

namespace SellingAlbums;
public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    // It configures the services of the application.
    public void ConfigureServices(IServiceCollection services)
    {
        // Registers the AppDbContext as a service setting SQL Server as the database provider
        // and using the connection string defined in appsettings.json
        // Lifetime Scoped: For each request there will be a new service instance created for AppDbContext
        // and the instance can be injected into the controllers that need it.
        services.AddDbContext<AppDbContext>(options => 
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        services.AddTransient<IAlbumRepository, AlbumRepository>();
        services.AddTransient<IArtistRepository, ArtistRepository>();
        services.AddTransient<IGenreRepository, GenreRepository>();
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddScoped(sc => ShoppingCart.GetCart(sc));

        services.AddControllersWithViews();

        services.AddMemoryCache();
        services.AddSession();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    // It configures the pipeline of processors that handle HTTP requests and responses.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();
        app.UseSession();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            // Definition of the default mapping used by ASP.NET application
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}