using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopActive = true;
            int i = 0;


            while (loopActive)
            {
                Console.WriteLine("Sisesta arv 1 ja 10 vahel");
                int randomNumber = Convert.ToInt32(Console.ReadLine());

                if (randomNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne, arvasid numbri ära!");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine($"Vale vastus, proovi uuesti.");
                    i++;
                    Console.WriteLine($"Sa oled proovinud {i} korda:");
                }
            }

        }
    }
}
