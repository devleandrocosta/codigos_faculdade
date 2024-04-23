using System.ComponentModel;

class Hotel
{
    private const int QUANTIDADEQUARTOS = 30;
    private List<Quarto> quartos = new List<Quarto>(){
        new Quarto(1),
        new Quarto(2),
        new Quarto(3),
        new Quarto(4),
        new Quarto(5),
        new Quarto(6),
        new Quarto(7),
        new Quarto(8),
        new Quarto(9),
        new Quarto(10),
        new Quarto(11),
        new Quarto(12),
        new Quarto(13),
        new Quarto(14),
        new Quarto(15),
        new Quarto(16),
        new Quarto(17),
        new Quarto(18),
        new Quarto(19),
        new Quarto(20),
        new Quarto(21),
        new Quarto(22),
        new Quarto(23),
        new Quarto(24),
        new Quarto(25),
        new Quarto(26),
        new Quarto(27),
        new Quarto(28),
        new Quarto(29),
        new Quarto(30),
    };
    private List<Hospede> hospedes = new List<Hospede>(60);

    public bool Check_in(long CPF, long Numero, string Nome, string Endereco){
        Hospede hospede = new Hospede(CPF, Numero, Nome, Endereco);
        hospedes.Add(hospede);
        hospede.quarto = EscolherQuartoDisponivel();
        foreach (Quarto quartoOcupado in quartos)
        {
            if(quartoOcupado.NumeroQuarto == hospede.quarto){
                quartoOcupado.Disponibilidade = false;
                quartoOcupado.QuartoEmUso();
            }
        }
        return true;
    }
    public bool Check_out(long Cpf){
        int i = 0;
        foreach(Hospede hospedeAsair in hospedes){
            if(hospedeAsair.Cpf == Cpf){
                hospedes.Remove(hospedeAsair);
                var quarto = hospedeAsair.quarto;
                foreach (Quarto quartoCheckOut in quartos)
                {
                    if(quartoCheckOut.NumeroQuarto == quarto){
                        quartoCheckOut.Disponibilidade = true;
                        quartoCheckOut.LimparQuarto();
                    }
                }
                break;
            }
            i++;
        }
        return true;
    }
    public int EscolherQuartoDisponivel(){
        int NumeroQuarto = 1;
        foreach(Quarto quarto in quartos){
            if(quarto.Disponibilidade == true){
                return NumeroQuarto;
            }
            NumeroQuarto++;
        }
        return NumeroQuarto;
    }

    public void MostrarListaDeHospedes(){
        foreach(Hospede hospede in hospedes) {
            Console.Write("{0}", hospede.Nome);
        }
    }
}