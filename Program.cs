namespace BasicCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
               Console.WriteLine("Hello");
        }

  private static void GuessTheNumber()
  {
      Random rnd = new Random();
      int on = rnd.Next(1, 101);

      int un = 0;
      while (true)
      {
          Console.WriteLine("Guess the number.");
          un = Convert.ToInt32(Console.ReadLine());

          if (un == on)
          {
              Console.WriteLine("You got the right number.");
              break;
          }
          else if (un < on)
          {
              Console.WriteLine("you guessed it Low");
          }
          else
          {
              Console.WriteLine("you guessed it high");
          }
      }
  }

        
         private static void FindMaxIn3Numbers()
 {
     Console.WriteLine("Enter Number 1 ");
     int a = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Enter Number 2 ");
     int b = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Enter Number 3 ");
     int c = Convert.ToInt32(Console.ReadLine());

     int max = a;

     if (max < b)
     {
         max = b;
     }
     if (max < c)
     {
         max = c;
     }

     HighlightLine("MAX Value is " + max);
 }
    }
}
