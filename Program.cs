using Microsoft.EntityFrameworkCore;
using MyCourse_Custom.Models.Options;
using MyCourse_Custom.Models.Services.Application;
using MyCourse_Custom.Models.Services.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Aggiungi ApplicationDBContext ai servizi configurando anche la stringa di connessione 
builder.Services.AddDbContext<ApplicationDbContext>(options => {
    string connectionString = builder.Configuration.GetSection("ConnectionStrings")
                            .GetValue<string>("Default");
    options.UseSqlServer(connectionString);
});

// Leggi le configurazioni e applicale agli oggetti configuration
// Questo ha l'obiettivo di rendere le configuration fortemente tipizzate
builder.Services.Configure<JobsOptions>(builder.Configuration.GetSection("Jobs"));

builder.Services.AddTransient<IJobService, EfCoreJobService>();

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
