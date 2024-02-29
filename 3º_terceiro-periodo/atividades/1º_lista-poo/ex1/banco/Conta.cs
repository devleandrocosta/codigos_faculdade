using System;
using System.Collections.Generic;
class Conta
{
    public double cpf;
    public double numConta;
    public string nome;
    public double saldo;
    public double limite;
    public Extrato extrato;

    public Conta(double c, double num, string nomes)
    {
        this.cpf = c;
        this.numConta = num;
        this.nome = nomes;
        this.saldo = 0;
        this.limite = 0;
        this.extrato = new Extrato();
    }
    public void InserirMovimento(string tipo, double valor)
    {
        extrato.Inserir(tipo, valor);
    }
    public void Imprimir()
    {
        for (int i = 0; i < extrato.extrato.Count; i++)
        {
            Console.WriteLine((i+1) + "ª: " + extrato.extrato[i]);
        }
    }

    public void Mostrar()
    {
        Console.WriteLine("Saldo: " + saldo + " / Limite: " + limite);
    }
}
