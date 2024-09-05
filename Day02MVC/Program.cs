using Microsoft.AspNetCore.Builder;

namespace Day02MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();// Register the Built in MVC services in the Container 
            
            //builder.Services.AddControllers();// Register the Built in Apis services in the Container 
            //builder.Services.AddMVC();// Register the Built in All Web services in the Container 
            
            var app = builder.Build();

            // app.MapGet("/", () => "Hello World!");
            //app.MapGet("/hamda", () => "Hello World!");
            //app.MapGet("/signin", signin);
            app.MapControllerRoute(
                name:"default",
                pattern: "/{controller=Home}/{action=Index}/{id:int?}"  ///*alpha:length(3,10)?*/
                );
            app.UseStaticFiles();
            app.Run();

        }
        public static string signin()
        {
            return "SignIn";
        }
    }
}
