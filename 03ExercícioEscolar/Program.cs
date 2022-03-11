using System;

namespace _03ExercícioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instaciar objeto da classe Aluno
            Aluno a = new Aluno();
            Aluno b = new Aluno();
            Aluno c = new Aluno();
            Aluno d = new Aluno();

            a.nome = "Antonio";
            a.nota1 = 8;
            a.nota2 = 10;

            b.nome = "André";
            b.nota1 = 5;
            b.nota2 = 7;

            c.nome = "Antônio César";
            c.nota1 = 6;
            c.nota2 = 9;

            d.nome = "Letícia";
            d.nota1 = 7;
            d.nota2 = 7;

            a.Mensagem();
            b.Mensagem();
            c.Mensagem();
            d.Mensagem();
            
            Console.WriteLine("");
        }
    }
}