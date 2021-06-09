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
                    Id = Guid.Parse("f799e33e-651e-431b-adbc-f7d2f5dc60a8"),
                    Content = "This is a comment for small house",
                    UserName = "Classe",
                    CreatedOn = DateTime.Now.AddDays(-10),
                    RealEstateId = Guid.Parse("f30f7fd5-afe5-40f8-9294-7dea56fd106c"),
                    UserId = Guid.Parse("fe987917-89e7-49ca-b92d-6c49efc26dfb")
                }
            );
        }
    }
}
