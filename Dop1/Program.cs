// Task 1236

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[,] TransposeHorizontally(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0) / 2; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int a = matrix[i,j];
            matrix[i,j] = matrix[matrix.GetLength(0) - 1 - i,j];
            matrix[matrix.GetLength(0) - 1 - i,j] = a;
        }
    }
    return matrix;
}

Console.Clear();
Console.Write("Enter matrix size (N, M) via space: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
InputMatrix(matrix);
TransposeHorizontally(matrix);
Console.WriteLine();
Console.WriteLine("Result");
PrintMatrix(matrix);