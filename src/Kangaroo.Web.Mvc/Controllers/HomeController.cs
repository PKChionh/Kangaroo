using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Kangaroo.Controllers;

namespace Kangaroo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : KangarooControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
