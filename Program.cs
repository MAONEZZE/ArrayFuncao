namespace ArrayFuncao
{
    internal class Program
    {
        public static void removerNum(ref int[] num, int numeroRemover)
        {
            for (int i = 0; i < 10; i++)
            {
                if (num[i] == numeroRemover)
                {
                    num[i] = 0;
                    break;
                }
            }
        }

        public static void mostrarNaTela(int nMaior, int nMenor, int numNegativo, decimal valorMedio, int[] num)
        {
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if (num[i] != 0)
                {
                    Console.Write(num[i] + ", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Valor Medio: " + valorMedio);
            Console.WriteLine("Maior número: " + nMaior);
            Console.WriteLine("Menor número: " + nMenor);
            Console.WriteLine("Valor Negativo: " + numNegativo);

            Array.Sort(num);

            Console.Write("Os 3 maiores números: ");
            for (int i = 7; i < 10; i++)
            {
                Console.Write(num[i] + " ");
            }

        }

        public static void verificador(ref int nMaior, ref int nMenor, int[] num, ref int numNegativo)
        {
            for (int i = 0; i < 10; i++)
            {
                if (num[i] < nMenor)
                {
                    nMenor = num[i];
                }

                if (num[i] > nMaior)
                {
                    nMaior = num[i];
                }

                if (num[i] < 0)
                {
                    numNegativo = num[i];
                }
            }
        }

        public static void lerNumeros(ref int[] num, ref int soma)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um numero: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
                soma = soma + num[i];
                Console.WriteLine();
            }
        }

        public static void Main()
        {
            int[] num = new int[10];
            int nMaior, nMenor, soma = 0, numNegativo = 0;
            decimal valorMedio;
            char op;
            int numeroRemover;

            lerNumeros(ref num, ref soma);

            nMaior = nMenor = num[0];

            verificador(ref nMaior, ref nMenor, num, ref numNegativo);

            Console.Write("Deseja remover algum número? (S/N): ");
            op = Convert.ToChar(Console.ReadLine());

            if (op == 's' || op == 'S')
            {
                Console.Write("Digite o numero que deseja remover: ");
                numeroRemover = Convert.ToInt32(Console.ReadLine());

                removerNum(ref num, numeroRemover);
            }

            valorMedio = soma / 10;

            mostrarNaTela(nMaior, nMenor, numNegativo, valorMedio, num);
        }
    }
}