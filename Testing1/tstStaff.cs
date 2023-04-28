using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        string StaffFirstName = "Steve";
        string StaffSurname = "Gates";
        string StaffEmail = "SteveGates@gmail.com";
        string StaffPhoneNumber = "07313954875";
        string StaffStartDate = DateTime.Now.Date.ToString();
        string StaffSalary = "27000";
        string Active = "true";

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstnameMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffFirstName = "";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstnameMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffFirstName = "a";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstnameMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffFirstName = "aa";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstnameMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffFirstName = "aaaaaaaaaaaaaa";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstnameMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffFirstName = "aaaaaaaaaaaaaaa";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstnameMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffFirstName = "aaaaaaaa";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstnameMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffFirstName = "aaaaaaaaaaaaaaaa";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstnameExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(500, 'a');
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSurnameMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffSurname = "";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSurnameMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffSurname = "a";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSurnameMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffSurname = "aa";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSurnameMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffSurname = "aaaaaaaaaaaaaaaaaaa";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSurnameMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffSurname = "aaaaaaaaaaaaaaaaaaaa";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSurnameMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffSurname = "aaaaaaaaaaaaaaaaaaaaa";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSurnameMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffSurname = "aaaaaaaaaa";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSurnameExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffSurname = "";
            StaffSurname = StaffSurname.PadRight(500, 'a');
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNumberExtremeMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffPhoneNumber = "-1000000000";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNumberMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffPhoneNumber = "-1";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNumberMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffPhoneNumber = "0";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNumberMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffPhoneNumber = "1";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNumberMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffPhoneNumber = "2147483646";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNumberMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffPhoneNumber = "2147483647";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNumberMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffPhoneNumber = "2147483648";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNumberMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffPhoneNumber = "1073741824";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNumberInvalidData()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffPhoneNumber = "Not a number";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffEmail = "";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffEmail = "a";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffEmail = "aa";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(49, 'a');
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(50, 'a');
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(51, 'a');
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(25, 'a');
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(500, 'a');
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffStartDateExtremeMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string StaffStartDate = TestDate.ToString();
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffStartDateMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string StaffStartDate = TestDate.ToString();
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffStartDateMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string StaffStartDate = TestDate.ToString();
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffStartDateMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string StaffStartDate = TestDate.ToString();
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffStartDateExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string StaffStartDate = TestDate.ToString();
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffStartDateInvalid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffStartDate = "this is not a date!";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryExtremeMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffSalary = "-1000000";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffSalary = "-1";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffSalary = "0";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffSalary = "1";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffSalary = "999999";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffSalary = "1000000";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffSalary = "1000001";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffSalary = "500000";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffSalary = "500000000";
            Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary, Active);
            Assert.AreNotEqual(Error, "");
        }

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
            aStaff.StaffStartDate = TestData;
            Assert.AreEqual(aStaff.StaffStartDate, TestData);
        }

        [TestMethod]
        public void StaffFirstNameOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "Steve";
            aStaff.StaffFirstName = TestData;
            Assert.AreEqual(aStaff.StaffFirstName, TestData);
        }

        [TestMethod]
        public void StaffIdOK()
        {
            clsStaff aStaff = new clsStaff();
            Int32 TestData = 2;
            aStaff.StaffId = TestData;
            Assert.AreEqual(aStaff.StaffId, TestData);
        }

        [TestMethod]
        public void StaffSurnameOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "Gates";
            aStaff.StaffSurname = TestData;
            Assert.AreEqual(aStaff.StaffSurname, TestData);
        }

        [TestMethod]
        public void StaffPhoneNumberOK()
        {
            clsStaff aStaff = new clsStaff();
            // varchar(50) is just collectively a bunch of characters, because of the phone number size; we use this to store the phone number due to it being too small
            Int64 TestData = 07313954875;
            aStaff.StaffPhoneNumber = TestData;
            Assert.AreEqual(aStaff.StaffPhoneNumber, TestData);

        }

        [TestMethod]
        public void StaffEmailOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "SteveGates@gmail.com";
            aStaff.StaffEmail = TestData;
            Assert.AreEqual(aStaff.StaffEmail, TestData);
        }

        [TestMethod]
        public void StaffSalaryOK()
        {
            clsStaff aStaff = new clsStaff();
            float TestData = 27000;
            aStaff.StaffSalary = TestData;
            Assert.AreEqual(aStaff.StaffSalary, TestData);
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
            Int32 StaffId = 2;
            Found = aStaff.Find(StaffId);
            if (aStaff.StaffId != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 mStaffId = 2;
            Found = aStaff.Find(mStaffId);
            if (aStaff.StaffFirstName != "Steve")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 2;
            Found = aStaff.Find(StaffId);
            if (aStaff.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStartDateFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 2;
            Found = aStaff.Find(StaffId);
            if (aStaff.StaffStartDate != Convert.ToDateTime("27/04/2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSurnameFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 2;
            Found = aStaff.Find(StaffId);
            if (aStaff.StaffSurname != "Gates")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 2;
            Found = aStaff.Find(StaffId);
            if (aStaff.StaffEmail != "SteveGates@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSalaryFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 2;
            Found = aStaff.Find(StaffId);
            if (aStaff.StaffSalary != 27000)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 2;
            Found = aStaff.Find(StaffId);
            if (aStaff.StaffPhoneNumber != 07313954875)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}

