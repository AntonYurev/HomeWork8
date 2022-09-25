// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void PrintArray(int [,] table)
            {
            for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                        {
                            Console.Write(table[i,j] + "\t" );
                        }
                    Console.WriteLine();
                }
            }
int[,] FillArray (int m, int n)
            {
                int[,] array = new int[m,n];
                for (int i=0;i<m;i++)
                    {
                        for (int j=0;j<n;j++)
                            array[i,j] = new Random().Next(1,10);
                    }
                return array;
            }
Console.Write ("Введите количество строк матрицы А: ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите количество стобцов матрицы А: ");
int n = Convert.ToInt32 (Console.ReadLine());       
int[,] mas = FillArray(m,n);
Console.WriteLine("    Первая матрица: ");
PrintArray(mas);
Console.Write ("Введите количество строк матрицы В: ");
int m1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите количество стобцов матрицы В: ");
int n1 = Convert.ToInt32 (Console.ReadLine()); 
int[,] mas1=FillArray(m1,n1);
Console.WriteLine("    Вторая матрица: ");
PrintArray(mas1);
if (n != m1) Console.WriteLine("Произведение невозможно!");
    else
    {
        int[,] multiplication = new int[m,n1];
        int sum=0;
        for (int i=0; i<m; i++)
            {
                for(int j=0; j<n1; j++)
                    {
                        for (int a=0;a<n;a++)
                        {
                        sum=mas[i,a]*mas1[a,j]+sum;
                        }
                        multiplication[i,j]=sum; 
                        sum=0;
                    }
            }
        Console.WriteLine("Произведение матриц равно: ");
        PrintArray(multiplication);
    }