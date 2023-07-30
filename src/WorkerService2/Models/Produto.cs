using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService2.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Robo1 { get; set; }
        public string Robo2 { get; set; }
        public string Robo3 { get; set; }
        public StatusProduto Status { get; set; }
        public void ExecutaCodigo()
        {
            Codigo = Id.ToString().PadLeft(6,'0');
        }
    }

    public enum StatusProduto
    {
        Novo = 0,
        EmAnalise = 1,
        Autorizado = 2
    }
}
