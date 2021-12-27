using System;

namespace Matrix
{ 
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NET.C#.07 Обработка исключений. Матрицы");
            var testMatrix = new Matrix(3, 3);
            testMatrix[0, 0] = 1;
            testMatrix[0, 1] = 3;
            testMatrix[0, 2] = -2;
            testMatrix[1, 0] = 1;
            testMatrix[1, 1] = 0;
            testMatrix[1, 2] = 7;
            testMatrix[2, 0] = 1;
            testMatrix[2, 1] = 1;
            testMatrix[2, 2] = -1;

            var testMatrix1 = new Matrix(3, 3);
            testMatrix1[0, 0] = 7;
            testMatrix1[0, 1] = 6;
            testMatrix1[0, 2] = -2;
            testMatrix1[1, 0] = 1;
            testMatrix1[1, 1] = 43;
            testMatrix1[1, 2] = 7;
            testMatrix1[2, 0] = 4;
            testMatrix1[2, 1] = 32;
            testMatrix1[2, 2] = -123;

            Console.WriteLine("Задана тестовая матрица 3*3");
            for (var i=0; i < testMatrix.M; i++)
            {
                for (var j=0; j < testMatrix.N; j++)
                {
                    Console.Write("{0:d}", testMatrix[i, j] + " ");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("Склярное умножение матрицы на число");

            testMatrix = testMatrix * 5;
            for (var i = 0; i < testMatrix.M; i++)
            {
                for (var j = 0; j < testMatrix.N; j++)
                {
                    Console.Write("{0:d}", testMatrix[i, j] + " ");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("Умножение матрицы на матрицу");

            testMatrix = testMatrix * testMatrix1;
            for (var i = 0; i < testMatrix.M; i++)
            {
                for (var j = 0; j < testMatrix.N; j++)
                {
                    Console.Write("{0:d}", testMatrix[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
