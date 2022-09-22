// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
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
                            array[i,j] = new Random().Next(1,100);
                    }
                return array;
            }
Console.Write ("Введите количество строк двумерного массива ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите количество стобцов двумерного массива ");
int n = Convert.ToInt32 (Console.ReadLine());       
int[,] mas = FillArray(m,n);
Console.WriteLine("    Наш массив: ");
PrintArray(mas);
int sum=0, minsum=0, line=0;
for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
            {
                sum=sum+mas[i,j];
            }
        if (i==0) minsum=sum;
        if (sum<minsum) 
            {minsum=sum; line=i;}
    sum=0;
    }
Console.Write($"{line+1} строка с наименьшей суммой элементов");    