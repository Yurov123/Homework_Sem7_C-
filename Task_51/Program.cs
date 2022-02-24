// Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.Clear();

Console.Write("Enter the number of lines: "); // Введите количество строк
int m = int.Parse(Console.ReadLine());
Console.Write("Enter number of columns: "); // Введите количество столбцов
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = i + j;
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}