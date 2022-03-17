using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EmployeeManagementCore
{
    public class Program
    {
        //Flow: Main-->CreateDefaultBuilder
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        //CreateDefaultBuilder sets up a default web host
        //As a part of setting web host, we are also configuring Startup method using 'UseStartup' extension method
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
