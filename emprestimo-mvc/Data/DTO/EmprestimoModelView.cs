using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emprestimomvc.Data.DTO
{
    public class EmprestimoModelView
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Entrada { get; set; }
        public double Valor { get; set; }
        public string Prazo { get; set; }
    }
}
