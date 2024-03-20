namespace Dateadd_OlderStuff.Models
{
    public class Food
    {
        private string _description;
        private DateTime _created;
        private Int32 calories;

       

        public string Description { get => _description; set => _description = value; }
        public DateTime Created { get => _created; set => _created = value; }
        public int Calories { get => calories; set => calories = value; }
    }
}
