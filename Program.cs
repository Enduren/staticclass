using System;

namespace staticclatt
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Greenday", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);



        }
    }
}
