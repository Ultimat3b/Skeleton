using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffId;
        private bool mActive;
        private DateTime mDateAdded;
        private string mStaffFirstName;
        private string mStaffSurname;
        private Int64 mStaffPhoneNumber;
        private string mStaffEmail;
        private float mStaffSalary;
        private DateTime mStaffStartDate;
        public Int32 StaffId
        {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }
        }
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public string StaffFirstName
        {
            get
            {
                return mStaffFirstName;
            }
            set
            {
                mStaffFirstName = value;
            }
        }
        public string StaffSurname
        {
            get
            {
                return mStaffSurname;
            }
            set
            {
                mStaffSurname = value;
            }
        }
        public long StaffPhoneNumber
        {
            get
            {
                return mStaffPhoneNumber;
            }
            set
            {
                mStaffPhoneNumber = value;
            }
        }
        public string StaffEmail
        {
            get
            {
                return mStaffEmail;
            }
            set
            {
                mStaffEmail = value;
            }
        }
        public float StaffSalary
        {
            get
            {
                return mStaffSalary;
            }
            set
            {
                mStaffSalary = value;
            }
        }
        public DateTime StaffStartDate
        {
            get
            {
                return mStaffStartDate;
            }
            set
            {
                mStaffStartDate = value;
            }
        }
        public bool Find(int StaffId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", StaffId);
            DB.Execute("sproc_tblStaff_FilterByStaffId");

            if (DB.Count == 1)
            {
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["staff_Id"]);
                mStaffFirstName = Convert.ToString(DB.DataTable.Rows[0]["Staff_FirstName"]);
                mStaffSurname = Convert.ToString(DB.DataTable.Rows[0]["Staff_Surname"]);
                mStaffPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[0]["Staff_PhoneNumber"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["Staff_Email"]);
                mStaffStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Staff_StartDate"]);
                mStaffSalary = (float)Convert.ToDouble(DB.DataTable.Rows[0]["Staff_Salary"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Staff_Active"]);
    

            return true;
            }

            else
            {
                return false;
            }
        }

        public string Valid(string StaffFirstName, string StaffSurname, string StaffPhoneNumber, string StaffEmail, string StaffStartDate, string StaffSalary, string Active)
        {
            String Error = "";
            DateTime DateTemp;
            float SalaryTemp;
            Int32 PhoneNumberTemp;

            if (StaffFirstName.Length == 0)
            {
                Error = Error + "The Staff First name may not be blank : ";
            }

            if (StaffFirstName.Length > 15)
            {
                Error = Error + "The staff first name must be less than 16 characters";
            }

            if (StaffSurname.Length == 0)
            {
                Error = Error + "The Staff Surname may not be blank : ";
            }

            if (StaffSurname.Length > 20)
            {
                Error = Error + "The staff Surname must be less than 16 characters";
            }

            if (StaffEmail.Length == 0)
            {
                Error = Error + "The Staff Email may not be blank : ";
            }

            if (StaffEmail.Length > 50)
            {
                Error = Error + "The staff Email must be less than 16 characters";
            }

            try
            {
                DateTemp = Convert.ToDateTime(StaffStartDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "the date cannot be in the future";
                }
            }
            catch
            {
                Error = Error + "The date is not valid date : ";
            }

            try
            {
                SalaryTemp = (float)Convert.ToDouble(StaffSalary);
                if (SalaryTemp < 0)
                {
                    Error = Error + "The salary can't be negative : ";
                }
                if (SalaryTemp > 1000000)
                {
                    Error = Error + "The salary must be below 1000000 : ";
                }
            }
            catch
            {
                Error = Error + "The salary was not a valid number";
            }

            try
            {
                PhoneNumberTemp = Convert.ToInt32(StaffPhoneNumber);
                if (PhoneNumberTemp < 0)
                {
                    Error = Error + "The phone number must be atleast 0 : ";
                }
            }
            catch (OverflowException)
            {
                Error = Error + "this number is too high : ";
            }
            catch (FormatException)
            {
                Error = Error + "The phone number was invalid : ";
            }

            return Error;
        }
    }
}