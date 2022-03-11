using System;

namespace _04ExercicioIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa individuo1 = new Pessoa();

            Console.WriteLine("Olá, bem-vindo ao cálculo de IMC!");
            Console.Write("Qual é a sua altura? ");
            individuo1.altura = float.Parse(Console.ReadLine());

            Console.Write("Qual é o seu peso? ");
            individuo1.peso = float.Parse(Console.ReadLine());

            individuo1.Mensagem();
        }
    }
}