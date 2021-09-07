using Finisar.SQLite;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace School.Pages
{
    /// <summary>
    /// Interaction logic for Classes.xaml
    /// </summary>
    public partial class Classes : Page
    {

        public Classes()
        {
            InitializeComponent();
            string filepath = @"school.db";
            if (!File.Exists(filepath))
            {
                SQLiteConnection sqlite_conn;
                SQLiteCommand sqlite_cmd;
                //SQLiteDataReader sqlite_datareader;
                sqlite_conn = new SQLiteConnection("Data Source=school.db;Version=3;New=True;Compress=True;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                //sqlite_cmd.CommandText = "CREATE TABLE [IF NOT EXISTS]  test (id integer primary key, text varchar(100));";
                sqlite_cmd.CommandText = "CREATE TABLE  classes (id integer primary key, name integer(255));";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "CREATE TABLE  students (id integer primary key, name varchar(255));";
                sqlite_cmd.ExecuteNonQuery();
                
                sqlite_cmd.CommandText = "CREATE TABLE marks (id integer primary key, classId integer(11), studentsId integer(11)" +
                    " ,One integer(11), Two integer(11) , Three integer(11) , Four integer(11) , Five integer(11) , Six integer(11) " +
                    ", Seven integer(11) , Eight integer(11) , Nine integer(11) , Ten integer(11) , Eleven integer(11)  " +
                    ", Twelve integer(11) , Thirteen integer(11) , Fourteen integer(11) , Fifteen integer(11)" +
                    ", Sixteen integer(11) , Seventeen integer(11) , Eighteen integer(11) , Nineteen integer(11)" +
                    ", Twenty integer(11) , Twentyone integer(11) , Twentytwo integer(11) , Twentythree integer(11) , Twentyfour integer(11) " +
                    ", Twentyfive integer(11) , Twentysix integer(11) " +
                    ", Twentyseven integer(11), Twentyeight integer(11), Twentynine integer(11), Thirty integer(11) ," +
                    " FOREIGN KEY(classId) REFERENCES classes(id)" +
                    " FOREIGN KEY(studentsId) REFERENCES students(id));";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT into students(name) VALUES(\"axmad\");";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT into students(name) VALUES(\"said\");";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT into students(name) VALUES(\"sobir\");";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT into students(name) VALUES(\"bakir\");";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT into students(name) VALUES(\"zokir\");";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT into students(name) VALUES(\"eshon\");";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT into students(name) VALUES(\"xasan\");";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT into students(name) VALUES(\"xusan\");";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT into students(name) VALUES(\"ali\");";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT into students(name) VALUES(\"nasir\");";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT into classes(name) VALUES(\"class1\");";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT into classes(name) VALUES(\"class2\");";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT into classes(name) VALUES(\"class3\");";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT into classes(name) VALUES(\"class4\");";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(1, 1); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(1, 2); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(1, 3); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(1, 4); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(1, 5); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(1, 6); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(1, 7); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(1, 8); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(1, 9); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(1, 10); ";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(2, 1); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(2, 2); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(2, 3); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(2, 4); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(2, 5); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(2, 6); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(2, 7); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(2, 8); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(2, 9); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(2, 10); ";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(3, 1); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(3, 2); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(3, 3); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(3, 4); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(3, 5); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(3, 6); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(3, 7); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(3, 8); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(3, 9); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(3, 10); ";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(4, 1); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(4, 2); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(4, 3); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(4, 4); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(4, 5); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(4, 6); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(4, 7); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(4, 8); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(4, 9); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = " INSERT INTO marks(classId, studentsId) VALUES(4, 10); ";
                sqlite_cmd.ExecuteNonQuery();

            }
        }
        Logger lg = new Logger();
        private void btnClass1_Click(object sender, RoutedEventArgs e)
        {
            lg.WriteEnterSheadule(1);
            this.NavigationService.Navigate(new Marks2(1));
        }

        private void btnClass2_Click(object sender, RoutedEventArgs e)
        {
            lg.WriteEnterSheadule(2);
            this.NavigationService.Navigate(new Marks2(2));

        }

        private void btnClass3_Click(object sender, RoutedEventArgs e)
        {
            lg.WriteEnterSheadule(3);
            this.NavigationService.Navigate(new Marks2(3));

        }

        private void btnClass4_Click(object sender, RoutedEventArgs e)
        {
            lg.WriteEnterSheadule(4);
            this.NavigationService.Navigate(new Marks2(4));

        }
        public int getValue()
        {
            return 1;
        }
    }
}