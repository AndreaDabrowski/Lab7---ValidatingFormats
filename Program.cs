using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompts users for input and states if it is correct
            Console.WriteLine("Welcome to the Format Validation Tool!");
            string userName = ValidateName();
            Console.WriteLine("That is the correct format: " + userName);
            string userEmail = ValidateEmail();
            Console.WriteLine("That is the correct format: " + userEmail);
            string userPhoneNumber = ValidatePhoneNumber();
            Console.WriteLine("That is the correct format: "+ userPhoneNumber);
            string userDate = ValidateDate();
            Console.WriteLine("That is the correct format: "+ userDate);
            Console.WriteLine("Thank you, {0}",userName);
            Console.ReadLine();

        }
        //Validates email format for XXX@XXX.XXX format
        public static string ValidateEmail()
        {
            Console.Write("What is your Email address? ");
            //input
            string userEmail = Console.ReadLine();
            //processing
            while (!Regex.IsMatch(userEmail, @"^[A-z0-9]{5,30}@+[a-z0-9]{5,10}.+[a-z0-9]{2,3}$"))
            {
                Console.WriteLine("That's not the correct format, try again");
                userEmail = Console.ReadLine();
            }
            //output
            return userEmail;
        }
        //Validates name for Xxxx format
        public static string ValidateName()
        {
            Console.Write("What's your name? ");
            //input
            string userName = Console.ReadLine();
            //processing
            while (!Regex.IsMatch(userName, @"^[A-Z]+[a-z]{2,30}$"))
            {
                Console.WriteLine("That's not the correct format, try again");
                userName = Console.ReadLine();
            }
            return userName;
            //output

        }
        //validates Date for XX/XX/XXXX format
        public static string ValidateDate()
        {
            Console.Write("What's the date today? (MM/DD/YYYY) ");
            //input
            string userDate = Console.ReadLine();
            //processing
            while (!Regex.IsMatch(userDate, @"^(0[1-9]|1[012])[/](0[1-9]|[12][0-9]|3[01])[/](19|20)\d\d$"))//can switch (19|20) for \d\d to validate any year, not just recent.
            {
                Console.WriteLine("That's not the correct format, try again");
                userDate = Console.ReadLine();
            }
            //output
            return userDate;
            
        }
        //Validates phone number for XXX-XXX-XXXX format
        public static string ValidatePhoneNumber()
        {
            Console.Write("What's your phone number? (XXX-XXX-XXXX) ");
            //input
            string userNumber = Console.ReadLine();
            //processing
            while (!Regex.IsMatch(userNumber, @"^[0-9]{3}[-]+[0-9]{3}[-]+[0-9]{4}$"))// @"^\d\d\d-\d\d\d-\d\d\d\d$"
            {
                Console.WriteLine("That's not the correct format, try again");
                userNumber = Console.ReadLine();
            }
            //output
            return userNumber;
            


        }
    }
}
