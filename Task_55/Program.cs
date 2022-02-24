// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.Write("Enter the number of lines: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter number of columns: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int j = 0; j < n; j++)
{   
    double average = 0;
    for (int i = 0; i < m; i++)
    {
        average = average + array[i, j];
    }
    Console.Write($"{average / m}" + "\t");
}
