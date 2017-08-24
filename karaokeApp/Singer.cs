using System;

namespace karaokeApp
{
    public class Singer
    {
        public static void WriteLine(string line)
        {
            var results = line.Split(':');
            WriteLine(results[0], int.Parse(results[1]));
        }

        public static void WriteLine(string line, int time)
        {
            var speed = time / line.Length;
            foreach(var letter in line.ToCharArray())
            {
                Console.WriteLine(letter);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine("");
           
        }

    }
}
