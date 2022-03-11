using System;

class Atendente : Imposto
{
    // Método
    public override void ValeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto atendente do vale alimentação R$ {0}", salario * 0.12);
    }
}