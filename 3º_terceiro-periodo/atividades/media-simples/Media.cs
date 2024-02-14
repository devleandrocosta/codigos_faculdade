class Media
{
    public int CriarVetor(int tam)
    {
        int num;
        int soma = 0;
        int[] vetor = new int[tam];
        for (int i = 0; i< vetor.Length; i++){
            Console.Write("numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            vetor[i] = num;
            soma += num;
        }
        return soma;
    }
    public int MediaVetor()
    {
        Console.Write("tamanho vetor: ");
        int tamanhovetor = (Convert.ToInt32(Console.ReadLine()));
        int num = 0;
        int media = 0;
        num = CriarVetor(tamanhovetor);
        media = num / tamanhovetor;
        return media;
    }
}