using System;
//v00egd00001l.lec-admin.dmu.ac.uk
namespace ClassLibrary
{
    public class clsCustomer

    {
        public int CustomerId { get; set; }

        public string CustomerFirstName { get; set; }

        public string CustomerSurname { get; set; }

        public float CustomerPhoneNumber { get; set; }

        public string CustomerEmail { get; set; }

        public DateTime DateAdded { get; set; }

        public bool ReturnCustomer { get; set; }

        public string Valid(string strngTest)
        {
            if (strngTest.Length < 1)
            {
                return "Either CustomerFirstName or CustomerSurname is blank";
            }
            if (strngTest.Length > 50)
            {
                return "CustomerFirstName and CustomerSurname cannot be longer than 50";
            }
            else
            {
                return "";
            }
        }
    }
}