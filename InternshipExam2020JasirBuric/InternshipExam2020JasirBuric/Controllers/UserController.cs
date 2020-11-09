using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternshipExam2020JasirBuric.Dal.Repository;
using Microsoft.AspNetCore.Mvc;

namespace InternshipExam2020JasirBuric.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
       
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userRepository.GetFive();
            return Ok(users);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> Search(string name)
        {
            var users = await _userRepository.SearchByNameOrEmail(name);
            return Ok(users);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Profile(int id)
        {
            var profile = await _userRepository.GetProfile(id);
            return Ok(profile);
        }
    }
}
