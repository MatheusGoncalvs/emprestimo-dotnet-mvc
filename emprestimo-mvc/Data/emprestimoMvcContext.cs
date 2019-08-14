using emprestimomvc.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emprestimomvc.Data
{
    public class emprestimoMvcContext : DbContext
    {
        public emprestimoMvcContext(DbContextOptions<emprestimoMvcContext> options) : base(options)
        {
        }

        public DbSet<Emprestimo> emprestimos { get; set; }
        public DbSet<Pessoa> pessoas { get; set; }
    }
}
