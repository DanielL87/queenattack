using System;
using System.Collections.Generic;

namespace Game
{
  public class QueenAttack
  {
    public static bool QueenCanAttack(int X1, int Y1, int X2, int Y2)
    {
      if (X1 == X2)
      {
          return true;
      }
      else if (Y1 == Y2)
      {
          return true;
      }
      else if ((Math.Abs(X1-X2)) == (Math.Abs(Y1-Y2)))
      {
          return true;
      }
      else {
          return false;
         }
      }

      public static void Main()
      {
          Console.WriteLine("Give me X1.");
          int X1 = int.Parse(Console.ReadLine());

          Console.WriteLine("Give me Y1");
          int Y1 = int.Parse(Console.ReadLine());

          Console.WriteLine("Give me X2");
          int X2 = int.Parse(Console.ReadLine());

          Console.WriteLine("Give me Y2");
          int Y2 = int.Parse(Console.ReadLine());

          Console.WriteLine(QueenCanAttack(X1,Y1,X2,Y2));
      }
      
    }
  }
