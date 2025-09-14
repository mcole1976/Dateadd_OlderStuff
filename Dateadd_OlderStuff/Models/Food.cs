using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dateadd_OlderStuff.Models
{
    public class Food
    {
        private string _description;
        private DateTime _created;
        private Int32 calories;
        private string _meal;

       
        public string Description { get => _description; set => _description = value; }
        public DateTime Created { get => _created; set => _created = value; }
        public int Calories { get => calories; set => calories = value; }
        public string Meal { get => _meal; set => _meal = value; }


        public List<SelectListItem> MealOptions { get; set; }
    }
}
