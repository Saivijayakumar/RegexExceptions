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
            string actual = RegexAllMethods.CheckFirstName("Sai");
            Assert.AreEqual(expected, actual);

        }
        // Test for invalid first name
        [TestMethod]
        public void TestMethodforInValidFirstName()
        {
            string expected = "Invalid";
            string actual = RegexAllMethods.CheckFirstName("S");
            Assert.AreEqual(expected, actual);

        }
        //Test for empty name
        [TestMethod]
        public void TestMethodforEmptyName()
        {
            try
            {
                RegexAllMethods.CheckLastName("");
            }
            catch (RegexCustomException ex)
            {
                string expected = "Empty Last Name";
                Assert.AreEqual(expected, ex.Message);
            }

        }
        //Test for Valid last name
        [TestMethod]
        public void TestMethodforLastName()
        {
            try
            {
                RegexAllMethods.CheckLastName("Kumar");
            }
            catch (RegexCustomException ex)
            {
                string expected = "Valid";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //test for invalid last name
        [TestMethod]
        public void TestMethodforInvalidLastName()
        {
            try
            {
                RegexAllMethods.CheckLastName("kum");
            }
            catch (RegexCustomException ex)
            {
                string expected = "Invalid Last Name";
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
