class Banco{
    Conta conta_1 = new Conta(123456789, 123, "leandro costa");
    Conta conta_2 = new Conta(123456788, 124, "leandro augusto");
    Conta conta_3 = new Conta(123456787, 125, "leandro lino");

    public void Sacar(){
        Console.Write("Sacar: ");
        double valor = Convert.ToInt32(Console.ReadLine());
        Console.Write("Numero da conta:");
        int numeroConta = Convert.ToInt32(Console.ReadLine());

        if(numeroConta == conta_1.numConta){
            if(valor <= conta_1.saldo){
                conta_1.saldo -= valor;
            }
            else if(valor > conta_1.saldo){
                conta_1.saldo -= valor;
                conta_1.limite += conta_1.saldo;
                conta_1.saldo = 0;
            }
            else if(valor <= conta_1.limite && conta_1.saldo == 0){
                conta_1.limite -= valor;
            }
        }
        conta_1.Mostrar();
    }
    public void Depositar(){
        Console.Write("Depositar: ");
        double valor = Convert.ToInt32(Console.ReadLine());
        Console.Write("Numero da conta:");
        int numeroConta = Convert.ToInt32(Console.ReadLine());

        double limite = 100;

        if(numeroConta == conta_1.numConta){
            if(conta_1.limite == 100){
                conta_1.saldo += valor;
            }
            else if(conta_1.saldo == 0 && conta_1.limite > 0){
                conta_1.limite -= valor;
            }
            else if(conta_1.limite > 0){
                double pcent = conta_1.limite * 0.003;
                conta_1.saldo -= (conta_1.limite + pcent);
            }
            else if(conta_1.saldo == 0 && conta_1.limite < 100){
                conta_1.saldo += (valor - (conta_1.limite*1.003));
            }
        }
        conta_1.Mostrar();
    }
}