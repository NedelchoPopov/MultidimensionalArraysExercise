/*
5
0K0K0
K000K
00K00
K000K
0K0K0

2
KK
KK

8
0K0KKK00
0K00KKKK
00K0000K
KKKKKK0K
K0K0000K
KK00000K
00K0K000
000K00KK

 */


int rows = int.Parse(Console.ReadLine());

char[,] board = new char[rows, rows];

for (int row = 0; row < board.GetLength(0); row++)
{

    char[] chars = Console.ReadLine()
        .ToCharArray();

    for (int col = 0; col < board.GetLength(1); col++)
    {
        board[row, col] = chars[col];
    }
}

int removeKnights = 0;

while (true)
{
    int maxAttacks = 0;
    int knightRow = 0;
    int knightCol = 0;
    
    for (int row = 0;row < board.GetLength(0); row++) 
    { 

        for (int col = 0;col < board.GetLength(1); col++)
        {
            int currentAttacks = 0;

            if (board[row, col] != 'K')
            {
                continue;
            }

            int[] positions =
            {
                -2, -1,
                -2, 1,
                2, -1,
                2, 1,
                -1, 2,
                1, 2,
                -1, -2,
                1, -2,
            };


            for (int i = 0; i < positions.Length; i+= 2)
            {
                int nextRow = row + positions[i];
                int nextCol = col + positions[i + 1];

                if (IsInsideBoard(board, nextRow, nextCol)
                    && board[nextRow, nextCol] == 'K')
                {
                    currentAttacks++;
                }
            }

            //if(IsInsideBoard(board, row - 2, col - 1)
            //        && board[row - 2, col - 1] == 'K')
            //{
            //     currentAttacks++;
            //}
            //if (IsInsideBoard(board, row - 2, col + 1)
            //   && board[row - 2, col + 1] == 'K')
            //{
            //    currentAttacks++;
            //}

            //if (IsInsideBoard(board, row + 2, col - 1)
            //       && board[row + 2, col - 1] == 'K')
            //{
            //    currentAttacks++;
            //}
            //if (IsInsideBoard(board, row + 2, col + 1)
            //       && board[row + 2, col + 1] == 'K')
            //{
            //    currentAttacks++;
            //}

            //if (IsInsideBoard(board, row - 1, col + 2)
            //       && board[row - 1, col + 2] == 'K')
            //{
            //    currentAttacks++;
            //}
            //if (IsInsideBoard(board, row + 1, col + 2)
            //       && board[row + 1, col + 2] == 'K')
            //{
            //    currentAttacks++;
            //}

            //if (IsInsideBoard(board, row - 1, col - 2)
            //       && board[row - 1, col - 2] == 'K')
            //{
            //    currentAttacks++;
            //}
            //if (IsInsideBoard(board, row + 1, col - 2)
            //       && board[row + 1, col - 2] == 'K')
            //{
            //    currentAttacks++;
            //}

            if (currentAttacks > maxAttacks)
            {
                maxAttacks = currentAttacks;
                knightRow = row;
                knightCol = col;
            }

        }
    }

    if (maxAttacks > 0)
    {
        board[knightRow, knightCol] = '0';
        removeKnights++;
    }
    else
    {
        break;
    }

}

Console.WriteLine(removeKnights);

bool IsInsideBoard(char[,] board, int row, int col)
{

    return row >= 0 && row <= board.GetLength(0) - 1
        && col >= 0 && col <= board.GetLength(1) - 1;
}