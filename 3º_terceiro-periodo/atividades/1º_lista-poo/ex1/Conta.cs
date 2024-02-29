using System;

class Conta
{
    public double cpf;
    public double numConta;
    public string nome;
    public double saldo;
    public double limite;

    // Corrigir o nome do construtor
    public Conta(double c,double num, string nomes)
    {
        this.cpf = c;
        this.numConta = num;
        this.nome = nomes;
        this.saldo = 0;
        this.limite = 100;
    }

    public void Mostrar()
    {
        Console.WriteLine(saldo+" "+limite);
    }
}
