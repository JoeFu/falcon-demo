using Microsoft.AspNetCore.Mvc;
using Syntaq.Falcon.Web.Controllers;

namespace Syntaq.Falcon.Web.Public.Controllers
{
    public class HomeController : FalconControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}