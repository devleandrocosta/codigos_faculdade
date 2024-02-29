class Banco{
    Conta conta = new Conta(123456789, 12345, "leandro costa");

    public void Sacar(){
        Console.Write("Sacar: ");
        double valor = Convert.ToInt32(Console.ReadLine());
        Console.Write("Numero da conta:");
        int numeroConta = Convert.ToInt32(Console.ReadLine());

        if(numeroConta == conta.numConta){
            if(valor <= conta.saldo){
                conta.saldo -= valor;
            }
            else if(valor > conta.saldo){
                conta.saldo -= valor;
                conta.limite += conta.saldo;
                conta.saldo = 0;
            }
            else if(valor <= conta.limite && conta.saldo == 0){
                conta.limite -= valor;
            }
        }
        conta.Mostrar();
    }
    public void Depositar(){
        Console.Write("Depositar: ");
        double valor = Convert.ToInt32(Console.ReadLine());
        Console.Write("Numero da conta:");
        int numeroConta = Convert.ToInt32(Console.ReadLine());

        double porcent = 0;
        double limit = conta.limite;

        if(numeroConta == conta.numConta){
            if(conta.saldo == 0 || conta.limite < 0){
                porcent -= conta.limite*1.03;
                if(conta.saldo >= 0){
                    conta.saldo = valor;
                    if(conta.limite < 0){
                        conta.saldo -= porcent;
                        conta.limite -= limit;
                    }
                }
            }
            else if(conta.saldo > 0 && conta.limite == 0){//deposito com limite no 0
                conta.saldo += valor;
            } 
        }
        conta.Mostrar();
    }
}