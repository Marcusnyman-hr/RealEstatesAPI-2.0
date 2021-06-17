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
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        private const string adminUserId = "70b0335d-e79b-4071-bda1-2e5ed3b9a4e1";
        private const string adamUserId = "09f047af-baf6-4400-aeb0-260360ecdc03";
        private const string classeUserId = "f6b60805-d507-470a-beaa-e020fc012845";
        private const string marcusUserId = "37afcdde-6387-4e34-aa1e-99d8ae0a9e2a";
        private const string nisseId = "515b001c-726b-4582-8609-6471833634e6";
        private const string dajaId = "37afcdde-6387-4e34-aa1e-99d8ae0a9e2b";

        private const string adminRoleId = "be5a6e87-46a2-4011-8c15-0bf09e624972";
        private const string userRoleId = "e92fb341-f59b-4fef-b0af-66f0a8865f72";

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = adminUserId
            },
            new IdentityUserRole<string>
            {
                RoleId = userRoleId,
                UserId = adamUserId
            },
            new IdentityUserRole<string>
            {
                RoleId = userRoleId,
                UserId = classeUserId
            },
            new IdentityUserRole<string>
            {
                RoleId = userRoleId,
                UserId = marcusUserId
            },
            new IdentityUserRole<string>
            {
                RoleId = userRoleId,
                UserId = nisseId
            },
            new IdentityUserRole<string>
            {
                RoleId = userRoleId,
                UserId = dajaId
            });

        }
    }
}
