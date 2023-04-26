using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStaff aStaff = new clsStaff();
            Assert.IsNotNull(aStaff);
        }

        [TestMethod]
        public void ActivePropertOK()
        {
            clsStaff aStaff = new clsStaff();
            Boolean TestData = true;
            aStaff.Active = TestData;
            Assert.AreEqual(aStaff.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            aStaff.StaffStartTime = TestData;
            Assert.AreEqual(aStaff.mStaffStartDate, TestData);
        }

        [TestMethod]
        public void StaffFirstNameOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "Steve";
            aStaff.Staff_FirstName = TestData;
            Assert.AreEqual(aStaff.mStaffFirstName, TestData);
        }

        [TestMethod]
        public void StaffIdOK()
        {
            clsStaff aStaff = new clsStaff();
            Int32 TestData = 2;
            aStaff.Staff_Id = TestData;
            Assert.AreEqual(aStaff.Staff_Id, TestData);
        }

        [TestMethod]
        public void StaffSurnameOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "gates";
            aStaff.Staff_Surname = TestData;
            Assert.AreEqual(aStaff.Staff_Surname, TestData);
        }

        [TestMethod]
        public void StaffPhoneNumberOK()
        {
            clsStaff aStaff = new clsStaff();
            // varchar(50) is just collectively a bunch of characters, because of the phone number size; we use this to store the phone number due to it being too small
            String TestData = "07313954875";
            aStaff.Staff_PhoneNumber = TestData;
            Assert.AreEqual(aStaff.Staff_PhoneNumber, TestData);

        }

        [TestMethod]
        public void StaffEmailOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "SteveGates@gmail.com";
            aStaff.Staff_Email = TestData;
            Assert.AreEqual(aStaff.Staff_email, TestData);
        }

        [TestMethod]
        public void StaffSalary()
        {
            clsStaff aStaff = new clsStaff();
            float TestData = 27000;
            aStaff.Staff_Salary = TestData;
            Assert.AreEqual(aStaff.Staff_email, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Int32 Staff_Id = 2;
            Found = aStaff.Find(Staff_Id);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Staff_Id = 2;
            Found = aStaff.Find(Staff_Id);
            if (aStaff.Staff_Id != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstName()
        {
            clsStaff aStaff = new csStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 mStaffId = 2;
            Found = aStaff.Find(mStaffId);
            if (aStaff.mStaffFirstName != "Steve")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}

