using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass the method
        private string strngTest = "Charliechaplin";
        string CustomerFirstName = "Charlie";
        string CustomerSurname = "Jones";
        string CustomerEmail = "charles.C@gmail.com";
        string DateAdded = DateTime.Now.Date.ToString();


        [TestMethod]
        public void InstanceOK()
        //this method is to test if we can make an instance of class Customer
        //ie a customer object
        {
            clsCustomer aCustomer = new clsCustomer();
            Assert.IsNotNull(aCustomer);
        }

        [TestMethod]
        public void CustomerIdOK()

        {
            clsCustomer aCustomer = new clsCustomer();
            Int32 TestData = 1;
            aCustomer.CustomerId = TestData;
            Assert.AreEqual(aCustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void CustomerFirstNameOK()

        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = strngTest;
            aCustomer.CustomerFirstName = TestData;
            Assert.AreEqual(aCustomer.CustomerFirstName, TestData);
        }

        [TestMethod]
        public void CustomerSurnameOK()

        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = strngTest;
            aCustomer.CustomerSurname = TestData;
            Assert.AreEqual(aCustomer.CustomerSurname, TestData);
        }

        [TestMethod]
        public void CustomerEmailOK()

        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = strngTest;
            aCustomer.CustomerEmail = TestData;
            Assert.AreEqual(aCustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void DateAddedOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the Customer
            DateTime TestData = DateTime.Now.Date;
            //assihm the data to the Customer
            aCustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void ReturnCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the Customer
            bool TestData = true;
            //assign the data to the Customer
            aCustomer.ReturnCustomer = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.ReturnCustomer, TestData);
        }


        //creating tests for the necessary methods
        //FIND METHOD

        [TestMethod]
        public void FindMethodOK() //needs testing
        {
            //create a customer object
            clsCustomer aCustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean found = false;
            //create some test data to use with the method
            int CustomerID = 6;
            //invoke the method
            found = aCustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestCustomerIDFound() //needs to be tested
        {
            /*this test finds record number 2 and checks to see if the
            Customer ID property is also set to 2*/

            //create a customer object
            clsCustomer aCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean found = false;
            //bool variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerId = 10;
            //invoke the method
            found = aCustomer.Find(CustomerId);
            //check the Customer Id
            if (aCustomer.CustomerId != 10) //checks if record 2 == customer id property or value in this place is also 2
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /*these following tests check if the properties belonging to record number 21 are present for the object aCustomer*/

        [TestMethod]
        public void TestCustomerFirstNameFound() //needs to be tested
        {
            //create a customer object
            clsCustomer aCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean found = false;
            //bool variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerId = 10;
            //invoke the method
            found = aCustomer.Find(CustomerId);
            //check the property
            if (aCustomer.CustomerFirstName != "Jamie")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerSurnameFound() //needs to be tested
        {
            //create a customer object
            clsCustomer aCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean found = false;
            //bool variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerId = 10;
            //invoke the method
            found = aCustomer.Find(CustomerId);
            //check the property
            if (aCustomer.CustomerSurname != "Mupenyu")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound() //needs to be tested
        {
            //create a customer object
            clsCustomer aCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean found = false;
            //bool variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerId = 10;
            //invoke the method
            found = aCustomer.Find(CustomerId);
            //check the property
            if (aCustomer.CustomerEmail != "j.mupe@gmail.com") //checks at record 21 to see if customer email property is "t.shoniwa@gmail.com"
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound() //needs to be tested
        {
            //create a customer object
            clsCustomer aCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean found = false;
            //bool variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerId = 10;
            //invoke the method
            found = aCustomer.Find(CustomerId);
            //check the property
            if (aCustomer.DateAdded != Convert.ToDateTime("21/04/2023"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReturnCustomerFound() //needs to be tested
        {
            //create a customer object
            clsCustomer aCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean found = false;
            //bool variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerId = 10;
            //invoke the method
            found = aCustomer.Find(CustomerId);
            //check the property that correlates to the specified customer Id
            if (aCustomer.ReturnCustomer != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        // TESTING VALIDATION METHOD

        [TestMethod]

        public void ValidMethodOK() //needs to be tested
        {
            //create a customer object
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            Assert.AreEqual(Error, "");
        }

        //Validating and Testing Customer First name

        [TestMethod]
        public void CustomerFirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerFirstName = ""; //this should trigger an error
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerFirstName = "a"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //saying there won't be an error message for this
            //only use arenotequal if there will be an error message
        }

        [TestMethod]
        public void CustomerFirstNameMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerFirstName = "aa"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerFirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerFirstNameMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerFirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerFirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerFirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(500, 'a'); //this should trigger an error
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Validating and Testing Customer Surname

        [TestMethod]
        public void CustomerSurnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerSurname = ""; //this should trigger an error
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMin()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerSurname = "a"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //saying there won't be an error message for this
            //only use arenotequal if there will be an error message
        }

        [TestMethod]
        public void CustomerSurnameMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerSurname = "aa"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMaxLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerSurname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerSurnameMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerSurname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerSurname = "aaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerSurname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerSurname = "";
            CustomerSurname = CustomerSurname.PadRight(500, 'a'); //this should trigger an error
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Validating and Testing Customer Email

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerEmail = ""; //this should trigger an error
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerEmail = "a"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //saying there won't be an error message for this
            //only use arenotequal if there will be an error message
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerEmail = "aa"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa@gmail.com"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa@gmail.com"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerEmail = "aaaaaaaaaaaaaaaaa@gmail.com"; //this should be ok
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa@gmail.com"; //this should trigger an error
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //about to override the parameter we declared in our test data section
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(500, 'a'); //this should trigger an error
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //testing the Date added property
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years;
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable which is passed to the validation method
            string DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day;
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable which is passed to the validation method
            string DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable which is passed to the validation method
            string DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //there should not be an error for this one
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day;
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable which is passed to the validation method
            string DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years;
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable which is passed to the validation method
            string DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string DateAdded = "this is not a date";
            //invoke the method
            Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
            // test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}

