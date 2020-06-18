using System;
namespace CoverLetterGenerator
{
    public class Letter
    {
        //Variables that don't rely on user input
        public string letterBody;
        public string date;

        //These are all variables containing user input
        private string username;
        private string company;
        private string position;
        private string jobBoard;
        private string companyInfo;
        private string summary;

        //Setting properties to user input variables so the input can be verified
        public string Username {
            get { return username; }
            set {
                username = value;
            }
        }

        public string Company
        {
            get { return company; }
            set {
                company = value;
            }
        }

        public string Position
        {
            get { return position; }
            set {
                position = value;
            }
        }

        public string JobBoard
        {
            get { return jobBoard; }
            set {
                jobBoard = value;
            }
        }

        public string CompanyInfo
        {
            get { return companyInfo; }
            set {
                companyInfo = value;
            }
        }

        public string Summary
        {
            get { return summary; }
            set {
                summary = value;
            }
        }

        public Letter()
        {
            //Setting the date to the current date
            this.date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            //This is creating a template for the letter to be printed from later
            this.letterBody = $"{this.date}\b\nTo whom it may concern,\n\nMy name is {this.username} and I am interested in applying for {this.position} at {this.company}. I learned about this position through {this.jobBoard}, and after visiting your website, {this.companyInfo} \n\nI am a graduate of the Vanderbilt University Full Stack Web Development Bootcamp.In this program I studied several aspects of web development ranging from HTML, CSS, and Javascript to Node, Express, and React; in addition, I also studied technologies such as mySQL and noSQL databases and concepts like Object Oriented Programming.During my time at Vanderbilt, I built a comprehensive portfolio of projects to demonstrate my proficiencies as a programmer.Several projects were created in collaborative groups which used version control with Git and project management with Agile methodologies. Upon graduation from Vanderbilt, I have continued my education by creating projects with Python and AWS. \n\nHaving an extensive background in music education  has helped  to strengthen my pursuit into web development.Through studying, performing, and teaching music, I have gained strengths such as leadership, quick problem solving, multitasking, and independence in my curriculum, which would make me a valuable addition to your team at {this.company}. \n \n{this.summary} I am looking forward to meeting with you in regards to the {this.position} position. \n \nThank you for your consideration. \n \nSincerely, \n{this.username} \nPhone: 615 - 477 - 2263 \nE - Mail: ptj92e@gmail.com";
        }
    }
}
