using InternshipExam2020JasirBuric.Dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipExam2020JasirBuric.Dal.Configuration
{
    public class BlogConfiguration : BaseEntityConfiguration<Blog>
    {
        public override void Configure(EntityTypeBuilder<Blog> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Title).IsRequired(true).HasMaxLength(64);
            builder.Property(p => p.Summary).IsRequired(true).HasMaxLength(350);
            builder.Property(p => p.Content).IsRequired(true).HasMaxLength(3500);
            builder.Property(p => p.Published).IsRequired(true);

            builder.HasOne(p => p.Profile)
                .WithMany(b => b.Blogs)
                .HasForeignKey(p => p.ProfileId);
        }
    }
}
