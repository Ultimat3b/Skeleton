using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing6
{
    public class OrderIdValidator
    {
        public bool IsValidOrderId(string orderId)
        {
            // Check if the order ID is in the correct format
            if (orderId.Length != 8)
            {
                return false;
            }

            // Check if the order ID consists of only digits
            foreach (char c in orderId)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }

            // Add any additional requirements for the order ID here
            // ...

            // If all checks pass, the order ID is valid
            return true;
        }
    }

}
