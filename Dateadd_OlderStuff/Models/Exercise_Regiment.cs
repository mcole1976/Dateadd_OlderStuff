namespace Dateadd_OlderStuff.Models
{
    public class Exercise_Regiment
    {
        private string _name;
        private int _id;
        private int _timeAmnt;

        public Exercise_Regiment(string name, int id, int timeAmnt)
        {
            _name = name;
            _id = id;
            _timeAmnt = timeAmnt;

        }

        public string Name { get => _name; set => _name = value; }
        public int Id { get => _id; set => _id = value; }
        public int TimeAmnt { get => _timeAmnt; set => _timeAmnt = value; }
    }
}
