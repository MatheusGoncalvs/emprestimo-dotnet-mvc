using emprestimomvc.Data;
using emprestimomvc.Data.DTO;
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
        Object Add(Object newObject);

        List<string> BuscarNomePessoa(string term);

        Pessoa BuscarPessoa(string nome);

        int Commit();
    }
}
