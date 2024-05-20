/*
5 6
SoftUni

*/


int[] size = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = size[0];
int cols = size[1];

char[] snake = Console.ReadLine()
       .ToCharArray();

char[,] board = new char[rows, cols];

int caunter = 0;

for (int row = 0; row < board.GetLength(0); row++)
{

    for (int col = 0; col < board.GetLength(1); col++)
    {
        if ( row % 2 == 0)
        {
            board[row, col] = snake[caunter++];
            if (caunter == snake.Length)
            {
                caunter = 0;
            }
        }
        else
        {
            board[row, board.GetLength(1) - 1 - col] = snake[caunter++];

            if (caunter == snake.Length)
            {
                caunter = 0;
            }
        }
    } 
}

for (int row = 0; row < board.GetLength(0); row++)
{
    for(int col = 0;col < board.GetLength(1); col++)
    {
        Console.Write(board[row, col]);
    }
    Console.WriteLine();
}

