namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompting for and getting a maximum number from the user.
            Console.Write("please enter number maximum:");
            int maximum = int.Parse(Console.ReadLine());

            //Print all the even numbers from 0 up to the maximum number 
            //(or 1 less than the maximum number if the maximum number is odd).
            for (int i = 0; i < maximum; i++)
            {
               if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            //Prompting for and getting a row width from the user.
            Console.Write("please insert the width for each row:");
            int numberAsterisks = int.Parse(Console.ReadLine());

            //Printing a single row asterisks that the user-specified row width
            for (int i = numberAsterisks; i > 0; i--)  
            {
                Console.Write("*"); 
            }
        }
    }
}