using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipExam2020JasirBuric.Dal.Domain
{
    public class Blog : BaseEntity
    {
        public Blog()
        {
            Published = DateTime.UtcNow.ToString("hh:mm, DD MMM YYYY");
        }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public string Published { get; set; }

        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
