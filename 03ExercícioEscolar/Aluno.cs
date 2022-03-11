using System;

class Aluno
{
    // Atributos

    public string nome = string.Empty, situacao = string.Empty;
    public double media, nota1, nota2;

    // Média
    public double Media()
    {
        media = (nota1 + nota2)/2;
        return media;
    }

    // Situação
    public string Situacao()
    {
        if (Media() >= 7)
        {
            situacao = "aprovado";
        }
        else
        {
            situacao = "reprovado";
        }

        return situacao;
    }

    // Mensagem
    public void Mensagem()
    {
        // Obter a média
        double obterMedia = Media();

        // Obter a situação
        string obterSituacao = Situacao();

        // Mensagem
        Console.WriteLine("");
        Console.WriteLine("{0} está {1} com média igual a {2}.", nome, obterSituacao, obterMedia);
    }
}