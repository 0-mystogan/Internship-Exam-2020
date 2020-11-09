using InternshipExam2020JasirBuric.Dal.Context;
using InternshipExam2020JasirBuric.Dal.Domain;
using InternshipExam2020JasirBuric.Dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InternshipExam2020JasirBuric.Dal.Repository
{
    public class SqlServerBlogRepository : IBlogRepository
    {
        private readonly InternshipJasirBuricDbContext _internshipJasirBuricDbContext;
        public SqlServerBlogRepository(InternshipJasirBuricDbContext internshipJasirBuricDbContext)
        {
            _internshipJasirBuricDbContext = internshipJasirBuricDbContext;
        }
        public async Task<BlogDto> Add(BlogDto blog, CancellationToken cancellationToken = default)
        {
            var blogDomain = new Blog
            {
                Title = blog.Title,
                Content = blog.Content,
                Summary = blog.Summary,
                Published = blog.Published,
                Id = blog.Id
            };

            await _internshipJasirBuricDbContext.Blogs.AddAsync(blogDomain);
            await _internshipJasirBuricDbContext.SaveChangesAsync();
            return new BlogDto(blogDomain);
        }

        public Task<BlogDto> Delete(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<BlogDto> Update(BlogDto blogDto, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
