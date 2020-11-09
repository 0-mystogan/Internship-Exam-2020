using InternshipExam2020JasirBuric.Dal.Domain;

namespace InternshipExam2020JasirBuric.Dal.ViewModel
{
    public class BlogDto
    {
        public BlogDto()
        {
        }

        public BlogDto(Blog blog)
        {
            Id = blog.Id;
            Title = blog.Title;
            Summary = blog.Content;
            Published = blog.Published;
            Profile = new ProfileDto(blog.Profile);
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public string Published { get; set; }

        public virtual ProfileDto Profile { get; set; }
    }
}