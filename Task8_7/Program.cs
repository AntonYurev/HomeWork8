// Напишите программу, которая заполнит спирально массив 4 на 4.
// Работает для всех квадратных массивах
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
Console.Write ("Введите количество строк двумерного массива ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите количество стобцов двумерного массива ");
int n = Convert.ToInt32 (Console.ReadLine());
int [,] mas = new int[m,n];
int count=1, row=0, col=0;
for (int f=1; f < n+1; f++)
    {
        for (int i=col; i<n; i++)
        {
            mas[row,i]=count;
            count++;
        }
        n--;row++;
        for (int j=row; j<m; j++)
        {
            mas[j,m-1]=count;
            count++;
        }
        m--;
        for (int i = n-1; i > col-1; i=i-1)
        {
            mas[m,i]=count;
            count++;
        }        
        for (int j=m-1; j>row-1; j--)
        {
            mas[j,col]=count;
            count++;
        }
    col++;
    }
PrintArray(mas);