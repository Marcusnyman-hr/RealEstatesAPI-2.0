using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstatesAPI.Migrations
{
    public partial class addedmoreComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f699e33e-651e-431b-acbc-f7d2f6dc60a8"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f789e33e-651e-431b-adbc-f7d2f6dc60a8"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f799e33e-651e-431b-acbc-f7d2f6dc60a8"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f799e33e-651e-431b-adbc-f7d2f5dc60a8"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f799e33e-651e-431b-adbc-f7d2f5dc60a9"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f799e33e-651e-431b-adbc-f7d2f6dc60a8"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f799e33e-651e-431b-bdbc-f7d2f6dc60a8"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f899e33e-651e-431b-adbc-f7d2f6dc60a8"));

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedOn", "RealEstateId", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("634d3bb7-8bb2-4758-a2aa-200442a8211c"), "I dont wan't this house, im just here to read the comments!", new DateTime(2021, 6, 3, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(5035), new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("9034d3c6-2217-432f-95ba-53e825c50513"), "Can this house even fit one person?", new DateTime(2021, 6, 16, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9956), new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("a4e8538d-3ea0-45e4-865c-c159c543f85f"), "Eehm, lol?", new DateTime(2021, 6, 7, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9937), new Guid("493294d0-ed52-48e8-b517-4a3fc0ab4810"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("2f380826-31b7-4325-9e2a-8d807e3fc251"), "What is wrong with people? This is a chat for the property.", new DateTime(2021, 6, 1, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9922), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("71386bff-86c6-4a3a-b700-916e28c62aef"), "The creator of this website seems really smart!", new DateTime(2021, 6, 6, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9905), new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("9cdbd1b7-aa3d-48cf-8fc6-e4066320a0bd"), "Knock, knock!", new DateTime(2021, 6, 9, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9890), new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("3b629381-3535-4765-b644-5db1ce900d13"), "PLEASE ADD ME ON FORTNITE! MY GAMERTAG IS BEASTKILLER_5343", new DateTime(2021, 6, 3, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9875), new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("d72e5059-c116-48fe-802c-9e7bd4373ed2"), "Great use of space!", new DateTime(2021, 6, 13, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9858), new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("932e232b-d14f-4bc5-b2ef-19f631165b70"), "Why would you ever wanna buy this garbage house?", new DateTime(2021, 6, 6, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9843), new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("14d3bfe8-0731-4c73-8510-199fe67428f9"), "Knock, knock!", new DateTime(2021, 6, 11, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9828), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("ca16d403-cafb-4087-b6c6-70c1b43779cc"), "What is wrong with people? This is a chat for the property.", new DateTime(2021, 6, 12, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9813), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("690079f1-f6f9-4255-9683-38cbc6963a11"), "Why is this even up here? Should be taken down!", new DateTime(2021, 5, 31, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9799), new Guid("493294d0-ed52-48e8-b517-4a3fc0ab4810"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("5d2ac5c9-f459-4829-9565-18132aa7e7d1"), "Eehm, lol?", new DateTime(2021, 6, 9, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9785), new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("3b3edc72-ea89-46b0-a8a6-2b220b0dd28e"), "Holy Moly, is this where the kardashians live?", new DateTime(2021, 6, 7, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9769), new Guid("c1c32290-5f67-4a19-aa3d-a44fc958b35b"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("c30f3ff3-a987-4d2b-8ccd-39d85028815f"), "I dont wan't this house, im just here to read the comments!", new DateTime(2021, 6, 9, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9754), new Guid("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("dca93398-9124-41c5-aa16-5b5635d84626"), "The creator of this website seems really smart!", new DateTime(2021, 6, 9, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9740), new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("5e934277-ac21-4ab6-97b1-d9f1f3d958be"), "How many doors does this property have?", new DateTime(2021, 6, 5, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9725), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("a75668df-9867-4e2e-aa77-319039b2e835"), "Just beastly =)", new DateTime(2021, 6, 10, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9711), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("09560698-875d-46fe-8604-37b83ee357de"), "Who's there?", new DateTime(2021, 6, 15, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9472), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("a905b361-f29c-41f8-9565-91bbb52cd529"), "I'm gonna rob this house!", new DateTime(2021, 6, 12, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9488), new Guid("f97003cf-751a-401a-b37e-452e966ffc33"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("0cabc01b-093f-4ed5-b35e-e63734c96116"), "How many doors does this property have?", new DateTime(2021, 6, 5, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9505), new Guid("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("7431a59f-5db0-400e-9ebe-f43a423b3e86"), "Knock, knock!", new DateTime(2021, 5, 29, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9536), new Guid("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("dd8e5465-6334-4d87-b073-17029686c936"), "I really do like the interior design!", new DateTime(2021, 6, 9, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9551), new Guid("493294d0-ed52-48e8-b517-4a3fc0ab4810"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("a93c44d2-18d2-4d63-bd59-928e3e657d05"), "Knock, knock!", new DateTime(2021, 6, 10, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9566), new Guid("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("51d9ec4f-9885-4003-84f9-5d8e4e5a20c5"), "How many doors does this property have?", new DateTime(2021, 6, 8, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9971), new Guid("c1c32290-5f67-4a19-aa3d-a44fc958b35b"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("4ef73023-e3a6-42a8-9d7f-859b3dfd85db"), "Atleast the carpets are nice!", new DateTime(2021, 6, 10, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9581), new Guid("c1c32290-5f67-4a19-aa3d-a44fc958b35b"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("bff08946-1d12-4f6b-bfc6-c3ad93ae9e43"), "Nice use of ivory in this shot :-)", new DateTime(2021, 6, 14, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9612), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("0dd4916a-db56-4d84-83f1-c6247b578990"), "Is the rat-infestation included in the price?", new DateTime(2021, 6, 14, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9627), new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("088b37c4-394b-4b10-bfa9-3cd65d9c6334"), "This is to expensive? ", new DateTime(2021, 6, 5, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9648), new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("598f1fec-6814-47f8-833e-305b4e86eb9f"), "Don't go here! This place is haunted!", new DateTime(2021, 6, 2, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9666), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("b293a801-db97-4326-a81e-aec69bf25ec6"), "This is a nice house!", new DateTime(2021, 6, 10, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9681), new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("ccc3ca0b-6f5c-4843-96c3-177014a06983"), "Are you sure this is the right address?", new DateTime(2021, 6, 12, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9696), new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("7557de64-b5fb-4542-8ad4-413c5afba537"), "Why is this even up here? Should be taken down!", new DateTime(2021, 6, 9, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9596), new Guid("f97003cf-751a-401a-b37e-452e966ffc33"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("fa81b7fe-7252-45df-bb2c-917a7b461d5c"), "Don't go here! This place is haunted!", new DateTime(2021, 6, 13, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9990), new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("6915a35c-fbf9-434c-bd8b-d50d7a65749f"), "Knock, knock!", new DateTime(2021, 5, 29, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(5), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("4383cea1-d521-4eab-9d90-70901330d481"), "Holy Moly, is this where the kardashians live?", new DateTime(2021, 6, 9, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(21), new Guid("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("7e404a16-7ea2-45b5-9c2d-08b1e01d42ab"), "How many doors does this property have?", new DateTime(2021, 5, 30, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(329), new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("1bd56c5b-ebff-423d-a1a9-6d4e90ff80b7"), "PLEASE ADD ME ON FORTNITE! MY GAMERTAG IS BEASTKILLER_5343", new DateTime(2021, 6, 1, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(344), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("20dd5218-ab86-403f-b605-d61894a2511f"), "This property is so cool!", new DateTime(2021, 6, 11, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(359), new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("522ea18e-52f7-4ca0-8e66-47b22a48a56a"), "WHAT?! This is my house! Im not selling my house?..", new DateTime(2021, 6, 16, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(376), new Guid("d604180f-37d8-4cc5-bfbd-45c904500023"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("4a00fc9b-5898-470f-a2a6-654fe483f22f"), "What is wrong with people? This is a chat for the property.", new DateTime(2021, 6, 4, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(390), new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("c5e8f955-aabb-461d-83b3-fa16b846a9bf"), "I like this house, but I also like watermelon, so who am I to have an opinion?", new DateTime(2021, 6, 5, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(406), new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedOn", "RealEstateId", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("49627a00-321f-45de-b7f1-0949495a8ffc"), "The creator of this website seems really smart!", new DateTime(2021, 6, 11, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(313), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("54ec667f-d9af-4207-9d03-3a9b1f717dc6"), "This is to expensive? ", new DateTime(2021, 6, 16, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(420), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("b7574518-92b8-4575-8c78-9f378f03cf7c"), "I really do like the interior design!", new DateTime(2021, 6, 13, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(451), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("61e8b1ab-3676-408f-892c-f59840347d22"), "Great use of space!", new DateTime(2021, 6, 10, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(466), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("c40bdc99-113b-4393-8fa7-abc1c44ccff6"), "PLEASE ADD ME ON FORTNITE! MY GAMERTAG IS BEASTKILLER_5343", new DateTime(2021, 6, 14, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(480), new Guid("f97003cf-751a-401a-b37e-452e966ffc33"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("e029516f-0c87-47af-9929-282c3713ed57"), "This is to expensive? ", new DateTime(2021, 6, 2, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(495), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("67307633-26bb-4a23-8f03-3307506f9c8e"), "Who's there?", new DateTime(2021, 5, 29, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(509), new Guid("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("0f9f13bf-d93e-4b57-8325-3f39925f6759"), "Eehm, lol?", new DateTime(2021, 6, 1, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(612), new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("d6b1eac9-0bbd-4ff7-b01a-cbef16d2b6d7"), "I dont wan't this house, im just here to read the comments!", new DateTime(2021, 6, 14, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(437), new Guid("f97003cf-751a-401a-b37e-452e966ffc33"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("b2fd98cd-5be3-4c89-b08d-0249c2c9d499"), "I'm in!", new DateTime(2021, 6, 5, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9456), new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("0ec9bced-0e92-4160-8114-f6651c5fc4a7"), "Can this house even fit one person?", new DateTime(2021, 6, 6, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(297), new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("9d2bab9e-3b40-4111-bcda-8d41ca53cf2c"), "Don't go here! This place is haunted!", new DateTime(2021, 6, 2, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(264), new Guid("d604180f-37d8-4cc5-bfbd-45c904500023"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("686f2788-6a65-4c48-90e5-181b9355bb36"), "Why would you ever wanna buy this garbage house?", new DateTime(2021, 5, 31, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(38), new Guid("d604180f-37d8-4cc5-bfbd-45c904500023"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("a463508b-62ed-4709-a2d5-7390284d0dca"), "Anyone wants to go on a date? Im up for it!", new DateTime(2021, 5, 29, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(54), new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("7ea39069-2727-438b-8004-b72bc3315f22"), "The creator of this website seems really smart!", new DateTime(2021, 6, 8, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(76), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("027c2254-35b7-4601-9d3c-245795c2d6e7"), "Eehm, lol?", new DateTime(2021, 6, 10, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(91), new Guid("d604180f-37d8-4cc5-bfbd-45c904500023"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("63d07933-f272-4fce-8273-feddbe0e5cb3"), "PLEASE ADD ME ON FORTNITE! MY GAMERTAG IS BEASTKILLER_5343", new DateTime(2021, 5, 29, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(106), new Guid("d604180f-37d8-4cc5-bfbd-45c904500023"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("7f3ec16d-5c7d-4e11-8c10-5eed6f8b6732"), "Are you sure this is the right address?", new DateTime(2021, 6, 10, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(121), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("ebcd509b-7b9b-4046-a8e3-a2c15db4650c"), "Why would you ever wanna buy this garbage house?", new DateTime(2021, 5, 29, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(281), new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("42523f11-c78b-4ad6-a8a4-12b0da97f35d"), "I think I'm crying. It's that beastly.", new DateTime(2021, 6, 10, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(135), new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("34839a66-96fc-4fc4-9751-56d7a290c516"), "The creator of this website seems really smart!", new DateTime(2021, 6, 6, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(170), new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("2c03cfe7-eeb0-43d5-ae48-2cb9a95b2c67"), "I think I'm crying. It's that beastly.", new DateTime(2021, 6, 16, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(189), new Guid("d604180f-37d8-4cc5-bfbd-45c904500023"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("b64729db-0eb3-46dd-8cca-dafc7639ab5b"), "Don't go here! This place is haunted!", new DateTime(2021, 6, 2, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(203), new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("ce73655b-489a-4322-800b-e5421bf3f5f0"), "What is wrong with people? This is a chat for the property.", new DateTime(2021, 6, 11, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(218), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("0f6d7332-2381-4147-8155-bc9c05d76fb4"), "Why would you ever wanna buy this garbage house?", new DateTime(2021, 6, 16, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(234), new Guid("d604180f-37d8-4cc5-bfbd-45c904500023"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("0cc8c8d8-e0e3-4dc3-9ec8-7b97fc560fac"), "Wow, this house sucks!", new DateTime(2021, 6, 9, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(248), new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("7358eb75-92a8-47bc-adac-d245fada72d2"), "This property is so cool!", new DateTime(2021, 6, 9, 9, 58, 21, 712, DateTimeKind.Local).AddTicks(154), new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("2b545cd3-d8ce-4662-982c-92aaf5a65fe4"), "Eehm, lol?", new DateTime(2021, 6, 9, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9428), new Guid("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("7d533fcc-47b1-4ec8-a96b-b5ef2db2669d"), "Nice use of ivory in this shot :-)", new DateTime(2021, 6, 1, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9520), new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("9e27527d-d392-4488-b4e0-995900c25233"), "WHAT?! This is my house! Im not selling my house?..", new DateTime(2021, 6, 8, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9361), new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("557a52c4-31f2-40fd-91e0-9396eb96318e"), "The creator of this website seems really smart!", new DateTime(2021, 6, 9, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8337), new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("c65f7e80-453d-4c8f-afa3-5d195168f5ff"), "I hope this property gets termites!", new DateTime(2021, 5, 30, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8364), new Guid("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("2073479b-d131-4932-ba96-afbf2f9f1416"), "Wow, this house sucks!", new DateTime(2021, 6, 15, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8379), new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("52fbb5ac-23b1-4398-9684-26c0f6880520"), "I think I'm crying. It's that beastly.", new DateTime(2021, 6, 7, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8393), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("7c38f735-da4f-47d9-97fd-4abe0f747172"), "Atleast the carpets are nice!", new DateTime(2021, 5, 30, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8408), new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("8dd28108-ac6f-4337-b09a-f5f865bc1b79"), "I think I'm crying. It's that beastly.", new DateTime(2021, 6, 8, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8423), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("1aa40b0b-b050-4a17-85ff-5b02bc317170"), "Knock, knock!", new DateTime(2021, 5, 30, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8250), new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("9605b50d-5d35-4741-9630-e47b97bcd479"), "I really do like the interior design!", new DateTime(2021, 6, 13, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8439), new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("ed8b4409-6b8b-441b-ab74-8b0335acb121"), "This is a nice house!", new DateTime(2021, 6, 16, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8473), new Guid("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("37e83fac-3b78-4ab1-8738-c3bfc4c56983"), "Wow, this house sucks!", new DateTime(2021, 6, 4, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8490), new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("f544f1c8-af7e-451f-a552-ad0cf9a694cf"), "Can this house even fit one person?", new DateTime(2021, 6, 14, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8508), new Guid("c1c32290-5f67-4a19-aa3d-a44fc958b35b"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("957a7066-0309-4a93-b424-e76c791459be"), "Holy Moly, is this where the kardashians live?", new DateTime(2021, 6, 16, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9384), new Guid("d604180f-37d8-4cc5-bfbd-45c904500023"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedOn", "RealEstateId", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("502f6097-e64c-4f21-9842-43294803f13c"), "I really do like the interior design!", new DateTime(2021, 6, 16, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8537), new Guid("f97003cf-751a-401a-b37e-452e966ffc33"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("8c119450-9afd-4631-a739-711a59281eee"), "Just beastly =)", new DateTime(2021, 6, 9, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8550), new Guid("493294d0-ed52-48e8-b517-4a3fc0ab4810"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("bf2fe3bd-4c51-424a-b276-7c8e0ab9c459"), "I really do like the interior design!", new DateTime(2021, 6, 12, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8455), new Guid("d604180f-37d8-4cc5-bfbd-45c904500023"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("91d3567f-d9e9-41fd-8dc5-d63411b111fb"), "Knock, knock!", new DateTime(2021, 6, 14, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8565), new Guid("d604180f-37d8-4cc5-bfbd-45c904500023"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("0403f5ba-2ee0-4e24-bf45-553037fc6c6f"), "Why is this even up here? Should be taken down!", new DateTime(2021, 6, 1, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8230), new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("0e97c4af-6f5e-407b-89f3-dd13d849d750"), "Great use of space!", new DateTime(2021, 6, 2, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8195), new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("988d0bfe-d832-4351-a11e-e872bf7cd40c"), "I really do like the interior design!", new DateTime(2021, 6, 4, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(7896), new Guid("c1c32290-5f67-4a19-aa3d-a44fc958b35b"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("73f400cc-87f3-4f93-854a-7304545b6f03"), "Are you sure this is the right address?", new DateTime(2021, 6, 6, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(7951), new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("6a5bbb67-0c94-4c2c-b5c2-e9fb1a1a36c5"), "Why would you ever wanna buy this garbage house?", new DateTime(2021, 6, 9, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(7970), new Guid("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("62f9b171-5216-4fed-9509-c10c889546ad"), "The creator of this website seems really smart!", new DateTime(2021, 6, 15, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8019), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("c84f2e70-b169-469d-9907-f5bc552bc335"), "This property is so cool!", new DateTime(2021, 6, 11, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8040), new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("71a7e92d-a030-4d3f-889e-7ede522445d2"), "Why is this even up here? Should be taken down!", new DateTime(2021, 6, 12, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8055), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("03a34cea-b733-45e4-9fe9-487e3c723f3c"), "Great use of space!", new DateTime(2021, 6, 7, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8212), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("ce438365-1b00-4cff-bb1f-f7f9f46c7ae6"), "How many carpenters does it take to unscrew a lightbulb?", new DateTime(2021, 6, 16, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8071), new Guid("f97003cf-751a-401a-b37e-452e966ffc33"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("4e05fe91-8817-4ceb-b8fa-99350c7aef8e"), "Are you sure this is the right address?", new DateTime(2021, 6, 6, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8101), new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("83be551f-2f20-4df0-9ee8-e8de7f443207"), "Atleast the carpets are nice!", new DateTime(2021, 6, 4, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8114), new Guid("493294d0-ed52-48e8-b517-4a3fc0ab4810"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("df2b9f79-8ac3-4dca-a74e-4cfdb489011a"), "This is a nice house!", new DateTime(2021, 6, 1, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8130), new Guid("493294d0-ed52-48e8-b517-4a3fc0ab4810"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("1255a8eb-960c-47b5-8c43-203fb84f8637"), "Can this house even fit one person?", new DateTime(2021, 6, 6, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8146), new Guid("c1c32290-5f67-4a19-aa3d-a44fc958b35b"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("bd1d8b68-2f68-494d-a671-d372fb96ff22"), "The creator of this website seems really smart!", new DateTime(2021, 6, 7, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8160), new Guid("f97003cf-751a-401a-b37e-452e966ffc33"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("59a63663-36f5-4481-86a2-47a207d9fa66"), "How many doors does this property have?", new DateTime(2021, 6, 14, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8175), new Guid("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("ecdfe2ef-43ca-474f-932e-65aa9ce95d82"), "How many doors does this property have?", new DateTime(2021, 6, 14, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8086), new Guid("f97003cf-751a-401a-b37e-452e966ffc33"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("72814ec8-5c78-4e15-a8f4-0cae19d36646"), "Why is this even up here? Should be taken down!", new DateTime(2021, 6, 7, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8580), new Guid("f97003cf-751a-401a-b37e-452e966ffc33"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("e62428b3-cbc8-474f-8ca6-a1807037d89d"), "Who's there?", new DateTime(2021, 6, 1, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8522), new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("a0ac255f-57c9-4a15-ba1c-d338845c9140"), "What is wrong with people? This is a chat for the property.", new DateTime(2021, 6, 2, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8612), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("ffe26a5a-cdc0-4f41-983b-1e417cebc69a"), "The creator of this website seems really smart!", new DateTime(2021, 6, 16, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9344), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("b9d74c45-9f5c-4a2e-8e70-470f2d8a98ba"), "Atleast the carpets are nice!", new DateTime(2021, 6, 11, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9325), new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("80b00405-fc16-42ea-ae44-678f3c037f48"), "Is the rat-infestation included in the price?", new DateTime(2021, 5, 29, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9301), new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("98f7713b-16de-4a35-9d54-81d641686889"), "How many carpenters does it take to unscrew a lightbulb?", new DateTime(2021, 5, 31, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9286), new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("e35b63d0-da4d-4c55-9e3c-8668a7f19d6c"), "Knock, knock!", new DateTime(2021, 6, 4, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9275), new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("0beb6a4b-614c-4c72-942b-fd0b8c4c295c"), "I really do like the interior design!", new DateTime(2021, 6, 2, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9264), new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("cb5f189e-1a07-42e9-9b01-3ca4f0da94cb"), "Who's there?", new DateTime(2021, 5, 30, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9251), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("eae70de0-3fb1-4e6b-aa2d-67c278854dac"), "Holy Moly, is this where the kardashians live?", new DateTime(2021, 5, 31, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9235), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("2a22598c-5ba9-44bb-aa2c-0b3237c69d19"), "I'm in!", new DateTime(2021, 5, 30, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9212), new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("fd9688c4-7d72-49ce-9c86-fdd737084eb5"), "Is the rat-infestation included in the price?", new DateTime(2021, 6, 7, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9169), new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("b0bd316e-3106-4cbc-bb4d-d039db46df56"), "Why would you ever wanna buy this garbage house?", new DateTime(2021, 6, 10, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8596), new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("de854650-9e5a-44b6-a480-f9075b81fd97"), "PLEASE ADD ME ON FORTNITE! MY GAMERTAG IS BEASTKILLER_5343", new DateTime(2021, 6, 5, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9141), new Guid("d604180f-37d8-4cc5-bfbd-45c904500023"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("53a36a6a-9ab4-4147-8a2d-3caaca9e934a"), "How many doors does this property have?", new DateTime(2021, 5, 31, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9124), new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("a3787355-cd69-469e-9478-d5fadfe49c82"), "I think I'm crying. It's that beastly.", new DateTime(2021, 6, 3, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9103), new Guid("c1c32290-5f67-4a19-aa3d-a44fc958b35b"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("3cd27f55-c4fa-4091-97a9-8eaeda23d4c8"), "I'm gonna rob this house!", new DateTime(2021, 6, 15, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8875), new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("1ca17c06-b6b0-454b-8994-2ea17ca8c376"), "How many carpenters does it take to unscrew a lightbulb?", new DateTime(2021, 6, 16, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(9155), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("002a3077-d886-4aec-834d-ae00a3739d74"), "Why is this even up here? Should be taken down!", new DateTime(2021, 6, 15, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8845), new Guid("f97003cf-751a-401a-b37e-452e966ffc33"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("738dbf01-af71-414f-b50b-43498b8cae16"), "I'm in!", new DateTime(2021, 6, 2, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8626), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedOn", "RealEstateId", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("4fdad378-9b7c-432e-90ca-381b1cb5c44c"), "This is to expensive? ", new DateTime(2021, 6, 3, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8640), new Guid("d604180f-37d8-4cc5-bfbd-45c904500023"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("fb33ac79-fa54-4202-95fe-29bbf886a086"), "I think I'm crying. It's that beastly.", new DateTime(2021, 6, 8, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8861), new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"), new Guid("09f047af-baf6-4400-aeb0-260360ecdc03"), "Adam" },
                    { new Guid("07a22b25-a701-4fe4-82fc-ca462616880c"), "Just beastly =)", new DateTime(2021, 6, 9, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8667), new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("404f0986-6a0b-44d6-a466-17fba2eb7568"), "I really do like the interior design!", new DateTime(2021, 6, 7, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8683), new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("f580ca02-8d6a-44c3-9fac-69e805bfe8b0"), "This property is so cool!", new DateTime(2021, 6, 7, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8698), new Guid("c1c32290-5f67-4a19-aa3d-a44fc958b35b"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" },
                    { new Guid("385bf01c-6ae1-4f33-9414-032b1bd84e74"), "Knock, knock!", new DateTime(2021, 6, 7, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8715), new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("a63eff1e-d05b-4609-bc70-2874b788c109"), "WHAT?! This is my house! Im not selling my house?..", new DateTime(2021, 6, 3, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8655), new Guid("c1c32290-5f67-4a19-aa3d-a44fc958b35b"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("4a21b014-dfb0-4408-8863-5416da785a7f"), "I'm in!", new DateTime(2021, 6, 13, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8749), new Guid("edc04431-20d9-42d5-9c05-edae58138bba"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("db84db1c-6018-469b-91d2-74a81e1d6fef"), "Eehm, lol?", new DateTime(2021, 6, 16, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8766), new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"), new Guid("515b001c-726b-4582-8609-6471833634e7"), "Classe" },
                    { new Guid("1d9db001-ae5f-409c-b006-c402f49363b0"), "This is to expensive? ", new DateTime(2021, 6, 5, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8783), new Guid("16b1323c-590b-478b-9e20-b02c06817ada"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a"), "Marcus" },
                    { new Guid("9fe27cd7-245a-4c48-8b13-52c159a6c357"), "I hope this property gets termites!", new DateTime(2021, 6, 14, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8799), new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("4fe00604-e488-4ed9-a262-3935c80e0941"), "I think I'm crying. It's that beastly.", new DateTime(2021, 6, 15, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8817), new Guid("c1c32290-5f67-4a19-aa3d-a44fc958b35b"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("ace2141e-c784-4f89-b1c7-f6ddc3b2742f"), "Why is this even up here? Should be taken down!", new DateTime(2021, 5, 31, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8830), new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"), new Guid("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b"), "Daja" },
                    { new Guid("a0b54d62-c617-4f92-a896-267249d99b33"), "How many doors does this property have?", new DateTime(2021, 5, 30, 9, 58, 21, 711, DateTimeKind.Local).AddTicks(8730), new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"), new Guid("515b001c-726b-4582-8609-6471833634e6"), "Nisse" }
                });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("16b1323c-590b-478b-9e20-b02c06817ada"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 9, 58, 21, 686, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("493294d0-ed52-48e8-b517-4a3fc0ab4810"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 9, 58, 21, 686, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 9, 58, 21, 686, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 9, 58, 21, 686, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("c1c32290-5f67-4a19-aa3d-a44fc958b35b"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 9, 58, 21, 686, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 9, 58, 21, 686, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("d604180f-37d8-4cc5-bfbd-45c904500023"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 9, 58, 21, 686, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("edc04431-20d9-42d5-9c05-edae58138bba"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 9, 58, 21, 686, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 9, 58, 21, 686, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("f97003cf-751a-401a-b37e-452e966ffc33"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 9, 58, 21, 686, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 3, 9, 58, 21, 685, DateTimeKind.Local).AddTicks(5110));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("002a3077-d886-4aec-834d-ae00a3739d74"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("027c2254-35b7-4601-9d3c-245795c2d6e7"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("03a34cea-b733-45e4-9fe9-487e3c723f3c"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("0403f5ba-2ee0-4e24-bf45-553037fc6c6f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("07a22b25-a701-4fe4-82fc-ca462616880c"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("088b37c4-394b-4b10-bfa9-3cd65d9c6334"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("09560698-875d-46fe-8604-37b83ee357de"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("0beb6a4b-614c-4c72-942b-fd0b8c4c295c"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("0cabc01b-093f-4ed5-b35e-e63734c96116"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("0cc8c8d8-e0e3-4dc3-9ec8-7b97fc560fac"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("0dd4916a-db56-4d84-83f1-c6247b578990"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("0e97c4af-6f5e-407b-89f3-dd13d849d750"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("0ec9bced-0e92-4160-8114-f6651c5fc4a7"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("0f6d7332-2381-4147-8155-bc9c05d76fb4"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("0f9f13bf-d93e-4b57-8325-3f39925f6759"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("1255a8eb-960c-47b5-8c43-203fb84f8637"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("14d3bfe8-0731-4c73-8510-199fe67428f9"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("1aa40b0b-b050-4a17-85ff-5b02bc317170"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("1bd56c5b-ebff-423d-a1a9-6d4e90ff80b7"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("1ca17c06-b6b0-454b-8994-2ea17ca8c376"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("1d9db001-ae5f-409c-b006-c402f49363b0"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("2073479b-d131-4932-ba96-afbf2f9f1416"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("20dd5218-ab86-403f-b605-d61894a2511f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("2a22598c-5ba9-44bb-aa2c-0b3237c69d19"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("2b545cd3-d8ce-4662-982c-92aaf5a65fe4"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("2c03cfe7-eeb0-43d5-ae48-2cb9a95b2c67"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("2f380826-31b7-4325-9e2a-8d807e3fc251"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("34839a66-96fc-4fc4-9751-56d7a290c516"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("37e83fac-3b78-4ab1-8738-c3bfc4c56983"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("385bf01c-6ae1-4f33-9414-032b1bd84e74"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("3b3edc72-ea89-46b0-a8a6-2b220b0dd28e"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("3b629381-3535-4765-b644-5db1ce900d13"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("3cd27f55-c4fa-4091-97a9-8eaeda23d4c8"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("404f0986-6a0b-44d6-a466-17fba2eb7568"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("42523f11-c78b-4ad6-a8a4-12b0da97f35d"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("4383cea1-d521-4eab-9d90-70901330d481"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("49627a00-321f-45de-b7f1-0949495a8ffc"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("4a00fc9b-5898-470f-a2a6-654fe483f22f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("4a21b014-dfb0-4408-8863-5416da785a7f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("4e05fe91-8817-4ceb-b8fa-99350c7aef8e"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("4ef73023-e3a6-42a8-9d7f-859b3dfd85db"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("4fdad378-9b7c-432e-90ca-381b1cb5c44c"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("4fe00604-e488-4ed9-a262-3935c80e0941"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("502f6097-e64c-4f21-9842-43294803f13c"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("51d9ec4f-9885-4003-84f9-5d8e4e5a20c5"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("522ea18e-52f7-4ca0-8e66-47b22a48a56a"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("52fbb5ac-23b1-4398-9684-26c0f6880520"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("53a36a6a-9ab4-4147-8a2d-3caaca9e934a"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("54ec667f-d9af-4207-9d03-3a9b1f717dc6"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("557a52c4-31f2-40fd-91e0-9396eb96318e"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("598f1fec-6814-47f8-833e-305b4e86eb9f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("59a63663-36f5-4481-86a2-47a207d9fa66"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("5d2ac5c9-f459-4829-9565-18132aa7e7d1"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("5e934277-ac21-4ab6-97b1-d9f1f3d958be"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("61e8b1ab-3676-408f-892c-f59840347d22"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("62f9b171-5216-4fed-9509-c10c889546ad"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("634d3bb7-8bb2-4758-a2aa-200442a8211c"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("63d07933-f272-4fce-8273-feddbe0e5cb3"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("67307633-26bb-4a23-8f03-3307506f9c8e"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("686f2788-6a65-4c48-90e5-181b9355bb36"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("690079f1-f6f9-4255-9683-38cbc6963a11"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6915a35c-fbf9-434c-bd8b-d50d7a65749f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6a5bbb67-0c94-4c2c-b5c2-e9fb1a1a36c5"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("71386bff-86c6-4a3a-b700-916e28c62aef"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("71a7e92d-a030-4d3f-889e-7ede522445d2"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("72814ec8-5c78-4e15-a8f4-0cae19d36646"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("7358eb75-92a8-47bc-adac-d245fada72d2"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("738dbf01-af71-414f-b50b-43498b8cae16"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("73f400cc-87f3-4f93-854a-7304545b6f03"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("7431a59f-5db0-400e-9ebe-f43a423b3e86"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("7557de64-b5fb-4542-8ad4-413c5afba537"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("7c38f735-da4f-47d9-97fd-4abe0f747172"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("7d533fcc-47b1-4ec8-a96b-b5ef2db2669d"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("7e404a16-7ea2-45b5-9c2d-08b1e01d42ab"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("7ea39069-2727-438b-8004-b72bc3315f22"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("7f3ec16d-5c7d-4e11-8c10-5eed6f8b6732"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("80b00405-fc16-42ea-ae44-678f3c037f48"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("83be551f-2f20-4df0-9ee8-e8de7f443207"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("8c119450-9afd-4631-a739-711a59281eee"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("8dd28108-ac6f-4337-b09a-f5f865bc1b79"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9034d3c6-2217-432f-95ba-53e825c50513"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("91d3567f-d9e9-41fd-8dc5-d63411b111fb"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("932e232b-d14f-4bc5-b2ef-19f631165b70"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("957a7066-0309-4a93-b424-e76c791459be"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9605b50d-5d35-4741-9630-e47b97bcd479"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("988d0bfe-d832-4351-a11e-e872bf7cd40c"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("98f7713b-16de-4a35-9d54-81d641686889"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9cdbd1b7-aa3d-48cf-8fc6-e4066320a0bd"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9d2bab9e-3b40-4111-bcda-8d41ca53cf2c"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9e27527d-d392-4488-b4e0-995900c25233"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9fe27cd7-245a-4c48-8b13-52c159a6c357"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a0ac255f-57c9-4a15-ba1c-d338845c9140"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a0b54d62-c617-4f92-a896-267249d99b33"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a3787355-cd69-469e-9478-d5fadfe49c82"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a463508b-62ed-4709-a2d5-7390284d0dca"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a4e8538d-3ea0-45e4-865c-c159c543f85f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a63eff1e-d05b-4609-bc70-2874b788c109"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a75668df-9867-4e2e-aa77-319039b2e835"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a905b361-f29c-41f8-9565-91bbb52cd529"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a93c44d2-18d2-4d63-bd59-928e3e657d05"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("ace2141e-c784-4f89-b1c7-f6ddc3b2742f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("b0bd316e-3106-4cbc-bb4d-d039db46df56"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("b293a801-db97-4326-a81e-aec69bf25ec6"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("b2fd98cd-5be3-4c89-b08d-0249c2c9d499"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("b64729db-0eb3-46dd-8cca-dafc7639ab5b"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("b7574518-92b8-4575-8c78-9f378f03cf7c"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("b9d74c45-9f5c-4a2e-8e70-470f2d8a98ba"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("bd1d8b68-2f68-494d-a671-d372fb96ff22"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("bf2fe3bd-4c51-424a-b276-7c8e0ab9c459"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("bff08946-1d12-4f6b-bfc6-c3ad93ae9e43"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("c30f3ff3-a987-4d2b-8ccd-39d85028815f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("c40bdc99-113b-4393-8fa7-abc1c44ccff6"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("c5e8f955-aabb-461d-83b3-fa16b846a9bf"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("c65f7e80-453d-4c8f-afa3-5d195168f5ff"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("c84f2e70-b169-469d-9907-f5bc552bc335"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("ca16d403-cafb-4087-b6c6-70c1b43779cc"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("cb5f189e-1a07-42e9-9b01-3ca4f0da94cb"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("ccc3ca0b-6f5c-4843-96c3-177014a06983"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("ce438365-1b00-4cff-bb1f-f7f9f46c7ae6"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("ce73655b-489a-4322-800b-e5421bf3f5f0"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("d6b1eac9-0bbd-4ff7-b01a-cbef16d2b6d7"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("d72e5059-c116-48fe-802c-9e7bd4373ed2"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("db84db1c-6018-469b-91d2-74a81e1d6fef"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("dca93398-9124-41c5-aa16-5b5635d84626"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("dd8e5465-6334-4d87-b073-17029686c936"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("de854650-9e5a-44b6-a480-f9075b81fd97"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("df2b9f79-8ac3-4dca-a74e-4cfdb489011a"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("e029516f-0c87-47af-9929-282c3713ed57"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("e35b63d0-da4d-4c55-9e3c-8668a7f19d6c"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("e62428b3-cbc8-474f-8ca6-a1807037d89d"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("eae70de0-3fb1-4e6b-aa2d-67c278854dac"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("ebcd509b-7b9b-4046-a8e3-a2c15db4650c"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("ecdfe2ef-43ca-474f-932e-65aa9ce95d82"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("ed8b4409-6b8b-441b-ab74-8b0335acb121"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f544f1c8-af7e-451f-a552-ad0cf9a694cf"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f580ca02-8d6a-44c3-9fac-69e805bfe8b0"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("fa81b7fe-7252-45df-bb2c-917a7b461d5c"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("fb33ac79-fa54-4202-95fe-29bbf886a086"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("fd9688c4-7d72-49ce-9c86-fdd737084eb5"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("ffe26a5a-cdc0-4f41-983b-1e417cebc69a"));

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedOn", "RealEstateId", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("f799e33e-651e-431b-adbc-f7d2f5dc60a8"), "This is a comment for small house", new DateTime(2021, 6, 5, 10, 10, 38, 467, DateTimeKind.Local).AddTicks(8071), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("fe987917-89e7-49ca-b92d-6c49efc26dfb"), "Classe" },
                    { new Guid("f799e33e-651e-431b-adbc-f7d2f5dc60a9"), "This is a another comment for small house", new DateTime(2021, 6, 5, 10, 10, 38, 468, DateTimeKind.Local).AddTicks(863), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("fe987917-89e7-49ca-b92d-6c49efc26dfb"), "Classe" },
                    { new Guid("f799e33e-651e-431b-adbc-f7d2f6dc60a8"), "This is a third comment for small house", new DateTime(2021, 6, 5, 10, 10, 38, 468, DateTimeKind.Local).AddTicks(922), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("fe987917-89e7-49ca-b92d-6c49efc26dfb"), "Classe" },
                    { new Guid("f789e33e-651e-431b-adbc-f7d2f6dc60a8"), "This is a third comment for small house", new DateTime(2021, 6, 5, 10, 10, 38, 468, DateTimeKind.Local).AddTicks(938), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("fe987917-89e7-49ca-b92d-6c49efc26dfb"), "Classe" },
                    { new Guid("f899e33e-651e-431b-adbc-f7d2f6dc60a8"), "This is a third comment for small house", new DateTime(2021, 6, 5, 10, 10, 38, 468, DateTimeKind.Local).AddTicks(997), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("fe987917-89e7-49ca-b92d-6c49efc26dfb"), "Classe" },
                    { new Guid("f799e33e-651e-431b-bdbc-f7d2f6dc60a8"), "This is a third comment for small house", new DateTime(2021, 6, 5, 10, 10, 38, 468, DateTimeKind.Local).AddTicks(1014), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("fe987917-89e7-49ca-b92d-6c49efc26dfb"), "Classe" },
                    { new Guid("f799e33e-651e-431b-acbc-f7d2f6dc60a8"), "This is a third comment for small house", new DateTime(2021, 6, 5, 10, 10, 38, 468, DateTimeKind.Local).AddTicks(1028), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("fe987917-89e7-49ca-b92d-6c49efc26dfb"), "Classe" },
                    { new Guid("f699e33e-651e-431b-acbc-f7d2f6dc60a8"), "This is a third comment for small house", new DateTime(2021, 6, 5, 10, 10, 38, 468, DateTimeKind.Local).AddTicks(1042), new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"), new Guid("fe987917-89e7-49ca-b92d-6c49efc26dfb"), "Classe" }
                });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("16b1323c-590b-478b-9e20-b02c06817ada"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 1, 10, 10, 38, 465, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("493294d0-ed52-48e8-b517-4a3fc0ab4810"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 1, 10, 10, 38, 465, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("51b4e09d-69da-4130-af68-c319ae70ca52"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 1, 10, 10, 38, 465, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 1, 10, 10, 38, 465, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("c1c32290-5f67-4a19-aa3d-a44fc958b35b"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 1, 10, 10, 38, 465, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("ccf6bebe-692c-49ca-85e0-531223869fb9"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 1, 10, 10, 38, 465, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("d604180f-37d8-4cc5-bfbd-45c904500023"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 1, 10, 10, 38, 465, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("edc04431-20d9-42d5-9c05-edae58138bba"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 1, 10, 10, 38, 465, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 1, 10, 10, 38, 465, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("f97003cf-751a-401a-b37e-452e966ffc33"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 1, 10, 10, 38, 465, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: new Guid("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                column: "CreatedOn",
                value: new DateTime(2021, 6, 1, 10, 10, 38, 464, DateTimeKind.Local).AddTicks(8581));
        }
    }
}
