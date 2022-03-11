using System;

class Colaborador : Pessoa
{
    // Atributos
    private float salario = 0;

    // Construtor
    public Colaborador(string nome, int idade, float salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        MensagemPessoa();
        MensagemColaborador();
    }

    // Método
    private void MensagemColaborador()
    {
        Console.WriteLine("Salário: R$ {0}.", salario);
    }
}