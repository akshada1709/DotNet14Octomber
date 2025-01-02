var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//context is call back function written using  our middaleware
app.Run(async (context) => 
{

    await context.Response.WriteAsync("Welcome to ASP.Net core 8");
});

app.Run();
