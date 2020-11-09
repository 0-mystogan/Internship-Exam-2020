using InternshipExam2020JasirBuric.Dal.Context;
using InternshipExam2020JasirBuric.Dal.Domain;
using InternshipExam2020JasirBuric.Dal.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InternshipExam2020JasirBuric.Dal.Repository
{
    public class SqlServerUserRepository : IUserRepository
    {
        private readonly InternshipJasirBuricDbContext _internshipJasirBuricDbContext;
        public SqlServerUserRepository(InternshipJasirBuricDbContext internshipJasirBuricDbContext)
        {
            _internshipJasirBuricDbContext = internshipJasirBuricDbContext;
        }
        public async Task<UserViewModel> GetFive(CancellationToken cancellationToken)
        {
            int maxUsers = 5;
            var Users = await _internshipJasirBuricDbContext.Users.Take(maxUsers).ToListAsync(cancellationToken);
            return new UserViewModel(Users);
        }

        public async Task<ProfileDto> GetProfile(int id, CancellationToken cancellationToken = default)
        {
            var profile = await _internshipJasirBuricDbContext.Profiles.Include(u => u.User).Include(b => b.Blogs).Where(u => u.UserId == id).SingleOrDefaultAsync();
            return new ProfileDto(profile);
        }

        public async Task<UserViewModel> SearchByNameOrEmail(string nameoremail, CancellationToken cancellationToken = default)
        {
            const int maxTop = 10;

            var users =
                await _internshipJasirBuricDbContext.Users
                .Where(u => u.Name.ToLower().IndexOf(nameoremail.ToLower()) != -1 || u.Email.ToLower().IndexOf(nameoremail.ToLower()) != -1)
                .ToListAsync(cancellationToken);

            var collection = users.Take(maxTop).ToList();
            return new UserViewModel(collection);
        }
    }
}
