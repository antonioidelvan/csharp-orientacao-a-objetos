using System;

class Pessoa
{


    // M�todo 03
    public void Apresentar(string nome, int idade)
    {
        Console.WriteLine("Ol�, {0}! Voc� tem {1} anos!", nome, idade);
    }

    public void Teste(){
        Apresentar("");
    }

}