using System;

class Gerente : Imposto
{
    // Método
    public override void ValeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto gerente do vale alimentação R$ {0}", salario * 0.15);
    }
}