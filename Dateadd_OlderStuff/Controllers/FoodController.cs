using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CreateExercises;
using ExerciseMethodShareDtNt;
using Dateadd_OlderStuff.Models;

namespace Dateadd_OlderStuff.Controllers
{
    public class FoodController : Controller
    {
        // GET: FoodController1
        public ActionResult Index()
        {
            return View();
        }

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
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
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
