using Microsoft.EntityFrameworkCore;
using MVCApp.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=Index}/{id?}"
);

app.Run();
