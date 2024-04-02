using Microsoft.AspNetCore.Mvc;

namespace ASPCMVC04.Controllers
{
	public class StatusController : Controller
	{
		public IActionResult S200()
		{
            Random random = new Random();
            int statusCode = random.Next(200, 299);
            return StatusCode(statusCode);
        }

		public IActionResult S300()
		{
            var alternativeUrls = new List<string>
			{
				"https://example.com/option1",
				"https://example.com/option2",
				"https://example.com/option3"
			};

            var response = new ContentResult
            {
                StatusCode = 300,
                Content = string.Join(Environment.NewLine, alternativeUrls),
                ContentType = "text/plain"
            };

            return response;
        }

		public IActionResult S500()
		{
			try
			{
				int i = 0;
                int a = 1 / i;
			}
			catch (Exception ex) 
			{ 
				return StatusCode(500, ex.Message);
			}
			return View();
		}
	}
}
