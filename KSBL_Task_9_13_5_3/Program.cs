using System;

namespace KSBL_Task_9_13_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(5, 6);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i + j;
                }
            }

            matrix.Print();

            matrix.ChangeColNLines(10, 8);
            Console.WriteLine();
            matrix.Print();

            matrix.ChangeColNLines(3, 3);
            Console.WriteLine();
            matrix.Print();

            Console.ReadKey();
        }
    }

    class MyMatrix
    {
        private int[,] matrix;

        public int this[int index1, int index2]
        {
            get
            {
                return matrix[index1, index2];
            }
            set
            {
                matrix[index1, index2] = value;
            }
        }

        public MyMatrix(int x, int y)
        {
            matrix = new int[x, y];
        }

        public void ChangeColNLines(int x, int y)
        {
            int[,] matrixNew = new int[x, y];

            for (int i = 0; i < Math.Min(matrix.GetLength(0), matrixNew.GetLength(0)); i++)
            {
                for (int j = 0; j < Math.Min(matrix.GetLength(1), matrixNew.GetLength(1)); j++)
                {
                    matrixNew[i, j] = matrix[i, j];
                }
            }
            matrix = matrixNew;
        }

        public void Print()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int GetLength(int dimension)
        {
            return matrix.GetLength(dimension);
        }

    }
}


