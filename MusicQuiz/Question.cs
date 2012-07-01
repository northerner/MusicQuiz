using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicQuiz
{
    struct Question
    {
        public Song answer1;
        public Song answer2;
        public Song answer3;

        public Question(Song answer1, Song answer2, Song answer3)
        {
            this.answer1 = answer1;
            this.answer2 = answer2;
            this.answer3 = answer3;
        }
    }
}
