using System;
using System.Collections;
class Funcionario
{
    public string _nome;
    private string _cargo;
    private string _departamento;
    private int _dataDeAdmissao;
    static private int _horasTrabalhadas = 0;
    private Queue<Tarefa> tarefas;
    private int _quantidadeTarefasPendentes = 0;
    private const int _MAXHORASTRABALHADAS = 200;

    public Funcionario(string _nome, string _cargo, string _departamento, int _dataDeAdmissao){
        this._nome = _nome;
        this._cargo = _cargo;
        this._departamento = _departamento;
        this._dataDeAdmissao = _dataDeAdmissao;
        tarefas = new Queue<Tarefa>();
    }

    public bool AtribuirTarefa(string _name){
        Tarefa tarefa = new Tarefa(_name);
        if(_quantidadeTarefasPendentes != 10 && _horasTrabalhadas < _MAXHORASTRABALHADAS){
            _quantidadeTarefasPendentes++;
            tarefas.Enqueue(tarefa);
            return true;
        }
        return false;
    }
    public bool ExecutarTarefa(){
        tarefas.Dequeue();
        _quantidadeTarefasPendentes--;
        return true;
    }
    public void ExibirTarefas(){
        foreach(Tarefa tarefa in tarefas){
            Console.WriteLine(tarefa._name+" - Horas: "+tarefa._horasTrabalhadasTarefa);
        }
        Console.WriteLine("Existem "+_quantidadeTarefasPendentes+" tarefas pendentes!");
    }
    public bool LancarHorasTarefa(int _horas){
        Tarefa tarefa = tarefas.Peek();
        _horasTrabalhadas += _horas;
        tarefa._horasTrabalhadasTarefa += _horas;
        return true;
    }
}