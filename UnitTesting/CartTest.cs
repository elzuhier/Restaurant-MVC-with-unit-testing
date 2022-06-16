using NUnit.Framework;
using Restratant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestFixture]
    internal class CartTest
    {
        Cart cart;

        [SetUp]
        public void CartSetUp()
        {
            cart = new Cart();

        }
        [Test]
        public void HasCounter()
        {
            
            Assert.That(cart, Has.Property("Counter"));

        }
        [Test]
        public void HasCustomerId()
        {
            Assert.That(cart, Has.Property("CustomerId"));

        }
        [Test]
        public void HasCustomer()
        {
            
            Assert.That(cart, Has.Property("Customer"));

        }
        [Test]
        public void HasMeals()
        {
            
            Assert.That(cart, Has.Property("Meals"));

        }
        [Test]
        public void HasCartItem()
        {
            
            Assert.That(cart, Has.Property("CartItem"));

        }
        [Test]
        public void HasId()
        {
            
            Assert.That(cart, Has.Property("Id"));

        }
    }
}
