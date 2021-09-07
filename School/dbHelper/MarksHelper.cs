using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.dbModules;
using System.Collections.ObjectModel;

namespace School.dbHelper
{
    class MarksHelper
    {
        public static void addMarks( )
        {
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var collection = db.GetCollection<StudentsMarksModule>("Marks");
                StudentsMarksModule marks = new StudentsMarksModule();
                collection.Insert(new StudentsMarksModule()
                {
                }) ;
               
            }
        }
        public static ObservableCollection<StudentsMarksModule> getMarks()
        {
            var marks = new ObservableCollection<StudentsMarksModule>();

            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var collection = db.GetCollection<StudentsMarksModule>("Marks");
                var results = collection.FindAll();
                foreach (var result in results)
                {
                    marks.Add(result);
                }
            }
            return marks;
        }
    }
}
