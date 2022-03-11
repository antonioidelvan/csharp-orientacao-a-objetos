using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar um objeto

            Pessoa obj = new Pessoa();
            obj.nome = "Antonio";
            obj.idade = 18;

            obj.Mensagem();
        }
    }
}