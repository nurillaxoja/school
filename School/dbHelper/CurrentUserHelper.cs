using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using School.dbModules;


namespace School.dbHelper
{
    class CurrentUserHelper
    {
        public static IEnumerable<CurrentUserModule> CurrentUserCollection()
        {
            var classes = new List<CurrentUserModule>();
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var collection = db.GetCollection<CurrentUserModule>("InitialUser");
                var result = collection.FindAll();
                classes.AddRange(result);

            }
            return classes;
        }

        public static void Adduser(string user)
        {
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var collection = db.GetCollection<CurrentUserModule>("InitialUser");
                collection.DeleteAll();
                collection.Insert(new CurrentUserModule()
                {
                    Id = 1,
                    curName = user
                });
            }
        }

        public static CurrentUserModule Get()
        {
            var userToReturn = new List<CurrentUserModule>();
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var calculator = db.GetCollection<CurrentUserModule>("InitialUser");
                var result = calculator.FindAll();
                foreach (CurrentUserModule userItem in result)
                {
                    userToReturn.Add(userItem);
                }
                return userToReturn.FirstOrDefault(p => p.Id >= 1);
            }
        }
    }
}
