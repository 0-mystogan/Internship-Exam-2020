using InternshipExam2020JasirBuric.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipExam2020JasirBuric.Dal.ViewModel
{
    public class UserDto
    {
        public UserDto()
        {

        }
        public UserDto(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Email = user.Email;
            NumberOfBlogs = user.NumberOfBlogs;
            Age = user.Age;
            if(user.Profile != null) 
                Profile = new ProfileDto(user.Profile);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int NumberOfBlogs { get; set; }
        public int Age { get; set; }

        public virtual ProfileDto Profile { get; set; }
    }
}
