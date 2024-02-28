namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompting for and getting a maximum number from the user.
            Console.WriteLine("please enter number maximum:");
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
        }
    }
}