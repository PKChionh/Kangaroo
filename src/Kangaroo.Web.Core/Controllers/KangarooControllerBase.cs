using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Kangaroo.Controllers
{
    public abstract class KangarooControllerBase: AbpController
    {
        protected KangarooControllerBase()
        {
            LocalizationSourceName = KangarooConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
