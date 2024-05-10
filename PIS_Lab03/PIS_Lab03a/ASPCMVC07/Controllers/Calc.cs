using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace ASPCMVC07.Controllers
{
	public class Calc : Controller
	{

		public IActionResult Index()
		{
			return View("Calc");
		}


        public ActionResult Sum(float? x, float? y)
        {
            string method = HttpContext.Request.Method;
            if (method == "POST")
            {
                if (x.HasValue && y.HasValue)
                {
                    ViewBag.z = x.Value + y.Value;
                    ViewBag.x = x.Value;
                    ViewBag.y = y.Value;
                }
                else
                {
                    ViewBag.Error = "Invalid input";
                }
            }

            ViewBag.press = "+";
            return View("Calc");
        }

        public ActionResult Sub(float? x, float? y)
        {
            string method = HttpContext.Request.Method;
            if (method == "POST")
            {
                if (x.HasValue && y.HasValue)
                {
                    ViewBag.z = x.Value - y.Value;
                }
                else
                {
                    ViewBag.Error = "Invalid input";
                }
            }

            ViewBag.press = "-";
            return View("Calc");
        }


        public ActionResult Mul(float? x, float? y)
        {
            string method = HttpContext.Request.Method;
            if (method == "POST")
            {
                if (x.HasValue && y.HasValue)
                {
                    ViewBag.z = x.Value * y.Value;
                }
                else
                {
                    ViewBag.Error = "Invalid input";
                }
            }

            ViewBag.press = "*";
            return View("Calc");
        }


        public ActionResult Div(float? x, float? y)
        {
            string method = HttpContext.Request.Method;
            if (method == "POST")
            {
                if (x.HasValue && y.HasValue)
                {
                    if (y.Value != 0)
                    {
                        ViewBag.z = x.Value / y.Value;
                    }
                    else
                    {
                        ViewBag.Error = "Division by zero";
                    }
                }
                else
                {
                    ViewBag.Error = "Invalid input";
                }
            }

            ViewBag.press = "/";
            return View("Calc");
        }
    }
}
