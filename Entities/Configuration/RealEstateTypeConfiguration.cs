using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class RealEstateTypeConfiguration : IEntityTypeConfiguration<RealEstateType>
    {
        public void Configure(EntityTypeBuilder<RealEstateType> builder)
        {
            builder.HasData
            (
                new RealEstateType()
                {
                    Id = 1,
                    Name = "Apartment"
                },
                new RealEstateType()
                {
                    Id = 2,
                    Name = "House"
                },
                new RealEstateType()
                {
                    Id = 3,
                    Name = "Office"
                },
                new RealEstateType()
                {
                    Id = 4,
                    Name = "Warehouse"
                }
            );
        }
    }
}
