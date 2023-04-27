using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of customer objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an customer object to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerId = 10;
            TestItem.CustomerFirstName = "Jamie";
            TestItem.CustomerSurname = "Mupenyu";
            TestItem.CustomerEmail = "j.mupe@gmail.com";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ReturnCustomer = true;
            //add the itme to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);

        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestCustomer = new clsCustomer();
            //set its properties
            TestCustomer.CustomerId = 10;
            TestCustomer.CustomerFirstName = "Jamie";
            TestCustomer.CustomerSurname = "Mupenyu";
            TestCustomer.CustomerEmail = "j.mupe@gmail.com";
            TestCustomer.DateAdded = DateTime.Now.Date;
            TestCustomer.ReturnCustomer = true;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);

        }

        /*•	The AddressList will provide us with an indexed list of Addresses from the database table.
          •	The Count property will always tell us how many addresses there are in this list.
        */

        [TestMethod]
        public void ListandCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of customer objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an customer object to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerId = 10;
            TestItem.CustomerFirstName = "Jamie";
            TestItem.CustomerSurname = "Mupenyu";
            TestItem.CustomerEmail = "j.mupe@gmail.com";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ReturnCustomer = true;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            //if all is working well then both lists should report a count of 1
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }

        //TESTING THE ADD, DELETE, UPDATE AND INSERT METHODS
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property 
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerId = 9;
            TestItem.CustomerFirstName = "Jamie";
            TestItem.CustomerSurname = "Mupenyu";
            TestItem.CustomerEmail = "j.mupe@gmail.com";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ReturnCustomer = true;
            //set this address to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property 
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerFirstName = "Jamie";
            TestItem.CustomerSurname = "Mupenyu";
            TestItem.CustomerEmail = "j.mupe@gmail.com";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ReturnCustomer = true;
            //set this address to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //modify the test data
            TestItem.CustomerFirstName = "James";
            TestItem.CustomerSurname = "Mupenyu";
            TestItem.CustomerEmail = "jay.mupe@gmail.com";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ReturnCustomer = false;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property 
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerFirstName = "Jamie";
            TestItem.CustomerSurname = "Mupenyu";
            TestItem.CustomerEmail = "j.mupe@gmail.com";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ReturnCustomer = true;
            //set this address to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void ReportBySurnameOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an intsance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.ReportBySurname("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportBySurnameNoneFound()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a Surname that doesn't exist
            FilteredCustomers.ReportBySurname("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);

        }

        [TestMethod]
        public void ReportBySurnameTestDataFound()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a Customer surname that doesn't exist
            FilteredCustomers.ReportBySurname("zzzz");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {

                //check that the first record is id 27 and check that the second record is id 28
                if (FilteredCustomers.CustomerList[0].CustomerId != 27 && FilteredCustomers.CustomerList[1].CustomerId != 28)
                {
                    OK = false;
                }
                 /*
                //check that the second record is id 28
                if (FilteredCustomers.CustomerList[1].CustomerId != 28)
                {
                    OK = false;
                }*/
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);


        }

    }
}
