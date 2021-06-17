using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstatesAPI.Migrations.Authentication
{
    public partial class userSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "be5a6e87-46a2-4011-8c15-0bf09e624972", "c5443beb-5681-4193-868c-77f5d9a55f74", "Admin", "ADMINISTRATOR" },
                    { "e92fb341-f59b-4fef-b0af-66f0a8865f72", "f4226405-627a-441e-9de4-5332feed187b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RealEstates", "SecurityStamp", "TwoFactorEnabled", "UserName", "amountOfRatings" },
                values: new object[,]
                {
                    { "70b0335d-e79b-4071-bda1-2e5ed3b9a4e1", 0, "64744c97-e605-4faa-b79f-87451daffa3a", "Admin@Admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEJ5LkMLMkfTfJa/q2H5nkyWAcpkN8GIvpAgagkLyWhnGmrxCY9gm4OeNpGCQEBBV5A==", "XXXXXXXXXXXXX", true, 0m, 0, "00000000-0000-0000-0000-000000000000", false, "Admin", 0 },
                    { "09f047af-baf6-4400-aeb0-260360ecdc03", 0, "1836d627-091c-4ad8-bd43-8b302f7ca0d4", "Adam@mail.com", true, false, null, "ADAM@MAIL.COM", "ADAM", "AQAAAAEAACcQAAAAEIkL7+eDuFb1XFiGNYaTVu9YhGMA47xZrU6o4sYg67rhOT4ydGhKpxLRDl/Yv5dyBg==", "XXXXXXXXXXXXX", true, 0m, 0, "00000000-0000-0000-0000-000000000000", false, "Adam", 0 },
                    { "f6b60805-d507-470a-beaa-e020fc012845", 0, "3350649c-2884-442a-a466-d76feacd471e", "Classe@mail.com", true, false, null, "CLASSE@MAIL.COM", "CLASSE", "AQAAAAEAACcQAAAAENn+DaUM5OfYgHa8mU6jeaCfMs13SLIbivdNtAZYJZcBjiuT4srS27v5i76o/lz/vg==", "XXXXXXXXXXXXX", true, 0m, 0, "00000000-0000-0000-0000-000000000000", false, "Classe", 0 },
                    { "37afcdde-6387-4e34-aa1e-99d8ae0a9e2a", 0, "66a5c4ad-5a32-4d36-90f3-a39839e28e04", "Marcus@mail.com", true, false, null, "MARCUS@MAIL.COM", "MARCUS", "AQAAAAEAACcQAAAAEMxwW/mNCgSH6HPoTk+9CR1+4galIkafk5840hfatGQUmnYFN8P0PVEMAH6dDMn+/A==", "XXXXXXXXXXXXX", true, 0m, 0, "00000000-0000-0000-0000-000000000000", false, "Marcus", 0 },
                    { "515b001c-726b-4582-8609-6471833634e6", 0, "0d4abe0f-b9b2-460a-9247-6ab8ad968e4c", "Nisse@mail.com", true, false, null, "NISSE@MAIL.COM", "NISSE", "AQAAAAEAACcQAAAAEM83QbLYl5KjMQlRL3ffVRjUb9g+gVR8PY6SXE+GN63KKWVpH1WhRmd1UytWhYyq8Q==", "XXXXXXXXXXXXX", true, 0m, 0, "00000000-0000-0000-0000-000000000000", false, "Nisse", 0 },
                    { "37afcdde-6387-4e34-aa1e-99d8ae0a9e2b", 0, "af6a0022-ce21-4495-9090-8d69f040bf08", "Dajana@mail.com", true, false, null, "DAJANA@MAIL.COM", "DAJANA", "AQAAAAEAACcQAAAAEFxsq3ag7kaVaujAzltm4fcRQkXXiS8dBsXCAOM3JdvTNrI7JVCgd9dbKXFgY/PZXA==", "XXXXXXXXXXXXX", true, 0m, 0, "00000000-0000-0000-0000-000000000000", false, "Daja", 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "be5a6e87-46a2-4011-8c15-0bf09e624972", "70b0335d-e79b-4071-bda1-2e5ed3b9a4e1" },
                    { "e92fb341-f59b-4fef-b0af-66f0a8865f72", "09f047af-baf6-4400-aeb0-260360ecdc03" },
                    { "e92fb341-f59b-4fef-b0af-66f0a8865f72", "f6b60805-d507-470a-beaa-e020fc012845" },
                    { "e92fb341-f59b-4fef-b0af-66f0a8865f72", "37afcdde-6387-4e34-aa1e-99d8ae0a9e2a" },
                    { "e92fb341-f59b-4fef-b0af-66f0a8865f72", "515b001c-726b-4582-8609-6471833634e6" },
                    { "e92fb341-f59b-4fef-b0af-66f0a8865f72", "37afcdde-6387-4e34-aa1e-99d8ae0a9e2b" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e92fb341-f59b-4fef-b0af-66f0a8865f72", "09f047af-baf6-4400-aeb0-260360ecdc03" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e92fb341-f59b-4fef-b0af-66f0a8865f72", "37afcdde-6387-4e34-aa1e-99d8ae0a9e2a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e92fb341-f59b-4fef-b0af-66f0a8865f72", "37afcdde-6387-4e34-aa1e-99d8ae0a9e2b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e92fb341-f59b-4fef-b0af-66f0a8865f72", "515b001c-726b-4582-8609-6471833634e6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "be5a6e87-46a2-4011-8c15-0bf09e624972", "70b0335d-e79b-4071-bda1-2e5ed3b9a4e1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e92fb341-f59b-4fef-b0af-66f0a8865f72", "f6b60805-d507-470a-beaa-e020fc012845" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be5a6e87-46a2-4011-8c15-0bf09e624972");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e92fb341-f59b-4fef-b0af-66f0a8865f72");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09f047af-baf6-4400-aeb0-260360ecdc03");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37afcdde-6387-4e34-aa1e-99d8ae0a9e2a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37afcdde-6387-4e34-aa1e-99d8ae0a9e2b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "515b001c-726b-4582-8609-6471833634e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70b0335d-e79b-4071-bda1-2e5ed3b9a4e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6b60805-d507-470a-beaa-e020fc012845");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
