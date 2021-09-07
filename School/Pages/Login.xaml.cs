using School.dbHelper;
using School.dbModules;
using School.MainView;
using System.Windows;
using System.Windows.Controls;

namespace School.Pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();

        }
        private void SignUp(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Signup());
        }

        string value;
      
        private void Login_Click(object sender, RoutedEventArgs e)
        {

            if (texUserName.Text != null && txtPassword.Password != null)
            {
                value = texUserName.Text;
                string username = "";
                string password = "";

                UsersModule userModule = UsersHelper.LogIn(value);
                if (userModule != null)
                {
                    username = userModule.userName;
                    password = userModule.password;

                    if (username == value && txtPassword.Password == password)
                    {

                        Logger lg = new Logger();
                        lg.WriteLogin(username);
                        //CurrentUserHelper userHelp = new CurrentUserHelper();
                        CurrentUserHelper.Adduser(username);

                        Main main = new Main();
                        var v = Application.Current.Windows[0];
                        v.Hide();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or password was wrong" +
                            " please try again !!", "Error", MessageBoxButton.OK, MessageBoxImage.Stop);
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Please enter all fields !!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txtPassword.Password = "";
            }
        }
    }
}
