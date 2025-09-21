using Dateadd_OlderStuff.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using System.Reflection;

namespace Dateadd_OlderStuff.Controllers
{
    public class ExerciseController : Controller
    {
        // GET: ExerciseController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExerciseController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExerciseController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExerciseController1/Create
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

        // GET: ExerciseController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExerciseController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Exercise model, IFormCollection collection)
        {
            try
            {
                string name = model.Description;
                int calories = model.Calories;
                int time = model.Time_taken;

                CreateExercises.ExerciseDataFeed.Make_Exercise_Regiment(4, model.Description, model.Time_taken);
                CreateExercises.ExerciseDataFeed.Make_Log_Entry_Names(model.Calories,model.Description, model.Time_taken);

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: ExerciseController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExerciseController1/Delete/5
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
