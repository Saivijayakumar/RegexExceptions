using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingExceptionsInRegex
{
    //Custom Exceptions
    public class RegexCustomException : Exception
    {
        //enum declaration
        ExceptionType exceptiontype;
        public enum ExceptionType
        {
            EMPTY_MESSAGE, NULL_MESSAGE, INVALID_EMAIL, INVALID_PASSWORD, NO_SUCH_CLASS, NO_CONSTRUCTOR_FOUND, NO_METHOD_FOUND, INVALID_PHONE, INVALID_NAME
        }
        
        //constructor for Regex custom exception class
        public RegexCustomException(ExceptionType exception, string message) : base(message)
        {
            this.exceptiontype = exception;
        }
    }
}
