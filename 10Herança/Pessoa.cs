using System;

class Pessoa 
{
    // Atributos
    protected string nome = "";
    protected int idade = 0;

    // Método
    protected void MensagemPessoa()
    {
        Console.WriteLine("Nome: {0}.", nome);
        Console.WriteLine("Idade: {0} anos.", idade);
    }
}