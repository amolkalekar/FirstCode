namespace BasicCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
               Console.WriteLine("Hello");
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
