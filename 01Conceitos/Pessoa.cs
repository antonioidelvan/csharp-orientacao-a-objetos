using System;

class Pessoa
{
    // Atributos
    public string nome = string.Empty;
    public int idade;

    // Métodos
    public void Mensagem()
    {
        Console.WriteLine("Olá , {0}! Você tem {1} anos!", nome, idade);
    }
}