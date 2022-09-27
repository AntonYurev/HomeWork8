// Напишите программу, которая заполнит спирально массив 4 на 4.
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
                int a=0;
                for (int i=0;i<m;i++)
                    {
                        for (int j=0;j<n;j++)
                            array[i,j] = 1+a;a++;
                    }
                return array;
            }
int[,] mas = FillArray(4,4);
Console.WriteLine("    Наш массив: ");
PrintArray(mas);
