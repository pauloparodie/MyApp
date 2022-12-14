using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.DomainModel.Entities;

namespace MyApp.RepositoryContract
{
    public interface IPessoasRepositoryManager : IDisposable
    {
        Task<List<Pessoa>> GetPessoasAsync();

        Task<Pessoa> GetPessoaAsync(int id);

        Task CreatePessoaAsync(Pessoa pessoa);

        Task EditPessoaAsync(Pessoa pessoa);

        Task DeletePessoaAsync(int id);
    }
}
