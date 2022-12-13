// Task 715

void InputMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            string[] WB = {"W", "B"};
            matrix[i, j] = WB[new Random().Next(0, 2)];
            Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

void Mistakes(string[,] matrix, string[,] matrix1)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] != matrix1[i,j])
            {
                count++;
            }
        }
    }
    Console.WriteLine($"Number of mistakes = {count}");
}

Console.Clear();
Console.Write("Enter matrix size via space: ");
string[] numbers = Console.ReadLine().Split(" ");
string[,] pozitive = new string[int.Parse(numbers[0]), int.Parse(numbers[1])];
string[,] negative = new string[int.Parse(numbers[0]), int.Parse(numbers[1])];
InputMatrix(pozitive);
Console.WriteLine();
InputMatrix(negative);
Console.WriteLine();
Mistakes(pozitive, negative);

