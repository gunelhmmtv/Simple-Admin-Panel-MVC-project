using Microsoft.EntityFrameworkCore;
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
    public class CustomerConfig:BaseConfig<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.FirstName)
                .HasColumnType("nvarchar(30)")
                .IsRequired();
            builder.Property(x => x.LastName)
                .HasColumnType("nvarchar(50)")
                .IsRequired();
            builder.Property(x=>x.Address)
                .HasColumnType("nvarchar(250)")
                .IsRequired();
            builder.Property(x => x.Email)
                .HasColumnType("nvarchar(100)")
                .IsRequired();
            builder.Property(x => x.CardNumber)
                .IsRequired();
            builder.Property(x => x.PhoneNumber)
                .IsRequired();


        }
    }
}
