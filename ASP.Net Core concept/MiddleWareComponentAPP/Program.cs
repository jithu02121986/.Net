var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Map() Method calling
//app.MapGet("/", () => "Hello World!");

//app.MapGet("/greet", () => "Hello from greet end point !");

//app.MapGet("/greet/{name}", (string name) => $"Hello {name}, Welcome!");

//Run() Extension method calling

/*
 app.Run(async (context) =>
{
    await context.Response.WriteAsync("This is 1_Middleware component in pipeline");
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("This is 2_middleware component in pipeline");
});
*/

//Use() Extension method calling

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("This is 1_Middle ware commponent in pipe line by using Use()");
    await next();
});
app.Run(async (context) =>
{
    await context.Response.WriteAsync("\n This is 2_middleware component in pipeline by using Run()");
});
app.Run();
