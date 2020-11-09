using InternshipExam2020JasirBuric.Dal.Configuration;
using InternshipExam2020JasirBuric.Dal.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipExam2020JasirBuric.Dal.Context
{
    public class InternshipJasirBuricDbContext : DbContext
    {
        public InternshipJasirBuricDbContext(DbContextOptions<InternshipJasirBuricDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
