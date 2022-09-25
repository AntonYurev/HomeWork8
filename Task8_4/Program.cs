// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] FillArray (int m, int n, int k)
            {
                int[,,] array = new int[m,n,k];
                int a=0;
                for (int i=0;i<m;i++)
                    {
                        for (int j=0;j<n;j++)
                        {
                            for (int l=0;l<k;l++)
                            {
                                array[i,j,l] = 10+a;
                                a++;
                            }
                        }
                    }
                return array;
            }
void PrintArray(int [,,] table)
            {
            for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                        {
                            for (int l=0; l < table.GetLength(2); l++)
                                {
                                Console.Write($"{table[i,j,l]} ({i},{j},{l}) ");
                                }
                            Console.WriteLine();
                        }  
                    Console.WriteLine();  
                }
            }
Console.WriteLine("Задайте размерность трехмерного массива:");
Console.Write ("Первое измерение: ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Второе измерение: ");
int n = Convert.ToInt32 (Console.ReadLine()); 
Console.Write ("Третье измерение: ");
int k = Convert.ToInt32 (Console.ReadLine());     
if (m*n*k > 89) Console.WriteLine("Слишком большая размерность!");
else
    {
        int[,,] mas = FillArray(m,n,k);
        PrintArray(mas);
    }

