using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipExam2020JasirBuric.Dal.Domain
{
    public class Profile : BaseEntity
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public virtual List<Blog> Blogs { get; set; }
    }
}
