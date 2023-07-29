using WorkerService2.Services;

namespace WorkerService2
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IGerenciadorService _gerenciadorService;
        public Worker(ILogger<Worker> logger, IGerenciadorService gerenciadorService)
        {
            _logger = logger;
            _gerenciadorService = gerenciadorService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            await Task.Delay(500, stoppingToken);
            _gerenciadorService.Executar();
            _logger.LogInformation("Worker finish at: {time}", DateTimeOffset.Now);
        }
    }
}