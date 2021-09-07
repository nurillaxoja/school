using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using School.dbModules;

namespace School.dbHelper
{
    class ColIndexHelper
    {

        public static IEnumerable<ColIndexModule> CurrentColumnCollection()
        {
            var classes = new List<ColIndexModule>();
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var collection = db.GetCollection<ColIndexModule>("ColIndex");
                var result = collection.FindAll();
                classes.AddRange(result);

            }
            return classes;
        }
        public static void AddColIndex(int columnIndex)
        {
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var collection = db.GetCollection<ColIndexModule>("ColIndex");
                collection.DeleteAll();
                collection.Insert(new ColIndexModule()
                {
                    Id = 1,
                    colIndex = columnIndex
                });
            }
        }

        public static ColIndexModule Get()
        {
            var colToReturn = new List<ColIndexModule>();
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var calculator = db.GetCollection<ColIndexModule>("ColIndex");
                var result = calculator.FindAll();
                foreach (ColIndexModule userItem in result)
                {
                    colToReturn.Add(userItem);
                }
                return colToReturn.Find(p => p.Id >= 1);
                //p => p.Id >= 1
            }
        }

        //public static ColIndexHelper Get()
        //{
        //    var userToReturn = new List<ColIndexHelper>();
        //    using (var db = new LiteDatabase(dbConnection.dbLocation))
        //    {
        //        var calculator = db.GetCollection<ColIndexHelper>("InitialUser");
        //        var result = calculator.FindAll();
        //        foreach (ColIndexHelper userItem in result)
        //        {
        //            userToReturn.Add(userItem);
        //        }
        //        return userToReturn.FirstOrDefault(p => p.Id >= 1);
        //    }
        //}
    }
}
