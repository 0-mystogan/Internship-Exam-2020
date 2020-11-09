using InternshipExam2020JasirBuric.Dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipExam2020JasirBuric.Dal.Configuration
{
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name);
            builder.Property(p => p.Email);
            builder.Property(p => p.Age);
            builder.Property(p => p.NumberOfBlogs);
            builder.Property(p => p.ProfileId);

            builder
                .HasOne(p => p.Profile)
                .WithOne(u => u.User)
                .HasForeignKey<Profile>(p => p.UserId);

            builder.HasData(new List<User>
            {
                new User
                {
                    Id = 1,
                    Name = "Garvin Wannop",
                    Email = "gwannop0@hud.gov",
                    Age = 20
                },
                new User
                {
                    Id = 2,
                    Name = "Cherin Vines",
                    Email = "cvines1@xinhuanet.com",
                    Age = 24
                },   
                new User
                {
                    Id = 3,
                    Name = "Myer Ivashnikov",
                    Email = "mivashnikov2@wikimedia.org",
                    Age = 26
                },   
                new User
                {
                    Id = 4,
                    Name = "Vern McClure",
                    Email = "vmcclure3@usgs.gov",
                    Age = 29
                },   
                new User
                {
                    Id = 5,
                    Name = "Sheridan Ferenczy",
                    Email = "sferenczy4@hugedomains.com",
                    Age = 40
                },   
                new User
                {
                    Id = 6,
                    Name = "Garvin Wannop",
                    Email = "gwannop0@hud.gov",
                    Age = 36
                },   new User
                {
                    Id = 7,
                    Name = "Xenos Dewdeny",
                    Email = "xdewdeny5@china.com.cn",
                    Age = 27
                },   new User
                {
                    Id = 8,
                    Name = "Leela Bloxsum",
                    Email = "lbloxsum6@sina.com.cn",
                    Age = 20
                },   new User
                {
                    Id = 9,
                    Name = "Rocky Noteyoung",
                    Email = "rnoteyoung7@thetimes.co.uk",
                    Age = 21
                },   new User
                {
                    Id = 10,
                    Name = "Garvin Wannop",
                    Email = "gwannop0@hud.gov",
                    Age = 20
                },
            });
        }
    }
}
