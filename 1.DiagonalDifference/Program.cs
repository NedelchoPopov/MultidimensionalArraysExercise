/*
3
11 2 4
4 5 6
10 8 -12

 */

int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];


for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] numbers = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = numbers[col];
    }
}
int leftDiagonalSum = 0;
int rightDiagonalSum = 0;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    leftDiagonalSum += matrix[row, row];
    rightDiagonalSum += matrix[row, matrix.GetLength(1) - 1 - row];
    

}

Console.WriteLine($"{Math.Abs(leftDiagonalSum - rightDiagonalSum)}");


