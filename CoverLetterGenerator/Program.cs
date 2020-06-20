namespace CoverLetterGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var letterService = new LetterService();
            letterService.CreateLetter();
        }
    }
}