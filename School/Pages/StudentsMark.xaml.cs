using School.dbHelper;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace School.Pages
{
    /// <summary>
    /// Interaction logic for StudentsMark.xaml
    /// </summary>
    public partial class StudentsMark : Page
    {

        public StudentsMark()
        {
            InitializeComponent();

            //var test = SchoolClassHelper.GetClasses();
            //int i = 1;

            //for (int x = 1; x <= DateTime.Now.Day; x++)
            //{
            //    Label lbl = new Label();
            //    Grid.SetColumn(lbl, x);
            //    Grid.SetRow(lbl, 0);
            //    lbl.Content = string.Format("{0}", x);
            //    lbl.VerticalAlignment = VerticalAlignment.Center;
            //    lbl.Foreground = Brushes.White;
            //    grid.Children.Add(lbl);
            //}

            //for (int y = 1; y <= DateTime.Now.Day; y++)
            //{
            //    for (int j = 1; j <= test.Count / 4; j++)
            //    {
            //        TextBox tb = new TextBox();
            //        tb.VerticalAlignment = VerticalAlignment.Center;
            //        tb.HorizontalAlignment = HorizontalAlignment.Center;
            //        Grid.SetColumn(tb, y);
            //        Grid.SetRow(tb, j);
            //        string gname = string.Format("grid{0}{1}", y, j);
            //        grid.Name = gname;
            //        grid.Children.Add(tb);
            //    }
            //}

            //foreach (var result in test)
            //{
            //    if (result.classNum == 2)
            //    {
            //        /* adding student name */
            //        string resname = result.name;
            //        TextBox txt = new TextBox();
            //        txt.Name = resname;
            //        txt.VerticalAlignment = VerticalAlignment.Center;
            //        txt.HorizontalAlignment = HorizontalAlignment.Center;
            //        Grid.SetColumn(txt, 0);
            //        Grid.SetRow(txt, i);
            //        txt.Text = resname;
            //        grid.Children.Add(txt);

            //        /*adding sttudent mark*/
            //        int date = result.markDate.Day;
            //        TextBox txt2 = new TextBox();
            //        txt2.Text = result.mark.ToString();
            //        txt2.VerticalAlignment = VerticalAlignment.Center;
            //        txt2.HorizontalAlignment = HorizontalAlignment.Center;
            //        Grid.SetColumn(txt2, date);
            //        Grid.SetRow(txt2, i);
            //        grid.Children.Add(txt2);
            //        i++;
            //    }
            //}

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //string[] userNames = new string[30];
            //var test = SchoolClassHelper.getOneClass(2);

            //foreach (var result in test)
            //{
            //    int i = 0;
            //    userNames[i] = result.name;
            //    i++;
            //}

            //for (int y = 1; y <= DateTime.Now.Day; y++)
            //{
            //    for (int j = 1; j <= test.Count; j++)
            //    {
            //        TextBox tb = new TextBox();
            //        Grid.SetColumn(tb, y);
            //        Grid.SetRow(tb, j);
            //        if (tb.Text != null)
            //        {
            //            int smark = int.Parse(tb.Text);

            //            string stname = userNames[j + 1];

            //            int month = DateTime.Now.Month;
            //            int year = DateTime.Now.Year;
            //            DateTime insertDate = new DateTime(year, month, y);

            //            SchoolClassHelper.addMarks(1, smark, stname, insertDate);
            //        }
            //    }
            //}
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
