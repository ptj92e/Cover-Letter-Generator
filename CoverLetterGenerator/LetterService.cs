using System;

using static System.IO.File;

namespace CoverLetterGenerator
{
    public class LetterService
    {
        private Letter LetterInfo()
        {
            //Prompts to get the user's information for the cover letter
            Console.WriteLine("What is your name?");
            //Sets the 
            var name = Console.ReadLine();
            //Clears the console just to make it less cluttered
            Console.Clear();

            Console.WriteLine("What is the company's name?");
            var company = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What is the position you are applying for?");
            var position = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Where did you find this position?");
            var jobBoard = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("I am excited at the opportunity to work for a company that...");
            var companyInfo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Why would you be a good fit for this position?");
            var summary = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What's a good phone number?");
            var phoneNum = Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("What's a good email?");
            var email = Console.ReadLine();
            Console.Clear();

            var applicant = new Applicant
            {
                Name = name,
                Phone = phoneNum,
                Email = email
            };

            return new Letter
            {
                Applicant = applicant,
                Company = company,
                CompanyInfo = companyInfo,
                JobBoard = jobBoard,
                Position = position,
                Summary = summary
            };
        }

        public void CreateLetter()
        {
            var newLetter = LetterInfo();
            
            if (newLetter == null
            || newLetter.Applicant == null
            || string.IsNullOrEmpty(newLetter.Applicant.Name)
            || string.IsNullOrEmpty(newLetter.Applicant.Phone)
            || string.IsNullOrEmpty(newLetter.Applicant.Email)
            || string.IsNullOrEmpty(newLetter.Company)
            || string.IsNullOrEmpty(newLetter.CompanyInfo)
            || string.IsNullOrEmpty(newLetter.JobBoard)
            || string.IsNullOrEmpty(newLetter.Position)
            || string.IsNullOrEmpty(newLetter.Summary))
                return;
            
            var letterBody =
                $"{DateTime.Now.ToString("MM-dd-yyyy")}\b\nTo whom it may concern,\n\nMy name is {newLetter.Applicant.Name} and I am interested in applying for {newLetter.Position} at {newLetter.Company}. I learned about this position through {newLetter.JobBoard}, and after visiting your website, {newLetter.CompanyInfo} \n\nI am a graduate of the Vanderbilt University Full Stack Web Development Bootcamp.In this program I studied several aspects of web development ranging from HTML, CSS, and Javascript to Node, Express, and React; in addition, I also studied technologies such as mySQL and noSQL databases and concepts like Object Oriented Programming.During my time at Vanderbilt, I built a comprehensive portfolio of projects to demonstrate my proficiencies as a programmer.Several projects were created in collaborative groups which used version control with Git and project management with Agile methodologies. Upon graduation from Vanderbilt, I have continued my education by creating projects with Python and AWS. \n\nHaving an extensive background in music education  has helped  to strengthen my pursuit into web development.Through studying, performing, and teaching music, I have gained strengths such as leadership, quick problem solving, multitasking, and independence in my curriculum, which would make me a valuable addition to your team at {newLetter.Company}. \n \n{newLetter.Summary} I am looking forward to meeting with you in regards to the {newLetter.Position} position. \n \nThank you for your consideration. \n \nSincerely, \n{newLetter.Applicant.Name} \nPhone: {newLetter.Applicant.Phone} \nE - Mail: {newLetter.Applicant.Email}";

            WriteAllText($"/Users/phillipjones/Desktop/{newLetter.Company}.txt", letterBody);
        }
    }
}