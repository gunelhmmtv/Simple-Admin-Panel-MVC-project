using Microsoft.EntityFrameworkCore;
using ProjectDataAccessLayer.Abstract;
using ProjectDataAccessLayer.Concrete.EfCoreRepositories.Products;
using ProjectDataAccessLayer.EntityFramework.Context;
using ProjectBusinessLogicLayer.Ioc;
using FluentValidation.AspNetCore;
using ProjectBusinessLogicLayer.ValidationRules.FluentValidation.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddControllersWithViews()
    .AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<ICommonValidator>());
builder.Services.AddDbContext<ProductContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Local")));
builder.Services.AddServices();



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
    name: "areas",
    pattern: "{area}/{controller=Product}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); ;



app.Run();
