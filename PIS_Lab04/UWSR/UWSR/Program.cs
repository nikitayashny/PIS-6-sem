using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UWSR.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddSession();


        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));


        builder.Services.AddRazorPages();
        builder.Services.AddControllersWithViews();
        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseSession();

        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Link}/{action=Index}/{id?}");

        app.MapRazorPages();


        app.Run();
    }
}