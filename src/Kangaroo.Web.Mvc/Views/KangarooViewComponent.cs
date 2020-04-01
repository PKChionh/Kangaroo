using Abp.AspNetCore.Mvc.ViewComponents;

namespace Kangaroo.Web.Views
{
    public abstract class KangarooViewComponent : AbpViewComponent
    {
        protected KangarooViewComponent()
        {
            LocalizationSourceName = KangarooConsts.LocalizationSourceName;
        }
    }
}
