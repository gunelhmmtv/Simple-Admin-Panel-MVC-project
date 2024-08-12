using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectEntities.Concrete.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAccessLayer.EntityFramework.Configuration.ConfigClasses
{
    public class ProductOrderConfig : IEntityTypeConfiguration<ProductOrder>
    {
        public void Configure(EntityTypeBuilder<ProductOrder> builder)
        {
            builder.HasKey(x => new { x.OrderId, x.ProductId });
            builder.HasOne(x => x.Order)
                .WithMany(x => x.ProductOrders)
                .HasForeignKey(x => x.OrderId);
            builder.HasOne(x => x.Product)
               .WithMany(x => x.ProductOrders)
               .HasForeignKey(x => x.ProductId);
        }
    }
}
