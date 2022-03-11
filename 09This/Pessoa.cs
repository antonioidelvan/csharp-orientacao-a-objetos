using System;

class Pessoa
{

    // Atributo
    private string nome = "André";
    
    // Construtor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}