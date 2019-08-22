using System;

namespace Practice_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            //Printing
            Console.WriteLine("Hello, Adam Asher!");
            //Printing Hello {name} with string
            String name = "Adam Asher!";
            Console.WriteLine("Hello, " + name);
            // Numbers
            int num1 = 2;
            int num2 = 8;
            int num3 = 10;
            int sum = num1 + num2;
            int dif = num2 - num1;
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(num3 += 1);
            Console.WriteLine(num3 -= 2);

            string community = "Dean: It's not easy being the dean Jeffery \nJeff: THEN STOP BEING THE DEAN! \nDEAN: [crying hysterically] IT'S MY WHOLE I-DEAN-TITY \nI mean, wah, see what I did there? thats proof!";
            Console.WriteLine(community);

            int a = 12;
            int b = 145;
            Console.WriteLine(b % a);

            char cat = "cat"[2];
            Console.WriteLine(cat + "ruecoders.io");

            bool nobool = true;
            Console.WriteLine(nobool);

            double pie = 3.14;
            Console.WriteLine(pie);


            //do-while
            int num4 = 1;
            do
            {
                Console.WriteLine("Number {0}", num4);

                num4++;

            } while (num4 <= 10);

            //Foreach
            string[] TV = { "The Boys", "jojo's bizarre adventure", "Dr. stone", "Community" };
            foreach (string value in TV)
            {
                Console.WriteLine("Shows Binged in class: " + value);

            }

            //while & if, elseif, else
            Random rand = new Random();

            int game = rand.Next(1, 100);
            int guess = 0;
            bool correct = false;

            while (!correct)
            {
                Console.Write("Find the right number thats\nBetween 1 and 100: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("That's not a number.");
                    continue;
                }

                if (guess < game)
                {
                    Console.WriteLine("oop to low");
                }
                else if (guess > game)
                {
                    Console.WriteLine("oop to high");
                }
                else
                {
                    correct = true;
                    Console.WriteLine("DING\nDING\nDING\nWINNER WINNER WINNER\nSorry no prizes...... :( ");
                }
            }

        }

    }
}






