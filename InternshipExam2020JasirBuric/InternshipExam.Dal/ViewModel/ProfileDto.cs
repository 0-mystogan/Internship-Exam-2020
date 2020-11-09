using InternshipExam2020JasirBuric.Dal.Domain;
using System.Collections.Generic;

namespace InternshipExam2020JasirBuric.Dal.ViewModel
{
    public class ProfileDto
    {
        public ProfileDto()
        { }
        
        public ProfileDto(Profile profile)
        {
            User = new UserDto(profile.User);
            if(profile.Blogs != null)
                foreach (var blog in profile.Blogs)
                {
                    Blogs.Add(new BlogDto(blog));
                }
        }

        public  virtual UserDto User { get; set; }
        public virtual List<BlogDto> Blogs { get; set; }
    }
}