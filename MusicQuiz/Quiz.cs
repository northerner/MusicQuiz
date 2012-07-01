using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using TagLib;
using System.Diagnostics;
using System.Windows.Forms;

namespace MusicQuiz
{
    class Quiz
    {
        private string path;
        public List<Song> songs;
        Random random;

        public Quiz(string path, Random random)
        {
            this.path = path;
            this.random = random;
            songs = new List<Song>();

            // Search the base path for files, then directories within it
            List<string> directoryList = new List<string>();
            String[] baseDirectoryArray = Directory.GetFiles(path);
            directoryList = baseDirectoryArray.ToList<string>();

            String[] subDirectories = Directory.GetDirectories(path);
            for (int i = 0; i < subDirectories.Length; i++)
            {
                String[] subDirectoryArray = Directory.GetFiles(subDirectories[i]);
                List<string> tempList = subDirectoryArray.ToList<string>();
                foreach (string directoryString in tempList)
                {
                    directoryList.Add(directoryString);
                }                
            }

            String [] directoryArray = directoryList.ToArray<string>();

            //DEBUG code
            Debug.Assert(directoryArray.Length > 3);

            build(directoryArray);
            MessageBox.Show("Total songs added: " + songs.Count.ToString());
        }

        private void build(string[] directoryArray)
        {
            int fileCount = directoryArray.Length;
            for (int i = 0; i < fileCount; i++)
            {
                if (directoryArray[i].EndsWith(".mp3"))
                {
                    TagLib.File mp3 = TagLib.File.Create(directoryArray[i]);
                    bool performerTag = false;
                    string artist = "";
                    string album = "";
                    string title = "";
                    if (mp3.Tag.Performers.Length > 0)
                    {
                        artist = mp3.Tag.Performers[0];
                        performerTag = true;
                    }
                    album = mp3.Tag.Album;
                    title = mp3.Tag.Title;
                    if (performerTag)
                    {
                        songs.Add(new Song(title, artist, album, directoryArray[i]));
                    }
                }
            }
        }

        public Question newQuestion()
        {
            int count = songs.Count;
            int questionCount = 0;
            List<Song> questionSongs = new List<Song>();

            while (questionCount < 3)
            {
                Song randSong = songs[random.Next(0, songs.Count)];
                if (!questionSongs.Contains(randSong))
                {
                    questionSongs.Add(randSong);
                    questionCount++;
                }
            }
            Question question = new Question(questionSongs[0], questionSongs[1],
                questionSongs[2]);
            return question;
        }
    }
}
