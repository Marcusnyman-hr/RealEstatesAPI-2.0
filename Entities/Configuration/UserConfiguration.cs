using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        private const string adminId = "70b0335d-e79b-4071-bda1-2e5ed3b9a4e1";
        private const string adamId = "09f047af-baf6-4400-aeb0-260360ecdc03";
        private const string classeId = "f6b60805-d507-470a-beaa-e020fc012845";
        private const string marcusId = "37afcdde-6387-4e34-aa1e-99d8ae0a9e2a";
        private const string nisseId = "515b001c-726b-4582-8609-6471833634e6";
        private const string dajaId = "37afcdde-6387-4e34-aa1e-99d8ae0a9e2b";
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {

            var admin = new ApplicationUser
            {
                Id = adminId,
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "Admin@Admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString("D")
            };
            var adam = new ApplicationUser
            {
                Id = adamId,
                UserName = "Adam",
                NormalizedUserName = "ADAM",
                Email = "Adam@mail.com",
                NormalizedEmail = "ADAM@MAIL.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString("D")
            };
            var classe = new ApplicationUser
            {
                Id = classeId,
                UserName = "Classe",
                NormalizedUserName = "CLASSE",
                Email = "Classe@mail.com",
                NormalizedEmail = "CLASSE@MAIL.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString("D")
            };
            var marcus = new ApplicationUser
            {
                Id = marcusId,
                UserName = "Marcus",
                NormalizedUserName = "MARCUS",
                Email = "Marcus@mail.com",
                NormalizedEmail = "MARCUS@MAIL.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString("D")
            };
            var nisse = new ApplicationUser
            {
                Id = nisseId,
                UserName = "Nisse",
                NormalizedUserName = "NISSE",
                Email = "Nisse@mail.com",
                NormalizedEmail = "NISSE@MAIL.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString("D")
            };
            var daja = new ApplicationUser
            {
                Id = dajaId,
                UserName = "Daja",
                NormalizedUserName = "DAJANA",
                Email = "Dajana@mail.com",
                NormalizedEmail = "DAJANA@MAIL.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString("D")
            };
            admin.PasswordHash = PassGenerate(admin);
            adam.PasswordHash = PassGenerate(adam);
            classe.PasswordHash = PassGenerate(classe);
            marcus.PasswordHash = PassGenerate(marcus);
            nisse.PasswordHash = PassGenerate(nisse);
            daja.PasswordHash = PassGenerate(daja);

            builder.HasData(admin, adam, classe, marcus, nisse, daja);
        }
        public string PassGenerate(ApplicationUser user)
        {
            var passHash = new PasswordHasher<ApplicationUser>();
            return passHash.HashPassword(user, "Password1*");
        }
    }
}
