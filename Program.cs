using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Liftoff.Data;
using Liftoff.Models;

var builder = WebApplication.CreateBuilder(args);

// Adicionar serviços MVC
builder.Services.AddControllersWithViews();

// String de ligação ao PostgreSQL
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Configurar DbContext com PostgreSQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));

// Configurar Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.Password.RequiredLength = 6;
    options.SignIn.RequireConfirmedAccount = false;
})
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders();


// Cookies (configuração login)
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.LogoutPath = "/Account/Logout";
});


var app = builder.Build();

// Configuração do pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// Servir ficheiros estáticos da pasta wwwroot
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Rotas MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();