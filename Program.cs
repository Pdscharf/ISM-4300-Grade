using System;

namespace ISM_4300_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to receive in ISM 4300?");
            try
            {
                string input = Console.ReadLine();
                int average = int.Parse(input);

                if (average >= 98)
                {
                    Console.WriteLine("You will receive an A+. Great Job!");
                }
                else if ((average >= 92) && (average < 98))
                {
                    Console.WriteLine("You will receive a A.");
                }
                else if ((average >= 90) && (average < 92))
                {
                    Console.WriteLine("You will receive a A-.");
                }
                else if ((average >=88 ) && (average < 90))
                {
                    Console.WriteLine("You will receive a B+.");
                }
                else if ((average >= 82) && (average < 88))
                {
                    Console.WriteLine("You will receive a B.");
                }
                else if ((average >= 80) && (average < 82))
                {
                    Console.WriteLine("You will receive a B-.");
                }
                else if ((average >= 78) && (average < 80))
                {
                    Console.WriteLine("You will receive a C+.");
                }
                else if ((average >= 72) && (average < 78))
                {
                    Console.WriteLine("You will receive a C.");
                }
                else if ((average >= 70) && (average < 72))
                {
                    Console.WriteLine("You will receive a C-.");
                }
                else if ((average >= 68) && (average < 70))
                {
                    Console.WriteLine("You will receive a D+.");
                }
                else if ((average >= 62) && (average < 68))
                {
                    Console.WriteLine("You will receive a D.");
                }
                else if ((average >= 60) && (average < 62))
                {
                    Console.WriteLine("You will receive a D-.");
                }
                else if (average < 60)
                {
                    Console.WriteLine("You will receive an F.");
                }
            }

            catch
            {

            }

        }
    }
}
