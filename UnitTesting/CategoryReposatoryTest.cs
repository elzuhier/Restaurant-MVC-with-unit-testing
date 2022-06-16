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
    public class CategoryReposatoryTest
    {
        
        CategoryRepository category;
        Context context;
        [SetUp]
        public void setup()
        {
            context = new Context();
            category = new CategoryRepository(context); 
        }
        [Test]
        public void GetAllCategoytypeTest()
        {
            var result = category.GetAll();
            Assert.That(result.GetType(),Is.EqualTo(typeof(List<Category>)));
        }
        [Test]
        public void GetByIDtypeTest()
        {
            Category newcategory = new Category();
            newcategory.Name = "skfalf";
            newcategory.Description = "fhdsl";
            category.Insert(newcategory);
            var result = category.GetById(newcategory.Id);
            Assert.That(result.GetType(), Is.EqualTo(typeof(Category)));
        }
        [Test]
        public void GetNullCategoryByID()
        {
            Assert.That(() => category.GetById(4354), Throws.TypeOf<NullReferenceException>());
        }
        [Test]
        public void InsertCategoryTypeTest()
        {
            Category newcategory = new Category();
            newcategory.Name = "skfalf";
            newcategory.Description = "fhdsl";
            var result = category.Insert(newcategory);
            Assert.That(result.GetType(), Is.EqualTo(typeof(int)));
        }
        [Test]
        public void InsertCategoryReturnTest()
        {
            Category newcategory = new Category();
            newcategory.Name = "skfalf";
            newcategory.Description = "fhdsl";
            var result = category.Insert(newcategory);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UpdateCategoryTypeTest()
        {
            Category newcategory = new Category();
            newcategory.Name = "ay7aga";
            newcategory.Description = "koko";
            category.Insert(newcategory);
            newcategory.Name = "pizza";
            var result = category.Update(newcategory.Id,newcategory);
            Assert.That(result.GetType(), Is.EqualTo(typeof(int)));
        }
        [Test]
        public void UpdateCategoryReturnTest()
        {
            Category newcategory = new Category();
            newcategory.Name = "ay7aga";
            newcategory.Description = "koko";
            category.Insert(newcategory);
            newcategory.Name = "pasta";
            var result = category.Update(newcategory.Id,newcategory);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void WrongUpdateCategoryReturnTest()
        {
            Category newcategory = new Category();
            newcategory.Name = "pasta";
            var result = category.Update(887434, newcategory);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void UpdateNullCategory()
        {
            Category newcategory = new Category();
            newcategory.Name = "pasta";
            Assert.That(() => category.Update(555555, newcategory), Throws.TypeOf<NullReferenceException>());
        }
        [Test]
        public void DeleteCatgoryTest()
        {
            Category oldcategory = new Category() ;
            oldcategory.Name = "pizaa";
            oldcategory.Description = "ay7aga";
            category.Insert(oldcategory);
            var result = category.Delete(oldcategory.Id);
            Assert.That(result.GetType(), Is.EqualTo(typeof(int)));
        }
        [Test]
        public void DeleteCatgoryReturnTest()
        {
            Category oldcategory = new Category();
            oldcategory.Name = "pizaa";
            oldcategory.Description = "ay7aga";
            category.Insert(oldcategory);
            var result = category.Delete(oldcategory.Id);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void WrongDeleteCatgoryTest()
        {
            
            var result = category.Delete(47553);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void DeleteNullCategory()
        {
            Assert.That(() => category.Delete(843630), Throws.TypeOf<NullReferenceException>());
        }

        [Test]
        public void CategoryNameProbertyType()
        {

            Category newcategory = new Category();
            newcategory.Name = "Makrona";
            Assert.That(newcategory.Name.GetType(), Is.EqualTo(typeof(string)));

        }
        [Test]
        public void CategoryNameProbertylength()
        {

            Category newcategory = new Category();
            newcategory.Name = "tawgen";
            Assert.That(newcategory.Name.Length, Is.InRange(3,100));

        }
        [Test]
        public void CategoryDescriptionProbertyType()
        {

            Category newcategory = new Category();
            newcategory.Description = "hamda";
            Assert.That(newcategory.Description.GetType(), Is.EqualTo(typeof(string)));

        }
        [Test]
        public void CategoryDescriptionProbertyLength()
        {

            Category newcategory = new Category();
            newcategory.Description = "koko";
            Assert.That(newcategory.Description.Length, Is.InRange(3,100));

        }
        [Test]
        public void CategoryIDProbertyType()
        {

            Category newcategory = new Category();
            newcategory.Id = 123;
            Assert.That(newcategory.Id.GetType(), Is.EqualTo(typeof(int)));

        }

    }
}
