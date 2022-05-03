using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DorsetCollegeOnlineStore.Data;
using DorsetCollegeOnlineStore.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DorsetCollegeOnlineStoreContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DorsetCollegeOnlineStoreContext") ?? throw new InvalidOperationException("Connection string 'DorsetCollegeOnlineStoreContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

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

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();