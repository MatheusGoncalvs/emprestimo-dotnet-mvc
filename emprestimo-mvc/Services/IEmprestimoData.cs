using emprestimomvc.Data;
using emprestimomvc.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emprestimomvc.Services
{
    public interface IEmprestimoData
    {
        Pessoa Add(Pessoa newPessoa);

        List<string> BuscarNomePessoa(string term);

        IEnumerable<Pessoa> BuscarPessoa(string nome);

        int Commit();
    }
}
