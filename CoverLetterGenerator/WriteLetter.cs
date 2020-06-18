using System;
namespace CoverLetterGenerator
{
    public class WriteLetter
    {
        Letter newLetter = new Letter();

        public WriteLetter()
        {
        }

        public void LetterInfo()
        {
            //Prompts to get the user's information for the cover letter
            Console.WriteLine("What is your name?");
            //Sets the 
            newLetter.Username = Console.ReadLine();
            //Clears the console just to make it less cluttered
            Console.Clear();

            Console.WriteLine("What is the company's name?");
            newLetter.Company = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What is the position you are applying for?");
            newLetter.Position = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Where did you find this position?");
            newLetter.JobBoard = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("I am excited at the opportunity to work for a company that...");
            newLetter.CompanyInfo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Why would you be a good fit for this position?");
            newLetter.Summary = Console.ReadLine();
            Console.Clear();

            Console.WriteLine(newLetter.letterBody);
        }
    }

}
