/*
4 5
1 5 5 2 4
2 1 4 14 3
3 7 11 2 8
4 8 12 16 4

 */

int[] n = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = n[0];
int cols = n[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] values = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = values[col];
    }

}

int maxSum = int.MinValue;

int[] firstRow = new int[3];
int[] secondRow = new int[3];
int[] thirdRow = new int[3];

for (int row = 0; row < matrix.GetLength(0) - 2; row++)
{
    for (int col = 0; col < matrix.GetLength(1)  - 2; col++)
    {
        int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
              + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
              + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
            
        if (sum > maxSum)
        {
            maxSum = sum;

            firstRow[0] = matrix[row, col];
            firstRow[1] = matrix[row, col + 1];
            firstRow[2] = matrix[row, col + 2];

            secondRow[0] = matrix[row + 1, col];
            secondRow[1] = matrix[row + 1, col + 1];
            secondRow[2] = matrix[row + 1, col + 2];

            thirdRow[0] = matrix[row + 2, col];
            thirdRow[1] = matrix[row + 2, col + 1];
            thirdRow[2] = matrix[row + 2, col + 2];

        }
    }
}

Console.WriteLine($"Sum = {maxSum}");
Console.WriteLine(string.Join( " ", firstRow));
Console.WriteLine(string.Join(" ", secondRow));
Console.WriteLine(string.Join(" ", thirdRow));

//int[,] result = new int[3, 3];

//for (int row = 0; row < result.GetLength(0); row++)
//{
//    for (int col = 0; col < result.GetLength(1); col++)
//    {
//        if (row == 0)
//        {
//            result[row, col] = firstRow[col];
//        }
//        else  if (row == 1)
//        {
//            result[row, col] = secondRow[col];
//        }
//        else
//        {
//            result[row, col] = thirdRow[col];
//        }
//    }
//}

