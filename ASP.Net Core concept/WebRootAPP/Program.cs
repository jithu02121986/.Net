using Microsoft.Extensions.FileProviders;

namespace WebRootAPP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            /*  app.MapGet("/", () => $"Environement Name :  {app.Environment.EnvironmentName} \n"+
              $"Application Name : {app.Environment.ApplicationName}\n"+
              $"webroot Path : {app.Environment.WebRootPath} \n"+
              $"content Path : {app.Environment.ContentRootPath}"
              );*/

            /* app.UseStaticFiles(new StaticFileOptions
             {
                 OnPrepareResponse = ctx =>
                 {
                     ctx.Context.Response.Headers["cache-control"] = "public,max-age=259200";
                 }
             });*/
            //app.UseDefaultFiles();
            
            DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            defaultFilesOptions.DefaultFileNames.Clear();

            defaultFilesOptions.DefaultFileNames.Add("MyCustomPage_1.html");
           

            //app.UseDefaultFiles(defaultFilesOptions);

            // app.UseDirectoryBrowser();

            // app.UseFileServer();

            var fileserverOptions = new FileServerOptions
            {
                EnableDirectoryBrowsing = true,

                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"wwwroot"))

            };

          //  fileserverOptions.DefaultFilesOptions.DefaultFileNames.Clear();


            app.UseFileServer(fileserverOptions);   
                
                
           // app.UseStaticFiles();

            app.Run(async (context) => 
            {
                await context.Response.WriteAsync("Request Handled and Response generated !");
            });

          //  app.MapGet("/", () => "Hello Jitendra");

            app.Run();
        }
    }
}
