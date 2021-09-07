using Microsoft.Win32;
using School.dbHelper;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;


namespace School.Pages
{
    /// <summary>
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : Page
    {
        public Signup()
        {
            InitializeComponent();
        }
        string strUserName;
        bool usernameCheck = false;
        bool nameCheck = false;
        bool imageCheck = false;
        bool datecheck = false;
        bool genderCheck = false;
        bool passCheck = false;

        private void txtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {

            strUserName = txtUserName.Text.ToString();

            if (txtUserName.Text != null)
            {
                usernameCheck = true;
            }
            if (txtName.Text != null)
            {
                nameCheck = true;
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Login());

        }


        private void btnLoadImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";
            open.Filter = "JPG files (*.jpg)|.jpg|PNG files (*.png)|.png" +
                "|All files (*.*)|*.*";
            open.FilterIndex = 3;
            //open.ShowDialog();
            //System.IO.File.Copy("source", "destination");
            if (open.ShowDialog() == true)
            {
                if (open.CheckFileExists)
                {

                    string basePath = System.AppDomain.CurrentDomain.BaseDirectory;
                    //string startupUploadsPath = System.AppDomain.CurrentDomain.BaseDirectory;
                    // If directory does not exist, create it
                    if (!Directory.Exists(basePath + "\\uploads"))
                    {
                        Directory.CreateDirectory(basePath + "\\uploads");
                        Directory.CreateDirectory(basePath + "\\uploads\\images");

                    }
                    string startupUploadsPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\uploads\\images\\";
                    //string startupUploadsPath = System.IO.Directory.GetParent(@"../../uploads/").FullName;
                    File.Copy(open.FileName, startupUploadsPath + strUserName + ".jpg"); //+ "\\images\\"

                }
            }
            imageCheck = true;

        }
        DateTime date;
        private void datePickerCloseEvent(object sender, RoutedEventArgs e)
        {
            var date = Convert.ToDateTime(datePicker.SelectedDate);
            if (datePicker != null)
            {
                datecheck = true;
            }


        }
        string photo = "";
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {


            UsersHelper userHelp = new UsersHelper();
            string name = txtName.Text;
            string userName = txtUserName.Text;
            string pass = pswPassword.Password;
            string gender = " ";

            if (male.IsChecked == true)
            {
                gender = "male";
                genderCheck = true;
            }
            if (femail.IsChecked == true)
            {
                gender = " femail";
                genderCheck = true;
            }
            if (pass != null)
            {
                passCheck = true;
            }

            if (usernameCheck == true &&
             nameCheck == true &&
             imageCheck == true &&
             datecheck == true &&
             genderCheck == true &&
             passCheck == true &&
             imageCheck == true
             )
            {
                photo = name + ".jpg";
                userHelp.userInsert(name, userName, pass, gender, Convert.ToDateTime(datePicker.SelectedDate), photo);
                txtName.Clear();
                txtUserName.Clear();
                pswPassword.Clear();
                male.IsChecked = false;
                femail.IsChecked = false;
                photo = "";
                datePicker.Text = "";
                MessageBox.Show("User was saved", "Saved", MessageBoxButton.OK, MessageBoxImage.Information);
                usernameCheck = false;
                nameCheck = false;
                imageCheck = false;
                datecheck = false;
                genderCheck = false;
                passCheck = false;
                this.NavigationService.Navigate(new Login());

            }

            else
            {
                MessageBox.Show("Please fill enter all Fields !!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }
}
