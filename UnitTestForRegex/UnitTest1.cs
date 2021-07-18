using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UsingExceptionsInRegex;

namespace UnitTestForRegex
{
    [TestClass]
    public class UnitTest1
    {
        //Test for valid first name
        [TestMethod]
        public void TestMethodforValidFirstName()
        {
            string expected = "Valid";
            string actual = RegexAllMethods.CheckFirstName("Ram");
            Assert.AreEqual(expected, actual);

        }
        // Test for invalid first name
        [TestMethod]
        public void TestMethodforInValidFirstName()
        {
            string expected = "Invalid";
            string actual = RegexAllMethods.CheckFirstName("Ra");
            Assert.AreEqual(expected, actual);

        }
    }
}
