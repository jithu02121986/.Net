var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

var app = builder.Build();

app.UseRouting();

//app.MapDefaultControllerRoute();

app.MapControllerRoute( name : "default",pattern : "{controller=Home }/{action=index}/{id?}");

//app.MapGet("/", () => "Hello World!");

app.Run();
