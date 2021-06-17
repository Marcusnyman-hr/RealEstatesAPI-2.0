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
    public class CommentsConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData
            (
                new Comment()
                {
                    Id = Guid.Parse("634d3bb7-8bb2-4758-a2aa-200442a8211c"),
                    Content = "I dont wan't this house, im just here to read the comments!",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-14),
                    RealEstateId = Guid.Parse("51b4e09d-69da-4130-af68-c319ae70ca52"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("988d0bfe-d832-4351-a11e-e872bf7cd40c"),
                    Content = "I really do like the interior design!",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-13),
                    RealEstateId = Guid.Parse("c1c32290-5f67-4a19-aa3d-a44fc958b35b"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("73f400cc-87f3-4f93-854a-7304545b6f03"),
                    Content = "Are you sure this is the right address?",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-11),
                    RealEstateId = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("6a5bbb67-0c94-4c2c-b5c2-e9fb1a1a36c5"),
                    Content = "Why would you ever wanna buy this garbage house?",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-8),
                    RealEstateId = Guid.Parse("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("62f9b171-5216-4fed-9509-c10c889546ad"),
                    Content = "The creator of this website seems really smart!",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-2),
                    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("c84f2e70-b169-469d-9907-f5bc552bc335"),
                    Content = "This property is so cool!",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-6),
                    RealEstateId = Guid.Parse("ccf6bebe-692c-49ca-85e0-531223869fb9"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("71a7e92d-a030-4d3f-889e-7ede522445d2"),
                    Content = "Why is this even up here? Should be taken down!",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-5),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("ce438365-1b00-4cff-bb1f-f7f9f46c7ae6"),
                    Content = "How many carpenters does it take to unscrew a lightbulb?",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-1),
                    RealEstateId = Guid.Parse("f97003cf-751a-401a-b37e-452e966ffc33"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("ecdfe2ef-43ca-474f-932e-65aa9ce95d82"),
                    Content = "How many doors does this property have?",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-3),
                    RealEstateId = Guid.Parse("f97003cf-751a-401a-b37e-452e966ffc33"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("4e05fe91-8817-4ceb-b8fa-99350c7aef8e"),
                    Content = "Are you sure this is the right address?",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-11),
                    RealEstateId = Guid.Parse("ccf6bebe-692c-49ca-85e0-531223869fb9"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("83be551f-2f20-4df0-9ee8-e8de7f443207"),
                    Content = "Atleast the carpets are nice!",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-13),
                    RealEstateId = Guid.Parse("493294d0-ed52-48e8-b517-4a3fc0ab4810"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("df2b9f79-8ac3-4dca-a74e-4cfdb489011a"),
                    Content = "This is a nice house!",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-16),
                    RealEstateId = Guid.Parse("493294d0-ed52-48e8-b517-4a3fc0ab4810"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("1255a8eb-960c-47b5-8c43-203fb84f8637"),
                    Content = "Can this house even fit one person?",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-11),
                    RealEstateId = Guid.Parse("c1c32290-5f67-4a19-aa3d-a44fc958b35b"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("bd1d8b68-2f68-494d-a671-d372fb96ff22"),
                    Content = "The creator of this website seems really smart!",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-10),
                    RealEstateId = Guid.Parse("f97003cf-751a-401a-b37e-452e966ffc33"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("59a63663-36f5-4481-86a2-47a207d9fa66"),
                    Content = "How many doors does this property have?",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-3),
                    RealEstateId = Guid.Parse("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("0e97c4af-6f5e-407b-89f3-dd13d849d750"),
                    Content = "Great use of space!",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-15),
                    RealEstateId = Guid.Parse("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("03a34cea-b733-45e4-9fe9-487e3c723f3c"),
                    Content = "Great use of space!",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-10),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("0403f5ba-2ee0-4e24-bf45-553037fc6c6f"),
                    Content = "Why is this even up here? Should be taken down!",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-16),
                    RealEstateId = Guid.Parse("ccf6bebe-692c-49ca-85e0-531223869fb9"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("1aa40b0b-b050-4a17-85ff-5b02bc317170"),
                    Content = "Knock, knock!",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-18),
                    RealEstateId = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("557a52c4-31f2-40fd-91e0-9396eb96318e"),
                    Content = "The creator of this website seems really smart!",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-8),
                    RealEstateId = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("c65f7e80-453d-4c8f-afa3-5d195168f5ff"),
                    Content = "I hope this property gets termites!",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-18),
                    RealEstateId = Guid.Parse("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("2073479b-d131-4932-ba96-afbf2f9f1416"),
                    Content = "Wow, this house sucks!",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-2),
                    RealEstateId = Guid.Parse("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("52fbb5ac-23b1-4398-9684-26c0f6880520"),
                    Content = "I think I'm crying. It's that beastly.",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-10),
                    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("7c38f735-da4f-47d9-97fd-4abe0f747172"),
                    Content = "Atleast the carpets are nice!",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-18),
                    RealEstateId = Guid.Parse("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("8dd28108-ac6f-4337-b09a-f5f865bc1b79"),
                    Content = "I think I'm crying. It's that beastly.",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-9),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("9605b50d-5d35-4741-9630-e47b97bcd479"),
                    Content = "I really do like the interior design!",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-4),
                    RealEstateId = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("bf2fe3bd-4c51-424a-b276-7c8e0ab9c459"),
                    Content = "I really do like the interior design!",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-5),
                    RealEstateId = Guid.Parse("d604180f-37d8-4cc5-bfbd-45c904500023"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("ed8b4409-6b8b-441b-ab74-8b0335acb121"),
                    Content = "This is a nice house!",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-1),
                    RealEstateId = Guid.Parse("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("37e83fac-3b78-4ab1-8738-c3bfc4c56983"),
                    Content = "Wow, this house sucks!",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-13),
                    RealEstateId = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("f544f1c8-af7e-451f-a552-ad0cf9a694cf"),
                    Content = "Can this house even fit one person?",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-3),
                    RealEstateId = Guid.Parse("c1c32290-5f67-4a19-aa3d-a44fc958b35b"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("e62428b3-cbc8-474f-8ca6-a1807037d89d"),
                    Content = "Who's there?",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-16),
                    RealEstateId = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("502f6097-e64c-4f21-9842-43294803f13c"),
                    Content = "I really do like the interior design!",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-1),
                    RealEstateId = Guid.Parse("f97003cf-751a-401a-b37e-452e966ffc33"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("8c119450-9afd-4631-a739-711a59281eee"),
                    Content = "Just beastly =)",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-8),
                    RealEstateId = Guid.Parse("493294d0-ed52-48e8-b517-4a3fc0ab4810"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("91d3567f-d9e9-41fd-8dc5-d63411b111fb"),
                    Content = "Knock, knock!",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-3),
                    RealEstateId = Guid.Parse("d604180f-37d8-4cc5-bfbd-45c904500023"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("72814ec8-5c78-4e15-a8f4-0cae19d36646"),
                    Content = "Why is this even up here? Should be taken down!",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-10),
                    RealEstateId = Guid.Parse("f97003cf-751a-401a-b37e-452e966ffc33"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("b0bd316e-3106-4cbc-bb4d-d039db46df56"),
                    Content = "Why would you ever wanna buy this garbage house?",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-7),
                    RealEstateId = Guid.Parse("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("a0ac255f-57c9-4a15-ba1c-d338845c9140"),
                    Content = "What is wrong with people? This is a chat for the property.",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-15),
                    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("738dbf01-af71-414f-b50b-43498b8cae16"),
                    Content = "I'm in!",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-15),
                    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("4fdad378-9b7c-432e-90ca-381b1cb5c44c"),
                    Content = "This is to expensive? ",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-14),
                    RealEstateId = Guid.Parse("d604180f-37d8-4cc5-bfbd-45c904500023"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("a63eff1e-d05b-4609-bc70-2874b788c109"),
                    Content = "WHAT?! This is my house! Im not selling my house?..",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-14),
                    RealEstateId = Guid.Parse("c1c32290-5f67-4a19-aa3d-a44fc958b35b"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("07a22b25-a701-4fe4-82fc-ca462616880c"),
                    Content = "Just beastly =)",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-8),
                    RealEstateId = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("404f0986-6a0b-44d6-a466-17fba2eb7568"),
                    Content = "I really do like the interior design!",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-10),
                    RealEstateId = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("f580ca02-8d6a-44c3-9fac-69e805bfe8b0"),
                    Content = "This property is so cool!",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-10),
                    RealEstateId = Guid.Parse("c1c32290-5f67-4a19-aa3d-a44fc958b35b"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("385bf01c-6ae1-4f33-9414-032b1bd84e74"),
                    Content = "Knock, knock!",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-10),
                    RealEstateId = Guid.Parse("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("a0b54d62-c617-4f92-a896-267249d99b33"),
                    Content = "How many doors does this property have?",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-18),
                    RealEstateId = Guid.Parse("ccf6bebe-692c-49ca-85e0-531223869fb9"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("4a21b014-dfb0-4408-8863-5416da785a7f"),
                    Content = "I'm in!",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-4),
                    RealEstateId = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("db84db1c-6018-469b-91d2-74a81e1d6fef"),
                    Content = "Eehm, lol?",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-1),
                    RealEstateId = Guid.Parse("51b4e09d-69da-4130-af68-c319ae70ca52"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("1d9db001-ae5f-409c-b006-c402f49363b0"),
                    Content = "This is to expensive? ",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-12),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("9fe27cd7-245a-4c48-8b13-52c159a6c357"),
                    Content = "I hope this property gets termites!",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-3),
                    RealEstateId = Guid.Parse("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("4fe00604-e488-4ed9-a262-3935c80e0941"),
                    Content = "I think I'm crying. It's that beastly.",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-2),
                    RealEstateId = Guid.Parse("c1c32290-5f67-4a19-aa3d-a44fc958b35b"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("ace2141e-c784-4f89-b1c7-f6ddc3b2742f"),
                    Content = "Why is this even up here? Should be taken down!",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-17),
                    RealEstateId = Guid.Parse("51b4e09d-69da-4130-af68-c319ae70ca52"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("002a3077-d886-4aec-834d-ae00a3739d74"),
                    Content = "Why is this even up here? Should be taken down!",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-2),
                    RealEstateId = Guid.Parse("f97003cf-751a-401a-b37e-452e966ffc33"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("fb33ac79-fa54-4202-95fe-29bbf886a086"),
                    Content = "I think I'm crying. It's that beastly.",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-9),
                    RealEstateId = Guid.Parse("ccf6bebe-692c-49ca-85e0-531223869fb9"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("3cd27f55-c4fa-4091-97a9-8eaeda23d4c8"),
                    Content = "I'm gonna rob this house!",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-2),
                    RealEstateId = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("a3787355-cd69-469e-9478-d5fadfe49c82"),
                    Content = "I think I'm crying. It's that beastly.",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-14),
                    RealEstateId = Guid.Parse("c1c32290-5f67-4a19-aa3d-a44fc958b35b"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("53a36a6a-9ab4-4147-8a2d-3caaca9e934a"),
                    Content = "How many doors does this property have?",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-17),
                    RealEstateId = Guid.Parse("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("de854650-9e5a-44b6-a480-f9075b81fd97"),
                    Content = "PLEASE ADD ME ON FORTNITE! MY GAMERTAG IS BEASTKILLER_5343",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-12),
                    RealEstateId = Guid.Parse("d604180f-37d8-4cc5-bfbd-45c904500023"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("1ca17c06-b6b0-454b-8994-2ea17ca8c376"),
                    Content = "How many carpenters does it take to unscrew a lightbulb?",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-1),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("fd9688c4-7d72-49ce-9c86-fdd737084eb5"),
                    Content = "Is the rat-infestation included in the price?",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-10),
                    RealEstateId = Guid.Parse("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("2a22598c-5ba9-44bb-aa2c-0b3237c69d19"),
                    Content = "I'm in!",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-18),
                    RealEstateId = Guid.Parse("ccf6bebe-692c-49ca-85e0-531223869fb9"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("eae70de0-3fb1-4e6b-aa2d-67c278854dac"),
                    Content = "Holy Moly, is this where the kardashians live?",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-17),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("cb5f189e-1a07-42e9-9b01-3ca4f0da94cb"),
                    Content = "Who's there?",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-18),
                    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("0beb6a4b-614c-4c72-942b-fd0b8c4c295c"),
                    Content = "I really do like the interior design!",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-15),
                    RealEstateId = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("e35b63d0-da4d-4c55-9e3c-8668a7f19d6c"),
                    Content = "Knock, knock!",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-13),
                    RealEstateId = Guid.Parse("51b4e09d-69da-4130-af68-c319ae70ca52"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("98f7713b-16de-4a35-9d54-81d641686889"),
                    Content = "How many carpenters does it take to unscrew a lightbulb?",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-17),
                    RealEstateId = Guid.Parse("51b4e09d-69da-4130-af68-c319ae70ca52"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("80b00405-fc16-42ea-ae44-678f3c037f48"),
                    Content = "Is the rat-infestation included in the price?",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-19),
                    RealEstateId = Guid.Parse("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("b9d74c45-9f5c-4a2e-8e70-470f2d8a98ba"),
                    Content = "Atleast the carpets are nice!",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-6),
                    RealEstateId = Guid.Parse("51b4e09d-69da-4130-af68-c319ae70ca52"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("ffe26a5a-cdc0-4f41-983b-1e417cebc69a"),
                    Content = "The creator of this website seems really smart!",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-1),
                    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("9e27527d-d392-4488-b4e0-995900c25233"),
                    Content = "WHAT?! This is my house! Im not selling my house?..",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-9),
                    RealEstateId = Guid.Parse("51b4e09d-69da-4130-af68-c319ae70ca52"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("957a7066-0309-4a93-b424-e76c791459be"),
                    Content = "Holy Moly, is this where the kardashians live?",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-1),
                    RealEstateId = Guid.Parse("d604180f-37d8-4cc5-bfbd-45c904500023"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("2b545cd3-d8ce-4662-982c-92aaf5a65fe4"),
                    Content = "Eehm, lol?",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-8),
                    RealEstateId = Guid.Parse("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("b2fd98cd-5be3-4c89-b08d-0249c2c9d499"),
                    Content = "I'm in!",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-12),
                    RealEstateId = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("09560698-875d-46fe-8604-37b83ee357de"),
                    Content = "Who's there?",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-2),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("a905b361-f29c-41f8-9565-91bbb52cd529"),
                    Content = "I'm gonna rob this house!",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-5),
                    RealEstateId = Guid.Parse("f97003cf-751a-401a-b37e-452e966ffc33"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("0cabc01b-093f-4ed5-b35e-e63734c96116"),
                    Content = "How many doors does this property have?",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-12),
                    RealEstateId = Guid.Parse("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("7d533fcc-47b1-4ec8-a96b-b5ef2db2669d"),
                    Content = "Nice use of ivory in this shot :-)",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-16),
                    RealEstateId = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("7431a59f-5db0-400e-9ebe-f43a423b3e86"),
                    Content = "Knock, knock!",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-19),
                    RealEstateId = Guid.Parse("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("dd8e5465-6334-4d87-b073-17029686c936"),
                    Content = "I really do like the interior design!",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-8),
                    RealEstateId = Guid.Parse("493294d0-ed52-48e8-b517-4a3fc0ab4810"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("a93c44d2-18d2-4d63-bd59-928e3e657d05"),
                    Content = "Knock, knock!",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-7),
                    RealEstateId = Guid.Parse("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("4ef73023-e3a6-42a8-9d7f-859b3dfd85db"),
                    Content = "Atleast the carpets are nice!",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-7),
                    RealEstateId = Guid.Parse("c1c32290-5f67-4a19-aa3d-a44fc958b35b"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("7557de64-b5fb-4542-8ad4-413c5afba537"),
                    Content = "Why is this even up here? Should be taken down!",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-8),
                    RealEstateId = Guid.Parse("f97003cf-751a-401a-b37e-452e966ffc33"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("bff08946-1d12-4f6b-bfc6-c3ad93ae9e43"),
                    Content = "Nice use of ivory in this shot :-)",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-3),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("0dd4916a-db56-4d84-83f1-c6247b578990"),
                    Content = "Is the rat-infestation included in the price?",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-3),
                    RealEstateId = Guid.Parse("ccf6bebe-692c-49ca-85e0-531223869fb9"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("088b37c4-394b-4b10-bfa9-3cd65d9c6334"),
                    Content = "This is to expensive? ",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-12),
                    RealEstateId = Guid.Parse("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("598f1fec-6814-47f8-833e-305b4e86eb9f"),
                    Content = "Don't go here! This place is haunted!",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-15),
                    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("b293a801-db97-4326-a81e-aec69bf25ec6"),
                    Content = "This is a nice house!",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-7),
                    RealEstateId = Guid.Parse("51b4e09d-69da-4130-af68-c319ae70ca52"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("ccc3ca0b-6f5c-4843-96c3-177014a06983"),
                    Content = "Are you sure this is the right address?",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-5),
                    RealEstateId = Guid.Parse("51b4e09d-69da-4130-af68-c319ae70ca52"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("a75668df-9867-4e2e-aa77-319039b2e835"),
                    Content = "Just beastly =)",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-7),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("5e934277-ac21-4ab6-97b1-d9f1f3d958be"),
                    Content = "How many doors does this property have?",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-12),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("dca93398-9124-41c5-aa16-5b5635d84626"),
                    Content = "The creator of this website seems really smart!",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-8),
                    RealEstateId = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("c30f3ff3-a987-4d2b-8ccd-39d85028815f"),
                    Content = "I dont wan't this house, im just here to read the comments!",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-8),
                    RealEstateId = Guid.Parse("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("3b3edc72-ea89-46b0-a8a6-2b220b0dd28e"),
                    Content = "Holy Moly, is this where the kardashians live?",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-10),
                    RealEstateId = Guid.Parse("c1c32290-5f67-4a19-aa3d-a44fc958b35b"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("5d2ac5c9-f459-4829-9565-18132aa7e7d1"),
                    Content = "Eehm, lol?",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-8),
                    RealEstateId = Guid.Parse("51b4e09d-69da-4130-af68-c319ae70ca52"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("690079f1-f6f9-4255-9683-38cbc6963a11"),
                    Content = "Why is this even up here? Should be taken down!",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-17),
                    RealEstateId = Guid.Parse("493294d0-ed52-48e8-b517-4a3fc0ab4810"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("ca16d403-cafb-4087-b6c6-70c1b43779cc"),
                    Content = "What is wrong with people? This is a chat for the property.",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-5),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("14d3bfe8-0731-4c73-8510-199fe67428f9"),
                    Content = "Knock, knock!",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-6),
                    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("932e232b-d14f-4bc5-b2ef-19f631165b70"),
                    Content = "Why would you ever wanna buy this garbage house?",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-11),
                    RealEstateId = Guid.Parse("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("d72e5059-c116-48fe-802c-9e7bd4373ed2"),
                    Content = "Great use of space!",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-4),
                    RealEstateId = Guid.Parse("ccf6bebe-692c-49ca-85e0-531223869fb9"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("3b629381-3535-4765-b644-5db1ce900d13"),
                    Content = "PLEASE ADD ME ON FORTNITE! MY GAMERTAG IS BEASTKILLER_5343",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-14),
                    RealEstateId = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("9cdbd1b7-aa3d-48cf-8fc6-e4066320a0bd"),
                    Content = "Knock, knock!",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-8),
                    RealEstateId = Guid.Parse("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("71386bff-86c6-4a3a-b700-916e28c62aef"),
                    Content = "The creator of this website seems really smart!",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-11),
                    RealEstateId = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("2f380826-31b7-4325-9e2a-8d807e3fc251"),
                    Content = "What is wrong with people? This is a chat for the property.",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-16),
                    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("a4e8538d-3ea0-45e4-865c-c159c543f85f"),
                    Content = "Eehm, lol?",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-10),
                    RealEstateId = Guid.Parse("493294d0-ed52-48e8-b517-4a3fc0ab4810"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("9034d3c6-2217-432f-95ba-53e825c50513"),
                    Content = "Can this house even fit one person?",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-1),
                    RealEstateId = Guid.Parse("ccf6bebe-692c-49ca-85e0-531223869fb9"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("51d9ec4f-9885-4003-84f9-5d8e4e5a20c5"),
                    Content = "How many doors does this property have?",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-9),
                    RealEstateId = Guid.Parse("c1c32290-5f67-4a19-aa3d-a44fc958b35b"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("fa81b7fe-7252-45df-bb2c-917a7b461d5c"),
                    Content = "Don't go here! This place is haunted!",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-4),
                    RealEstateId = Guid.Parse("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("6915a35c-fbf9-434c-bd8b-d50d7a65749f"),
                    Content = "Knock, knock!",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-19),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("4383cea1-d521-4eab-9d90-70901330d481"),
                    Content = "Holy Moly, is this where the kardashians live?",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-8),
                    RealEstateId = Guid.Parse("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("686f2788-6a65-4c48-90e5-181b9355bb36"),
                    Content = "Why would you ever wanna buy this garbage house?",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-17),
                    RealEstateId = Guid.Parse("d604180f-37d8-4cc5-bfbd-45c904500023"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("a463508b-62ed-4709-a2d5-7390284d0dca"),
                    Content = "Anyone wants to go on a date? Im up for it!",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-19),
                    RealEstateId = Guid.Parse("51b4e09d-69da-4130-af68-c319ae70ca52"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("7ea39069-2727-438b-8004-b72bc3315f22"),
                    Content = "The creator of this website seems really smart!",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-9),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("027c2254-35b7-4601-9d3c-245795c2d6e7"),
                    Content = "Eehm, lol?",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-7),
                    RealEstateId = Guid.Parse("d604180f-37d8-4cc5-bfbd-45c904500023"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("63d07933-f272-4fce-8273-feddbe0e5cb3"),
                    Content = "PLEASE ADD ME ON FORTNITE! MY GAMERTAG IS BEASTKILLER_5343",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-19),
                    RealEstateId = Guid.Parse("d604180f-37d8-4cc5-bfbd-45c904500023"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("7f3ec16d-5c7d-4e11-8c10-5eed6f8b6732"),
                    Content = "Are you sure this is the right address?",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-7),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("42523f11-c78b-4ad6-a8a4-12b0da97f35d"),
                    Content = "I think I'm crying. It's that beastly.",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-7),
                    RealEstateId = Guid.Parse("51b4e09d-69da-4130-af68-c319ae70ca52"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("7358eb75-92a8-47bc-adac-d245fada72d2"),
                    Content = "This property is so cool!",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-8),
                    RealEstateId = Guid.Parse("ccf6bebe-692c-49ca-85e0-531223869fb9"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("34839a66-96fc-4fc4-9751-56d7a290c516"),
                    Content = "The creator of this website seems really smart!",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-11),
                    RealEstateId = Guid.Parse("51b4e09d-69da-4130-af68-c319ae70ca52"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("2c03cfe7-eeb0-43d5-ae48-2cb9a95b2c67"),
                    Content = "I think I'm crying. It's that beastly.",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-1),
                    RealEstateId = Guid.Parse("d604180f-37d8-4cc5-bfbd-45c904500023"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("b64729db-0eb3-46dd-8cca-dafc7639ab5b"),
                    Content = "Don't go here! This place is haunted!",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-15),
                    RealEstateId = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("ce73655b-489a-4322-800b-e5421bf3f5f0"),
                    Content = "What is wrong with people? This is a chat for the property.",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-6),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("0f6d7332-2381-4147-8155-bc9c05d76fb4"),
                    Content = "Why would you ever wanna buy this garbage house?",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-1),
                    RealEstateId = Guid.Parse("d604180f-37d8-4cc5-bfbd-45c904500023"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("0cc8c8d8-e0e3-4dc3-9ec8-7b97fc560fac"),
                    Content = "Wow, this house sucks!",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-8),
                    RealEstateId = Guid.Parse("ccf6bebe-692c-49ca-85e0-531223869fb9"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("9d2bab9e-3b40-4111-bcda-8d41ca53cf2c"),
                    Content = "Don't go here! This place is haunted!",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-15),
                    RealEstateId = Guid.Parse("d604180f-37d8-4cc5-bfbd-45c904500023"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("ebcd509b-7b9b-4046-a8e3-a2c15db4650c"),
                    Content = "Why would you ever wanna buy this garbage house?",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-19),
                    RealEstateId = Guid.Parse("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("0ec9bced-0e92-4160-8114-f6651c5fc4a7"),
                    Content = "Can this house even fit one person?",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-11),
                    RealEstateId = Guid.Parse("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("49627a00-321f-45de-b7f1-0949495a8ffc"),
                    Content = "The creator of this website seems really smart!",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-6),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("7e404a16-7ea2-45b5-9c2d-08b1e01d42ab"),
                    Content = "How many doors does this property have?",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-18),
                    RealEstateId = Guid.Parse("edc04431-20d9-42d5-9c05-edae58138bba"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("1bd56c5b-ebff-423d-a1a9-6d4e90ff80b7"),
                    Content = "PLEASE ADD ME ON FORTNITE! MY GAMERTAG IS BEASTKILLER_5343",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-16),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("20dd5218-ab86-403f-b605-d61894a2511f"),
                    Content = "This property is so cool!",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-6),
                    RealEstateId = Guid.Parse("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                },
                new Comment()
                {
                    Id = Guid.Parse("522ea18e-52f7-4ca0-8e66-47b22a48a56a"),
                    Content = "WHAT?! This is my house! Im not selling my house?..",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-1),
                    RealEstateId = Guid.Parse("d604180f-37d8-4cc5-bfbd-45c904500023"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("4a00fc9b-5898-470f-a2a6-654fe483f22f"),
                    Content = "What is wrong with people? This is a chat for the property.",
                    UserName = "Nisse",
                    CreatedOn = DateTime.Now.AddDays(-13),
                    RealEstateId = Guid.Parse("ccf6bebe-692c-49ca-85e0-531223869fb9"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e6")
                },
                new Comment()
                {
                    Id = Guid.Parse("c5e8f955-aabb-461d-83b3-fa16b846a9bf"),
                    Content = "I like this house, but I also like watermelon, so who am I to have an opinion?",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-12),
                    RealEstateId = Guid.Parse("ccf6bebe-692c-49ca-85e0-531223869fb9"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("54ec667f-d9af-4207-9d03-3a9b1f717dc6"),
                    Content = "This is to expensive? ",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-1),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("d6b1eac9-0bbd-4ff7-b01a-cbef16d2b6d7"),
                    Content = "I dont wan't this house, im just here to read the comments!",
                    UserName = "Daja",
                    CreatedOn = DateTime.Now.AddDays(-3),
                    RealEstateId = Guid.Parse("f97003cf-751a-401a-b37e-452e966ffc33"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2b")
                },
                new Comment()
                {
                    Id = Guid.Parse("b7574518-92b8-4575-8c78-9f378f03cf7c"),
                    Content = "I really do like the interior design!",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-4),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("61e8b1ab-3676-408f-892c-f59840347d22"),
                    Content = "Great use of space!",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-7),
                    RealEstateId = Guid.Parse("16b1323c-590b-478b-9e20-b02c06817ada"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("c40bdc99-113b-4393-8fa7-abc1c44ccff6"),
                    Content = "PLEASE ADD ME ON FORTNITE! MY GAMERTAG IS BEASTKILLER_5343",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-3),
                    RealEstateId = Guid.Parse("f97003cf-751a-401a-b37e-452e966ffc33"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("e029516f-0c87-47af-9929-282c3713ed57"),
                    Content = "This is to expensive? ",
                    UserName = "Adam",
                    CreatedOn = DateTime.Now.AddDays(-15),
                    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                    UserId = Guid.Parse("09f047af-baf6-4400-aeb0-260360ecdc03")
                },
                new Comment()
                {
                    Id = Guid.Parse("67307633-26bb-4a23-8f03-3307506f9c8e"),
                    Content = "Who's there?",
                    UserName = "Marcus",
                    CreatedOn = DateTime.Now.AddDays(-19),
                    RealEstateId = Guid.Parse("b0e501a1-bfa8-4fcf-ad7e-5daf590797fe"),
                    UserId = Guid.Parse("37afcdde-6387-4e34-aa1e-99d8ae0a9e2a")
                },
                new Comment()
                {
                    Id = Guid.Parse("0f9f13bf-d93e-4b57-8325-3f39925f6759"),
                    Content = "Eehm, lol?",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-16),
                    RealEstateId = Guid.Parse("f97a72cb-5c1b-419a-a1c1-14d318ea22b7"),
                    UserId = Guid.Parse("515b001c-726b-4582-8609-6471833634e7")
                }
                //new Comment()
                //{
                //    Id = Guid.Parse("f799e33e-651e-431b-adbc-f7d2f5dc60a8"),
                //    Content = "This is a comment for small house",
                //    UserName = "Classe",
                //    CreatedOn = DateTime.Now.AddDays(-10),
                //    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                //    UserId = Guid.Parse("fe987917-89e7-49ca-b92d-6c49efc26dfb")
                //},
                //new Comment()
                //{
                //    Id = Guid.Parse("f799e33e-651e-431b-adbc-f7d2f5dc60a9"),
                //    Content = "This is a another comment for small house",
                //    UserName = "Classe",
                //    CreatedOn = DateTime.Now.AddDays(-10),
                //    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                //    UserId = Guid.Parse("fe987917-89e7-49ca-b92d-6c49efc26dfb")
                //},
                //new Comment()
                //{
                //    Id = Guid.Parse("f799e33e-651e-431b-adbc-f7d2f6dc60a8"),
                //    Content = "This is a third comment for small house",
                //    UserName = "Classe",
                //    CreatedOn = DateTime.Now.AddDays(-10),
                //    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                //    UserId = Guid.Parse("fe987917-89e7-49ca-b92d-6c49efc26dfb")
                //},
                //new Comment()
                //{
                //    Id = Guid.Parse("f789e33e-651e-431b-adbc-f7d2f6dc60a8"),
                //    Content = "This is a third comment for small house",
                //    UserName = "Classe",
                //    CreatedOn = DateTime.Now.AddDays(-10),
                //    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                //    UserId = Guid.Parse("fe987917-89e7-49ca-b92d-6c49efc26dfb")
                //},
                //new Comment()
                //{
                //    Id = Guid.Parse("f899e33e-651e-431b-adbc-f7d2f6dc60a8"),
                //    Content = "This is a third comment for small house",
                //    UserName = "Classe",
                //    CreatedOn = DateTime.Now.AddDays(-10),
                //    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                //    UserId = Guid.Parse("fe987917-89e7-49ca-b92d-6c49efc26dfb")
                //},
                //new Comment()
                //{
                //    Id = Guid.Parse("f799e33e-651e-431b-bdbc-f7d2f6dc60a8"),
                //    Content = "This is a third comment for small house",
                //    UserName = "Classe",
                //    CreatedOn = DateTime.Now.AddDays(-10),
                //    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                //    UserId = Guid.Parse("fe987917-89e7-49ca-b92d-6c49efc26dfb")
                //},
                //new Comment()
                //{
                //    Id = Guid.Parse("f799e33e-651e-431b-acbc-f7d2f6dc60a8"),
                //    Content = "This is a third comment for small house",
                //    UserName = "Classe",
                //    CreatedOn = DateTime.Now.AddDays(-10),
                //    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                //    UserId = Guid.Parse("fe987917-89e7-49ca-b92d-6c49efc26dfb")
                //},
                //new Comment()
                //{
                //    Id = Guid.Parse("f699e33e-651e-431b-acbc-f7d2f6dc60a8"),
                //    Content = "This is a third comment for small house",
                //    UserName = "Classe",
                //    CreatedOn = DateTime.Now.AddDays(-10),
                //    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                //    UserId = Guid.Parse("fe987917-89e7-49ca-b92d-6c49efc26dfb")

                //}


            );
        }
    }
}
