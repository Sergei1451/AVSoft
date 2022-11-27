using Microsoft.EntityFrameworkCore;
using TestAVSoftClear.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));//Подключение класса ApplicationContext в качестве сервиса с помощью DependencyInjection(Пункт №1 ТЗ)
builder.Services.AddTransient<DataProvider>();//Подключение класса DataProvider в качестве сервиса с помощью DependencyInjection(Пункт №2 ТЗ)
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseRouting();

app.MapRazorPages();
app.MapControllerRoute(
    name: "Default",
    pattern: "{controller}/{action=Index}/{id?}");

app.Run();
