using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService2.Models
{
    internal class Robo0
    {

        public int FazAlgumaCoisa(Gerenciador g)
        {
            Console.WriteLine($"Pedido Id: {g.Produto.Id}");
            g.Produto.ExecutaCodigo();
            Console.WriteLine($"Pedido Cod: {g.Produto.Codigo}");
            return g.Produto.Id;
        }

    }
    internal class Robo1
    {
        public void FazAlgumaCoisa(Gerenciador g)
        {
            System.Threading.Thread.Sleep(100);
            string msg = $"Robo 1 Executou..{DateTimeOffset.Now}";
            Console.WriteLine(msg);
            g.Produto.Robo1 = msg;

        }
    }
    internal class Robo2
    {
        public void FazAlgumaCoisa(Gerenciador g)
        {
            string msg = $"Robo 2 Executou..{DateTimeOffset.Now}";
            Console.WriteLine(msg);
            g.Produto.Robo2 = msg;
        }
    }
    internal class Robo3
    {
        public void FazAlgumaCoisa(Gerenciador g)
        {
            System.Threading.Thread.Sleep(100);
            string msg = $"Robo 3 Executou..{DateTimeOffset.Now}";
            Console.WriteLine(msg);
            g.Produto.Robo3 = msg;
            g.Produto.Status = StatusProduto.EmAnalise;
            g.Repository.Atualizar(g.Produto);            
            g.ExecutarTarefas();
        }
    }
}
