using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace ASPCMVC07.Controllers
{
	public class Calc : Controller
	{
        [HttpGet("/")]
		public IActionResult Index()
		{
			return View("Calc");
		}

        [HttpGet("Calc/Sum")]
        [HttpPost("Calc/Sum")]
        public ActionResult Sum(float? x, float? y)
        {
            string method = HttpContext.Request.Method;
            if (method == "POST")
            {
                if (x.HasValue && y.HasValue)
                {
                    ViewBag.z = x.Value + y.Value;
                }
                else
                {
                    ViewBag.Error = "Invalid input";
                }
            }

            ViewBag.press = "+";
            return View("Calc");
        }

        [HttpGet("Calc/Sub")]
        [HttpPost("Calc/Sub")]
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

        [HttpPost("Calc/Mul")]
        [HttpGet("Calc/Mul")]
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

        [HttpPost("Calc/Div")]
        [HttpGet("Calc/Div")]
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
