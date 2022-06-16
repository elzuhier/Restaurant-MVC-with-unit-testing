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
    internal class CustomerRepoTest
    {

        CartRepository cartRepository;
        CustomerRepository customerRepository;


        [SetUp]
        public void CustomerRepositorySetup()
        {
            Context _context = new Context();

            customerRepository = new CustomerRepository(_context);

            cartRepository = new CartRepository(_context);



        }

        [Test]
        public void getAllCustomersTest()
        {
            var result = customerRepository.GetAll();
            Assert.That(result.GetType(), Is.EqualTo(typeof(List<Customer>)));
        }

        [Test]
        public void getCustomerByIdTestReturn()
        {
            var x = "4a8f91bd-1a03-4d32-ade6-c58788153143";
            var result = customerRepository.GetById(x);
            Assert.That(result.GetType(), Is.EqualTo(typeof(Customer)));
        }

        [Test]
        public void getCustomerByIdTestReturnNull()
        {
            var x = "4a8f91bd";

            Assert.That(() => customerRepository.GetById(x), Throws.TypeOf<NullReferenceException>());

        }



 

        [Test]
        public void getCustomerByIdTestType()
        {

            var x = "4a8f91bd-1a03-4d32-ade6-c58788153143";

            var result = customerRepository.GetById(x);


            Assert.That(x.GetType(), Is.EqualTo(typeof(string)));




        }

        [Test]
        public void InsertCustomerTestReturn()
        {
            Cart newCart = new Cart();

            cartRepository.Insert(newCart);

            


            Customer newCustomer = new Customer();

            newCustomer.Address = "assuuit";

            newCustomer.CartId = newCart.Id;
            


            var result = customerRepository.Insert(newCustomer);


            Assert.That(result.GetType(), Is.EqualTo(typeof(int)));




        }



        [Test]
        public void InsertCustomerTestType()
        {


            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;




            var result = customerRepository.Insert(newCustomer);


            Assert.That(newCustomer.GetType(), Is.EqualTo(typeof(Customer)));




        }


       [Test]
       public void updateCustomerTestReturn()
        {

            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;




            var r = customerRepository.Insert(newCustomer);

            newCustomer.Address = "safaga";


            var result = customerRepository.Update(newCustomer.Id,newCustomer);
            Assert.That(result.GetType(), Is.EqualTo(typeof(int)));


        }


        [Test]
        public void updateCustomerTestReturn2()
        {

        


            Customer newCustomer = new Customer();






            newCustomer.Address = "safaga";


            var result = customerRepository.Update("dsdsdsdsa", newCustomer);
            Assert.That(result, Is.EqualTo(0));


        }

        [Test]
        public void UpdateCustomerTestIdType()
        {
            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;




            var r = customerRepository.Insert(newCustomer);

          var y =  customerRepository.Update(newCustomer.Id, newCustomer);



            Assert.That(newCustomer.Id.GetType(), Is.EqualTo(typeof(string)));




        }



        [Test]
        public void UpdateCustomerTestIdType2()
        {
            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;




            var r = customerRepository.Insert(newCustomer);

            var y = customerRepository.Update(newCustomer.Id, newCustomer);



            Assert.That(newCustomer.GetType(), Is.EqualTo(typeof(Customer)));




        }


        [Test]
        public void UpdateCustomerTestReturnNull()
        {
            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;




            var r = customerRepository.Insert(newCustomer);

            Assert.That(() => customerRepository.Update("dsdsdsd", newCustomer), Throws.TypeOf<NullReferenceException>());

        }




        [Test]
        public void DeleteCustomerTestReturn()
        {





            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;




            var r = customerRepository.Insert(newCustomer);



            var result = customerRepository.Delete(newCustomer.Id);


            Assert.That(result.GetType(), Is.EqualTo(typeof(int)));




        }



        [Test]
        public void DeleteCustomerTestIdType()
        {
            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;




            var r = customerRepository.Insert(newCustomer);

            var y = customerRepository.Delete(newCustomer.Id);



            Assert.That(newCustomer.Id.GetType(), Is.EqualTo(typeof(string)));




        }


        [Test]
        public void DeleteCustomerTestIdType2()
        {
            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;




            var r = customerRepository.Insert(newCustomer);

            var y = customerRepository.Delete(newCustomer.Id);



            Assert.That(newCustomer.GetType(), Is.EqualTo(typeof(Customer)));




        }


        [Test]
        public void DeleteCustomerTestReturnNull()
        {
            Cart newCart = new Cart();

            cartRepository.Insert(newCart);


            Customer newCustomer = new Customer();

            newCustomer.CartId = newCart.Id;




            var r = customerRepository.Insert(newCustomer);

            Assert.That(() => customerRepository.Delete("dsdsdsd"), Throws.TypeOf<NullReferenceException>());

        }


        [Test]

        public void CustomerProbertyAddress()
        {

            Customer customer = new Customer();

            customer.Address = "asdasda";
            
            Assert.That(customer.Address.GetType(), Is.EqualTo(typeof(string)));

        }

        [Test]

        public void CustomerObjectType()
        {

            Customer customer = new Customer();


            Assert.That(customer.GetType(), Is.EqualTo(typeof(Customer)));

        }

        [Test]
        public void CustomerObjectTypeCart()
        {

            Customer customer = new Customer();

            customer.Cart = new Cart();


            Assert.That(customer.Cart.GetType(), Is.EqualTo(typeof(Cart)));

        }

        [Test]
        public void CustomerProbertyCartId()
        {

            Customer customer = new Customer();

            customer.CartId = 2232;

            Assert.That(customer.CartId.GetType(), Is.EqualTo(typeof(int)));

        }


        [Test]
        public void CustomerProbertyId()
        {

            Customer customer = new Customer();

            customer.Id = "dsdsdsd";

            Assert.That(customer.Id.GetType(), Is.EqualTo(typeof(string)));

        }

    }
}
