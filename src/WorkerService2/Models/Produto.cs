using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService2.Models
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public void ExecutaCodigo()
        {
            Codigo = Id.ToString().PadLeft(5,'0');
        }
    }
}
