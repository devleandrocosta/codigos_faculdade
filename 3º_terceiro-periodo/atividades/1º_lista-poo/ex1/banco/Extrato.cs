class Extrato
{
    public List<string> extrato;
    public Extrato()
    {
        extrato = new List<string>();
    }

    public void Inserir(string tipo, double valor)
    {
        if (extrato.Count == 10)
        {
            extrato.RemoveAt(0);
        }
        extrato.Add(tipo + " " + valor);
    }

    public void UltimoMovimento()
    {
        if (extrato.Count > 0){
            Console.WriteLine(extrato[extrato.Count - 1]);
        }
    }
}