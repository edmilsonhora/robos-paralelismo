using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService2.Models
{
    internal class Robo0
    {
        private static int _numerador;
        public int FazAlgumaCoisa(Gerenciador g)
        {            
            if (_numerador < 20)
            {
                g.Produto.Id = Numerador();
                Console.WriteLine($"Pedido Id: {g.Produto.Id}");
                g.Produto.ExecutaCodigo();                
                Console.WriteLine($"Pedido Cod: {g.Produto.Codigo}");
                return g.Produto.Id;
            }
            return 0;
        }
        private static int Numerador()
        {
            return ++_numerador;
        }
    }
    internal class Robo1
    {
        public void FazAlgumaCoisa(Gerenciador g)
        {
            Console.WriteLine($"Robo 1 Executou..{DateTimeOffset.Now}");
            System.Threading.Thread.Sleep(1000);
        }
    }
    internal class Robo2
    {
        public void FazAlgumaCoisa(Gerenciador g)
        {
            Console.WriteLine($"Robo 2 Executou..{DateTimeOffset.Now}");
            System.Threading.Thread.Sleep(1000);
        }
    }
    internal class Robo3
    {
        public void FazAlgumaCoisa(Gerenciador g)
        {
            Console.WriteLine($"Robo 3 Executou..{DateTimeOffset.Now}");            
            System.Threading.Thread.Sleep(1000);

            g.ExecutarTarefas();
        }
    }
}
