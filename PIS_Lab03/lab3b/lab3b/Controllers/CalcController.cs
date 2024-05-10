using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace lab3a_new.Controllers;

[Authorize(Roles = "Master, Employee")]
public class CalcController : Controller
{
    [Authorize(Roles = "Master, Employee")]
    public IActionResult Index()
    {
        ViewBag.press = HttpContext.Request.Query["press"];
        ViewBag.x = 0;
        ViewBag.y = 0;
        ViewBag.z = 0;
        return View();
    }
    [Authorize(Roles = "Master, Employee")]
    [HttpPost]
    public IActionResult Sum(string x, string y, string press)
    {
        try
        {
            ViewBag.x = 0;
            ViewBag.y = 0;
            ViewBag.press = press;
            ViewBag.z = 0;
            if (float.TryParse(x, out float parsedX))
            {
                ViewBag.x = parsedX;
            }
            else
                ViewBag.error = "--ERROR--";
            if (float.TryParse(y, out float parsedY))
            {
                ViewBag.y = parsedY;
            }
            else
                ViewBag.error = "--ERROR--";

            if (ViewBag.error != "--ERROR--")
                ViewBag.z = parsedX + parsedY;
        }
        catch
        {
            ViewBag.error = "--ERROR--";
            return View();
        }
        return View();
    }
    [HttpPost]
    public IActionResult Sub(string x, string y, string press)
    {
        try
        {
            ViewBag.x = 0;
            ViewBag.y = 0;
            ViewBag.press = press;
            ViewBag.z = 0;
            if (float.TryParse(x, out float parsedX))
            {
                ViewBag.x = parsedX;
            }
            else
                ViewBag.error = "--ERROR--";
            if (float.TryParse(y, out float parsedY))
            {
                ViewBag.y = parsedY;
            }
            else
                ViewBag.error = "--ERROR--";

            if (ViewBag.error != "--ERROR--")
                ViewBag.z = parsedX - parsedY;
        }
        catch
        {
            ViewBag.error = "--ERROR--";
            return View();
        }
        return View();
    }
    [HttpPost]
    public IActionResult Mul(string x, string y, string press)
    {
        try
        {
            ViewBag.x = 0;
            ViewBag.y = 0;
            ViewBag.press = press;
            ViewBag.z = 0;
            if (float.TryParse(x, out float parsedX))
            {
                ViewBag.x = parsedX;
            }
            else
                ViewBag.error = "--ERROR--";
            if (float.TryParse(y, out float parsedY))
            {
                ViewBag.y = parsedY;
            }
            else
                ViewBag.error = "--ERROR--";

            if (ViewBag.error != "--ERROR--")
                ViewBag.z = parsedX * parsedY;
        }
        catch
        {
            ViewBag.error = "--ERROR--";
            return View();
        }
        return View();
    }
    [HttpPost]
    public IActionResult Div(string x, string y, string press)
    {
        try
        {
            ViewBag.x = 0;
            ViewBag.y = 0;
            ViewBag.press = press;
            ViewBag.z = 0;
            if (float.TryParse(x, out float parsedX))
            {
                ViewBag.x = parsedX;
            }
            else
                ViewBag.error = "--ERROR--";
            if (float.TryParse(y, out float parsedY))
            {
                ViewBag.y = parsedY;
                if (parsedY == 0)
                    ViewBag.error = "--ERROR--";
            }
            else
                ViewBag.error = "--ERROR--";

            if (ViewBag.error != "--ERROR--")
                ViewBag.z = parsedX / parsedY;
        }
        catch
        {
            ViewBag.error = "--ERROR--";
            return View();
        }
        return View();
    }
}