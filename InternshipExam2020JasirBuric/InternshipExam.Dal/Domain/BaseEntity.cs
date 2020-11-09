using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipExam2020JasirBuric.Dal.Domain
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedAt = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
