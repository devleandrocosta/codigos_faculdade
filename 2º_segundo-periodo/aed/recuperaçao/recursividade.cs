using System;
class Recursividade{
    public int exercicio1(int n){
        //Escreva uma função recursiva que calcule a soma dos primeiros n cubos: S(n) = 13 + 23 + ... +n3
        if(n == 0){
            return 0;
        }
        else{
            return (int)Math.Pow(n,3)+exercicio1(n-1);
        }
    }
    public int exercicio2(int i, int j, int k){
        //Escreva uma função recursiva SomaSerie(i,j,k). Esta função devolve a soma da série de valores do intervalo [i,j], com incremento k
        if(i > j){
            return 0; 
        }
        else{
            return i+exercicio2(i+k,j,k);
        }
    }
    public int exercicio3(int n){
        //Faça uma função recursiva que receba um número inteiro positivo ímpar N e retorne o fatorial duplo desse número. O fatorial duplo é definido como o produto de todos os números naturais ímpares de 1 até algum número natural ímpar N. Assim, o fatorial duplo de 5 é: 5!! = 1 * 3 * 5 = 15
        if(n == 1){
            return 1;
        }
        else{
            return n*exercicio3(n-2);
        }
    }
    public int exercicio4(int n){
        //Faça uma função recursiva para calcular os números de Pell. Os números de Pell são definidos, pela seguinte recursão:, p(n) = 0 se n = 0;, p(n) = 1 se n = 1;, p(n) = 2p(n-1)+ p(n-2) se n > 1
        if(n == 0){
            return 0;
        }
        else if(n == 1){
            return 1;
        }
        else{
            return 2*exercicio4(n-1)+exercicio4(n-2);
        }
    }
    public int exercicio5(int x, int y){
        //O máximo divisor comum dos inteiros x e y é o maior inteiro que é divisível por x e y. Escreva uma função recursiva mdc que retorna o máximo divisor comum de x e y. O mdc de x e y é definido como segue: se y é igual a 0, então mdc(x,y) é x; caso contrário, mdc(x,y) é mdc (y, x%y), onde % é o operador resto
        if(y == 0){
            return x;
        }
        else{
            return exercicio5(y, x%y);
        }
    }
    static int exercicio6(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * exercicio6(n - 1);
        }
    }

    static int SuperfatorialExercicio3(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return exercicio6(n) * SuperfatorialExercicio3(n - 1);
        }
    }
}