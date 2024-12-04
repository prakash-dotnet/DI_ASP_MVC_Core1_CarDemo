using DI_ASP_MVC_Core1_CarDemo.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Dependency Injection happened here
builder.Services.AddScoped<IEngine, ElectricEngine>();
//builder.Services.AddScoped<IEngine, PetrolEngine>();
//builder.Services.AddScoped<IEngine,DieselEngine>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Car}/{action=Index}/{id?}");

app.Run();
