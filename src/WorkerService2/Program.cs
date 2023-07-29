using WorkerService2.Services;

namespace WorkerService2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddHostedService<Worker>();
                    services.AddSingleton<IGerenciadorService, GerenciadorService>();
                })
                .Build();

            host.Run();
        }
    }
}