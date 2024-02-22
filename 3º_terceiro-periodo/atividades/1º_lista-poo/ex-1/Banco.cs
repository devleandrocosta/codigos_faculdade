class Banco{
    public void Menu(){
        int opc = -1;

        do{
            Console.Write("Digite a opção que desejar: ");
            opc = Console.ReadLine();
            
            switch(opc){
                case 1:
                    CriarConta();
                break;
                case 2:
                    VerificarDeposito();
                break;

                default:
                    Console.WriteLine("Escolha uma opção");
                break;
            }
        }while(opc != 0);
    }
    private void CriarConta(){
        string nome;
        string cpf;

        Console.Write("NOME: ");
        nome = Console.ReadLine();
        Console.Write("CPF: ");
        cpf = Console.ReadLine();

        SalvarConta(cpf, nome);
    }
    public bool SalvarConta(string cpf, string nome){
        string diretorio = Directory.GetCurrentDirectory() + "/db/contas.txt";
        using (StreamWriter writer = new StreamWriter(diretorio, append: true))
        {
            string data = $"{cpf},{nome}";
            writer.WriteLine(data);
        }
    }
    public void VerificarConta(string cpf, string nome){
        string diretorio = Directory.GetCurrentDirectory() + "/db/contas.txt";
        string[] data = File.ReadLines(diretorio).ToArray();
        for (int i = 0; i < data.Length; i++)
        {
            Console.WriteLine(data[i]);
        }
    }

    public void VerificarDeposito(){
        string cpf;
        string valor;

        Console.Write("CPF: ");
        cpf = Console.ReadLine();
        Console.Write("Valor: ");
        valor = Console.ReadLine();
    }
}