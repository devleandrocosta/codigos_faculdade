class Quarto
{
    public bool Disponibilidade = true;
    public bool Limpo = true;
    private int Preco { get; set; }
    public int NumeroQuarto { get; set; }
    
    public Quarto(int NumeroQuarto){
        this.NumeroQuarto = NumeroQuarto;
    }
    public void LimparQuarto(){
        Limpo = true;
    }
    public void QuartoEmUso(){
        Limpo = false;
    }
}