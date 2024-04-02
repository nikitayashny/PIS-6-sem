namespace PIS_Lab01.Handlers
{
    public class YNS_GET_Handler
    {
        public async Task Handle(HttpContext context)
        {
            string paramA = context.Request.Query["ParmA"];
            string paramB = context.Request.Query["ParmB"];

            string responseText = $"GET-Http-YNS:ParmA = {paramA},ParmB = {paramB}";

            context.Response.ContentType = "text/plain";
            await context.Response.WriteAsync(responseText);
        }
    }
}