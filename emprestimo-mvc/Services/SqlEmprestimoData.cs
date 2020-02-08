using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using emprestimomvc.Data;
using emprestimomvc.Data.DTO;
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

        public Object Add(Object newObject)
        {
            db.Add(newObject);
            return newObject;
        }

        //Retorna um DTO object. Tentando retornar id para salvar no banco o id da pessoa.
        /*
        public List<EmprestimoModelView> BuscarNomePessoa(string term)
        {
            using (db)
            {
                var resultSearch = from p in db.pessoas
                                   select new EmprestimoModelView()
                                   {
                                       Id = p.Id,
                                       Nome = p.Nome
                                   };
                return resultSearch.ToList();
            }
        } */

        public Pessoa BuscarPessoa(string nome)
        {
             return this.db.pessoas.FirstOrDefault(p => p.Nome.Contains(nome));
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        List<string> IEmprestimoData.BuscarNomePessoa(string term)
        {
            var resultSearch = db.pessoas.Where(p => p.Nome.Contains(term))
                .Select(p => p.Nome).ToList();
            return resultSearch;
        }
    }
}
