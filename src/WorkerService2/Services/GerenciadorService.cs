using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerService2.Models;

namespace WorkerService2.Services
{
    public class GerenciadorService : IGerenciadorService
    {
        private ILogger<GerenciadorService> _logger;
        public GerenciadorService(ILogger<GerenciadorService> logger)
        {
            _logger = logger;
        }
        public void Executar()
        {
            int qtdTasks = 6;
            Task[] tasks = new Task[qtdTasks];

            for (int i = 0; i < qtdTasks; i++)
            {
                Gerenciador g = new Gerenciador();
                tasks[i] = Task.Factory.StartNew(() => g.ExecutarTarefas());
                System.Threading.Thread.Sleep(1000);
            }

            Task.WaitAll(tasks);
        }
    }

    public interface IGerenciadorService
    {
        void Executar();
    }
}
