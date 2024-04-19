Console.Title = "Tic-Tac-Toe";
Console.Clear();


GameBoard game = new GameBoard();
game.DrawBoard();

while (true)
{
    PlayerMoves player = new PlayerMoves();
    game.updateBoard(player.GetPlayerMove(player.PlayerTurn = "X"), player.PlayerTurn = "X");
    game.updateBoard(player.GetPlayerMove(player.PlayerTurn = "O"), player.PlayerTurn = "O");
}

class GameBoard
{

    public static string[,] board = new string[3, 3]
    {
        {"1", "2", "3"},
        {"4", "5", "6"},
        {"7", "8", "9"}
    };

    public void DrawBoard()
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
        DrawBoard();
        return player;
    }
}

class PlayerMoves
{
    public string PlayerTurn;
    public string playerMove;
    public bool validMove = false;

    public int GetPlayerMove(string player)
    {
        Console.WriteLine($"Player {player}'s turn" );
        playerMove = Console.ReadLine();
        return int.Parse(playerMove);
    }
}

