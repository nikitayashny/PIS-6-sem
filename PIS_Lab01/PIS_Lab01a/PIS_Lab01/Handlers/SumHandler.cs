namespace PIS_Lab01.Handlers
{
    public class SumHandler
    {
        public async Task Handle(HttpContext context)
        {
            string paramX = context.Request.Form["X"];
            string paramY = context.Request.Form["Y"];

            int result = int.Parse(paramX) + int.Parse(paramY);
            string responseText = $"Sum: {paramX} + {paramY} = {result}";

            context.Response.ContentType = "text/plain";
            await context.Response.WriteAsync(responseText);
        }
    }
}
