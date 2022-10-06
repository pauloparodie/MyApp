using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.DomainModel.Entities;
using MyApp.DataLayer.Context;
using System.Data.Entity;
using MyApp.RepositoryContract;


namespace MyApp.RepositoryLayer
{
    public class PessoasRepositoryManager : IPessoasRepositoryManager
    {
        private ModelContext _ctx;

        public PessoasRepositoryManager()
        {
            _ctx = new ModelContext();
        }

        public async Task<Pessoa> GetPessoaAsync(int id)
        {
            return await _ctx.Pessoas.FindAsync(id);
        }

        public async Task<List<Pessoa>> GetPessoasAsync()
        {
            return await _ctx.Pessoas.ToListAsync<Pessoa>();
        }

        public async Task CreatePessoaAsync(Pessoa pessoa)
        {
            _ctx.Pessoas.Add(pessoa);
            await _ctx.SaveChangesAsync();
        }

        public async Task EditPessoaAsync(Pessoa pessoa)
        {
            _ctx.Entry<Pessoa>(pessoa).State = EntityState.Modified;
            await _ctx.SaveChangesAsync();
        }

        public async Task DeletePessoaAsync(int id)
        {
            var elem = await _ctx.Pessoas.FindAsync(id);
            if (elem == null)
            {
                throw new Exception("Element not found");
            }
            _ctx.Pessoas.Remove(elem);
            await _ctx.SaveChangesAsync();
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
                    _ctx.Dispose();
                }
                disposedValue = true;
            }
        }
    }
}
