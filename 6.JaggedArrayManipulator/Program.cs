/*
5
10 20 30
1 2 3
2
2
10 10
End


5
10 20 30
1 2 3
2
2
10 10
Add 0 10 10
Add 0 0 10
Subtract -3 0 10
Subtract 3 0 10
End

*/

int size = int.Parse(Console.ReadLine());

int[][] matrix = new int[size][];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] values = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    matrix[row] = values;
    
}

for (int row = 0;row < matrix.GetLength(0) - 1; row++)
{
    if (matrix[row].Length == matrix[row + 1].Length)
    {
        for (int col = 0; col < matrix[row].Length; col++)
        {
            matrix[row][col] *= 2;
            matrix[row + 1][col] *= 2;
        }
    }
    else
    {
        for(int col = 0; col < matrix[row].Length; col++)
        {
            if (matrix[row][col] % 2 != 0)
            {
                continue;
            }
            else
            {
                matrix[row][col] /= 2;
            }
        }
        for (int col = 0; col < matrix[row + 1].Length; col++)
        {
            if (matrix[row + 1][col] % 2 != 0)
            {
                continue;
            }
            else
            {
                matrix[row + 1][col] /= 2;
            }
        }
    }
}

string command;
while ((command = Console.ReadLine())  != "End")
{
    string[] arguments = command
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (arguments[0] == "Add")
    {
        int row = int.Parse(arguments[1]);
        int col = int.Parse(arguments[2]);
        int value = int.Parse(arguments[3]);
        if (IsValidIndex(row, matrix.GetLength(0) - 1)
             && IsValidIndex(col, matrix[row].Length - 1))
        {
            matrix[row][col] += value;
        }
    }
    else if (arguments[0] == "Subtract")
    {
        int row = int.Parse(arguments[1]);
        int col = int.Parse(arguments[2]);
        int value = int.Parse(arguments[3]);
        if (IsValidIndex(row, matrix.GetLength(0) - 1)
             && IsValidIndex(col, matrix[row].Length - 1))
        {
            matrix[row][col] -= value;
        }

    }

}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    Console.WriteLine(string.Join(" ", matrix[row]));
}

 static bool IsValidIndex(int checkIndex, int endIndex)
{
    return 0 <= checkIndex && checkIndex <= endIndex;
}