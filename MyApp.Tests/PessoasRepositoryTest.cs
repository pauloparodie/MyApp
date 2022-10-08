using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApp.DomainModel.Entities;
using MyApp.RepositoryLayer;
using System.Threading.Tasks;
using MyApp.RepositoryContract;
using System.Diagnostics;


namespace MyApp.Tests
{
    [TestClass]
    public class PessoasRepositoryTest
    {
        [TestMethod]
        public async Task TestCreatePessoa()
        {
            using (IPessoasRepositoryManager repo = new PessoasRepositoryManager())
            {

                Pessoa newPessoa = new Pessoa { Name = "Pessoa Teste", Pais = "Egypt", Age = 23, PhotoName = "pic45.jpg" };
                try
                {
                    await repo.CreatePessoaAsync(newPessoa);
                }
                catch (Exception ex)
                {
                    int a = 0;
                }
                int id = newPessoa.Cod;

                Pessoa pessoaDb = await repo.GetPessoaAsync(newPessoa.Cod);
                Assert.IsTrue(newPessoa.Name.Equals(pessoaDb.Name));
                Assert.IsTrue(newPessoa.Pais.Equals(pessoaDb.Pais));
                Assert.IsTrue(newPessoa.Age.Equals(pessoaDb.Age));
                Assert.IsTrue(newPessoa.PhotoName.Equals(pessoaDb.PhotoName));

                Console.WriteLine("TESTE COM SUCESSO1");
                Trace.WriteLine("TESTE COM SUCESSO2");
            }
        }
    }
}
