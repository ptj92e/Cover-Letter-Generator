using System;

namespace CoverLetterGenerator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Letter coverLetter = new Letter();
            Console.WriteLine(coverLetter.letterBody);
        }
    }
}
