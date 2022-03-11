using System;

class Imposto
{
    // Métodos
    public virtual void ValeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto padrão do vale alimentação R$ {0}", salario * 0.1);
    }

    public void ValeTransporte(double salario)
    {
        Console.WriteLine("Desconto padrão do vale transporte R$ {0}", salario * 0.06);
    }
}