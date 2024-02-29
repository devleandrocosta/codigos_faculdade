class Menu{
    Banco banco = new Banco();
    public void MenuGeral(){
        int op = -1;
        do{
            Console.WriteLine("1 - Sacar");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            op = Convert.ToInt32(Console.ReadLine());
            switch(op){
                case 1:
                    banco.Sacar();
                break;
                case 2:
                    banco.Depositar();
                break;
                default:
                    Console.WriteLine("Digite uma opção valida");
                break;
            }
        }while(op != 0);
    }
}