using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CreateExercises;
using ExerciseMethodShareDtNt;
using Dateadd_OlderStuff.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.CodeDom;
using Dateadd_OlderStuff.Service;
using Dateadd_OlderStuff.Models;
using System.Reflection;

namespace Dateadd_OlderStuff.Controllers
{
    public class FoodController : Controller
    {
        // GET: FoodController1
        public ActionResult Index()
        {
            var model = new Food();
            model.Created = DateTime.Now;
            List <string> mealTypes = new List<string>();

            Service.ServiceDB serviceDB = new Service.ServiceDB();
            mealTypes = serviceDB.MakeDDLLIst();
            model.MealOptions = new List<SelectListItem>();

            foreach (var meal in mealTypes)
            {
                SelectListItem s = new SelectListItem{ Value = meal, Text =meal };
                model.MealOptions.Add(s);
            }

            return View(model);
        }


        //public ActionResult Index(Food m)
        //{
            

        //    return View(m);
        //}

        // GET: FoodController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FoodController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FoodController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FoodController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Food model, IFormCollection collection)
        {
            try
            {
                string description = collection["Description"];
                string meal = collection["Meal"];
                string calories = collection["Calories"];
                string created = collection["Created"];

                Food_Log f = new Food_Log();
                f.Meal_Description = description;
                f.Meal = meal;
                f.Date = DateTime.Parse(created);
                f.Calorie_Count = int.Parse(calories);

                ServiceDB s = new ServiceDB();

                s.makeFood(f);


                ModelState.Clear();
                // Return a new, empty model to clear the form
                Food fd =  fnMakeFmodel();

               

                //return View(model);
                return View("Index", fd);

            }
            catch
            {
                return View();
            }
        }

        private Food fnMakeFmodel()
        {
            var m = new Food();
            m.Created = DateTime.Now;
            List<string> mealTypes = new List<string>();

            Service.ServiceDB serviceDB = new Service.ServiceDB();
            mealTypes = serviceDB.MakeDDLLIst();
            m.MealOptions = new List<SelectListItem>();

            foreach (var j in mealTypes)
            {
                SelectListItem r = new SelectListItem { Value = j, Text = j };
                m.MealOptions.Add(r);
            }

            return m;
        }

        // GET: FoodController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FoodController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
