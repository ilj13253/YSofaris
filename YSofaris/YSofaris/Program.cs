/*
using Microsoft.EntityFrameworkCore;
using SofariDb;
var builder = WebApplication.CreateBuilder(args);
string conn = builder.Configuration.GetConnectionString("SOFARIdb");
// Add services to the container.
builder.Services.AddDbContext<SOFARIDB>(options => options.UseSqlServer());
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
*/
using Microsoft.EntityFrameworkCore;
using SofariDb;

var builder = WebApplication.CreateBuilder(args);
string conn = builder.Configuration.GetConnectionString("SOFARIdb");  // Correct key

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SOFARIDB>(options => options.UseSqlServer(conn));  // Pass connection string

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
