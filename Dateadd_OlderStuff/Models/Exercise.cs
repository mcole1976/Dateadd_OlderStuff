namespace Dateadd_OlderStuff.Models
{
    public class Exercise
    {
        private string _description;
        private int _calories;
        private int _time_taken;

       

        public string Description { get => _description; set => _description = value; }
        public int Calories { get => _calories; set => _calories = value; }
        public int Time_taken { get => _time_taken; set => _time_taken = value; }
    }
}
