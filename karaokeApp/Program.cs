using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using karaokeApp;

namespace KaraokeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = new string[] { "allthistime", "endoftheworld", "itsasmallworld" };
            Console.WriteLine("Welcome to Singer");
            while (true)
            {
                Console.WriteLine("Please choose a song you would like to sing");
                Console.WriteLine("1 for Jonathan Coulton's All This Time");
                Console.WriteLine("2 for End of the World");
                Console.WriteLine("3 for It's A Small World");
                Console.WriteLine("Type 'Quit' to quit the application");

                var response = Console.ReadLine();

                if (response.ToLower() == "quit")
                    break;

                var song = 0;
                if(!int.TryParse(response, out song))
                    {
                        Console.WriteLine("Invalid Input, Try again.");
                        continue;
                    }
                    song--;
                    var fileName = songs[song] + ".txt";
                    Console.WriteLine(fileName);

                if(!File.Exists(fileName)) {
                    Console.WriteLine("File not found, Try again");
                    continue;
                }

                var lines = File.ReadAllLines(fileName);
                Console.WriteLine("=================================");
                foreach(var line in lines)
                {
                    Singer.WriteLine(line);
                }
                Console.WriteLine("=================================");
            }
        }
    }
}
