using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*Console.WriteLine("Enter a number from 1 to 10");
            int userNumber1;
            userNumber1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number from 1 to 10");
            int userNumber2;
            userNumber2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number from 1 to 10");
            int userNumber3;
            userNumber3= Int32.Parse(Console.ReadLine());

            if (userNumber1 > userNumber2)
            {
                if (userNumber1 > userNumber3)
                {
                    Console.WriteLine($"{userNumber1} is a winner");
                }
            else if (userNumber2 > userNumber3)
                {
                    if (userNumber2 > userNumber1)
                    {
                        Console.WriteLine($"{userNumber2} is a winner");
                    }
             else if (userNumber3 > userNumber2)
                    {
                        if (userNumber3 > userNumber1)
                        {
                            Console.WriteLine($"{userNumber3} is a winner");
                        }
             Console.ReadLine();
                    }
                }
            }*/



            /*Random number generator*/


            /*Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1,11);
            Console.WriteLine(randomNumber);*/

            /*Random randomGenerator = new Random();
            int cpuRoll = randomGenerator.Next(1, 7);
            Console.WriteLine("Throw a dice (enter a number from 1-6): ");
            int userRoll = int.Parse(Console.ReadLine());

            if (userRoll > cpuRoll)
            {
                Console.WriteLine("Congratulations, you won!");
            }
            else if (userRoll < cpuRoll)
            {
                Console.WriteLine("You lost! Try again!");
            }
            else
            {
                Console.WriteLine("Tie!");
            }
            Console.ReadLine();*/

            /*int userRoll;
            int cpuRoll;
            int rolls = 0;
            int userScore = 0;
            int cpuScore = 0;

            Random rnd = new Random();

            while (rolls < 3)
            {
                userRoll = rnd.Next(1, 7);
                cpuRoll = rnd.Next(1, 7);

                Console.WriteLine($"You rolled {userRoll}, CPU rolled {cpuRoll}");

                if (userRoll > cpuRoll)
                {
                    // userScore = userScore + 1;
                    userScore++;
                }
                else if (userRoll < cpuRoll)
                {
                    cpuScore++;
                }
                else
                {
                    continue;
                }
                rolls++;
                Console.ReadLine();
                {

                    if (userScore > cpuScore)
                    {
                        Console.WriteLine("Congratulation! You won!");
                    }
                    else if (userScore < cpuScore)
                    {
                        Console.WriteLine("oops, you lost. Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Tie. Nobody wins or loses!");
                    }
                    Console.WriteLine($"You scored {userScore}, cpu scored {cpuScore}");

                    Console.ReadLine();*/

            /*Random rnd = new Random();
            int randomNumber = rnd.Next(1, 6);
            Console.WriteLine($"CPU generated {randomNumber}");

            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("CPU generated nothing");
                    break;
            }*/

            Console.WriteLine("Pick a color (red, black, blue): ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "red":
                    Console.WriteLine("You are a romantic type");
                    break;
                case "black":
                    Console.WriteLine("You are a loner");
                    break;
                case "blue":
                    Console.WriteLine("You are a in love with sea");
                    break;
                default:
                    Console.WriteLine("cannot recognize the color");
                    break;
            }
            Console.ReadLine();



        }
    }
}





        }
    }
}
