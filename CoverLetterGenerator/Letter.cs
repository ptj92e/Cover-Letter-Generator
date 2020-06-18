using System;
namespace CoverLetterGenerator
{
    public class Letter
    {
        //Define variables
        //letter body
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
            date = DateTime.UtcNow.ToString("MM-dd-yyyy");
        }
    }
}
