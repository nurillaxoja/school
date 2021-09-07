using LiteDB;
using School.dbModules;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace School.dbHelper
{
    class SchoolClassHelper
    {   
        //public static IEnumerable<SchoolClassModule> SchoolClassesCollection()
        //{
        //    var classes = new List<SchoolClassModule>();
        //    using (var db = new LiteDatabase(dbConnection.dbLocation))
        //    {
        //        var collection = db.GetCollection<SchoolClassModule>("Classes");
        //        var result = collection.FindAll();
        //        classes.AddRange(result);

        //    }
        //    return classes;
        //}

        public static void addMarks(int classn)
        {
            using(var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var collection = db.GetCollection<SchoolClassModule>("Classes");
                SchoolClassModule usermod = new SchoolClassModule();
                collection.Insert(new SchoolClassModule()
                {
                    classnum = classn
                    /*classNum = classNumber , mark = markStudent, markDate = dateMark*/
                }) ;
                //collection.Count();
                //collection.DeleteAll();
            }
        }

        

        public static ObservableCollection<SchoolClassModule> GetClasses()
        {
            var classes = new ObservableCollection<SchoolClassModule>();

            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var collection = db.GetCollection<SchoolClassModule>("Classes");
                var results = collection.FindAll();
                foreach (var result in results)
                {
                    classes.Add(new SchoolClassModule { Id = result.Id ,
                        classnum = result.classnum 
                       /* classNum = result.classNum, mark = result.mark, , markDate = result.markDate*/});
                }
            }
            return classes;
        }

        public static ObservableCollection<SchoolClassModule>getOneClass(int classnumber)
        {
            var classToRetrun = new ObservableCollection<SchoolClassModule>(); 
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var collection = db.GetCollection<SchoolClassModule>("Classes");
                var result = collection.FindAll();
                foreach (SchoolClassModule oneClass in result)
                {
                    if (oneClass.classnum == classnumber)
                    {
                        classToRetrun.Add(oneClass);
                    }
                }
                return classToRetrun;
            }
        }

        //public static SchoolClassModule getOneClass(int classnumber)
        //{
        //    var classToRetrun = new List<SchoolClassModule>();
        //    using (var db = new LiteDatabase(dbConnection.dbLocation))
        //    {
        //        var collection = db.GetCollection<SchoolClassModule>("Classes");
        //        var result = collection.FindAll();
        //        foreach (SchoolClassModule oneClass in result)
        //        {
        //            classToRetrun.Add(oneClass);
        //        }
        //        int getClassCount = classToRetrun.Count();
        //        return classToRetrun.Find(x=> x.classNum == classnumber);
        //    }
        //}

       
    }
}
