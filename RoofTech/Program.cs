using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog.Configuration;
using Serilog;
using Serilog.Core;
using Serilog.Extensions;
using Serilog.Settings.Configuration;
using Serilog.Events;

namespace RoofTech
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            //Log.Logger = new LoggerConfiguration()
            ////.Enrich.FromLogContext()
            ////.MinimumLevel.Debug()
            //.WriteTo.RollingFile(@"Logs/log-{Date}.txt")
            //    .CreateLogger();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
