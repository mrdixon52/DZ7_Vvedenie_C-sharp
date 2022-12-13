// task 50

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void CheckPositions(int[,] matrix, int n, int m)
{
    if (n < matrix.GetLength(0) && m < matrix.GetLength(1))
    {
        Console.WriteLine($"In position {n}, {m} located {matrix[n, m]}");
    }
    else 
    {
        Console.WriteLine("There is no such position in the array");
    }
}

Console.Clear();
Console.Write("Enter matrix size: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
InputMatrix(matrix);
Console.WriteLine("Enter position of element via enter:");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
CheckPositions(matrix, n, m);
