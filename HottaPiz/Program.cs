using HottaPiz.DataLayer.Context;
using HottaPiz.DataLayer.Repositories.Implementations;
using HottaPiz.DataLayer.Repositories.Interfaces;
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

#endregion

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
