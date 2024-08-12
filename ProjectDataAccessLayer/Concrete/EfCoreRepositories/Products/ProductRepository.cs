using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjectDataAccessLayer.Abstract;
using ProjectDataAccessLayer.Concrete.EfCoreRepositories.Commons;
using ProjectDataAccessLayer.EntityFramework.Context;
using ProjectEntities.Concrete.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAccessLayer.Concrete.EfCoreRepositories.Products
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ProductContext context) : base(context)
        {

        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
