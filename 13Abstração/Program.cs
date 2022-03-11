using System;

namespace _13Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            PessoaFisica pf = new PessoaFisica();
            pf.TaxaEmprestimo(1000);

            PessoaJuridica pj = new PessoaJuridica();
            pj.TaxaEmprestimo(1000);

            Console.WriteLine("");
        }
    }
}