using Mediplus_DAL.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var ConnectionStrings = builder.Configuration.GetConnectionString("MSSql");
builder.Services.AddDbContext<MediplusDbContext>(option => option.UseSqlServer(ConnectionStrings));
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();