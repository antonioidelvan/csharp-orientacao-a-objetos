using System;

namespace Program;
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            p.nome = "Arroz";
            p.valor = 5; // 'valor' não é visivel em outra classe
        }
    }