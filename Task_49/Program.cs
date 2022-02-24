// Показать двумерный массив размером m×n, заполненный вещественными числами

Console.Clear();
Random rand = new Random();
Console.Write("Enter the minimum value: ");  // введите минимальное значение
int min = int.Parse(Console.ReadLine());
Console.Write("Enter the maximum value: "); // введите максимальное значение
int max = int.Parse(Console.ReadLine());
Console.Write("Enter the number of array rows: "); // введите количество строк массива
int m = int.Parse(Console.ReadLine());
Console.Write("Enter the number of array columns: "); // введите количество столбцов массива
int n = int.Parse(Console.ReadLine());
double[,] arr = new double[m, n];
Console.WriteLine("array:"); // массив
 for (int i = 0; i < m; i++)
 {
        for (int k = 0; k < n; k++)
    {
         arr[i, k] = Math.Round((rand.Next(min, max + 1)) * 1.1, 2);
         Console.Write(arr[i, k] + "\t");
    }
Console.WriteLine();
 }
