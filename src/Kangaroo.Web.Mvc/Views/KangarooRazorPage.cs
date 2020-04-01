using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Kangaroo.Web.Views
{
    public abstract class KangarooRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected KangarooRazorPage()
        {
            LocalizationSourceName = KangarooConsts.LocalizationSourceName;
        }
    }
}
