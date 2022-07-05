using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;


namespace KanyeVSRonSwanson
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string vote;
            do
            {
                Kanye.Speak();
                Console.WriteLine(" - Kanye");
                Console.WriteLine();
                RonSwanson.Speak();
                Console.WriteLine(" - Ron Swanson");
                Console.WriteLine("\nDid someone win? y/n");
                vote = WinVote.VoteTool();
            }
            while (vote != "y");
        }


    }
}
