using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstatesAPI.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RealEstateTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Apartment" },
                    { 2, "House" },
                    { 3, "Office" },
                    { 4, "Warehouse" }
                });

            migrationBuilder.InsertData(
                table: "RealEstates",
                columns: new[] { "Id", "Address", "CanBeRented", "CanBeSold", "ConstructionYear", "Contact", "CreatedOn", "Description", "RealEstateTypeId", "RentingPrice", "SellingPrice", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"), "Mladost 1A, Telerik Academy building", true, true, 2005, "0888-888-888", new DateTime(2021, 5, 26, 16, 33, 8, 676, DateTimeKind.Local).AddTicks(2945), "You will love it. The view is great!", 1, 500, 120000, "Nice Apartment", new Guid("dcb8af96-64a9-4a24-b1a5-86f43acde49c") },
                    { new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), "Mladost 2A, Telerik Academy building", true, true, 2005, "0888-888-888", new DateTime(2021, 5, 26, 16, 33, 8, 685, DateTimeKind.Local).AddTicks(1741), "You will love it. The view is great!", 1, 500, 120000, "Ugly Apartment", new Guid("dcb8af96-64a9-4a24-b1a5-86f43acde49c") },
                    { new Guid("d604180f-37d8-4cc5-bfbd-45c904500023"), "Mladost 3A, Telerik Academy building", true, true, 1990, "0888-888-888", new DateTime(2021, 5, 26, 16, 33, 8, 685, DateTimeKind.Local).AddTicks(1927), "This apartment is not nice, but cheap", 1, 300, 20000, "Very old Apartment", new Guid("dcb8af96-64a9-4a24-b1a5-86f43acde49c") },
                    { new Guid("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"), "Mladost 23A, Telerik PREMIUM building", true, true, 2019, "0888-888-888", new DateTime(2021, 5, 26, 16, 33, 8, 685, DateTimeKind.Local).AddTicks(1961), "This is premium living!", 1, 2000, 450000, "EXPENSIVE Apartment", new Guid("dcb8af96-64a9-4a24-b1a5-86f43acde49c") },
                    { new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), "HouseStreet 23", false, true, 2019, "0888-888-888", new DateTime(2021, 5, 26, 16, 33, 8, 685, DateTimeKind.Local).AddTicks(1989), "Perfect house for small family", 2, 0, 350000, "Small house", new Guid("dcb8af96-64a9-4a24-b1a5-86f43acde49c") },
                    { new Guid("c1c32290-5f67-4a19-aa3d-a44fc958b35b"), "HouseStreet 24", false, true, 2016, "0888-888-888", new DateTime(2021, 5, 26, 16, 33, 8, 685, DateTimeKind.Local).AddTicks(2188), "Perfect house for a medium sized family", 2, 0, 450000, "Medium house", new Guid("dcb8af96-64a9-4a24-b1a5-86f43acde49c") },
                    { new Guid("f97003cf-751a-401a-b37e-452e966ffc33"), "HouseStreet 27", false, true, 2014, "0888-888-888", new DateTime(2021, 5, 26, 16, 33, 8, 685, DateTimeKind.Local).AddTicks(2215), "Perfect house for a big family!", 2, 0, 850000, "GIGANTIC house", new Guid("dcb8af96-64a9-4a24-b1a5-86f43acde49c") },
                    { new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"), "HouseStreet 27", false, true, 2014, "0888-888-888", new DateTime(2021, 5, 26, 16, 33, 8, 685, DateTimeKind.Local).AddTicks(2237), "Perfect house for a big family!", 2, 0, 850000, "GIGANTIC house", new Guid("dcb8af96-64a9-4a24-b1a5-86f43acde49c") },
                    { new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), "Officestreet 33", false, true, 2010, "0888-888-888", new DateTime(2021, 5, 26, 16, 33, 8, 685, DateTimeKind.Local).AddTicks(2257), "The perfect office for a medium sized company", 3, 0, 1850000, "Modern Office", new Guid("dcb8af96-64a9-4a24-b1a5-86f43acde49c") },
                    { new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"), "Officestreet 553", false, true, 2010, "0888-888-888", new DateTime(2021, 5, 26, 16, 33, 8, 685, DateTimeKind.Local).AddTicks(2276), "The perfect office for a minicompany", 3, 0, 50000, "Mini Office", new Guid("dcb8af96-64a9-4a24-b1a5-86f43acde49c") },
                    { new Guid("493294d0-ed52-48e8-b517-4a3fc0ab4810"), "Warehousestreet 1", false, true, 2000, "0888-888-888", new DateTime(2021, 5, 26, 16, 33, 8, 685, DateTimeKind.Local).AddTicks(2300), "Gigantic warehouse that was formerly used by Amazon! Can fit 4.000.000 cars inside.", 4, 0, 199240000, "HUGE Warehouse", new Guid("dcb8af96-64a9-4a24-b1a5-86f43acde49c") }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedOn", "RealEstateId", "UserId", "UserName" },
                values: new object[] { new Guid("f799e33e-651e-431b-adbc-f7d2f5dc60a8"), "This is a comment for small house", new DateTime(2021, 5, 30, 16, 33, 8, 686, DateTimeKind.Local).AddTicks(9257), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("fe987917-89e7-49ca-b92d-6c49efc26dfb"), "Classe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f799e33e-651e-431b-adbc-f7d2f5dc60a8"));

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("16b1323c-590b-478b-9e20-b02c06817ada"));

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("493294d0-ed52-48e8-b517-4a3fc0ab4810"));

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"));

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"));

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("c1c32290-5f67-4a19-aa3d-a44fc958b35b"));

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"));

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("d604180f-37d8-4cc5-bfbd-45c904500023"));

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("edc04431-20d9-42d5-9c05-edae58138bba"));

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("f97003cf-751a-401a-b37e-452e966ffc33"));

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"));

            migrationBuilder.DeleteData(
                table: "RealEstateTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RealEstateTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RealEstateTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"));

            migrationBuilder.DeleteData(
                table: "RealEstateTypes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
