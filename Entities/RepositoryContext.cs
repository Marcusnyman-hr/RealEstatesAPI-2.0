using Entities.Configuration;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        { 
            modelBuilder.ApplyConfiguration(new RealEstateTypeConfiguration()); 
            modelBuilder.ApplyConfiguration(new RealEstateConfiguration());
            modelBuilder.ApplyConfiguration(new CommentsConfiguration());
        }
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<RealEstateType> RealEstateTypes { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
