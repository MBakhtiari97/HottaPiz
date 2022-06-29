using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using HottaPiz.DataLayer.Context;
using HottaPiz.DataLayer.Repositories.Implementations;
using HottaPiz.DataLayer.Repositories.Interfaces;
using HottaPiz.Infrastructure.Services.Implementations;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

#region Context

builder.Services.AddDbContext<HottaPizContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("HottaPizConnection"));
});


#endregion

#region IoC

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<ICustomerServices,CustomerServices>();

#endregion

builder.Services.AddNotyf(config => { config.DurationInSeconds = 5; config.IsDismissable = true; config.Position = NotyfPosition.TopRight; });

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

app.UseNotyf();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
