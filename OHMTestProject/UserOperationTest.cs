using DataAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EntityLayers;

namespace OHMTestProject
{
    
    
    /// <summary>
    ///This is a test class for UserOperationTest and is intended
    ///to contain all UserOperationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UserOperationTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Registraion
        ///</summary>
        [TestMethod()]
        public void RegistraionTest()
        {
            UserOperation target = new UserOperation(); // TODO: Initialize to an appropriate value
            Customer obj = new Customer()
            {
                _cname = "abc",
                _cUserID = "SU1292",
                _cityID = 101,
                _countryID = 1,
                _stateID = 5001,
                _street = "church",
                _house = "#12",
                _ph = "1234567890",

                _eMail = "abc@g.sa"

            };
            Credentials creObj = new Credentials()
            {
                _userPswd= "abds",
                //_userType = "A"

            };


            // Customer _reg = null; // TODO: Initialize to an appropriate value

         
           // Credentials _cre = null; // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Registraion(obj, creObj);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
