namespace Task2
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            int Bal = 85;
            if (Bal < 65)
            {
                Console.WriteLine("Kesildiniz");
            }
            else if (Bal >= 65 && Bal < 85)
            {
                Console.WriteLine("Tebrikler Adi Diploma Layiq Goruldunuz");
            }
            else if (Bal >= 85 && Bal < 95)
            {
                Console.WriteLine("Tebrikler Seref Diplomuna Layiq Goruldunuz!");
            }
            else if (Bal >= 95 && Bal <= 100)
            {
                Console.WriteLine("***TEBRIKLER ALI SEREF DIPLOMUNA LAYIQ GORULDUNUZ!***");
            }
            else if (Bal > 100)
            {
                Console.WriteLine("Tebrikler Easter Egg Tapdiniz :) PB201");
            }

        }
    }
}
