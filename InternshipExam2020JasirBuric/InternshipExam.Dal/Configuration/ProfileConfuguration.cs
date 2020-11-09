using InternshipExam2020JasirBuric.Dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipExam2020JasirBuric.Dal.Configuration
{
    public class ProfileConfuguration : BaseEntityConfiguration<Profile>
    {
        public override void Configure(EntityTypeBuilder<Profile> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.UserId);

            builder
                .HasOne(u => u.User)
                .WithOne(p => p.Profile)
                .HasForeignKey<Profile>(u => u.UserId);

            builder.HasMany(b => b.Blogs)
                .WithOne(p => p.Profile)
                .HasForeignKey(p => p.ProfileId);

            builder.HasData(new Profile
            {
                Id = 1,
                UserId = 1
            });
        }
    }
}
