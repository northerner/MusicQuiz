using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicQuiz
{
    class Song
    {
        public readonly string title;
        public readonly string artist;
        public readonly string album;
        public readonly string path;

        public Song(string title, string artist, string album, string path)
        {
            this.title = title;
            this.artist = artist;
            this.album = album;
            this.path = path;
        }
    }
}
