// task 52


void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 16);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void AverageColumn(double[,] matrix)
{
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = (sum + matrix[i,j]);
        }
        Console.Write($"{Math.Round((sum / matrix.GetLength(0)), 1)}    ");
        sum = 0;
    }
}

Console.Clear();
Console.Write("Enter matrix size: ");
string[] numbers = Console.ReadLine().Split(" ");
double[,] matrix = new double[int.Parse(numbers[0]), int.Parse(numbers[1])];
InputMatrix(matrix);
Console.WriteLine();
AverageColumn(matrix);