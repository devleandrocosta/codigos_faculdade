class Menu
{
    Empresa empresa = new Empresa();
    public void menu(){
        empresa.CadastrarNovoFuncionario("Leandro", "Analista de T.I", "Departamento de tecnologia", 230621);
        Console.Write("Nome do funcionario: ");
        var _nome = Console.ReadLine();
        empresa.GerenciarFuncionario(_nome);
    }
}