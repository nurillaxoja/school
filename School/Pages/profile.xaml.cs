using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using School.dbHelper;
using School.dbModules;
using School.MainView;

namespace School.Pages
{
    /// <summary>
    /// Interaction logic for profile.xaml
    /// </summary>
    
    public partial class profile : Page
    {
        string currentUser = CurrentUserHelper.Get().curName;
        int idCur = CurrentUserHelper.Get().Id;

        public profile()
        {
            InitializeComponent();
            imgInit();
            txtUserName.Text = currentUser;
            datePicerProfile.SelectedDate = UsersHelper.LogIn(currentUser).dateOfBrith;
        }

        private void changePhotoClick(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            //open.InitialDirectory = "C:\\";
            open.Filter = "JPG files (*.jpg)|.jpg|PNG files (*.png)|.png" +
                "|All files (*.*)|*.*";
            open.FilterIndex = 3;
            //open.ShowDialog();

            if (open.ShowDialog() == true)
            {
                if (open.CheckFileExists)
                {
                    string startupUploadsPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\uploads\\images\\";

                    File.Delete(startupUploadsPath + currentUser + ".jpg");
                    File.Copy(open.FileName, startupUploadsPath + currentUser + ".jpg");

                }

            }
            imgInit();
        }
        public void imgInit()
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory + "\\uploads\\images\\" + currentUser + ".jpg";
            var source = new BitmapImage();
            source.BeginInit();
            source.CreateOptions = BitmapCreateOptions.IgnoreImageCache; // srazu almashadi
            source.UriSource = new Uri(path, UriKind.RelativeOrAbsolute);
            source.CacheOption = BitmapCacheOption.OnLoad ; // chache sazdat qiladi
            source.EndInit();  // Required for full initialization to complete at this time
            var img = new System.Windows.Controls.Image { Source = source };
            imgProfile.Source = source;
                
        }
      
        private void cancelClick(object sender, System.Windows.RoutedEventArgs e)
        {
            txtUserName.Text = UsersHelper.LogIn(currentUser).userName;
            datePicerProfile.SelectedDate = UsersHelper.LogIn(currentUser).dateOfBrith;
        }

        private void saveClick(object sender, System.Windows.RoutedEventArgs e)
        {
            
            UsersHelper.update(txtUserName.Text, idCur,  datePicerProfile.SelectedDate.Value );
            string startupUploadsPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\uploads\\images\\" ;
            FileInfo fi = new FileInfo(startupUploadsPath + currentUser + ".jpg");
            if (fi.Exists)
            {
                fi.MoveTo(startupUploadsPath + txtUserName.Text + ".jpg");
                CurrentUserHelper.Adduser(txtUserName.Text);
                MessageBox.Show("Changes was applied", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }
    }
}
