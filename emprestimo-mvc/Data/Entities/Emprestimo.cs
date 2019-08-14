using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emprestimomvc.Data.Entities
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public float Valor { get; set; }
        public string Prazo { get; set; }
        public DateTime DataEntrada { get; set; }
        public Pessoa Pessoa { get; set; }
        public string NomeCliente { get; set; }
    }
}
