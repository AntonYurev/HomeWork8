// Напишите программу, которая заполнит спирально массив 4 на 4.
// Работает на всех массивах
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
            const int n = 6;
            const int m = 4;
            int[,] matrix = new int[n, m];
 
            int row = 0;
            int col = 0;
            int dx = 1;
            int dy = 0;
            int dirChanges = 0;
            int visits = m;
 
            for (int i = 0; i < matrix.Length; i++) {
                matrix[row, col] = i + 1;
              if (--visits == 0) {
                visits = m * (dirChanges %2) + n * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
                int temp = dx;
                dx = -dy;
                dy = temp;
                dirChanges++;
              }
 
              col += dx;
              row += dy;
            }
            PrintArray(matrix);