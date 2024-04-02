namespace PIS_Lab01.Handlers
{
    public class MulHandler
    {
        public async Task Handle(HttpContext context)
        {
            if (context.Request.Method == "GET")
            {
                string htmlFilePath = Path.Combine(Directory.GetCurrentDirectory(), "calculator.html");
                string html = await File.ReadAllTextAsync(htmlFilePath);

                context.Response.ContentType = "text/html";
                await context.Response.WriteAsync(html);
            }
            else if (context.Request.Method == "POST")
            {
                string paramX = context.Request.Form["x"];
                string paramY = context.Request.Form["y"];

                int result = int.Parse(paramX) * int.Parse(paramY);

                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync(result.ToString());
            }
            else
            {
                context.Response.StatusCode = 405; 
            }
        }
    }
}
