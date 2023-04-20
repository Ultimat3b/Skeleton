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

    }
}
