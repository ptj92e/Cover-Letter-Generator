using System;
namespace CoverLetterGenerator
{
    public class Letter
    {
        //A variable that don't rely on user input
        public string date;

        //Setting properties to user input variables so the input can be verified
        public string Username { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string JobBoard { get; set; }
        public string CompanyInfo { get; set; }
        public string Summary { get; set; }

        public Letter()
        {
            //Setting the date to the current date
            date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            //This is creating a template for the letter to be printed from later
            
        }
    }
}
