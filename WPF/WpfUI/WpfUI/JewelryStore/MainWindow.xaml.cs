using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;

namespace JewelryStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userName = UsernameTextBox.Text;
                var pass = PasswordTextBox.Text;

                var userExists = false;

                var databasePath = ConfigurationManager.AppSettings["databasePath"];
                var xelement = XElement.Load(databasePath);
                var users = xelement.Elements();

                foreach (var user in users)
                {
                    if (user.Element("UserName")?.Value == userName && user.Element("Password")?.Value == pass)
                    {
                        userExists = true;
                        new Form2(user.Element("UserType")?.Value).Show();
                        Close();
                    }
                }

                if (!userExists)
                {
                    MessageBox.Show("Check Username or Password");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}