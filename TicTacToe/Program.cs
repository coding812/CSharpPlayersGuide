Console.Title = "Tic-Tac-Toe";
Console.Clear();

GameBoard game = new GameBoard();
GameBoard.DrawBoard();
string Winner;

do
{
    PlayerInput player = new PlayerInput();

    // Calls the GetPlayerMove method from the PlayerInput class and passes the player's turn as an argument
    // the method returns the player's move and assigns it to the playerMove variable
    // the playerMove variable is then passed as an argument to the updateBoard method from the GameBoard class
    game.updateBoard(player.GetPlayerMove(player.PlayerTurn = "X"), player.PlayerTurn);
    Winner = CheckWinner.CheckWin(GameBoard.board);
    if (Winner != null)
    {
        break;
    }
    game.updateBoard(player.GetPlayerMove(player.PlayerTurn = "O"), player.PlayerTurn);
    Winner = CheckWinner.CheckWin(GameBoard.board);
}
while (Winner == null);

Console.WriteLine($"Player {Winner} wins!");

class GameBoard
{
    // Creates a 2D array to represent the game board
    public static string[,] board = new string[3, 3]
    {
        {"1", "2", "3"},
        {"4", "5", "6"},
        {"7", "8", "9"}
    };
    // Draws the game board
    public static void DrawBoard()
    {
        Console.Clear();
        Console.WriteLine("         |     |      ");
        Console.WriteLine("      {0}  |  {1}  |  {2}", board[0, 0], board[0, 1], board[0, 2]);
        Console.WriteLine("    _____|_____|_____ ");
        Console.WriteLine("         |     |      ");
        Console.WriteLine("      {0}  |  {1}  |  {2}", board[1, 0], board[1, 1], board[1, 2]);
        Console.WriteLine("    _____|_____|_____ ");
        Console.WriteLine("         |     |      ");
        Console.WriteLine("      {0}  |  {1}  |  {2}", board[2, 0], board[2, 1], board[2, 2]);
        Console.WriteLine("         |     |      ");
        Console.WriteLine();
    }
    // Updates the game board with the player's move
    public string updateBoard(int playerMove, string player)
    {
        string playerSymbol = player;
        switch (playerMove)
        {
            case 1:
                board[0, 0] = playerSymbol;
                break;
            case 2:
                board[0, 1] = playerSymbol;
                break;
            case 3:
                board[0, 2] = playerSymbol;
                break;
            case 4:
                board[1, 0] = playerSymbol;
                break;
            case 5:
                board[1, 1] = playerSymbol;
                break;
            case 6:
                board[1, 2] = playerSymbol;
                break;
            case 7:
                board[2, 0] = playerSymbol;
                break;
            case 8:
                board[2, 1] = playerSymbol;
                break;
            case 9:
                board[2, 2] = playerSymbol;
                break;
        }
        // Calls the DrawBoard method to display the updated game board and returns the player's symbol
        DrawBoard();
        return player;
    }
}

class PlayerInput
{
    // Declares variables to store the player's turn, move, and whether the move is valid
    public string? PlayerTurn;
    public string? playerMove;
    public bool validMove = false;
    // Gets the player's move
    public int GetPlayerMove(string player)
    {
        Console.WriteLine($"Player {player}'s turn" );
        playerMove = Console.ReadLine();
        if (playerMove == "" || playerMove == null || int.Parse(playerMove) > 9 || int.Parse(playerMove) < 1)
        {
            Console.WriteLine("Invalid move. Please try again.");
            return GetPlayerMove(player);
        }
        return int.Parse(playerMove);
    }
}

class CheckWinner
{
    public static string CheckWin(string[,] board)
    {
        // Check for horizontal win
        for (int i = 0; i < 3; i++)
        {
            if (GameBoard.board[i, 0] == GameBoard.board[i, 1] && GameBoard.board[i, 1] == GameBoard.board[i, 2])
            {
                return GameBoard.board[i, 0];
            }
        }
        // Check for vertical win
        for (int i = 0; i < 3; i++)
        {
            if (GameBoard.board[0, i] == GameBoard.board[1, i] && GameBoard.board[1, i] == GameBoard.board[2, i])
            {
                return GameBoard.board[0, i];
            }
        }
        // Check for diagonal win
        if (GameBoard.board[0, 0] == GameBoard.board[1, 1] && GameBoard.board[1, 1] == GameBoard.board[2, 2])
        {
            return GameBoard.board[0, 0];
        }
        if (GameBoard.board[0, 2] == GameBoard.board[1, 1] && GameBoard.board[1, 1] == GameBoard.board[2, 0])
        {
            return GameBoard.board[0, 2];
        }
        return null!;
    }
}