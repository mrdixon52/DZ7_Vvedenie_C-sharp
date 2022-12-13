// task 47


void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(-10, 11), 1);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Enter matrix size: ");
string[] numbers = Console.ReadLine().Split(" ");
double[,] matrix = new double[int.Parse(numbers[0]), int.Parse(numbers[1])];
InputMatrix(matrix);
