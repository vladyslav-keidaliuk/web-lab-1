using Microsoft.EntityFrameworkCore;
using WEB_Lab_1.Models;

var builder = WebApplication.CreateBuilder(args);





builder.Services.AddTransient<IDataRepository, EFDataRepository>();

builder.Services.AddDbContext<EFDatabaseContext>(op=>
    op.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=List}"
);

app.Run();