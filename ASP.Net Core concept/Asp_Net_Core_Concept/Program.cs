var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

String? mykey_1 = builder.Configuration.GetValue<String>("key_1", "101_Default Value");
String? mykey_2 = builder.Configuration["key_1"];



//app.MapGet("/", () => "Hello Jitendra,Welcome to .Net Program !" + System.Diagnostics.Process.GetCurrentProcess().ProcessName);

app.MapGet("/", () => $"{mykey_2}");

app.Run();
