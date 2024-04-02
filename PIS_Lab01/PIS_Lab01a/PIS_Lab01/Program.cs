//Task01 http://localhost:5062/Http-YNS?ParmA=aaa&ParmB=bbb

using PIS_Lab01.Handlers;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder();
        var app = builder.Build();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/Http-YNS", async context =>
            {
                var handler = new YNS_GET_Handler();
                await handler.Handle(context);
            });
            endpoints.MapPost("/Http-YNS", async context =>
            {
                var handler = new YNS_POST_Handler();
                await handler.Handle(context);
            });
            endpoints.MapPut("/Http-YNS", async context =>
            {
                var handler = new YNS_PUT_Handler();
                await handler.Handle(context);
            });
            endpoints.MapPost("/sum", async context =>
            {
                var handler = new SumHandler();
                await handler.Handle(context);
            });
            endpoints.MapGet("/html", async context =>
            {
                var handler = new MulHandler();
                await handler.Handle(context);
            });
            endpoints.MapPost("/mul", async context =>
            {
                var handler = new MulHandler();
                await handler.Handle(context);
            });
            endpoints.MapGet("/htmlform", async context =>
            {
                var handler = new MulFormHandler();
                await handler.Handle(context);
            });
            endpoints.MapPost("/mulform", async context =>
            {
                var handler = new MulFormHandler();
                await handler.Handle(context);
            });
        });

        app.Run();
    }
}