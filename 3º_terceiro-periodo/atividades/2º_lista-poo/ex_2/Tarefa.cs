class Tarefa
{
    public string _name;
    public int _horasTrabalhadasTarefa = 0;
    public Tarefa(string _name){
        this._name = _name.ToLower();
    }
}