class TicTacToe
{
    static void Main(string[] args)
    {

        List<string> board = GetNewBoard();
        string currentPlayer = "x";

        while (!IsGameOver(board))
        {
            DisplayBoard(board);

            int choice = GetMoveChoice(currentPlayer);
            MakeMove(board, choice, currentPlayer);

            currentPlayer = GetNextPlayer(currentPlayer);
        }

        DisplayBoard(board);
        Console.WriteLine("Good game. Thanks for playing!");
    }

    /// <summary>Gets a new instance of the board with the numbers 1-9 in place. </summary>
    /// <returns>A list of 9 strings representing each square.</returns>
    static List<string> GetNewBoard()
    {
        string[] tiles = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
        List<string> board = new List<string>(tiles);
        return board;
    }

    /// <summary>Displays the board in a 3x3 grid.</summary>
    /// <param name="board">The board</param>
    static void DisplayBoard(List<string> board)
    {
        Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
    }

    /// <summary>
    /// Determines if the game is over because of a win or a tie.
    /// </summary>
    /// <param name="board">The current board.</param>
    /// <returns>True if the game is over</returns>
    static bool IsGameOver(List<string> board)
    {   
        if (IsWinner(board, "x") || IsWinner(board, "o") || IsTie(board)) 
        {
            return true;
        }
        return false;
    }

    /// <summary>Determines if the provided player has a tic tac toe.</summary>
    /// <param name="board">The current board</param>
    /// <param name="player">The player to check for a win</param>
    /// <returns></returns>
    static bool IsWinner(List<string> board, string player)
    {
        for (int i = 0; i < 9; i++)
        {
            if (i < 3)
            {
                if (board[i] == player && board[i + 3] == player && board[i + 6] == player)
                {
                    return true;
                }
            }

            if ((i + 1) % 3 == 0)
            {
                if (board[i - 2] == player && board[i - 1] == player && board[i] == player)
                {
                    return true;
                }
            }

            if (i == 0)
            {
                if (board[i] == player && board[i + 4] == player && board[i + 8] == player)
                {
                    return true;
                }
            }

            if (i == 2)
            {
                if (board[i] == player && board[i + 2] == player && board[i + 4] == player)
                {
                    return true;
                }
            }
        }
        
        return false;
    }

    /// <summary>Determines if the board is full with no more moves possible.</summary>
    /// <param name="board">The current board.</param>
    /// <returns>True if the board is full.</returns>
    static bool IsTie(List<string> board)
    {
        foreach (string tile in board)
        {
            if (tile != "x" || tile != "o")
            {
                return false;
            } 
        }
        return true;
    }

    /// <summary>Cycles through the players (from x to o and o to x)</summary>
    /// <param name="currentPlayer">The current players sign (x or o)</param>
    /// <returns>The next players sign (x or o)</returns>
    static string GetNextPlayer(string currentPlayer)
    {
        if (currentPlayer == "x")
        {
            return "o";
        }
        return "x";
    }

    /// <summary>Gets the 1-based spot number associated with the user's choice.</summary>
    /// <param name="currentPlayer">The sign (x or o) of the current player.</param>
    /// <returns>A 1-based spot number (not a 0-based index)</returns>
    static int GetMoveChoice(string currentPlayer)
    {
            Console.WriteLine("Enter a number 1-9: ");
            string? input = Console.ReadLine();
            if (input == "1")
            {
                return 1;
            }

            else if (input == "2")
            {
                return 2;
            }

            else if (input == "3")
            {
                return 3;
            }

            else if (input == "4")
            {
                return 4;
            }

            else if (input == "5")
            {
                return 5;
            }

            else if (input == "6")
            {
                return 6;
            }

            else if (input == "7")
            {
                return 7;
            }

            else if (input == "8")
            {
                return 8;
            }

            else if (input == "9")
            {
                return 9;
            }
        return 1;
    }

    /// <summary>
    /// Places the current players mark on the board at the desired spot.
    /// This method does NOT check to ensure the spot is available.
    /// </summary>
    /// <param name="board">The current board</param>
    /// <param name="choice">The 1-based spot number (not a 0-based index).</param>
    /// <param name="currentPlayer">The current player's sign (x or o)</param>
    static void MakeMove(List<string> board, int choice, string currentPlayer)
    {
        board[choice - 1] = currentPlayer;
    }
}