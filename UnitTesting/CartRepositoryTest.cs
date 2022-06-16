using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restratant.Repository;
using Restratant.Interfaces;
using Restratant.Models;
using Restratant;

namespace UnitTesting
{
    [TestFixture]
    internal class CartRepositoryTest
    {
        CartRepository cartRepository;
        OrderRepository orderRepository;
        CustomerRepository customerRepository;


        [SetUp]
        public void CartRepositorySetup()
        {
            Context _context = new Context();

            cartRepository = new CartRepository(_context);
            customerRepository = new CustomerRepository(_context);

            orderRepository = new OrderRepository(_context);

        }
        [Test]
        public void getAllReturnedTypeIsListTest()
        {
            var result = cartRepository.GetAll();
            Assert.That(result.GetType(), Is.EqualTo(typeof(List<Cart>)));
        }
        [Test]
        public void getByIdTest()
        {
            
            var result = cartRepository.GetById(9);
            Assert.That(result.GetType(), Is.EqualTo(typeof(Cart)));

        }
        [Test]
        public void InsertTest()
        {
            Cart cart = new Cart();
            var result = cartRepository.Insert(cart);

            Customer customer = new Customer();
            customer.CartId = cart.Id;

            
            var cust = customerRepository.Insert(customer);
            cart.CustomerId = customer.Id;


            Assert.That(result.GetType(), Is.EqualTo(typeof(int)));
        }
        [Test]
        public void InsertCartItemTest()
        {
            Cart cart = new Cart();
            cartRepository.Insert(cart);
            CartItem cartItem = new CartItem();
            cartItem.CartId = cart.Id;
            var result = cartRepository.InsertCartItem(cartItem);
            Assert.That(result.GetType(), Is.EqualTo(typeof(int)));

        }
        [Test]
        public void UpdateTest()
        {
            Cart newCart = new Cart();

            var result = cartRepository.Update(1, newCart);
            Assert.That(result, Is.EqualTo(0));

        }
        [Test]
        public void DeleteTest()
        {

            //Cart cart = new Cart();
            //cart.Id = 1;
            customerRepository.Delete("0daf61fe-9469-4a32-b227-e13110d20737");
            var result = cartRepository.Delete(1);
            Assert.That(result.GetType(), Is.EqualTo(typeof(int)));


        }
        [Test]
        public void getCartByItemIdTest()
        {
            var result = cartRepository.GetCartItemById(1);
            Assert.That(result.GetType(), Is.EqualTo(typeof(CartItem)));
        }
        [Test]
        public void UpdateCartItemTest()
        {
            var result = cartRepository.UpdateCartItem(1, 5);
            Assert.That(result.GetType(), Is.EqualTo(typeof(int)));
        }
        [Test]
        public void DeleteCartItemTest()
        {
            var result = cartRepository.DeleteCartItem(2);
            Assert.That(result.GetType(), Is.EqualTo(typeof(int)));
        }
        [Test]
        public void GetByIdNull()
        {
            Assert.That(() => cartRepository.GetById(4354), Throws.TypeOf<NullReferenceException>());

        }
        [Test]
        public void GetByCustomerByIdNull()
        {
            Assert.That(() => cartRepository.GetByCustomerId(4354), Throws.TypeOf<NullReferenceException>());

        }
        [Test]

        public void UpdateNull()
        {
            Assert.That(() => cartRepository.Update(4354, new Cart()), Throws.TypeOf<NullReferenceException>());

        }
        [Test]
        public void DeleteNull()
        {
            Assert.That(() => cartRepository.Delete(4354), Throws.TypeOf<NullReferenceException>());

        }
        [Test]

        public void GetCartByIdNull()
        {
            Assert.That(() => cartRepository.GetCartItemById(4354), Throws.TypeOf<NullReferenceException>());

        }
        [Test]
        public void UpdateCartItemNull()
        {
            Assert.That(() => cartRepository.UpdateCartItem(4354, 5), Throws.TypeOf<NullReferenceException>());

        }
        [Test]
        public void DeleteCartItem()
        {
            Assert.That(() => cartRepository.DeleteCartItem(4354), Throws.TypeOf<NullReferenceException>());

        }

    }
}
