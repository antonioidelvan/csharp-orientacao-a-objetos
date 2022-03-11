using System;

class PessoaFisica : Padrao
{

    // Método Obrigatório
    public override void TaxaEmprestimo(float valor)
    {
        Console.WriteLine("Taxa de empréstimo para Pessoa Física R$ {0}", valor * 0.1f);
    }
}