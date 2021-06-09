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
    public class RealEstateConfiguration : IEntityTypeConfiguration<RealEstate>
    {
        public void Configure(EntityTypeBuilder<RealEstate> builder)
        {
            builder.HasData(
                new RealEstate()
                {
                    Id = Guid.Parse("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                    UserId = Guid.Parse("dcb8af96-64a9-4a24-b1a5-86f43acde49c"),
                    CreatedOn = DateTime.Now.AddDays(-14),
                    Title = "Nice Apartment",
                    Description = "You will love it. The view is great!",
                    Address = "Mladost 1A, Telerik Academy building",
                    Contact = "0888-888-888",
                    ConstructionYear = 2005,
                    SellingPrice = 120000,
                    RentingPrice = 500,
                    CanBeRented = true,
                    CanBeSold = true,
                    RealEstateTypeId = 1
                },
                new RealEstate()
                {
                    Id = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("dcb8af96-64a9-4a24-b1a5-86f43acde49c"),
                    CreatedOn = DateTime.Now.AddDays(-14),
                    Title = "Ugly Apartment",
                    Description = "You will love it. The view is great!",
                    Address = "Mladost 2A, Telerik Academy building",
                    Contact = "0888-888-888",
                    ConstructionYear = 2005,
                    SellingPrice = 120000,
                    RentingPrice = 500,
                    CanBeRented = true,
                    CanBeSold = true,
                    RealEstateTypeId = 1
                },
                new RealEstate()
                {
                    Id = Guid.Parse("d604180f-37d8-4cc5-bfbd-45c904500023"),
                    UserId = Guid.Parse("dcb8af96-64a9-4a24-b1a5-86f43acde49c"),
                    CreatedOn = DateTime.Now.AddDays(-14),
                    Title = "Very old Apartment",
                    Description = "This apartment is not nice, but cheap",
                    Address = "Mladost 3A, Telerik Academy building",
                    Contact = "0888-888-888",
                    ConstructionYear = 1990,
                    SellingPrice = 20000,
                    RentingPrice = 300,
                    CanBeRented = true,
                    CanBeSold = true,
                    RealEstateTypeId = 1
                },
                new RealEstate()
                {
                    Id = Guid.Parse("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"),
                    UserId = Guid.Parse("dcb8af96-64a9-4a24-b1a5-86f43acde49c"),
                    CreatedOn = DateTime.Now.AddDays(-14),
                    Title = "EXPENSIVE Apartment",
                    Description = "This is premium living!",
                    Address = "Mladost 23A, Telerik PREMIUM building",
                    Contact = "0888-888-888",
                    ConstructionYear = 2019,
                    SellingPrice = 450000,
                    RentingPrice = 2000,
                    CanBeRented = true,
                    CanBeSold = true,
                    RealEstateTypeId = 1
                },
                new RealEstate()
                {
                    Id = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                    UserId = Guid.Parse("dcb8af96-64a9-4a24-b1a5-86f43acde49c"),
                    CreatedOn = DateTime.Now.AddDays(-14),
                    Title = "Small house",
                    Description = "Perfect house for small family",
                    Address = "HouseStreet 23",
                    Contact = "0888-888-888",
                    ConstructionYear = 2019,
                    SellingPrice = 350000,
                    RentingPrice = 0,
                    CanBeRented = false,
                    CanBeSold = true,
                    RealEstateTypeId = 2
                },
                new RealEstate()
                {
                    Id = Guid.Parse("c1c32290-5f67-4a19-aa3d-a44fc958b35b"),
                    UserId = Guid.Parse("dcb8af96-64a9-4a24-b1a5-86f43acde49c"),
                    CreatedOn = DateTime.Now.AddDays(-14),
                    Title = "Medium house",
                    Description = "Perfect house for a medium sized family",
                    Address = "HouseStreet 24",
                    Contact = "0888-888-888",
                    ConstructionYear = 2016,
                    SellingPrice = 450000,
                    RentingPrice = 0,
                    CanBeRented = false,
                    CanBeSold = true,
                    RealEstateTypeId = 2
                },
                new RealEstate()
                {
                    Id = Guid.Parse("f97003cf-751a-401a-b37e-452e966ffc33"),
                    UserId = Guid.Parse("dcb8af96-64a9-4a24-b1a5-86f43acde49c"),
                    CreatedOn = DateTime.Now.AddDays(-14),
                    Title = "GIGANTIC house",
                    Description = "Perfect house for a big family!",
                    Address = "HouseStreet 27",
                    Contact = "0888-888-888",
                    ConstructionYear = 2014,
                    SellingPrice = 850000,
                    RentingPrice = 0,
                    CanBeRented = false,
                    CanBeSold = true,
                    RealEstateTypeId = 2
                },
                new RealEstate()
                {
                    Id = Guid.Parse("51b4e09d-69da-4130-af68-c319ae70ca52"),
                    UserId = Guid.Parse("dcb8af96-64a9-4a24-b1a5-86f43acde49c"),
                    CreatedOn = DateTime.Now.AddDays(-14),
                    Title = "GIGANTIC house",
                    Description = "Perfect house for a big family!",
                    Address = "HouseStreet 27",
                    Contact = "0888-888-888",
                    ConstructionYear = 2014,
                    SellingPrice = 850000,
                    RentingPrice = 0,
                    CanBeRented = false,
                    CanBeSold = true,
                    RealEstateTypeId = 2
                },
                 new RealEstate()
                 {
                     Id = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                     UserId = Guid.Parse("dcb8af96-64a9-4a24-b1a5-86f43acde49c"),
                     CreatedOn = DateTime.Now.AddDays(-14),
                     Title = "Modern Office",
                     Description = "The perfect office for a medium sized company",
                     Address = "Officestreet 33",
                     Contact = "0888-888-888",
                     ConstructionYear = 2010,
                     SellingPrice = 1850000,
                     RentingPrice = 0,
                     CanBeRented = false,
                     CanBeSold = true,
                     RealEstateTypeId = 3
                 },
                 new RealEstate()
                 {
                     Id = Guid.Parse("ccf6bebe-692c-49ca-85e0-531223869fb9"),
                     UserId = Guid.Parse("dcb8af96-64a9-4a24-b1a5-86f43acde49c"),
                     CreatedOn = DateTime.Now.AddDays(-14),
                     Title = "Mini Office",
                     Description = "The perfect office for a minicompany",
                     Address = "Officestreet 553",
                     Contact = "0888-888-888",
                     ConstructionYear = 2010,
                     SellingPrice = 50000,
                     RentingPrice = 0,
                     CanBeRented = false,
                     CanBeSold = true,
                     RealEstateTypeId = 3
                 },
                 new RealEstate()
                 {
                     Id = Guid.Parse("493294d0-ed52-48e8-b517-4a3fc0ab4810"),
                     UserId = Guid.Parse("dcb8af96-64a9-4a24-b1a5-86f43acde49c"),
                     CreatedOn = DateTime.Now.AddDays(-14),
                     Title = "HUGE Warehouse",
                     Description = "Gigantic warehouse that was formerly used by Amazon! Can fit 4.000.000 cars inside.",
                     Address = "Warehousestreet 1",
                     Contact = "0888-888-888",
                     ConstructionYear = 2000,
                     SellingPrice = 199240000,
                     RentingPrice = 0,
                     CanBeRented = false,
                     CanBeSold = true,
                     RealEstateTypeId = 4
                 }
            );
        }
    }
}
