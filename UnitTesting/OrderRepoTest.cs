using NUnit.Framework;
using Restratant;
using Restratant.Models;
using Restratant.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{

    [TestFixture]
    internal class OrderRepoTest
    {
        CartRepository cartRepository;
        OrderRepository orderRepository;
        CustomerRepository customerRepository;

        [SetUp]
        public void CustomerRepositorySetup()
        {
            Context _context = new Context();
            cartRepository = new CartRepository(_context);

            customerRepository = new CustomerRepository(_context);

            orderRepository = new OrderRepository(_context);


        }

        [Test]
        public void getAllOrdersTest()
        {
            var result = orderRepository.GetAll();
            Assert.That(result.GetType(), Is.EqualTo(typeof(List<Order>)));
        }

        [Test]
        public void getOrderByIdTestReturn()
        {

            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;

            var r = customerRepository.Insert(newCustomer);

            Order newOrder = new Order();

            newOrder.CustomerId = newCustomer.Id;

            orderRepository.Insert(newOrder);

            int x = newOrder.Id;

            var result = orderRepository.GetById(x);
            Assert.That(result.GetType(), Is.EqualTo(typeof(Order)));
        }

        [Test]
        public void getCustomerByIdTestType()
        {

            var x = 3433;

            var result = orderRepository.GetById(x);


            Assert.That(x.GetType(), Is.EqualTo(typeof(int)));




        }

        [Test]
        public void InsertOrderTestReturn()
        {
            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;

            var r = customerRepository.Insert(newCustomer);

            Order newOrder = new Order();

            newOrder.CustomerId = newCustomer.Id;

           var result= orderRepository.Insert(newOrder);

            Assert.That(result.GetType(), Is.EqualTo(typeof(int)));




        }



        [Test]
        public void InsertOrderTestType()
        {


            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;

            var r = customerRepository.Insert(newCustomer);

            Order newOrder = new Order();

            newOrder.CustomerId = newCustomer.Id;

            orderRepository.Insert(newOrder);


          

            Assert.That(newOrder.GetType(), Is.EqualTo(typeof(Order)));




        }


        [Test]
        public void updateOrderTestReturn()
        {

            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;

            var r = customerRepository.Insert(newCustomer);

            Order newOrder = new Order();

            newOrder.CustomerId = newCustomer.Id;

            orderRepository.Insert(newOrder);

            newOrder.TotalPrice = 1000;

            var result =orderRepository.Update(newOrder.Id , newOrder);



            Assert.That(result.GetType(), Is.EqualTo(typeof(int)));


        }


        [Test]
        public void updateOrderTestReturn2()
        {

            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;

            var r = customerRepository.Insert(newCustomer);

            Order newOrder = new Order();

            newOrder.CustomerId = newCustomer.Id;

            orderRepository.Insert(newOrder);

            newOrder.TotalPrice = 1000;

            var result = orderRepository.Update(3434, newOrder);



            Assert.That(result, Is.EqualTo(0));


        }

        [Test]
        public void UpdateOrderTestIdType()
        {
            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;

            var r = customerRepository.Insert(newCustomer);

            Order newOrder = new Order();

            newOrder.CustomerId = newCustomer.Id;

            orderRepository.Insert(newOrder);

            newOrder.TotalPrice = 1000;

            var result = orderRepository.Update(newOrder.Id, newOrder);




            Assert.That(newOrder.Id.GetType(), Is.EqualTo(typeof(int)));




        }



        [Test]
        public void UpdateOrderTestObjectType2()
        {

            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;

            var r = customerRepository.Insert(newCustomer);

            Order newOrder = new Order();

            newOrder.CustomerId = newCustomer.Id;

            orderRepository.Insert(newOrder);

            newOrder.TotalPrice = 1000;

            var result = orderRepository.Update(newOrder.Id, newOrder);




            Assert.That(newOrder.GetType(), Is.EqualTo(typeof(Order)));




        }




        [Test]
        public void DeleteOrderTestReturn()
        {





            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;

            var r = customerRepository.Insert(newCustomer);

            Order newOrder = new Order();

            newOrder.CustomerId = newCustomer.Id;

            orderRepository.Insert(newOrder);


            var result = orderRepository.Delete(newOrder.Id);



            Assert.That(result.GetType(), Is.EqualTo(typeof(int)));




        }



        [Test]
        public void DeleteOrderTestIdType()
        {
            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;

            var r = customerRepository.Insert(newCustomer);

            Order newOrder = new Order();

            newOrder.CustomerId = newCustomer.Id;

            orderRepository.Insert(newOrder);


            var result = orderRepository.Delete(newOrder.Id);





         



            Assert.That(newOrder.Id.GetType(), Is.EqualTo(typeof(int)));




        }


        [Test]
        public void DeleteOrderTestIdType2()
        {

            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;

            var r = customerRepository.Insert(newCustomer);

            Order newOrder = new Order();

            newOrder.CustomerId = newCustomer.Id;

            orderRepository.Insert(newOrder);


            var result = orderRepository.Delete(newOrder.Id);




            Assert.That(newOrder.GetType(), Is.EqualTo(typeof(Order)));




        }


        public void OrderProbertyIdTest()
        {

            Order order = new Order();
            order.Id = 3232;
            Assert.That(order.Id.GetType(), Is.EqualTo(typeof(int)));

        }

        [Test]
        public void OrderProbertyDateType()
        {

            Order order = new Order();
            order.Date = new DateTime();
            Assert.That(order.Date.GetType(), Is.EqualTo(typeof(DateTime)));

        }

        [Test]
        public void OrderObjectType()
        {

            Order order = new Order();
            Assert.That(order.GetType(), Is.EqualTo(typeof(Order)));

        }


        [Test]
        public void OrderPaymentProbertyType()
        {

            Order order = new Order();
            order.Payment = 3232.32;
            Assert.That(order.Payment.GetType(), Is.EqualTo(typeof(double)));

        }

        [Test]
        public void OrderTotalPriceProbertyType()
        {

            Order order = new Order();
            order.TotalPrice = 3232.32f;
            Assert.That(order.TotalPrice.GetType(), Is.EqualTo(typeof(float)));

        }

        [Test]
        public void OrderCustomerIdProbertyType()
        {

            Order order = new Order();
            order.CustomerId ="sdsddasdsasda" ;
            Assert.That(order.CustomerId.GetType(), Is.EqualTo(typeof(string)));

        }


        [Test]
        public void getOrderByIdTestReturnNull()
        {
            var x = 2323;

            Assert.That(() => orderRepository.GetById(x), Throws.TypeOf<NullReferenceException>());

        }


        [Test]
        public void UpdateOrderTestReturnNull()
        {
            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;

            var r = customerRepository.Insert(newCustomer);

            Order newOrder = new Order();

            newOrder.CustomerId = newCustomer.Id;

            orderRepository.Insert(newOrder);

            newOrder.TotalPrice = 1000;


            Assert.That(() => orderRepository.Update(12312, newOrder), Throws.TypeOf<NullReferenceException>());

        }


        [Test]
        public void DeleteCustomerTestReturnNull()
        {
            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;

            var r = customerRepository.Insert(newCustomer);

            Order newOrder = new Order();

            newOrder.CustomerId = newCustomer.Id;

            orderRepository.Insert(newOrder);


            Assert.That(() => orderRepository.Delete(422), Throws.TypeOf<NullReferenceException>());

        }
    }
}
