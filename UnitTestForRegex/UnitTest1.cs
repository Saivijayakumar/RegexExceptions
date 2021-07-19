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
        [TestCategory("First Name")]
        public void TestMethodforValidFirstName()
        {
            string expected = "Valid";
            string actual = RegexAllMethods.CheckFirstName("Sai");
            Assert.AreEqual(expected, actual);

        }
        // Test for invalid first name
        [TestMethod]
        [TestCategory("First Name")]
        public void TestMethodforInValidFirstName()
        {
            string expected = "Invalid";
            string actual = RegexAllMethods.CheckFirstName("S");
            Assert.AreEqual(expected, actual);

        }
        //Testing for empty Name
        [TestMethod]
        [TestCategory("First Name")]
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
        [TestCategory("Last Name")]
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
        [TestCategory("Last Name")]
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
        //test for invalid email
        [TestMethod]
        [TestCategory("Email")]
        public void TestForInvalidEmail()
        {
            try
            {
                RegexAllMethods.MailVerification("abc@%*.com");
            }
            catch (RegexCustomException ex)
            {
                string expected = "Email is invalid";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //Test for valid email
        [TestMethod]
        [TestCategory("Email")]
        public void TestForValidEmail()
        {
            string actual = RegexAllMethods.MailVerification("abc@gmail.com");
            string expected = "Valid";
            Assert.AreEqual(actual, expected);

        }
        //Test for valid Phone Number
        [TestMethod]
        [TestCategory("PhoneNumber")]
        public void TestForValidPhoneNumber()
        {
            string actual = RegexAllMethods.PhoneNumberValidation("91 9866201443");
            string expected = "Valid";
            Assert.AreEqual(actual, expected);

        }
        //Checking with Null
        [TestMethod]
        [TestCategory("PhoneNumber")]
        public void TestForPhoneNumber()
        {
            try
            {
                RegexAllMethods.PhoneNumberValidation(null);
            }
            catch (RegexCustomException ex)
            {
                string expected = "Null";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //Test for valid password
        [TestMethod]
        [TestCategory("Password")]
        public void TestMethodValidPassword()
        {
            try
            {
                RegexAllMethods.Password("awsvWf&2");
            }
            catch (RegexCustomException ex)
            {
                string expected = "Valid";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //Test for invalid password
        [TestMethod]
        [TestCategory("Password")]
        public void TestMethodInvalidPassword()
        {
            try
            {
                RegexAllMethods.Password("awsvWf&2#");
            }
            catch (RegexCustomException ex)
            {
                string expected = "Invalid Password";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //Test for object creation for RegexAllMethods class by using Default Constructor
        [TestMethod]
        [TestCategory("Reflection")]
        public void TestCreateObjectWithDefaultConstructor()
        {
            object expected = new RegexAllMethods();
            object actual = ReflectionFactory.CreateingObjectForDefaultConstructor("UsingExceptionsInRegex.RegexAllMethods", "RegexAllMethods");
            expected.Equals(actual);
        }
        //Test for object creation for RegexAllMethods class by using Parameterized Constructor
        [TestMethod]
        [TestCategory("Reflection")]
        public void TestCreateObjectWithParameterConstructor()
        {
            object expected = new RegexAllMethods("Parameter Constructor");
            object actual = ReflectionFactory.CreateingObjectForParameterizedConstructor("UsingExceptionsInRegex.RegexAllMethods", "RegexAllMethods", "Parameter Constructor");
            actual.Equals(expected);
        }
    }
}
