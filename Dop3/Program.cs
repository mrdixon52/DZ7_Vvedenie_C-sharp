// Task 364

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


Console.Clear();
Console.Write("Enter matrix size n and m via space: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
int n = matrix.GetLength(0);
int m = matrix.GetLength(1);
int i = 0, j = 0;
int p = 0;
int size = n * m;

for (int counter = -1; counter < size; counter++)
{
    if (j >= 0 && j < m && i < n)
    {
        matrix[i,j] = counter;
    }
    else if (p < m)
    {
        i = 0;
        j = p;
        p++;
        matrix[i,j] = counter;
    }
    else 
    {
       break; // додумываю как вводить последние 6 цифр
    }
    i++;
    j--;
}
PrintMatrix(matrix);
