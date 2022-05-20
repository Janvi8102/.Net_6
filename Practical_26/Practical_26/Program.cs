using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Practical_26.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Practical_26Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Practical_26Context") ?? throw new InvalidOperationException("Connection string 'Practical_26Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
