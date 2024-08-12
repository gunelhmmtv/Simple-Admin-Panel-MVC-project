using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectDataAccessLayer.EntityFramework.Configuration.Common;
using ProjectEntities.Concrete.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAccessLayer.EntityFramework.Configuration.ConfigClasses
{
    public class ProductConfig:BaseConfig<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.ProductName)
                .HasColumnType("nvarchar(50)")
                .IsRequired();
            builder.Property(x => x.Price)
                .IsRequired();


        }
    }
}
