using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProtoDEV___Proyecto_Programacion.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using DevExpress.Xpo;
using Abp.Domain.Uow;
using ProtoDEV___Proyecto_Programacion.Models.Utilidades;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProtoDEV___Proyecto_ProgramacionContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProtoDEV___Proyecto_ProgramacionContext") ?? throw new InvalidOperationException("Connection string 'ProtoDEV___Proyecto_ProgramacionContext' not found.")));

builder.Services.AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStores<ProtoDEV___Proyecto_ProgramacionContext>().AddDefaultTokenProviders();
builder.Services.AddRazorPages();
builder.Services.AddScoped<IEmailSender, EmailSender>();

// Add services to the container.
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
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
