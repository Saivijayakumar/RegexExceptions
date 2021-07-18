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
        //checking Last name valid or not
        public static string CheckLastName(string lastName)
        {
            string result = "Valid";
            Regex regex = new Regex(@"^[A-Z]{1}[a-z]{2,}");
            if (lastName != "")
            {
                Match match = regex.Match(lastName);
                if (match.Success)
                {
                    Console.WriteLine(lastName + " ----->Valid");
                }
                else
                {
                    Console.WriteLine(lastName + " ----->Invalid");
                    result = "Invalid";
                }
                if (result == "Invalid")
                    throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_NAME, "Invalid Last Name");
                else
                    return result;
            }
            else
            {
                throw new RegexCustomException(RegexCustomException.ExceptionType.EMPTY_MESSAGE, "Empty Last Name");
            }
        }
        //checks for valid email
        public static string MailVerification(string email)
        {
            string result = "Valid";
            Regex regex = new Regex(@"^abc([+. \-_]{1}\w+)?@[a-z0-9]+\.[a-z]{2,3}(\.[a-z]{2,3})?$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                Console.WriteLine(email + " ----->Valid");
            }
            else
            {
                Console.WriteLine(email + " ----->Invalid");
                result = "Invalid";
            }
            if (result == "Invalid")
            {
                throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_EMAIL, "Email is invalid");
            }
            else
            {
                return result;
            }
        }
        //Validating for phonenumber
        public static string PhoneNumberValidation(string number)
        {
            string result = "Valid";
            string pattern = @"^[1-9]{2}[ ][0-9]{10}$";
            Regex regex = new Regex(pattern);
            if (number != null)
            {
                Match match = regex.Match(number);
                if (match.Success)
                {
                    Console.WriteLine(number + " ------>Valid");
                    result = "Valid";
                }
                else
                {
                    Console.WriteLine(number + " ------>Invalid");
                    result = "Invalid";
                }
                if (result == "Invalid")
                    throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_PHONE, "Invalid PhoneNumber");
                else
                    return result;
            }
            else
            {
                throw new RegexCustomException(RegexCustomException.ExceptionType.NULL_MESSAGE, "Null");
            }
        }
        //Checks for Valid Password
        public static string Password(string password)
        {
            string result = "Valid";
            string pattern = @"^[a-z]*[A-Z][a-z]*.[a-z]*[0-9][a-z]*$";
            Regex regex = new Regex(pattern);

            Match match = regex.Match(password);
            if (match.Success)
            {
                Console.WriteLine(password + " ----->Valid");
                result = "Valid";
            }
            else
            {
                Console.WriteLine(password + " ----->Invalid");
                result = "Invalid";
            }

            if (result == "Invalid")
                throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
            else
            {
                return result;
            }
        }
    }
}
