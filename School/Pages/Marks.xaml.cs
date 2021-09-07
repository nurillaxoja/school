using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using Finisar.SQLite;
using School.dbHelper;

namespace School.Pages
{
    
    public partial class Marks : Page
    {
        public Marks()
        {
            InitializeComponent();
            //DataBaseConnection();
        }
        public Marks(int num)
        {
            InitializeComponent();
            DataBaseConnection(num);
        }
        SQLiteConnection sqlitecon = new SQLiteConnection("Data Source=school.db; Version=3;");

        public void DataBaseConnection(int classnum)
        {
            try
            {
                try
                {
                    SQLiteConnection sqlitecon = new SQLiteConnection("Data Source=school.db; Version=3;");
                    sqlitecon.Open();
                    string Query = "select DISTINCT marks.id as \"Sort\" , studentsId, classId ," +
                        " One as \"1\"  , Two as \"2\", Three as \"3\"," +
                        "Four as \"4\", Five as \"5\", Six as \"6\" " +
                        ", Seven as \"7\", Eight as \"8\", Nine as \"9\", Ten as \"10\", Eleven as \"11\"" +
                    ", Twelve as \"12\" , Thirteen as \"13\", Fourteen as \"14\" , Fifteen as \"15\"" +
                    ", Sixteen as \"16\" , Seventeen as \"17\", Eighteen as \"18\", Nineteen as \"19\"" +
                    ", Twenty as \"20\" , Twentyone as \"21\" , Twentytwo as \"22\" , Twentythree as \"23\"" +
                    ", Twentyfour as \"24\" , Twentyfive as \"25\" , Twentysix as \"26\" , Twentyseven as \"27\" " +
                    ",Twentyeight as \"28\", Twentynine as \"29\", Thirty as \"30\" from marks, students " +
                    "WHERE classId =  "+ classnum+" ;";
                    SQLiteCommand createCommand = new SQLiteCommand(Query, sqlitecon);
                    SQLiteDataAdapter dataAdapt = new SQLiteDataAdapter(createCommand);
                    createCommand.ExecuteNonQuery();
                    DataTable dt = new DataTable("marks");
                    dataAdapt.Fill(dt);
                    dataGrid.ItemsSource = dt.DefaultView;
                    dataAdapt.Update(dt);
                    sqlitecon.Close();




                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex+"SQLite DataBase Error!");
            }
        }


        string columnName = "";
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int columindex = dataGrid.CurrentCell.Column.DisplayIndex;
            ColIndexHelper.AddColIndex(columindex);

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = dataGrid.SelectedItem as DataRowView;

            int columindexintial = ColIndexHelper.Get().colIndex;
            string value = row.Row.ItemArray[columindexintial].ToString();
            int columindex = columindexintial - 1;
            string dataRow = row.Row.ItemArray[0].ToString();
            int dataRowInt = Convert.ToInt32(dataRow);


            if (columindex == 1)
            {
                columnName = "One";
            }
            if (columindex == 2)
            {
                columnName = "Two";
            }
            if (columindex == 3)
            {
                columnName = "Three";
            }
            if (columindex == 4)
            {
                columnName = "Four";
            }
            if (columindex == 5)
            {
                columnName = "Five";
            }
            if (columindex == 6)
            {
                columnName = "Six";
            }
            if (columindex == 7)
            {
                columnName = "Seven";
            }
            if (columindex == 8)
            {
                columnName = "Eight";
            }
            if (columindex == 9)
            {
                columnName = "Nine";
            }
            if (columindex == 10)
            {
                columnName = "Ten";
            }
            if (columindex == 11)
            {
                columnName = "Eleven";
            }
            if (columindex == 12)
            {
                columnName = "Twelve";
            }
            if (columindex == 13)
            {
                columnName = "Thirteen";
            }
            if (columindex == 14)
            {
                columnName = "Fourteen";
            }
            if (columindex == 15)
            {
                columnName = "Fifteen";
            }
            if (columindex == 16)
            {
                columnName = "Sixteen";
            }
            if (columindex == 17)
            {
                columnName = "Seventeen";
            }
            if (columindex == 18)
            {
                columnName = "Eighteen";
            }
            if (columindex == 19)
            {
                columnName = "Nineteen";
            }
            if (columindex == 20)
            {
                columnName = "Twenty";
            }
            if (columindex == 21)
            {
                columnName = "Twentyone";
            }
            if (columindex == 22)
            {
                columnName = "Twentytwo";
            }
            if (columindex == 23)
            {
                columnName = "Twentythree";
            }
            if (columindex == 24)
            {
                columnName = "Twentyfour";
            }
            if (columindex == 25)
            {
                columnName = "Twentyfive";
            }
            if (columindex == 26)
            {
                columnName = "Twentysix";
            }
            if (columindex == 27)
            {
                columnName = "Twentyseven";
            }
            if (columindex == 28)
            {
                columnName = "Twentyeight";
            }
            if (columindex == 29)
            {
                columnName = "Twentynine";
            }
            if (columindex == 30)
            {
                columnName = "Thirty";
            }

            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;

            sqlite_conn = new SQLiteConnection("Data Source = school.db; Version = 3; ");
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "UPDATE marks set " + columnName + " = " + value + " where marks.id = " + dataRowInt + " ; ";
            sqlite_cmd.ExecuteNonQuery();
            sqlitecon.Close();

        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = dataGrid.SelectedItem as DataRowView;
            int columindex = ColIndexHelper.Get().colIndex;
            string value = row.Row.ItemArray[columindex].ToString();
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;
            sqlite_conn = new SQLiteConnection("Data Source = school.db; Version = 3; ");
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO students (name)  Values(\"" + value + "\"); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO marks (id)  Values(NULL) ; ";
            sqlite_cmd.ExecuteNonQuery();
            sqlitecon.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new profile());
        }

        private void dataGrid_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            DataRowView row = dataGrid.SelectedItem as DataRowView;
            int columindex = ColIndexHelper.Get().colIndex;
            string value = row.Row.ItemArray[columindex].ToString();

            MessageBox.Show(value);
        }
    }
}
