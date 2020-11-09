using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternshipExam2020JasirBuric.Dal.Repository;
using InternshipExam2020JasirBuric.Dal.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace InternshipExam2020JasirBuric.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogrepository;
        public BlogController(IBlogRepository blogRepository)
        {
            _blogrepository = blogRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] BlogDto blog)
        {
            var newBlog = await _blogrepository.Add(blog);
            return Ok(newBlog);
        }
    }
}
