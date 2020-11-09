using InternshipExam2020JasirBuric.Dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InternshipExam2020JasirBuric.Dal.Repository
{
    public interface IBlogRepository
    {
        Task<BlogDto> Add(BlogDto blogDto, CancellationToken cancellationToken = default);
        Task<BlogDto> Update(BlogDto blogDto, CancellationToken cancellationToken = default);
        Task<BlogDto> Delete(int id, CancellationToken cancellationToken = default);
    }
}
