using System;
using System.Collections.Generic;
using School.dbModules;
using LiteDB;
using LiteDB.Engine;

namespace School.dbHelper
{
    class UsersHelper
    {

        public static IEnumerable<UsersModule> UsersCollections()
        {
            var users = new List<UsersModule>();
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var collection = db.GetCollection<UsersModule>("Users");
                var result = collection.FindAll();
                users.AddRange(result);
            }
            return users;
        }
        public void userInsert(string valName, string valUserName, string valPassword, string valGender, DateTime valDateOfBrith, string valPhoto)
        {
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var collection = db.GetCollection<UsersModule>("Users");
                UsersModule usermod = new UsersModule();
                //collection.DeleteAll();
                collection.Insert(new UsersModule()
                { name = valName, userName = valUserName, password = valPassword, gender = valGender, dateOfBrith = valDateOfBrith, photo = valPhoto });

                //collection.DeleteAll();
                Logger log = new Logger();
                string logerString = string.Format("New user was created with name -> {0} username -> {1} gender-> {2} date of Brith -> {3} photo name -> {4} ", valName, valUserName, valGender, valDateOfBrith, valPhoto);
                log.WriteSignup(logerString);
            }
        }


        public static UsersModule LogIn(string userVal)
        {
            var userToReturn = new List<UsersModule>();
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var users = db.GetCollection<UsersModule>("Users");
                var result = users.FindAll();
                foreach (UsersModule user in result)
                {
                    userToReturn.Add(user);
                }
                return userToReturn.Find(x => x.userName == userVal);
            }
        }

        public static UsersModule update(string newUserName, int userId, DateTime changedDate)
        {
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var collection = db.GetCollection<UsersModule>("Users");
                var user = collection.FindById(userId);
                user.userName = newUserName;
                user.dateOfBrith = changedDate;
                
                collection.Update(user);
            }

            return null;
        }

        public IList<UsersModule> GetAll()
        {
            var issuesToReturn = new List<UsersModule>();
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var issues = db.GetCollection<UsersModule>("Users");
                var results = issues.FindAll();
                foreach (UsersModule issueItem in results)
                {
                    issuesToReturn.Add(issueItem);
                }
                return issuesToReturn;
            }
        }
    }
}