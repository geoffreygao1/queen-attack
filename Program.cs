using System;
using Chess.Models;
//test edit
namespace Chess
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter X Coordinate of Queen");
      string stringQueenX = Console.ReadLine();
      int queenX = int.Parse(stringQueenX);
      Console.WriteLine("Enter Y Coordinate of Queen");
      string stringQueenY = Console.ReadLine();
      int queenY = int.Parse(stringQueenY);
      Console.WriteLine("Enter X Coordinate of Opponent");
      string stringOppX = Console.ReadLine();
      int oppX = int.Parse(stringOppX);
      Console.WriteLine("Enter Y Coordinate of Opponent");
      string stringOppY = Console.ReadLine();
      int oppY = int.Parse(stringOppY);

      Queen yourQueen = new Queen(queenX, queenY);
      Queen opp = new Queen(oppX, oppY);

      if (yourQueen.X == opp.X || yourQueen.Y == opp.Y || Math.Abs(yourQueen.X - opp.X) == Math.Abs(yourQueen.Y - opp.Y))
      {
        Console.WriteLine("You can attack the opposing piece");
      }
      else
      {
        Console.WriteLine("You can't attack the opposing piece");
      }
    }
  }
}