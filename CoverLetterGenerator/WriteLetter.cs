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
        }

        public void CreateLetter()
        {
            string letterBody = $"{newLetter.date}\b\nTo whom it may concern,\n\nMy name is {newLetter.Username} and I am interested in applying for {newLetter.Position} at {newLetter.Company}. I learned about this position through {newLetter.JobBoard}, and after visiting your website, {newLetter.CompanyInfo} \n\nI am a graduate of the Vanderbilt University Full Stack Web Development Bootcamp.In this program I studied several aspects of web development ranging from HTML, CSS, and Javascript to Node, Express, and React; in addition, I also studied technologies such as mySQL and noSQL databases and concepts like Object Oriented Programming.During my time at Vanderbilt, I built a comprehensive portfolio of projects to demonstrate my proficiencies as a programmer.Several projects were created in collaborative groups which used version control with Git and project management with Agile methodologies. Upon graduation from Vanderbilt, I have continued my education by creating projects with Python and AWS. \n\nHaving an extensive background in music education  has helped  to strengthen my pursuit into web development.Through studying, performing, and teaching music, I have gained strengths such as leadership, quick problem solving, multitasking, and independence in my curriculum, which would make me a valuable addition to your team at {newLetter.Company}. \n \n{newLetter.Summary} I am looking forward to meeting with you in regards to the {newLetter.Position} position. \n \nThank you for your consideration. \n \nSincerely, \n{newLetter.Username} \nPhone: 615 - 477 - 2263 \nE - Mail: ptj92e@gmail.com";

            Console.WriteLine(letterBody);
        }
    }

}
