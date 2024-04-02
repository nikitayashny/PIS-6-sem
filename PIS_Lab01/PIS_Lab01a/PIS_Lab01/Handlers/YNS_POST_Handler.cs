namespace PIS_Lab01.Handlers
{
    public class YNS_POST_Handler
    {
        public async Task Handle(HttpContext context)
        {
            string paramA = context.Request.Form["ParmA"];
            string paramB = context.Request.Form["ParmB"];

            string responseText = $"POST-Http-YNS: ParmA = {paramA}, ParmB = {paramB}";

            context.Response.ContentType = "text/plain";
            await context.Response.WriteAsync(responseText);
        }
    }
}
