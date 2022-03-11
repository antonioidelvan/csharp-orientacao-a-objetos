using System;

class Pessoa
{
    public float altura = 0, peso = 0, valorIMC = 0;
    public string situacaoIMC = string.Empty;

    public float CalcularIMC()
    {
        valorIMC = peso / (altura * altura);

        return valorIMC;
    }

    public string Situacao()
    {
        double obterIMC = CalcularIMC();

        if(obterIMC < 18.5f)
        {
            situacaoIMC = "abaixo do peso";
        }

        else if(obterIMC < 25f)
        {
            situacaoIMC = "peso normal";
        }

        else if(obterIMC < 30f)
        {
            situacaoIMC = "acima do peso";
        }

        else if(obterIMC < 35f)
        {
            situacaoIMC = "obesidade I";
        }

        else if(obterIMC < 40f)
        {
            situacaoIMC = "obesidade II";
        }

        else if(obterIMC >= 40f)
        {
            situacaoIMC = "obesidade III";
        }
        return situacaoIMC;
    }

    public void Mensagem()
    {
        string obterSituacao = Situacao();

        Console.WriteLine("Olá seu peso e altura é respectivamente {0} kg e {1} metros. O seu IMC é igual a {2}, sendo essa a sua situação {3}.", peso, altura, valorIMC, obterSituacao);
    }
}