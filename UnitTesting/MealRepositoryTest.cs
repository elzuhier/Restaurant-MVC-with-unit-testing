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
    internal class MealRepositoryTest
    {
        CategoryRepository categoryRepository;
        MealRepository mealRepository;


        [SetUp]
        public void MealRepositorySetup()
        {
            Context _context = new Context();

            categoryRepository = new CategoryRepository(_context);
            mealRepository = new MealRepository(_context);



        }


        [Test]
        public void FindTitleProperityTest()
        {
            Meal meal = new Meal();

            Assert.That(meal, Has.Property("Title"));
        }

        [Test]
        public void FindDescriptionProperityTest()
        {
            Meal meal = new Meal();

            Assert.That(meal, Has.Property("Description"));
        }
        [Test]
        public void FindPriceProperityTest()
        {
            Meal meal = new Meal();

            Assert.That(meal, Has.Property("Price"));
        }


        [Test]
        public void getAllMealsTest()
        {
            var result = mealRepository.GetAll();
            Assert.That(result.GetType(), Is.EqualTo(typeof(List<Meal>)));
        }

        [Test]
        public void getMealByIdTestReturn()
        {

            var result = mealRepository.GetById(3);
            Assert.That(result.GetType(), Is.EqualTo(typeof(Meal)));
        }


        [Test]
        public void getMealByIdTestType()
        {

            var x = 5;

            var result = mealRepository.GetById(x);


            Assert.That(x.GetType(), Is.EqualTo(typeof(int)));




        }
        [Test]
        public void getMealByIdTestReturnNull()
        {


            Assert.That(() => mealRepository.GetById(30), Throws.TypeOf<NullReferenceException>());

        }

        [Test]
        public void InsertMealTestReturn()
        {
            Category newCategory = new Category();
            newCategory.Description = "newCategory";
            newCategory.Name = "Happy";


            categoryRepository.Insert(newCategory);

            Meal newMeal = new Meal();

            newMeal.Title = "childMeal";
            newMeal.Image = "kid.jpeg";
            newMeal.Price = 500;
            newMeal.Description = "Happy Meal";
            newMeal.CategoryId = newCategory.Id;




            var result = mealRepository.Insert(newMeal);
            Assert.That(result.GetType(), Is.EqualTo(typeof(int)));
        }



        [Test]
        public void InsertMealTestType()
        {


            Category newCategory = new Category();
            newCategory.Name = "Category";

            newCategory.Description = "New Category";

            categoryRepository.Insert(newCategory);


            Meal newMeal = new Meal();


            newMeal.Title = "childMeal";
            newMeal.Image = "kid.jpeg";
            newMeal.Price = 500;
            newMeal.Description = "Happy Meal";
            newMeal.CategoryId = newCategory.Id;

            var result = mealRepository.Insert(newMeal);

            Assert.That(newMeal.GetType(), Is.EqualTo(typeof(Meal)));
        }



        [Test]
        public void updateMealTest()
        {

            Category newcategory = new Category();
            newcategory.Name = "category";
            newcategory.Description = "new category";

            categoryRepository.Insert(newcategory);


            Meal newMeal = new Meal();



            newMeal.CategoryId = newcategory.Id;
            newMeal.Title = "childMeal";
            newMeal.Image = "kid.jpeg";
            newMeal.Price = 500;
            newMeal.Description = "Happy Meal";
            var r = mealRepository.Insert(newMeal);

            var result = mealRepository.Update(newMeal.Id, newMeal);
            Assert.That(result.GetType(), Is.EqualTo(typeof(int)));

        }


        [Test]
        public void updateMealTestReturn()
        {

            Meal newMeal = new Meal();

            newMeal.Title = "childMeal";
            newMeal.Image = "kid.jpeg";
            newMeal.Price = 500;
            newMeal.Description = "Happy Meal";
            var result = mealRepository.Update(1, newMeal);
            Assert.That(result, Is.EqualTo(0));


        }

        [Test]
        public void UpdateMealTestId()
        {
            Category newCategory = new Category();
            newCategory.Name = "category";
            newCategory.Description = "new category";

            categoryRepository.Insert(newCategory);


            Meal newMeal = new Meal();

            newMeal.CategoryId = newCategory.Id;
            newMeal.Title = "childMeal";
            newMeal.Image = "kid.jpeg";
            newMeal.Price = 500;
            newMeal.Description = "Happy Meal";

            var x = mealRepository.Insert(newMeal);

            var y = mealRepository.Update(newMeal.Id, newMeal);



            Assert.That(newMeal.Id.GetType(), Is.EqualTo(typeof(int)));




        }

        [Test]
        public void UpdateMealTestIdType()
        {
            Category newCategory = new Category();
            newCategory.Name = "category";
            newCategory.Description = "new category";
            categoryRepository.Insert(newCategory);


            Meal newMeal = new Meal();
            newMeal.CategoryId = newCategory.Id;
            newMeal.Title = "childMeal";
            newMeal.Image = "kid.jpeg";
            newMeal.Price = 500;
            newMeal.Description = "Happy Meal";


            var x = mealRepository.Insert(newMeal);

            var y = mealRepository.Update(newMeal.Id, newMeal);



            Assert.That(newMeal.GetType(), Is.EqualTo(typeof(Meal)));




        }

        [Test]
        public void UpdateMealTestReturnNull()
        {
            Category newCategory = new Category();
            newCategory.Name = "category";
            newCategory.Description = "new category";


            categoryRepository.Insert(newCategory);


            Meal newMeal = new Meal();
            newMeal.CategoryId = newCategory.Id;
            newMeal.Title = "childMeal";
            newMeal.Image = "kid.jpeg";
            newMeal.Price = 500;
            newMeal.Description = "Happy Meal";

            var x = mealRepository.Insert(newMeal);

            Assert.That(() => mealRepository.Update(4, newMeal), Throws.TypeOf<NullReferenceException>());

        }

        [Test]
        public void DeleteMealTestReturn()
        {

            Category newCategory = new Category();
            newCategory.Name = "category";
            newCategory.Description = "new category";


            categoryRepository.Insert(newCategory);

            Meal newMeal = new Meal();
            newMeal.CategoryId = newCategory.Id;
            newMeal.Title = "childMeal";
            newMeal.Image = "kid.jpeg";
            newMeal.Price = 500;
            newMeal.Description = "Happy Meal";


            var x = mealRepository.Insert(newMeal);

            var result = mealRepository.Delete(newMeal.Id);


            Assert.That(result.GetType(), Is.EqualTo(typeof(int)));




        }

        [Test]
        public void DeleteMealTestIdType()
        {
            Category newCategory = new Category();
            newCategory.Name = "category";
            newCategory.Description = "new category";


            categoryRepository.Insert(newCategory);

            Meal newMeal = new Meal();
            newMeal.CategoryId = newCategory.Id;
            newMeal.Title = "childMeal";
            newMeal.Image = "kid.jpeg";
            newMeal.Price = 500;
            newMeal.Description = "Happy Meal";

            var x = mealRepository.Insert(newMeal);

            var y = mealRepository.Delete(newMeal.Id);



            Assert.That(newMeal.Id.GetType(), Is.EqualTo(typeof(int)));




        }

        [Test]
        public void DeleteMealTestId()
        {
            Category newCategory = new Category();
            newCategory.Name = "category";
            newCategory.Description = "new category";


            categoryRepository.Insert(newCategory);

            Meal newMeal = new Meal();
            newMeal.CategoryId = newCategory.Id;
            newMeal.Title = "childMeal";
            newMeal.Image = "kid.jpeg";
            newMeal.Price = 500;
            newMeal.Description = "Happy Meal";




            var x = mealRepository.Insert(newMeal);

            var y = mealRepository.Delete(newMeal.Id);



            Assert.That(newMeal.GetType(), Is.EqualTo(typeof(Meal)));




        }

        [Test]
        public void DeleteMealTestReturnNull()
        {
            Category newCategory = new Category();
            newCategory.Name = "category";
            newCategory.Description = "new category";


            categoryRepository.Insert(newCategory);

            Meal newMeal = new Meal();
            newMeal.CategoryId = newCategory.Id;
            newMeal.Title = "childMeal";
            newMeal.Image = "kid.jpeg";
            newMeal.Price = 500;
            newMeal.Description = "Happy Meal";

            var x = mealRepository.Insert(newMeal);

            Assert.That(() => mealRepository.Delete(4), Throws.TypeOf<NullReferenceException>());

        }


        [Test]

        public void MealProbertyTitle()
        {
            Meal meal = new Meal();


            meal.Title = "soon";

            Assert.That(meal.Title.GetType(), Is.EqualTo(typeof(string)));

        }
        [Test]
        public void MealProbertyDescription()
        {
            Meal meal = new Meal();


            meal.Description = "Our New Meal";

            Assert.That(meal.Description.GetType(), Is.EqualTo(typeof(string)));

        }
        [Test]
        public void MealProbertyPrice()
        {
            Meal meal = new Meal();


            meal.Price = 67.5f;

            Assert.That(meal.Price.GetType(), Is.EqualTo(typeof(float)));

        }
        [Test]
        public void MealProbertyImage()
        {
            Meal meal = new Meal();


            meal.Image = "f3.png";

            Assert.That(meal.Image.GetType(), Is.EqualTo(typeof(string)));

        }


        [Test]

        public void MealObjectType()
        {

            Meal meal = new Meal();

            Assert.That(meal.GetType(), Is.EqualTo(typeof(Meal)));

        }



        [Test]
        public void FindImageProperityTest()
        {
            Meal meal = new Meal();

            Assert.That(meal, Has.Property("Image"));
        }


        [Test]
        public void FindIDProperityTest()
        {
            Meal meal = new Meal();

            Assert.That(meal, Has.Property("Id"));
        }
        [Test]
        public void FindCategoryIDProperityTest()
        {
            Meal meal = new Meal();

            Assert.That(meal, Has.Property("CategoryId"));
        }




        [Test]
        public void MealObjectTypeCategory()
        {

            Meal meal = new Meal();


            meal.Category = new Category();


            Assert.That(meal.Category.GetType(), Is.EqualTo(typeof(Category)));

        }

        [Test]
        public void MealProbertyCategoryId()
        {

            Meal meal = new Meal();


            meal.CategoryId = 1;

            Assert.That(meal.CategoryId.GetType(), Is.EqualTo(typeof(int)));

        }

        [Test]
        public void MealProbertyId()
        {
            Meal meal = new Meal();

            meal.Id = 4;

            Assert.That(meal.Id.GetType(), Is.EqualTo(typeof(int)));

        }









    }
}
