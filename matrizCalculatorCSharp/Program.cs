using System;

namespace matrizCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program Start");
            mainMenu();
        }

        public static void mainMenu()
        {
            int seletor;
            Console.Write(
                "Escolher a função\n" +
                "\t 1 - Somar Matrizes\n" +
                "\t 2 - Subtrair Matrizes\n" +
                "\t 3 - Multiplicar Matrizes\n" +
                "\t 0 - encerrar programa\n"
            );
            seletor = Convert.ToInt32(Console.ReadLine());
            switch (seletor)
            {
                case 1:
                    //*declaração da matriz
                    int[,]  matriz1 = criarMatriz(),
                            matriz2 = criarMatriz();

                    mostrarMatriz(somarMatizes(matriz1, matriz2));

                    break;
                case 2:
                    Console.WriteLine("Opção Dois");
                    break;
            }
        }
        public static int[,] criarMatriz()
        {
            int[,] matriz;

            int col,
                row;

            //*definindo tamanho e os parametros da matriz
            Console.WriteLine("quantas colunas terá a matriz?");
            col = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("quantas Linhas terá a matriz?");
            row = Convert.ToInt32(Console.ReadLine());

            matriz = new int[col, row];

            for (int colCount = 0; colCount < col; colCount++)
            {
                for (int rowCount = 0; rowCount < row; rowCount++)
                {
                    Console.WriteLine($"Insira o valor da posição {colCount}x{rowCount} da matriz");
                    matriz[colCount, rowCount] = Convert.ToInt32(Console.ReadLine());
                }
            }

            return matriz;
        }

        public static void mostrarMatriz(int[,] matriz)
        {
            //* mostrar o resultado
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write("[");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    
                    Console.Write($"{matriz[j, i]}\t");
                }
                Console.WriteLine(" ]");
            }

        }
        public static int[,] somarMatizes(int[,] matriz1, int[,] matriz2)
        {
            int[,] resultado = new int[matriz1.GetLength(0), matriz1.GetLength(1)];

            //* verificar se as matrizes possuem o mesmo tamanho x e y
            if (matriz1.GetLength(0) == matriz2.GetLength(0) && matriz1.GetLength(1) == matriz2.GetLength(1))
            {
                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz1.GetLength(1); j++)
                    {
                        //* realizar a soma
                        resultado[i, j] = matriz1[i, j] + matriz2[i, j];
                    }
                }
            }
            else
            {
                //*     caso não realizar um promp a dizer que não será possivel efeturar a operação
                Console.WriteLine("Para ser somada as matrizes devem ter as mesmas dimenções");
                return resultado = new int[0, 0];
            }
            return resultado;
        }
        public static int[,] subtrairMatrizes(int[,] matriz1, int[,] matriz2)
        {
            int[,] resultado = new int[matriz1.GetLength(0), matriz1.GetLength(1)];

            //* verificar se as matrizes possuem o mesmo tamanho x e y
            if (matriz1.GetLength(0) == matriz2.GetLength(0) && matriz1.GetLength(1) == matriz2.GetLength(1))
            {
                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz1.GetLength(1); j++)
                    {
                        //* realizar a soma
                        resultado[i, j] = matriz1[i, j] - matriz2[i, j];
                    }
                }
            }
            else
            {
                //*     caso não realizar um promp a dizer que não será possivel efeturar a operação
                Console.WriteLine("Para ser subtraida as matrizes devem ter as mesmas dimenções");
                return resultado = new int[0, 0];
            }
            return resultado;
        }

    }
}
