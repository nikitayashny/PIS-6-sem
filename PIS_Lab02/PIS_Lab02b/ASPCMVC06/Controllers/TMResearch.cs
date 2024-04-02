using Microsoft.AspNetCore.Mvc;

namespace ASPCMVC06.Controllers
{
	public class TMResearch : Controller
	{
        public ActionResult M01(string value)
        {
            return Content("GET:M01");
        }

        public ActionResult M02(string value)
        {
            return Content("GET:M02");
        }


        public ActionResult M03(string value)
        {
            return Content("GET:M03");
        }


        public ActionResult MXX()
        {
            return Content("GET:MXX");
        }
    }
}
