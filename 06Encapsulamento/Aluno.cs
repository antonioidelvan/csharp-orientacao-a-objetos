using System;
class Aluno
{
    // Atributos
    private float nota1, nota2;

    // Média
    private float Media()
    {
        return (nota1 + nota2) / 2;
    }

    // Mensagem
    public void Mensagem()
    {

        Console.Write("Informe a primeira nota: ");
        nota1 = float.Parse(Console.ReadLine());

        Console.Write("Informe a segunda nota: ");
        nota2 = float.Parse(Console.ReadLine());

        Console.WriteLine("A média é igual a {0}.", Media());
    }
}