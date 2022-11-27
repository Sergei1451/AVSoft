using Microsoft.EntityFrameworkCore;
using TestAVSoftClear.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));//����������� ������ ApplicationContext � �������� ������� � ������� DependencyInjection(����� �1 ��)
builder.Services.AddTransient<DataProvider>();//����������� ������ DataProvider � �������� ������� � ������� DependencyInjection(����� �2 ��)
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseRouting();

app.MapRazorPages();
app.MapControllerRoute(
    name: "Default",
    pattern: "{controller}/{action=Index}/{id?}");

app.Run();
