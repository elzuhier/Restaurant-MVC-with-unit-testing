using NUnit.Framework;
using Restratant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestFixture]
    public class CategoryTest
    {
        [Test]
        public void Test_Has_Name_Property()
        {
            Category cat = new Category();

            Assert.That(cat, Has.Property("Name"));
        }
        [Test]
        public void Test_Has_Description_Property()
        {
            Category cat = new Category();

            Assert.That(cat, Has.Property("Description"));
        }
        [Test]
        public void Test_Has_Id_Property()
        {
            Category cat = new Category();

            Assert.That(cat, Has.Property("Id"));
        }
    }
}
