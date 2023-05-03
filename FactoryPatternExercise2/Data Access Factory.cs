using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class Data_Access_Factory
    {

        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType)
                {
                case "mongo":
                    return new MongoDataAccess();
                case "sql":
                    return new SQL_Data_Access();
                case "list":
                    return new ListDataAccess();
                default:
                    return new ListDataAccess();
            }

        }
    }
}
