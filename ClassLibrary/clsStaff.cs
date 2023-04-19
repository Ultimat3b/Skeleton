using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaff_Id;
        public Int32 Staff_Id
        {
            get
            {
                return Staff_Id;
            }
            set
            {
                mStaff_Id = value;
            }
        }
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public string Staff_FirstName { get; set; }
        public object Staff_Firstname { get; set; }
        public string Staff_Surname { get; set; }
        public string Staff_PhoneNumber { get; set; }
        public float Staff_email { get; set; }
        public string Staff_Email { get; set; }
        public float Staff_Salary { get; set; }
        public DateTime Staff_StartDate { get; set; }

        public bool Find(int staff_Id)
        {
            return true;
        }
    }
}