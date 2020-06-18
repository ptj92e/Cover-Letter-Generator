using System;
namespace CoverLetterGenerator
{
    public class Letter
    {
        //Define variables
        public string letterBody;
        public string date;
        //These are all variables containing user input
        public string username;
        public string company;
        public string position;
        public string jobBoard;
        public string companyInfo;
        public string summary;

        public Letter()
        {
            //This constructor takes in user input to create an instance of the letter class
            Console.WriteLine("What is your name?");
            this.username = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is the company's name?");
            this.company = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is the position you are applying for?");
            this.position = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Where did you find this position?");
            this.jobBoard = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("I am excited at the opportunity to work for a company that...");
            this.companyInfo = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Why would you be a good fit for this position?");
            this.summary = Console.ReadLine();
            Console.Clear();
            this.date = DateTime.UtcNow.ToString("MM-dd-yyyy");

            this.letterBody = $"{this.date}\b\nTo whom it may concern,\n\nMy name is {this.username} and I am interested in applying for {this.position} at {this.company}. I learned about this position through {this.jobBoard}, and after visiting your website, {this.companyInfo} \n\nI am a graduate of the Vanderbilt University Full Stack Web Development Bootcamp.In this program I studied several aspects of web development ranging from HTML, CSS, and Javascript to Node, Express, and React; in addition, I also studied technologies such as mySQL and noSQL databases and concepts like Object Oriented Programming.During my time at Vanderbilt, I built a comprehensive portfolio of projects to demonstrate my proficiencies as a programmer.Several projects were created in collaborative groups which used version control with Git and project management with Agile methodologies. Upon graduation from Vanderbilt, I have continued my education by creating projects with Python and AWS. \n\nHaving an extensive background in music education  has helped  to strengthen my pursuit into web development.Through studying, performing, and teaching music, I have gained strengths such as leadership, quick problem solving, multitasking, and independence in my curriculum, which would make me a valuable addition to your team at {this.company}. \n \n{this.summary} I am looking forward to meeting with you in regards to the {this.position} position. \n \nThank you for your consideration. \n \nSincerely, \n{this.username} \nPhone: 615 - 477 - 2263 \nE - Mail: ptj92e@gmail.com";
        }
    }
}
