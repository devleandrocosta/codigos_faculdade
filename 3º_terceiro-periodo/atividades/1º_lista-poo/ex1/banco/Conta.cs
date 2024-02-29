using System;
using System.Collections.Generic;
class Conta
{
    public double cpf;
    public double numConta;
    public string nome;
    public double saldo;
    public double limite;
    List<Extrato> extrato = new List<Extrato>(); 

    public Conta(double c,double num, string nomes)
    {
        this.cpf = c;
        this.numConta = num;
        this.nome = nomes;
        this.saldo = 0;
        this.limite = 0;
    }

    public void Mostrar()
    {
        Console.WriteLine("Saldo: "+saldo+" / Limite: "+limite);
        extrato.add(saldo);
    }
}
