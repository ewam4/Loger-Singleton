using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.Instance;
            logger.Log("Start aplikacji.");
            logger.Log("Wykonywanie operacji...");
           

            for (int i=0; i<=5; i++)
            {
                logger.Log(i.ToString());
            }
            logger.Log("Zakończenie działania aplikacji.");

            Console.WriteLine("Logi zostały zapisane.");
        }
    }
}
