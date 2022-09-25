// m = 3, n = 4.
int m = 3;
int n = 4;

double[,] array = new double[m, n];

void CreateRandomArray(double[,] array)
{



    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random random = new Random();
            array[i, j] = random.NextDouble() * 100  ;
            System.Console.Write("{0, 6:F2}   ", array[i, j]   );

        }
        Console.WriteLine();
    }
}
CreateRandomArray(array);
// void PrintArray(double[,] array)
// {
//     for (int row = 0; row < array.GetLength(0); row++)
//     {
//         for (int column = 0; column < array.GetLength(1); column++)
//             Console.Write(array[row, column] + "\t");
//         Console.WriteLine();
//     }
// }
// PrintArray(array);














