using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Kangaroo.Controllers;

namespace Kangaroo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : KangarooControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
