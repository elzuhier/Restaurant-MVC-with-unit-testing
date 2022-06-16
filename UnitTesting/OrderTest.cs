using NUnit.Framework;
using Restratant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{

    public class OrderTest
    {
        [Test]
        public void Test_Has_TotalPrice_Property()
        {
            Order ordr = new Order();

            Assert.That(ordr, Has.Property("TotalPrice"));
        }
        [Test]
        public void Test_Has_Date_Property()
        {
            Order ordr = new Order();

            Assert.That(ordr, Has.Property("Date"));
        }
        [Test]
        public void Test_Has_Payment_Property()
        {
            Order ordr = new Order();

            Assert.That(ordr, Has.Property("Payment"));
        }
        [Test]
        public void Test_Has_CustomerId_Property()
        {
            Order ordr = new Order();

            Assert.That(ordr, Has.Property("CustomerId"));
        }
        [Test]
        public void Test_Has_Id_Property()
        {
            Order ordr = new Order();

            Assert.That(ordr, Has.Property("Id"));
        }
    }
}
