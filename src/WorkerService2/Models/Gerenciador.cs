using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService2.Models
{
    internal class Gerenciador
    {
        public Gerenciador()
        {
            Robo0 = new Robo0();
            Robo1 = new Robo1();
            Robo2 = new Robo2();
            Robo3 = new Robo3();
        }

        protected Robo0 Robo0 { get; }
        protected Robo1 Robo1 { get; }
        protected Robo2 Robo2 { get; }
        protected Robo3 Robo3 { get; }
        public Produto Produto { get; set; }

        public void ExecutarTarefas()
        {
            Produto = new Produto();
            int id = Robo0.FazAlgumaCoisa(this);
            if (id != 0)
            {
                Robo1.FazAlgumaCoisa(this);
                Robo2.FazAlgumaCoisa(this);
                Robo3.FazAlgumaCoisa(this);
            }
        }
    }
}
