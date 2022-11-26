using System;

namespace Ex5
{
    class Program
    {
        static double[,] CriaMatriz()
        {
            // em resumo pede numero de linhas e colunas e cria a matriz
            int colunas;
            int linhas;
            Console.WriteLine("Digite as linhas da matriz :");
            linhas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite as colunas da matriz:");
            colunas = int.Parse(Console.ReadLine());
            double[,] matriz = new double[linhas, colunas];

            // preenche a matriz com os dados requeridos pelo usuário

            for (int i = 0; i < linhas; i++)
            {
                for (int y = 0; y < colunas; y++)
                {
                    Console.WriteLine("Digite o valor {0} x {1} da matriz:", i + 1, y + 1);
                    matriz[i, y] = double.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            // retorna a mariz
            return matriz;
        }
        static double[,] IncializaMatriz(double[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int z = 0; z < matriz.GetLength(0); z++)
                {
                    matriz[i, z] = 0;
                }
            }
            return matriz;
        }
        static double[,] MultiplicaMatriz(double[,] matrizUm, double[,] matrizDois)
        {
            // cria a matriz em acordo com o tamanho resultante de uma multiplicação
            double[,] matriz = new double[(matrizUm.GetLength(0)), (matrizDois.GetLength(1))];


            //inicializando matriz com 0
            matriz = IncializaMatriz(matriz);

            // calculando matriz um * matriz dois   

            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                for (int z = 0; z < matriz.GetLength(0); z++)
                {
                    for (int y = 0; y < matrizDois.GetLength(0); y++)
                    {
                        matriz[z, i] += matrizUm[z, y] * matrizDois[y, i];

                    }
                }
            }

            // retorna a matriz resultante da multiplicação
            return matriz;
        }

        static double[,] SomaMatriz(double[,] matrizUm, double[,] matrizDois)
        {


            double[,] matriz = new double[matrizUm.GetLength(0), matrizDois.GetLength(1)];

            for (int x = 0; x < matrizUm.GetLength(0); x++)
            {
                for (int z = 0; z < matrizUm.GetLength(0); z++)
                {
                    matriz[x, z] = matrizUm[x, z] + matrizDois[x, z];

                }
            }

            return matriz;

        }
        static void ImprimiMariz(double[,] matriz)
        {
            int indice = 1;
            foreach (int i in matriz)
            {

                Console.Write("{0} ", i);
                if (indice == matriz.GetLength(1))
                {
                    Console.Write("\r\n");
                    indice = 0;
                }
                indice += 1;
            }
        }
        static double[,] SubatraiMatriz(double[,] matrizUm, double[,] matrizDois)
        {


            double[,] matriz = new double[matrizUm.GetLength(0), matrizDois.GetLength(1)];

            for (int x = 0; x < matrizUm.GetLength(0); x++)
            {
                for (int z = 0; z < matrizUm.GetLength(0); z++)
                {
                    matriz[x, z] = matrizUm[x, z] - matrizDois[x, z];

                }
            }

            return matriz;

        }
        static double DetMatrizOrdemDois(double[,] matriz)
        {
            double detMatriz = (matriz[0, 0] * matriz[1, 1]) - (matriz[0, 1] * matriz[1, 0]);

            return detMatriz;
        }
        static double DetMatrizOrdemTres(double[,] matriz)
        {
            double detMatriz = ((matriz[0, 0] * matriz[1, 1] * matriz[2, 2]) +
              (matriz[0, 1] * matriz[1, 2] * matriz[2, 0]) +
              (matriz[0, 2] * matriz[1, 0] * matriz[2, 1])) -
              ((matriz[0, 2] * matriz[1, 1] * matriz[2, 0]) +
              (matriz[0, 0] * matriz[1, 2] * matriz[2, 1]) +
              (matriz[0, 1] * matriz[1, 0] * matriz[2, 2]));

            return detMatriz;
        }

        static double DetMatrizOrdemQuatro(double[,] matriz)
        {
            double detMatrizUm = ((matriz[1, 1] * matriz[2, 2] * matriz[3, 3]) +
              (matriz[1, 2] * matriz[2, 3] * matriz[3, 1]) +
              (matriz[1, 3] * matriz[2, 1] * matriz[3, 2])) -
              ((matriz[1, 3] * matriz[2, 2] * matriz[3, 1]) +
              (matriz[1, 1] * matriz[2, 3] * matriz[3, 2]) +
              (matriz[1, 2] * matriz[2, 1] * matriz[3, 3]));

            double detMatrizDois = ((matriz[1, 0] * matriz[2, 2] * matriz[3, 3]) +
              (matriz[1, 2] * matriz[2, 3] * matriz[3, 0]) +
              (matriz[1, 3] * matriz[2, 0] * matriz[3, 2])) -
              ((matriz[1, 3] * matriz[2, 2] * matriz[3, 0]) +
              (matriz[1, 0] * matriz[2, 3] * matriz[3, 2]) +
              (matriz[1, 2] * matriz[2, 0] * matriz[3, 3]));

            double detMatrizTres = ((matriz[1, 0] * matriz[2, 1] * matriz[3, 3]) +
              (matriz[1, 1] * matriz[2, 3] * matriz[3, 0]) +
              (matriz[1, 3] * matriz[2, 0] * matriz[3, 1])) -
              ((matriz[1, 3] * matriz[2, 1] * matriz[3, 0]) +
              (matriz[1, 0] * matriz[2, 3] * matriz[3, 1]) +
              (matriz[1, 1] * matriz[2, 0] * matriz[3, 3]));

            double detMatrizQuatro = ((matriz[1, 0] * matriz[2, 1] * matriz[3, 2]) +
              (matriz[1, 1] * matriz[2, 2] * matriz[3, 0]) +
              (matriz[1, 2] * matriz[2, 0] * matriz[3, 1])) -
              ((matriz[1, 2] * matriz[2, 1] * matriz[3, 0]) +
              (matriz[1, 0] * matriz[2, 2] * matriz[3, 1]) +
              (matriz[1, 1] * matriz[2, 0] * matriz[3, 2]));

            double detMatriz = 1 * matriz[0, 0] * detMatrizUm +
                            (-1) * matriz[0, 1] * detMatrizDois +
                            1 * matriz[0, 2] * detMatrizTres +
                           (-1) * matriz[0, 3] * detMatrizQuatro;

            return detMatriz;
        }
        static double[,] MatrizTransposta(double[,] matriz)
        {
            double[,] matrizTransposta = new double[matriz.GetLength(1), matriz.GetLength(0)];
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int z = 0; z < matriz.GetLength(1); z++)
                {
                    matrizTransposta[x, z] = matriz[z, x];
                }
            }
            return matrizTransposta;
        }
        static double[,] MatrizInversaOrdemDois(double[,] matriz)
        {
            double[,] matrizInversa = new double[2, 2];
            matrizInversa[0, 0] = matriz[1, 1];
            matrizInversa[1, 1] = matriz[0, 0];
            matrizInversa[0, 1] = -matriz[0, 1];
            matrizInversa[1, 0] = -matriz[1, 0];

            return matrizInversa;
        }
        static void Main(string[] _1)
        {


            string menu = "aaa";

            while (menu != "0")
            {
                Console.WriteLine("1-  Multiplicar duas Matrizes");
                Console.WriteLine("2-  Somar duas Matrizes");
                Console.WriteLine("3-  Subtrair duas Matrizes");
                Console.WriteLine("4-  Determinante ordem 2");
                Console.WriteLine("5-  Determinante ordem 3");
                Console.WriteLine("6-  Determinante ordem 4");
                Console.WriteLine("7-  Transposta de uma Matriz");
                Console.WriteLine("8-  Inversa de uma matriz ordem 2");
                Console.WriteLine("0-  Sair");
                Console.WriteLine("Digite uma opção valida:");
                menu = Console.ReadLine();
                if (menu == "1")
                {
                    double[,] matrizUm = CriaMatriz();
                    double[,] matrizDois = CriaMatriz();
                    if ((matrizUm.GetLength(1)) == (matrizDois.GetLength(0)))
                    {
                        double[,] matrizUmxMatrizDois = MultiplicaMatriz(matrizUm, matrizDois);
                        ImprimiMariz(matrizUmxMatrizDois);
                    }

                    else
                    {
                        Console.WriteLine("Não é possível Multiplicar a Matriz");
                    }
                }
                else if (menu == "2")
                {
                    double[,] matrizUm = CriaMatriz();
                    double[,] matrizDois = CriaMatriz();
                    if (matrizUm.GetLength(0) == matrizDois.GetLength(0) && matrizUm.GetLength(1) == matrizDois.GetLength(1))
                    {
                        double[,] somaMatriz = SomaMatriz(matrizUm, matrizDois);
                        ImprimiMariz(somaMatriz);
                    }
                    else
                    {
                        Console.WriteLine("Não é possivel realizar a soma");
                    }
                }
                else if (menu == "3")
                {
                    double[,] matrizUm = CriaMatriz();
                    double[,] matrizDois = CriaMatriz();
                    if (matrizUm.GetLength(0) == matrizDois.GetLength(0) && matrizUm.GetLength(1) == matrizDois.GetLength(1))
                    {
                        double[,] subtraimaMatriz = SubatraiMatriz(matrizUm, matrizDois);
                        ImprimiMariz(subtraimaMatriz);
                    }
                    else
                    {
                        Console.WriteLine("Não é possivel realizar a subtração");
                    }
                }

                else if (menu == "4")
                {
                    double[,] matriz = CriaMatriz();
                    if (matriz.GetLength(0) == 2 && matriz.GetLength(1) == 2)
                    {
                        Console.WriteLine("A Determinante da Matriz:");
                        ImprimiMariz(matriz);
                        Console.WriteLine("É : {0}", DetMatrizOrdemDois(matriz));
                    }
                    else
                    {
                        Console.WriteLine("A Matriz não é de ordem 2");
                    }
                }
                else if (menu == "5")
                {
                    double[,] matriz = CriaMatriz();
                    if (matriz.GetLength(0) == 3 && matriz.GetLength(1) == 3)
                    {
                        Console.WriteLine("A Determinante da Matriz:");
                        ImprimiMariz(matriz);
                        Console.WriteLine("É : {0}", DetMatrizOrdemTres(matriz));
                    }
                    else
                    {
                        Console.WriteLine("A Matriz não é de ordem 3");
                    }
                }
                else if (menu == "6")
                {
                    double[,] matriz = CriaMatriz();
                    if (matriz.GetLength(0) == 4 && matriz.GetLength(1) == 4)
                    {
                        Console.WriteLine("A Determinante da Matriz:");
                        ImprimiMariz(matriz);
                        Console.WriteLine("É : {0}", DetMatrizOrdemQuatro(matriz));
                    }
                    else
                    {
                        Console.WriteLine("A Matriz não é de ordem 4");
                    }
                }
                else if (menu == "7")
                {
                    double[,] matriz = CriaMatriz();
                    Console.WriteLine("A Matriz Transposta de :");
                    ImprimiMariz(matriz);
                    Console.WriteLine("É :");
                    ImprimiMariz(MatrizTransposta(matriz));
                }
                else if (menu == "8")
                {
                    double[,] matriz = CriaMatriz();
                    if (matriz.GetLength(0) == 2 && matriz.GetLength(1) == 2)
                    {
                        Console.WriteLine("A Matriz Inversa de :");
                        ImprimiMariz(matriz);
                        Console.WriteLine("É :");
                        ImprimiMariz(MatrizInversaOrdemDois(matriz));
                    }
                    else
                    {
                        Console.WriteLine("A Matriz não é de ordem 2");
                    }
                }
                else
                {
                    if (menu != "0")
                    {
                        Console.WriteLine("Opção invalída");
                    }
                }

            }

        }

    }
}