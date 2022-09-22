// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
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
int a=0, max=0;
for(int i=0;i<m;i++)  // Сортируем по строкам
    {
        max=mas[i,0];
        while (a<n-1)
        {
        for(int j=a;j<n-1;j++)
            {
               if (mas[i,j+1]  > max) 
                {
                    max=mas[i,j+1]; mas[i,j+1]=mas[i,a];mas[i,a]=max;
                }
            }
        a++;max=mas[i,a];    
        }  
    a=0;
    }    
Console.WriteLine("     Отсортированный массив: ");
PrintArray(mas);
