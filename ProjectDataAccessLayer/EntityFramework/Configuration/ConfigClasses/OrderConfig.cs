using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectDataAccessLayer.EntityFramework.Configuration.Common;
using ProjectEntities.Concrete.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAccessLayer.EntityFramework.Configuration.ConfigClasses
{
    public class OrderConfig:BaseConfig<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.TotalPrice)
                .IsRequired();
            builder.Property(x => x.Quantity)
                .IsRequired();
            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.CustomerId);


        }
    }
}
