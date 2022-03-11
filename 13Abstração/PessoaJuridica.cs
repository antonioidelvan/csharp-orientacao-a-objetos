using System;

class PessoaJuridica : Padrao
{
    // Método Obrigatório
    public override void TaxaEmprestimo(float valor)
    {
        Console.WriteLine("Taxa de empréstimo para Pessoa Jurídica R$ {0}", valor * 0.2f);
    }
}