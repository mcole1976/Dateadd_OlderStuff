using ExerciseMethodShareDtNt;

namespace Dateadd_OlderStuff.Service
{
    public class ServiceDB
    {

        private readonly string _connectionString;
        public ServiceDB() {  }

        public List<string> MakeDDLLIst()
        {
            return  CreateExercises.ExerciseDataFeed.MealTypeList();
        }

        public void makeFood(Food_Log f)
        {
            CreateExercises.ExerciseDataFeed.Make_Food_Entry_Dated(f);
        }


    }
}
