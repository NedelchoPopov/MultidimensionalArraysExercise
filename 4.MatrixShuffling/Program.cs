/*
2 3
1 2 3
4 5 6
swap 0 0 1 1
swap 10 9 8 7
swap 0 1 1 0
END

1 2
Hello World
0 0 0 1
swap 0 0 0 1
swap 0 1 0 0
END

 */


int[] size = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = size[0];
int cols = size[1];

string[,] matrix = new string[rows, cols];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] values = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
        
        
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = values[col];
    }
}

string input;

while((input = Console.ReadLine()) != "END")
{
    string[] arguments = input
        .Split(" ",StringSplitOptions.RemoveEmptyEntries);

    string command = arguments[0];

    
    if (arguments.Length != 5 )
    {
        Console.WriteLine("Invalid input!");
        continue;
    }
    

    switch (command)
    {
        case "swap":
            int row1 = int.Parse(arguments[1]);
            int col1 = int.Parse(arguments[2]);

            int row2 = int.Parse(arguments[3]);
            int col2 = int.Parse(arguments[4]);

            if (!(row1 < matrix.GetLength(0) && row1 >= 0
        && col1 < matrix.GetLength(1) && col1 >= 0
        && row2 < matrix.GetLength(0) && row2 >= 0
        && col2 < matrix.GetLength(1) && col2 >= 0))
            {
                Console.WriteLine("Invalid input!");
                break;
            }

            string currentValue = matrix[row1, col1];
            string swapValue = matrix[row2, col2];
            matrix[row2, col2] = currentValue;
            matrix[row1, col1] = swapValue;
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
            break;
        default:
            Console.WriteLine("Invalid input!");
            break;
    }
}