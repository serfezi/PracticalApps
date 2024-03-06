using Northwind.Web;

Host.CreateDefaultBuilder(args)
.ConfigureWebHostDefaults(webBuilder =>
{
    webBuilder.UseStartup<Startup>();
}).Build().Run();

System.Console.WriteLine("This executes after the web server has stopped!");