class Extrato{
    public string tipo;
    private double valor;
    private double saldo;
    private int conta;
    private double limite;

    public Extrato(string tipo, double valor, double saldo, int conta, double limite){
        this.tipo = tipo;
        this.valor = valor;
        this.saldo = saldo;
        this.conta = conta;
        this.limite = limite;
    }
    public void Mostrar(){
        Console.WriteLine(tipo+" "+valor+" "+saldo+" "+conta+" "+limite);
    }
}