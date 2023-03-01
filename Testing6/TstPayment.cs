using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class TstPayment
    {
        [TestMethod]
        public void TestValidOrderId()
        {
            // Arrange
            string orderId = "12345678";

            // Act
            bool isValid = IsValidOrderId(orderId);

            // Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void TestInvalidOrderId()
        {
            // Arrange
            string orderId = "notanumber";

            // Act
            bool isValid = IsValidOrderId(orderId);

            // Assert
            Assert.IsFalse(isValid);
        }

        private bool IsValidOrderId(string orderId)
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