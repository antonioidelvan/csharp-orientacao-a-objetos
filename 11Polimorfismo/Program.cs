using System;

namespace _11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Console.WriteLine("");

        // Instaciar Estagiário
        Imposto objetoE = new Estagiario();
        objetoE.ValeAlimentacao(1000);
        objetoE.ValeTransporte(1000);
        Console.WriteLine("----------------");

        // Instaciar Gerente
        Imposto objetoG = new Gerente();
        objetoG.ValeAlimentacao(5000);
        objetoG.ValeTransporte(5000);
        Console.WriteLine("----------------");

        // Instaciar Atendente
        Imposto objetoA = new Atendente();
        objetoA.ValeAlimentacao(2000);
        objetoA.ValeTransporte(2000);
        Console.WriteLine("----------------");
        }
    }
}