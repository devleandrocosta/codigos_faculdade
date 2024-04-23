class Hospede
{
    public long Cpf { get; set; }
    private long Telefone { get; set; }
    public string Nome { get; set; } = " ";
    private string Endereco { get; set; } = " ";
    public int quarto { get; set; }

    public Hospede(long Cpf, long Telefone, string Nome, string Endereco){
        this.Cpf = Cpf;
        this.Telefone = Telefone;   
        this.Nome = Nome;   
        this.Endereco = Endereco;
    }
}