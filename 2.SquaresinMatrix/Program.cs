/*
3 4
A B B D
E B B B
I J B B

2 2
a b
c d

 */

int[] n = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = n[0];
int cols = n[1];

char[,] matrixChars = new char[rows, cols];

for (int row = 0; row < matrixChars.GetLength(0); row++)
{
    char[] chars = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(char.Parse)
        .ToArray();

    for (int col = 0; col < matrixChars.GetLength(1); col++)
    {
        matrixChars[row, col] = chars[col];
    }
}

int countEqualSquares = 0;

for (int row = 0; row < matrixChars.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrixChars.GetLength(1) - 1; col++)
    {
        if (matrixChars[row, col] == matrixChars[row + 1, col]
            && matrixChars[row, col] == matrixChars[row + 1, col + 1]
            && matrixChars[row, col + 1] == matrixChars[row + 1, col + 1])
        {
            countEqualSquares++;
        }
    }

}
Console.WriteLine(countEqualSquares);
