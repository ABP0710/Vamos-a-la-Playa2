using System;

namespace Vamos_a_la_Playa2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //massage to the user, and variables to store the data
            Console.WriteLine("please enter how many rows of chairs you have");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter how many chairs there is in each row");
            int columns = int.Parse(Console.ReadLine());


            //makes the array sets the rows and columns to the user input
            int[,] chairs = new int[rows, columns];


            //random there set the seat to taken
            Random random = new Random();
            //int IsSeatIsTaken = random.Next(0, 1);

            //loops though the array and randomly set the value
            for (int i = 0; i < chairs.GetLength(0); i++)
            {
                for (int j = 0; j < chairs.GetLength(1); j++)
                {
                    chairs[i, j] = random.Next(0, 2);
                    if (chairs[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(chairs[i, j]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(chairs[i, j]);
                    }                    
                }
                Console.WriteLine();    
            }


            //int variable for counting the numbers of free chairs
            int count = 0;

            // loops the array to see if there is a free chair
            for (int k = 0; k < chairs.GetLength(0); k++)
            {
                for (int l = 1; l < chairs.GetLength(1) - 1; l++)
                {
                    if (chairs[k, l] == 0)
                    {
                        if ((chairs[k, l] == 0 && chairs[k, l - 1] != 1) && (chairs[k, l] == 0 && chairs[k, l + 1] != 1))
                        {
                            count++;
                        }                        
                    }
                }
            }
            Console.WriteLine($"There is {count} free deckchairs");

        }
    }
}
