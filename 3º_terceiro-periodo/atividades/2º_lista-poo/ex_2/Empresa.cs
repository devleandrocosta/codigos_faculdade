using System.Collections;
class Empresa
{
    private List<Funcionario> _funcionarios;
    public Empresa() { 
        _funcionarios = new List<Funcionario>();
    }

    public bool CadastrarNovoFuncionario(string _nome, string _cargo, string _departamento, int _dataDeAdmissao)
    {
        _funcionarios.Add(new Funcionario(_nome, _cargo, _departamento, _dataDeAdmissao));
        return true;
    }

    public bool GerenciarFuncionario(string _nome)
    {
        foreach (Funcionario funcionario in _funcionarios)
        {
            if (funcionario._nome == _nome)
            {
                string _opcao = " ";
                do
                {
                    Console.Write("Digite a opçao que deseja: ");
                    _opcao = Console.ReadLine();
                    switch (_opcao)
                    {
                        case "1":
                            Console.Write("Nome tarefa: ");
                            var _name = Console.ReadLine();
                            if (funcionario.AtribuirTarefa(_name))
                            {
                                Console.WriteLine("Sucesso!");
                            }
                            break;
                        case "2":
                            if (funcionario.ExecutarTarefa())
                            {
                                Console.WriteLine("Sucesso!");
                            }
                            break;
                        case "3":
                            funcionario.ExibirTarefas();
                            break;
                        case "4":
                            Console.Write("Horas: ");
                            var _horas = Convert.ToInt32(Console.ReadLine());
                            funcionario.LancarHorasTarefa(_horas);
                            break;
                    }
                } while (_opcao != "sair");
            }
            break;
        }
        return true;
    }
}