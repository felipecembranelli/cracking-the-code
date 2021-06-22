using System;

namespace MyDataStructure.Matrix
{
    public class Matrix
    {
        public static int[] CreateMatrixOneDimension(int[] values)
        {
            {
                int i, j;
                int[] arr1 = values;
                int size = values.Length;

                Console.Write("\n\nRead a 1D array of size " + size.ToString() + " and print the matrix :\n");
                Console.Write("------------------------------------------------------\n");

                /* Stored values into the array*/
                Console.Write("Input elements in the matrix :\n");
                for (i = 0; i < size; i++)
                {
                    Console.Write("element - [{0}] : ", i);
                    arr1[i] = values[i];
                }

                Console.Write("\nThe matrix is : \n");
                for (i = 0; i < size; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < size; j++)
                        Console.Write("{0}\t", arr1[i]);
                }
                Console.Write("\n\n");

                return arr1;
            }
        }
        public static int[,] CreateMatrix(int size, int[] values)
        {
            {
                int i, j;
                int count = 0;
                int[,] arr1 = new int[size, size];

                Console.Write("\n\nRead a 2D array of size " + size.ToString() + "x" + size.ToString() + " and print the matrix :\n");
                Console.Write("------------------------------------------------------\n");

                /* Stored values into the array*/
                Console.Write("Input elements in the matrix :\n");
                for (i = 0; i < size; i++)
                {
                    for (j = 0; j < size; j++)
                    {
                        Console.Write("element - [{0},{1}] : ", i, j);
                        //arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                        arr1[i, j] = values[count];
                        count++;
                    }
                }

                Console.Write("\nThe matrix is : \n");
                for (i = 0; i < size; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < size; j++)
                        Console.Write("{0}\t", arr1[i, j]);
                }
                Console.Write("\n\n");

                return arr1;
            }
        }
    }
}