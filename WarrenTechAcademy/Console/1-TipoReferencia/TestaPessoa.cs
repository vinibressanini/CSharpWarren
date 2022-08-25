using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class TestaPessoa

    {
        public static void ExecutaPessoa()
        {
            Pessoa p = new Pessoa("Vinicius", "Oliveira");
            Pessoa pf = new PessoaFisica("Vinicius", "Oliveira", "12312312312");
            Pessoa pj = new PessoaJuridica("Vinicius", "Oliveira", "123457891212");

            PessoaFisica pf2 = (PessoaFisica)pf;
            PessoaJuridica pj2 = (PessoaJuridica)pj;
            
            BaseRepository<Pessoa> repo = new BaseRepository<Pessoa>();
            repo.Create(p);
            repo.Create(pj2);
            repo.Create(pf2);

            foreach (var pessoa in repo.Read())
            {
                System.Console.WriteLine(pessoa.Saudacao());
            }

        }



        public static void ExecutaFisica()
        {
            PessoaFisica pessoaFisica = new PessoaFisica("Vinicius", "Bressanini", "12345678910");
            PessoaFisica pessoaFisica2 = new PessoaFisica("Vinicius", "Marcus", "12345678910");


            PessoaFisicaRepository repositoryPF = new PessoaFisicaRepository();

            repositoryPF.Create(pessoaFisica);
            repositoryPF.Create(pessoaFisica2);

            List<PessoaFisica> pessoasPF = repositoryPF.Read();


            foreach (var p in pessoasPF)
            {
                System.Console.WriteLine(p.Saudacao());
            }

        }

        public static void ExecutaJuridica()
        {
            PessoaJuridica pessoaJuridica1 = new PessoaJuridica("Bressanini", "Vinicius", "12345678910");
            PessoaJuridica pessoaJuridica2 = new PessoaJuridica("Marcus", "Vinicius", "12345678910");

            PessoaJuridicaRepository repositoryPJ = new PessoaJuridicaRepository();

            repositoryPJ.Create(pessoaJuridica1);
            repositoryPJ.Create(pessoaJuridica2);

            List<PessoaJuridica> pessoasPJ = repositoryPJ.Read();

            foreach (var p in pessoasPJ)
            {
                System.Console.WriteLine(p.Saudacao());
            }

        }

    }
}
