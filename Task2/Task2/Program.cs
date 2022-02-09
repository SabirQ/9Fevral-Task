using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "book", "pen", "table", "classroom", "room", "notebook","classmate" };
            foreach (string word in words)
            {
                if(word.Length>5)
                { Console.WriteLine(word); }
            }
        }
    }
}
