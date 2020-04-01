using Abp.Application.Services;
using Kangaroo.MultiTenancy.Dto;

namespace Kangaroo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

