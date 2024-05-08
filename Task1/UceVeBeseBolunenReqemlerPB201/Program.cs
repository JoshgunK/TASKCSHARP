namespace UceVeBeseBolunenReqemlerPB201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <=100; number++)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine($"{number} Uce Ve Bese Bolune Biler.");
                }
            }
        }
    }
}
