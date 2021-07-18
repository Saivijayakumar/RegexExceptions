using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UsingExceptionsInRegex
{
    public class RegexAllMethods
    {
        string message;
        //Default Constructor
        public RegexAllMethods()
        {

        }
        //Parameterized Constructor
        public RegexAllMethods(string message)
        {
            this.message = message;
        }
        //checking first name valid or not 
        public static string CheckFirstName(string firstName)
        {
            string result = "Valid";
            Regex regex = new Regex(@"^[A-Z]{1}[a-z]{2,}");
            Match match = regex.Match(firstName);
            if (match.Success)
            {
                Console.WriteLine(firstName + " ------>Valid");
            }
            else
            {
                Console.WriteLine(firstName + " ------>Invalid");
                result = "Invalid";
            }
            return result;
        }
    }
}
