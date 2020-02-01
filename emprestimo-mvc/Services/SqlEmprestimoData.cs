using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using emprestimomvc.Data;
using emprestimomvc.Data.Entities;

namespace emprestimomvc.Services
{
    public class SqlEmprestimoData : IEmprestimoData
    {
        private readonly emprestimoMvcContext db;

        public SqlEmprestimoData(emprestimoMvcContext db)
        {
            this.db = db;
        }

        public Pessoa Add(Pessoa newPessoa)
        {
            db.Add(newPessoa);
            return newPessoa;
        }

        public List<string> BuscarNomePessoa(string term)
        {
            var resultSearch = db.pessoas.Where(p => p.Nome.Contains(term))
                .Select(p => p.Nome).ToList();
            return resultSearch;
        }

        public IEnumerable<Pessoa> BuscarPessoa(string nome)
        {
            var pessoas = db.pessoas.Where(p => p.Nome.Contains(nome)).ToList<Pessoa>();
            return pessoas;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

    }
}
