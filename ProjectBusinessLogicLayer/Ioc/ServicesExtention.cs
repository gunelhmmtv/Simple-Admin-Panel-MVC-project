using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectBusinessLogicLayer.Abstract;
using ProjectBusinessLogicLayer.Concrete;
using ProjectDataAccessLayer.Abstract;
using ProjectDataAccessLayer.Concrete.EfCoreRepositories.Products;
using ProjectDataAccessLayer.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLogicLayer.Ioc
{
    public static class ServicesExtention
    {
        public static void AddServices(this IServiceCollection services )
        {
          
           services.AddScoped<IProductRepository, ProductRepository>();
           services.AddScoped<IProductService, ProductService>();
           services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
