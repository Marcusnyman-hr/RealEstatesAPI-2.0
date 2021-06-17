using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstatesAPI.Migrations
{
    public partial class addedimageurl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "RealEstates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f699e33e-651e-431b-acbc-f7d2f6dc60a8"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 4, 20, 2, 24, 468, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f789e33e-651e-431b-adbc-f7d2f6dc60a8"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 4, 20, 2, 24, 468, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f799e33e-651e-431b-acbc-f7d2f6dc60a8"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 4, 20, 2, 24, 468, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f799e33e-651e-431b-adbc-f7d2f5dc60a8"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 4, 20, 2, 24, 468, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f799e33e-651e-431b-adbc-f7d2f5dc60a9"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 4, 20, 2, 24, 468, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f799e33e-651e-431b-adbc-f7d2f6dc60a8"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 4, 20, 2, 24, 468, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f799e33e-651e-431b-bdbc-f7d2f6dc60a8"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 4, 20, 2, 24, 468, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f899e33e-651e-431b-adbc-f7d2f6dc60a8"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 4, 20, 2, 24, 468, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("16b1323c-590b-478b-9e20-b02c06817ada"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 20, 2, 24, 466, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("493294d0-ed52-48e8-b517-4a3fc0ab4810"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 20, 2, 24, 466, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 20, 2, 24, 466, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 20, 2, 24, 466, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("c1c32290-5f67-4a19-aa3d-a44fc958b35b"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 20, 2, 24, 466, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 20, 2, 24, 466, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("d604180f-37d8-4cc5-bfbd-45c904500023"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 20, 2, 24, 466, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("edc04431-20d9-42d5-9c05-edae58138bba"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 20, 2, 24, 466, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 20, 2, 24, 466, DateTimeKind.Local).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("f97003cf-751a-401a-b37e-452e966ffc33"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 20, 2, 24, 466, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 31, 20, 2, 24, 465, DateTimeKind.Local).AddTicks(3991));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "RealEstates");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f699e33e-651e-431b-acbc-f7d2f6dc60a8"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 13, 14, 40, 477, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f789e33e-651e-431b-adbc-f7d2f6dc60a8"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 13, 14, 40, 477, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f799e33e-651e-431b-acbc-f7d2f6dc60a8"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 13, 14, 40, 477, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f799e33e-651e-431b-adbc-f7d2f5dc60a8"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 13, 14, 40, 477, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f799e33e-651e-431b-adbc-f7d2f5dc60a9"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 13, 14, 40, 477, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f799e33e-651e-431b-adbc-f7d2f6dc60a8"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 13, 14, 40, 477, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f799e33e-651e-431b-bdbc-f7d2f6dc60a8"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 13, 14, 40, 477, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f899e33e-651e-431b-adbc-f7d2f6dc60a8"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 13, 14, 40, 477, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("16b1323c-590b-478b-9e20-b02c06817ada"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 30, 13, 14, 40, 473, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("493294d0-ed52-48e8-b517-4a3fc0ab4810"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 30, 13, 14, 40, 473, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 30, 13, 14, 40, 473, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 30, 13, 14, 40, 473, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("c1c32290-5f67-4a19-aa3d-a44fc958b35b"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 30, 13, 14, 40, 473, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 30, 13, 14, 40, 473, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("d604180f-37d8-4cc5-bfbd-45c904500023"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 30, 13, 14, 40, 473, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("edc04431-20d9-42d5-9c05-edae58138bba"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 30, 13, 14, 40, 473, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 30, 13, 14, 40, 473, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("f97003cf-751a-401a-b37e-452e966ffc33"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 30, 13, 14, 40, 473, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                column: "CreatedOn",
                value: new DateTime(2021, 5, 30, 13, 14, 40, 472, DateTimeKind.Local).AddTicks(1143));
        }
    }
}
