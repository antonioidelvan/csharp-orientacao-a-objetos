using System;

namespace _08GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            
            // Recebendo (Get)
            p.Nome;
            // Enviando (Set)
            p.Nome = "Antonio";

            Console.WriteLine(p.Nome);
        }
    }
}