int m = 10;
int n = 5;

int[,]array = new int[m  , n];
void CreateRandomArray(int[,] array)
{



    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(100);
        }
       
    }
}
CreateRandomArray(array);
void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
            Console.Write(array[row, column] + "\t");
        Console.WriteLine();
    }
}
PrintArray(array);
System.Console.WriteLine("введите индекс числа");
int Question = Convert.ToInt16(Console.ReadLine());
System.Console.WriteLine("введите индекс числа");
int Question2 = Convert.ToInt16(Console.ReadLine());

//Здесь  я написал - 1 т.к. индексация массива ведется с нуля и индексы 10 и 5 получаются вне массива
if (Question == 0 || Question2 ==0) {System.Console.WriteLine("индекс вне массива");} 
else {
if (Question - 1 < m   )
{
    if (Question2 -1  < n )
    {
        System.Console.WriteLine(array[Question - 1, Question2 -1 ]);
    }
    else 
    {
        System.Console.WriteLine("ваш индекс вне массива");
    }
}
else
{
     System.Console.WriteLine("ваш индекс вне массива");
}
}