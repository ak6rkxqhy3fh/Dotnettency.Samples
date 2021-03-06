﻿using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Sample.Basic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .UseUrls("http://*:5000", "http://*:5001", "http://*:5002", "http://*:5003")
                .Build();

            host.Run();
        }
    }
}
