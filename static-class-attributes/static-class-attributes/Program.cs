using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class_attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Music eminem = new Music("Marshall Mathers", 13);
            Console.WriteLine(eminem.artist);
            Console.WriteLine(eminem.spotifyRank);
            Console.WriteLine(Music.songCount);

            Music edsheeran = new Music("Ed Sheeran", 3);
            Console.WriteLine(edsheeran.artist);
            Console.WriteLine(edsheeran.spotifyRank);
            //Console.WriteLine(Music.songCount);
            Console.WriteLine(edsheeran.SongCount());

            Console.ReadLine();
        }
    }
}
