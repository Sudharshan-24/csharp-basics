using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class_attributes
{
    class Music
    {
        public string artist;
        public int spotifyRank;
        public static int songCount = 0;

        public Music(string aArtist, int aSpotifyRank)
        {
            artist = aArtist;
            spotifyRank = aSpotifyRank;
            songCount++;
        }

        public int SongCount()
        {
            return songCount;
        }
    }
}
