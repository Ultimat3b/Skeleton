using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffId;
        private bool mActive;
        private DateTime mDateAdded;
        private string mStaffFirstName;
        private string mStaffSurname;
        private string mStaffPhoneNumber;
        private string mStaffEmail;
        private float mStaffSalary;
        private DateTime mStaffStartTime;
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
        public string StaffFirstname
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
        public string StaffPhoneNumber
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
                return StaffStartDate;
            }
            set
            {
                StaffStartDate = value;
            }
        }
        public bool Find(int staff_Id)
        {
            mStaffId = 2;
            mStaffFirstName = "Steve";
            mStaffSurname = "Gates";
            mStaffPhoneNumber = "07313954875";
            mStaffEmail = "SteveGates@gmail.com";
            mDateAdded = Convert.ToDateTime("27/04/2023");
            mStaffSalary = 27000;
            mActive = true;

            return true;
        }
    }
}