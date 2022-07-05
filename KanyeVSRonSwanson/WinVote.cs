using System;
using System.Collections.Generic;
using System.Text;

namespace KanyeVSRonSwanson
{
    internal static class WinVote
    {
        public static string VoteTool()
        {

            string vote = Console.ReadLine();
            if (vote == "y")
            {
                Console.WriteLine("\nWho won?");
                var winner = Console.ReadLine().ToLower();
                bool inputKey;

                do {
                    if (winner == "kanye")
                    {
                        Console.WriteLine("\nThat's right Kanye West at his Kanye Best, putting Ron Swanson to Kanye Rest!");
                        break;
                    }
                    else if (winner == "ron swanson" || winner == "ron")
                    {
                        Console.WriteLine("\nEverything I do is the attitude of an award winner, because I've won an award.");
                        break;
                    }
                    else
                    {
                        inputKey = false;
                        while (!inputKey)
                        {
                            Console.WriteLine("Let's keep it between Ron and Kanye.");
                            winner = Console.ReadLine().ToLower();
                            inputKey = winner == "kanye" || winner == "ron swanson" || winner == "ron" ? true : false;
                        }
                    }
                }
                while (inputKey);

            }

            return vote;
        }
    }
}
