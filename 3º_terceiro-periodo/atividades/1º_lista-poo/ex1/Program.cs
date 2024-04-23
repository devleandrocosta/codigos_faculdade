// +--------------------------+
// |          Conta           |
// +--------------------------+
// | - cpf: double            |
// | - numConta: double       |
// | - nome: string           |
// | - saldo: double          |
// | - limite: double         |
// | - extrato: Extrato       |
// +--------------------------+
// | + Conta(c: double, num: double, nomes: string) |
// | + InserirMovimento(tipo: string, valor: double): void |
// | + Imprimir(): void |
// | + Mostrar(): void |
// +--------------------------+

// +--------------------------+
// |         Extrato          |
// +--------------------------+
// | - extrato: List<string>  |
// +--------------------------+
// | + Extrato()              |
// | + Inserir(tipo: string, valor: double): void |
// | + ExtratoMetodo(): void  |
// +--------------------------+
class Program{
    public static void Main(){
        Menu menu = new Menu();
        menu.MenuGeral();
    }
}