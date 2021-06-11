using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstatesAPI.Migrations.Authentication
{
    public partial class AddedAmountOfRatingsToAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "amountOfRatings",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "amountOfRatings",
                table: "AspNetUsers");
        }
    }
}
