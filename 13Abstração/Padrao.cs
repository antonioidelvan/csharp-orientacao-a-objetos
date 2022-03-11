using System;

abstract class Padrao
{
    // Obrigatório
    public abstract void TaxaEmprestimo(float valor);

    // Opcional
    public void CalculoPoupanca(float valor, float taxa)
    {
        Console.WriteLine("Ganhos obtidos pela poupança R$ {0}.", valor * taxa);
    }
}