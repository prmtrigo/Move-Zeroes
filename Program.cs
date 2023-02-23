namespace Move_Zeroes;
class Program
{

    static void MoverZeros(int[] vetor, int tamanho){

        //implementando contador
        int contador = 0;

        for(int i = tamanho -1; i >=0; i--){

            if(vetor[i] == 0){

                for (int j = i; j < tamanho - 1 - contador; j++)
                {
                    //jogando o zero sempre para a próxima posição e trocando ele de lugar
                    vetor[j] = vetor[j + 1];
                    vetor[j + 1] = 0;
                }

                contador++;
            }

        }

        for (int j = 0; j < tamanho; j++)
        {
            Console.Write(vetor[j] + " ");
        }

    }

    static void Main(string[] args)
    {
        
        Console.Write("Coloque o tamanho: ");
        //inserindo o tamanho
        int tamanho = Convert.ToInt32(Console.ReadLine());

        //declarando o vetor
        int[] vetor = new int [tamanho];

        //fazendo um loop
        for (int i = 0; i < tamanho; i++){

            Console.Write("Digite a posicao " + i + " do vetor:"); 
            vetor[i] = Convert.ToInt32(Console.ReadLine());
            
        }

        //chamando a função
        MoverZeros(vetor,tamanho);
    }
}
