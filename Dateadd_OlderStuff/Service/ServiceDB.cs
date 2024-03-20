namespace Dateadd_OlderStuff.Service
{
    public class ServiceDB
    {

        private bool _dbAction;
        public ServiceDB() { }
        public ServiceDB(string name) 
        { 
        }

        public ServiceDB(bool dbAction)
        {
            _dbAction = dbAction;
        }
    }
}
