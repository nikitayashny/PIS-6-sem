using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace ASPCMVC07.Controllers
{
	[Route("it")]
	public class TAResearch : Controller
	{
		[HttpGet("{intValue:int}/{stringValue}")]
		public IActionResult M04(int intValue, string stringValue)
		{
			return Content($"GET:M04: /{intValue}/{stringValue}");
		}

		[HttpGet("{boolValue:bool}/{letters}")]
		[HttpPost("{boolValue:bool}/{letters}")]
		public IActionResult M05(bool boolValue, string letters)
		{
			string method = HttpContext.Request.Method;
			return Content($"{method}:M05: /{boolValue}/{letters}");
		}

		[HttpGet("{floatValue:float}/{stringValue:length(2,5)}")]
		[HttpDelete("{floatValue:float}/{stringValue:length(2,5)}")]
		public IActionResult M06(float floatValue, string stringValue)
		{
			string method = HttpContext.Request.Method;
			return Content($"{method}:M06: /{floatValue}/{stringValue}");
		}

		[HttpPut("{letters:length(3,4)}/{intValue:int:min(100):max(200)}")]
		public IActionResult M07(string letters, int intValue)
		{
			return Content($"PUT:M07: /{letters}/{intValue}/");
		}

		[HttpPost("{mail}")]
		public IActionResult M08(string mail)
		{
			string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

			if (!Regex.IsMatch(mail, emailPattern))
			{
				return BadRequest("Invalid email format.");
			}

			return Content($"POST:M08/{mail}");
		}
	}
}
