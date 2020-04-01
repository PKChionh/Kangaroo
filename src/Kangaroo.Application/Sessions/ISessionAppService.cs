using System.Threading.Tasks;
using Abp.Application.Services;
using Kangaroo.Sessions.Dto;

namespace Kangaroo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
