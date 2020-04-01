using System.Threading.Tasks;
using Abp.Application.Services;
using Kangaroo.Authorization.Accounts.Dto;

namespace Kangaroo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
