using System;
using System.Collections.Generic;
using System.Text;

namespace staticclatt
{
    class Song
    {

        public string title;
        public string artist;
        public int duration;
        //create a static attribute for songCount
        public static int songCount = 0;
        
        //constructor method
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
           //every time a song object gets created the song count will add 1 to it
            songCount++;

        }





    }













}
