using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WorkerService2.DataAccess;

namespace WorkerService2.Models
{
    internal class Gerenciador
    {
        private static Queue<Produto> _filaProdutos;

        //object _data = new object();
        public Gerenciador()
        {
            Repository = new ProdutoRepository();
            _filaProdutos = new Queue<Produto>();
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
        public ProdutoRepository Repository { get; set; }

        public void ExecutarTarefas()
        {
            
            Produto = ObterProduto();
            if (Produto != null)
            {
                int id = Robo0.FazAlgumaCoisa(this);
                Robo1.FazAlgumaCoisa(this);
                Robo2.FazAlgumaCoisa(this);
                Robo3.FazAlgumaCoisa(this);
            }
        }

        private static Produto ObterProduto()
        {
            if (_filaProdutos.Count == 0)
            {
                _filaProdutos = new ProdutoRepository().ObterProdutos();
            }

            if(_filaProdutos.Count > 0)
            {
                return _filaProdutos.Dequeue();
            }

            return null;
            
        }
    }
}
