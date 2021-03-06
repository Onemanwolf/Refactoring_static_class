using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WorkerServiceRefactoreStatic.Interfaces;
using WorkerServiceRefactoreStatic.Models;

namespace WorkerServiceRefactoreStatic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {   //add service
                    services.AddSingleton<IAnotherStaticClassAdapter, AnotherStaticClassAdapter>();
                    services.AddSingleton<IStaticBehaviorAdapter, StaticAdapter>();
                    services.AddHostedService<Worker>();
                });
    }
}
