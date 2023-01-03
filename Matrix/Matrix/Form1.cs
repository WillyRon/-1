using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal void b_init_Click(object sender, EventArgs e)
        {
            int rowsA = int.Parse(mat1_1.Text);
            int colsA = int.Parse(mar1_2.Text);
            int rowsB = int.Parse(mat2_1.Text);
            int colsB = int.Parse(mat2_2.Text);

            int[,] matrixA = new int[rowsA, colsA];
            int[,] matrixB = new int[rowsB, colsB];

            Random rnd = new Random();
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    matrixA[i, j] = rnd.Next(1, 10);
                }
            }

            for (int i = 0; i < rowsB; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    matrixB[i, j] = rnd.Next(1, 10);
                }
            }
            // Очистка таблицы
            dataGridViewM1.Rows.Clear();
            dataGridViewM1.Columns.Clear();
            dataGridViewM2.Rows.Clear();
            dataGridViewM2.Columns.Clear();

            for (int i = 0; i < colsA; i++)
            {
                dataGridViewM1.Columns.Add("" + (i + 1), "" );
            }

            for (int i = 0; i < colsB; i++)
            {
                dataGridViewM2.Columns.Add("" + (i + 1), "" );
            }

            // Вывод матрицы A на форму
            for (int i = 0; i < rowsA; i++)
            {
                string[] row = new string[colsA];
                for (int j = 0; j < colsA; j++)
                {
                    row[j] = matrixA[i, j].ToString();
                }
                dataGridViewM1.Rows.Add(row);
            }

            // Вывод матрицы B на форму
            for (int i = 0; i < rowsB; i++)
            {
                string[] row = new string[colsB];
                for (int j = 0; j < colsB; j++)
                {
                    row[j] = matrixB[i, j].ToString();
                }
                dataGridViewM2.Rows.Add(row);
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            int rowsA = dataGridViewM1.RowCount;
            int colsA = dataGridViewM1.ColumnCount;
            int[,] matrixA = new int[rowsA, colsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    if (dataGridViewM1[j, i].Value != null)
                    {
                        matrixA[i, j] = int.Parse(dataGridViewM1[j, i].Value.ToString());
                    }
                    else
                    {
                        matrixA[i, j] = 0;
                    }
                }
            }

            int rowsB = dataGridViewM2.RowCount;
            int colsB = dataGridViewM2.ColumnCount;
            int[,] matrixB = new int[rowsB, colsB];

            for (int i = 0; i < rowsB; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    if (dataGridViewM2[j, i].Value != null)
                    {
                        matrixB[i, j] = int.Parse(dataGridViewM2[j, i].Value.ToString());
                    }
                    else
                    {
                        matrixB[i, j] = 0;
                    }
                }
            }


             int[,] MultiplyMatricesSequentially(int[,] matA, int[,] matB)
            {
                int rowA = matA.GetLength(0);
                int colA = matA.GetLength(1);
                int rowB = matB.GetLength(0);
                int colB = matB.GetLength(1);

                if (colA != rowB)
                {
                    throw new Exception("Недопустимые размеры матрицы для умножения");
                }

                int[,] result = new int[rowA, colB];

                for (int i = 0; i < rowA; i++)
                {
                    for (int j = 0; j < colB; j++)
                    {
                        for (int k = 0; k < colsA; k++)
                        {
                            result[i, j] += matA[i, k] * matB[k, j];
                        }
                    }
                }

                return result;
            }

             int[,] MultiplyMatricesParallel(int[,] matA, int[,] matB)
            {
                int rowA = matA.GetLength(0);
                int colA = matA.GetLength(1);
                int rowB = matB.GetLength(0);
                int colB = matB.GetLength(1);

                if (colsA != rowsB)
                {
                    throw new Exception("Недопустимые размеры матрицы для умножения");
                }

                int[,] result = new int[rowA, colB];

                Parallel.For(0, rowA, i =>
                {
                    for (int j = 0; j < colB; j++)
                    {
                        for (int k = 0; k < colA; k++)
                        {
                            result[i, j] += matA[i, k] * matB[k, j];
                        }
                    }
                });

                return result;
            }

            int[,] matrixC;

            // Последовательное умножение матриц
            Stopwatch stopwatch = Stopwatch.StartNew();
            matrixC = MultiplyMatricesSequentially(matrixA, matrixB);
            stopwatch.Stop();
            long sequentialTime = stopwatch.ElapsedMilliseconds;

            // Параллельное умножение матриц
            stopwatch = Stopwatch.StartNew();
            matrixC = MultiplyMatricesParallel(matrixA, matrixB);
            stopwatch.Stop();
            long parallelTime = stopwatch.ElapsedMilliseconds;

            // Вывод результатов на форму
            labelSequentialTime.Text = "Скорость последовательного умножения" + sequentialTime + "ms";
            labelParallelTime.Text = "Скорость параллельного умножения" + parallelTime + "ms";

            int rowsC = matrixC.GetLength(0);
            int colsC = matrixC.GetLength(1);
            dataGridViewM3.Rows.Clear();

            for (int i = 0; i < colsC; i++)
            {
                dataGridViewM3.Columns.Add("" + (i + 1), "");
            }

            for (int i = 0; i < rowsC; i++)
            {
                string[] row = new string[colsC];
                for (int j = 0; j < colsC; j++)
                {
                    row[j] = matrixC[i, j].ToString();
                }
                dataGridViewM3.Rows.Add(row);
            }

        }


    }
}
