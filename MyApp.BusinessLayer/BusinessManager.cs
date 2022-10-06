using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.DomainModel.Entities;
using MyApp.BusinessContract;
using MyApp.RepositoryContract;
using MyApp.RepositoryLayer;


namespace MyApp.BusinessLayer
{
    public class BusinessManager : IBusinessManager
    {
        private IPessoasRepositoryManager _pessoasRepositoryManager;

        public BusinessManager(IPessoasRepositoryManager pessoasRepositoryManager)
        {
            _pessoasRepositoryManager = pessoasRepositoryManager;
        }

        public async Task<Pessoa> GetPessoaAsync(int id)
        {
            return await _pessoasRepositoryManager.GetPessoaAsync(id);
        }

        public async Task<List<Pessoa>> GetPessoasAsync()
        {
            return await _pessoasRepositoryManager.GetPessoasAsync();
        }

        public async Task CreatePessoaAsync(Pessoa pessoa)
        {
            await _pessoasRepositoryManager.CreatePessoaAsync(pessoa);
        }

        public async Task EditPessoaAsync(Pessoa pessoa)
        {
            await _pessoasRepositoryManager.EditPessoaAsync(pessoa);
        }

        public async Task DeletePessoaAsync(int id)
        {
            await _pessoasRepositoryManager.DeletePessoaAsync(id);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposedValue = false; // To detect redundant calls
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _pessoasRepositoryManager.Dispose();
                }
                disposedValue = true;
            }
        }
    }
}
