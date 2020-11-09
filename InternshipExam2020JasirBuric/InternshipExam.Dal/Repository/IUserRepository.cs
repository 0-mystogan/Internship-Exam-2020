using InternshipExam2020JasirBuric.Dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InternshipExam2020JasirBuric.Dal.Repository
{
    public interface IUserRepository
    {
        Task<UserViewModel> GetFive(CancellationToken cancellationToken = default);
        Task<UserViewModel> SearchByNameOrEmail(string nameoremail, CancellationToken cancellationToken = default);
        Task<ProfileDto> GetProfile(int id, CancellationToken cancellationToken = default);
    }
}
