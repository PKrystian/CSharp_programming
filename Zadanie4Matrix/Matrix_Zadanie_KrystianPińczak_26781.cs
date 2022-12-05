using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        static void print_function(int[,] arr)
        {
            int i;
            int j;
            for (i = 0; i < arr.GetLength(0); i++)
            {
                for (j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        private readonly int[,] _values;
        public int this[int x, int y]
        {
            get 
            { 
                return _values[x, y];
            }
        }
        public Matrix(int[,] values)
        {
            _values = values;
        }
        public static Matrix operator +(Matrix x, Matrix y)
        {
            int[,] m0 = x._values;
            int[,] m1 = y._values;
            int a1 = m0.GetLength(0);
            int a2 = m0.GetLength(1);
            int[,] newMatrix = new int[a1,a2];
            for (int i = 0; i < a1; i++)
            {
                for (int j = 0; j < a2; j++)
                {
                    newMatrix[i, j] = m0[i, j] + m1[i, j];
                }
            }
            return new Matrix(newMatrix);
        }
        public static Matrix operator *(Matrix x, Matrix y)
        {
            int[,] m0 = x._values;
            int[,] m1 = y._values;
            int a1 = m0.GetLength(0);
            int a2 = m0.GetLength(1);
            int[,] newMatrix = new int[a1, a2];
            for (int i = 0; i < a1; i++)
            {
                for (int j = 0; j < a2; j++)
                {
                    newMatrix[i, j] = m0[i, j] * m1[i, j];
                }
            }
            return new Matrix(newMatrix);
        }
        public static int Main(string[] args)
        {
            Console.Title = "Matrix operations, Krystian Pińczak";
            String txt_input = File.ReadAllText(@"C:\Users\kryst\Desktop\matrix_1.txt");
            int i = 0, j = 0;
            foreach (var row in txt_input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    j++;
                }
                i++;
            }
            int columns = j;
            int rows = i;
            i = 0; j = 0;
            int[,] main_matrix = new int[rows, columns];
            foreach (var row in txt_input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    main_matrix[i, j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }
            Console.WriteLine("Matrix from txt:");
            int columns_t = columns;
            int rows_t = rows;
            print_function(main_matrix);
            if (rows != columns)
            {
                int temp = rows_t;
                rows_t = columns_t;
                columns_t = temp;
            }
            Console.WriteLine("Matrix after transpose:");
            int[,] transpose_matrix = new int[rows_t, columns_t];
            for (int m = 0; m < rows; m++)
            {
                for (int k = 0; k < columns; k++)
                {
                    transpose_matrix[k, m] = main_matrix[m, k];
                }
            }
            print_function(transpose_matrix);
            
            Matrix sum1 = new Matrix(main_matrix);
            Matrix sum2 = sum1 + sum1;
            Matrix mul1 = new Matrix(main_matrix);
            Matrix mul2 = mul1 * mul1;
            Console.WriteLine("Matrix after self addition:");
            for (int m = 0; m < rows; m++)
            {
                for (int k = 0; k < columns; k++)
                {
                    Console.Write(sum2[m, k] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix after self multiplication:");
            for (int m = 0; m < rows; m++)
            {
                for (int k = 0; k < columns; k++)
                {
                    Console.Write(mul2[m, k] + "\t");
                }
                Console.WriteLine();
            }
            Console.Write("Columns: " + columns + " Rows: " + rows + "\n");
            return 0;
        }
    }
}