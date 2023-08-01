using Reciplas.Data;
using Radzen;
using Blazored.Modal;
using Reciplas.Clases;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Reciplas.Repositorio;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;


var builder = WebApplication.CreateBuilder(args); 

builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
    options.UseSqlServer("Data Source=localhost\\sqlexpress;Initial Catalog=PedroBar;Integrated Security=True;Persist Security Info=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Connection Timeout=30;"));
System.Net.ServicePointManager.SecurityProtocol = 
    System.Net.SecurityProtocolType.Tls12;
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//aca
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();
builder.Services.AddBlazoredModal();   
builder.Services.AddControllers(); 
builder.Services.AddHttpClient();
//aca


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton(new HttpClient{
        BaseAddress = new Uri("https://localhost:44331/")
        });


builder.Services.AddScoped<IRepositorioCompras, RepositorioCompras>();
builder.Services.AddScoped<IRepositorioVentas, RepositorioVentas>();
builder.Services.AddScoped<IRepositorioProductos, RepositorioProductos>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.MapBlazorHub();
app.MapControllers();
app.MapFallbackToPage("/_Host");

app.Run();
