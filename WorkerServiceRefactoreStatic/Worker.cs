using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WorkerServiceRefactoreStatic.Interfaces;
using WorkerServiceRefactoreStatic.Models;

namespace WorkerServiceRefactoreStatic
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private IStaticBehaviorAdapter _adapter;

        public Worker(ILogger<Worker> logger, IStaticBehaviorAdapter adapter)
        {
            _logger = logger;
            _adapter = adapter;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                StaticBehavior.Print();
                _adapter.Print(isService:true); // Should just return Print if false return print if true return Print service
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
