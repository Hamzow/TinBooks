using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using TinBooks.Models;
using TinBooks.Models.Repositories;
using TinBooks.Views.Book;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // Lägg till MVC
builder.Services.AddScoped<IBookstoreRepository<Author>, AuthorDbRepository>(); // Lägg till repository
builder.Services.AddScoped<IBookstoreRepository<Book>, BookDbRepository>(); // Lägg till repository
builder.Services.AddDbContext<BookstoreDbContext>(options =>
{
    options.UseSqlite("Data Source=authors.db"); // SQLite databas
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options => options.LoginPath = "/Account/Index"); // Specifika inloggningsvägen

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); 
app.UseAuthorization(); // Lägg till auktorisering här

// Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();