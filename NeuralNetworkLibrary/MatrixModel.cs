using System;

namespace NeuralNetworkLibrary
{
    public class MatrixModel
    {
        public int Rows = 0;
        public int Cols = 0;
        public double[,] Data;

        public MatrixModel(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            Data = new double[Rows, Cols];

            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Cols; j++)
                {
                    Data[i, j] = 0;
                }
            }
        }

        public static MatrixModel FromArray(double[] arr)
        {
            var result = new MatrixModel(arr.Length, 1);
            for(int i = 0; i < arr.Length; i++)
            {
                result.Data[i, 0] = arr[i];
            }

            return result;
        }

        public double[] ToArray()
        {
            int count = 0;
            double[] arr = new double[Rows * Cols];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    arr[count] = Data[i, j];
                    count++;
                }
            }
            return arr;
        }

        public void Randomize()
        {
            var Rand = new Random();
            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Cols; j++)
                {
                    Data[i, j] = Rand.NextDouble() * 1.0;
                }
            }
        }

        public static MatrixModel Subtract(MatrixModel a, MatrixModel b)
        {
            var result = new MatrixModel(a.Rows, a.Cols);
            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result.Data[i, j] = a.Data[i, j] - b.Data[i, j];
                }
            }
            return result;
        }

        public static MatrixModel SubtractMSE(MatrixModel a, MatrixModel b)
        {
            var result = new MatrixModel(a.Rows, a.Cols);
            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result.Data[i, j] = 0.5 * Math.Pow(a.Data[i, j] - b.Data[i, j], 2);
                }
            }
            return result;
        }

        public void AddWithNumber(double x)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Data[i, j] += x;
                }
            }
        }

        public void AddWithMatrix(MatrixModel matrix)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Data[i, j] += matrix.Data[i, j];
                }
            }
        }

        public static MatrixModel AddWithMatrix(MatrixModel firstMatrix, MatrixModel secondMatrix)
        {
            var result = new MatrixModel(firstMatrix.Rows, firstMatrix.Cols);
            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result.Data[i, j] = firstMatrix.Data[i, j] + secondMatrix.Data[i, j];
                }
            }
            return result;
        }

        public void Multiply(double x)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Data[i, j] *= x;
                }
            }
        }

        public void MultiplyWithMatrix(MatrixModel matrix)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Data[i, j] *= matrix.Data[i, j];
                }
            }
        }

        public static MatrixModel MultiplyWithMatrix(MatrixModel a, MatrixModel b)
        {
            if (a.Cols != b.Rows) throw new ApplicationException("The colomn of first matrix must match with seocnd matrix rows");
            var result = new MatrixModel(a.Rows, b.Cols);
            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < a.Cols; k++)
                    {
                        sum += a.Data[i, k] * b.Data[k, j];
                    }

                    result.Data[i, j] = sum;
                }
            }
            return result;
        }

        public static MatrixModel Transpose(MatrixModel matrix)
        {
            var result = new MatrixModel(matrix.Cols, matrix.Rows);
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    result.Data[j, i] = matrix.Data[i, j];
                }
            }
            return result;
        }

        public void Map(Func<double, double> func)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    var value = Data[i, j];
                    Data[i, j] = func(value);
                }
            }
        }

        public static MatrixModel Map(MatrixModel matrix, Func<double, double> func)
        {
            var result = new MatrixModel(matrix.Rows, matrix.Cols);
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    var value = matrix.Data[i, j];
                    result.Data[i, j] = func(value);
                }
            }

            return result;
        }

        public void Print()
        {
            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Cols; j++)
                {
                    Console.Write($"{Data[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
