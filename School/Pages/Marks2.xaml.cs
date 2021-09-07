using Finisar.SQLite;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;

namespace School.Pages
{
    /// <summary>
    /// Interaction logic for Marks2.xaml
    /// </summary>
    public partial class Marks2 : Page
    {
        private SQLiteDataAdapter myDataAdapter;
        private DataSet myDataSet;
        private SQLiteCommandBuilder myBuilder;
        private SQLiteConnection myConn = new SQLiteConnection("Data Source=school.db; Version=3;");

        public Marks2(int classnum)
        {
            InitializeComponent();
            myConn.Open();
            myDataAdapter = new SQLiteDataAdapter
            {
                SelectCommand = new SQLiteCommand()
                {
                    Connection = myConn,
                    CommandText =
                    "select * from marks where classId = " + classnum,

                    //"SELECT st.name as stussssent_name, cl.name as class_name, mr.One as \"1\", mr.Two FROM marks mr " +
                    //"LEFT JOIN students st ON st.id == mr.studentsId " +
                    //"LEFT JOIN classes cl ON cl.id == mr.classId " +
                    //"WHERE mr.classId = " + classnum

                    //"SELECT students.name, marks.One, marks.Two FROM marks INNER JOIN students on students.id == marks.id where marks.classId = " + classnum


                    //" select id,classId, studentsId, One as \"1\", Two as \"2\", Three as \"3\"," +
                    //    "Four as \"4\", Five as \"5\", Six as \"6\" " +
                    //    ", Seven as \"7\", Eight as \"8\", Nine as \"9\", Ten as \"10\", Eleven as \"11\"" +
                    //", Twelve as \"12\" , Thirteen as \"13\", Fourteen as \"14\" , Fifteen as \"15\"" +
                    //", Sixteen as \"16\" , Seventeen as \"17\", Eighteen as \"18\", Nineteen as \"19\"" +
                    //", Twenty as \"20\" , Twentyone as \"21\" , Twentytwo as \"22\" , Twentythree as \"23\"" +
                    //", Twentyfour as \"24\" , Twentyfive as \"25\" , Twentysix as \"26\" , Twentyseven as \"27\" " +
                    //",Twentyeight as \"28\", Twentynine as \"29\", Thirty as \"30\" from marks where classId = " + classnum

                    //"SELECT marks.id, students.name, marks.One as \"1\", marks.Two as \"2 \" ,  marks.Three as \"3\",  marks.Four as \"4\", " +
                    //"marks.Five as \"5\",  marks.Six as \"6\",  marks.Seven as \"7\",  marks.Eight as \"8\", marks.Nine as \"9\", " +
                    //" marks.Ten as \"10\",  marks.Eleven as \"11\",  marks.Twelve as \"12\" ,  marks.Thirteen as \"13\"," +
                    //" marks.Fourteen as \"14\" ,  marks.Fifteen as \"15\",  marks.Sixteen as \"16\" ,  marks.Seventeen as \"17\"," +
                    //" marks.Eighteen as \"18\",  marks.Nineteen as \"19\",  marks.Twenty as \"20\" ,  marks.Twentyone as \"21\" , " +
                    //" marks.Twentytwo as \"22\" ,  marks.Twentythree as \"23\", marks.Twentyfour as \"24\" ,  marks.Twentyfive as \"25\" ," +
                    //" marks.Twentysix as \"26\" ,  marks.Twentyseven as \"27\" ,  marks.Twentyeight as \"28\",  marks.Twentynine as \"29\"," +
                    //"  marks.Thirty as \"30\" from marks INNER JOIN students on students.id == marks.studentsId where classId = "+classnum
                }
            };
            myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet, "marks");
            dtGrid.DataContext = myDataSet.Tables["marks"].DefaultView;
        }

        private void dtGrid_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {

            myBuilder = new SQLiteCommandBuilder(myDataAdapter);
            DataRowView myDRV = (DataRowView)dtGrid.SelectedItem;
            myDRV.BeginEdit();


        }
        private void dtGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            DataRowView myDRV = (DataRowView)dtGrid.SelectedItem;
            myDRV.EndEdit();
            myDataAdapter.UpdateCommand = (SQLiteCommand)myBuilder.GetUpdateCommand();
            myDataAdapter.Update(myDataSet, "marks");
        }
        private void dtGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            var tc = e.Column as DataGridTextColumn;
            var b = tc.Binding as Binding;

            b.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            b.ValidatesOnDataErrors = true;
            b.NotifyOnValidationError = true;

        }
    }
}
