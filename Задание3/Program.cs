int m = 4, n = 3;
Random random = new Random();
int[,] array = new int[n, m];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

System.Console.WriteLine(" ");
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{ sum / array.GetLength(0)} ");
}


System.Console.WriteLine(" ");









