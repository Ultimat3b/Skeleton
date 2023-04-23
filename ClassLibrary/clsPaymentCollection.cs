using System;
using System.Collections.Generic;

namespace ClassLibrary
{



    public class clsPaymentCollection
    {



        List<clsPayment> mPaymentList = new List<clsPayment>();
        public List<clsPayment> PaymentList
        {
            get
            {
                return mPaymentList;
            }

            set
            {
                mPaymentList = value;
            }
        }


        public int Count {
            get
            {
                return mPaymentList.Count;

            }
            set
            {

            }

        }

        public clsPayment ThisPayment { get; set; }

        public int Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }

    
    
        

    }