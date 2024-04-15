using System.Collections;

class Menu
{
    public void menu(){
        Hotel hotel= new Hotel();
        int OpcaoDeAcao;
        do{
            Console.Write("Proxima açao: ");
            OpcaoDeAcao = Convert.ToInt32(Console.ReadLine());
            switch (OpcaoDeAcao){
                case 1: 
                    Console.Write("CPF: ");
                        long CPF = long.Parse(Console.ReadLine());
                    Console.Write("Numero de celular: ");
                        long Numero = long.Parse(Console.ReadLine());
                    Console.Write("Endereço: ");
                        var Endereco = Console.ReadLine();      
                    Console.Write("Nome: ");
                        var Nome = Console.ReadLine();  
                    hotel.Check_in(CPF, Numero, Nome, Endereco);
                break;
                case 2:
                    Console.Write("CPF: ");
                        CPF = long.Parse(Console.ReadLine());
                    hotel.Check_out(CPF);                
                break;
                case 3:
                    hotel.MostrarListaDeHospedes();
                break;
            }
        }while(OpcaoDeAcao != 0);
    }
}