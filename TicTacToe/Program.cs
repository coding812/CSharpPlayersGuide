Console.Title = "Tic-Tac-Toe";
Console.Clear();


GameBoard game = new GameBoard();
game.DrawBoard();



class GameBoard
{
    public string[,] board = new string[3, 3]
    {
        {"1", "2", "3"},
        {"4", "5", "6"},
        {"7", "8", "9"}
    };

    public void DrawBoard()
    {
        Console.WriteLine("         |     |      ");
        Console.WriteLine("      {0}  |  {1}  |  {2}", board[0, 0], board[0, 1], board[0, 2]);
        Console.WriteLine("    _____|_____|_____ ");
        Console.WriteLine("         |     |      ");
        Console.WriteLine("      {0}  |  {1}  |  {2}", board[1, 0], board[1, 1], board[1, 2]);
        Console.WriteLine("    _____|_____|_____ ");
        Console.WriteLine("         |     |      ");
        Console.WriteLine("      {0}  |  {1}  |  {2}", board[2, 0], board[2, 1], board[2, 2]);
        Console.WriteLine("         |     |      ");
    }
}

class PlayerMoves
{
    public void PlayerXMove()
    {
        Console.WriteLine("X's turn, enter a number where you would like to go: ");
        int Xmove = Convert.ToInt32(Console.ReadLine());
    }

    public void PlayerOMove()
    {
        Console.WriteLine("O's turn, enter a number where you would like to go: ");
        int Omove = Convert.ToInt32(Console.ReadLine());
    }
}