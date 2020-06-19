using System;

namespace CoverLetterGenerator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WriteLetter coverLetter = new WriteLetter();
            coverLetter.LetterInfo();
            coverLetter.CreateLetter();
        }
    }
}
