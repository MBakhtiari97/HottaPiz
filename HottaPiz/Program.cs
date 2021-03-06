using System.Security.Claims;
using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using HottaPiz.DataLayer.Context;
using HottaPiz.DataLayer.Repositories.Implementations;
using HottaPiz.DataLayer.Repositories.Interfaces;
using HottaPiz.Infrastructure.Services.Implementations;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
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
builder.Services.AddScoped<IPizzaServices,PizzaServices>();
builder.Services.AddScoped<IOrderServices,OrderServices>();

#endregion

#region Application Address

builder.Configuration["Address"] = "https://localhost:44394/";

#endregion

#region Authentication Settings

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
}).AddCookie(options =>
{
    options.LoginPath = "/Login";
    options.LogoutPath = "/Logout";
    options.ExpireTimeSpan = TimeSpan.FromDays(30);
});

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

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor |
                       ForwardedHeaders.XForwardedProto
});


app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseNotyf();

app.UseAuthentication();

app.UseAuthorization();

app.Use(async (context, next) =>
{
    if (context.Request.Path.StartsWithSegments("/Admin"))
    {
        if (!context.User.Identity.IsAuthenticated || !bool.Parse(context.User.FindFirstValue("IsAdmin")))
        {
            context.Response.Redirect("/Login");
        }
    }

    await next.Invoke();
});

app.MapRazorPages();

app.Run();
