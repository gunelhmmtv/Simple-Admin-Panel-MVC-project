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
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ProductContext context) : base(context)
        {
        }
    }
}
