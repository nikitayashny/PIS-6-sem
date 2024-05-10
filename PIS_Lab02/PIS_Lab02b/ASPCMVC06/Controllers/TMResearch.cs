﻿using Microsoft.AspNetCore.Mvc;

namespace ASPCMVC06.Controllers
{
	public class TMResearch : Controller
	{
        public ActionResult M01(string value)
        {
            return Content("GET:M01 " + value);
        }

        public ActionResult M02(string value)
        {
            return Content("GET:M02 " + value);
        }


        public ActionResult M03(string value)
        {
            return Content("GET:M03 " + value);
        }


        public ActionResult MXX()
        {
            return Content("GET:MXX");
        }
    }
}
