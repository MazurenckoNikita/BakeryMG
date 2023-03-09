using System;
using System.Runtime.Remoting.Contexts;
using System.Windows;
using Garuchava_Mazurenko_Bakery.DB;
using Garuchava_Mazurenko_Bakery.Windows.ClientWindows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using static Garuchava_Mazurenko_Bakery.ClassHelper.EFClass;
namespace Garuchava_Mazurenko_Bakery
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
private void Button_Click(object sender, RoutedEventArgs e)
        {

            var userAuth = ContextDB.UserAccount.ToList()
            .Where(i => i.Email == loginTb.Text && i.Password == PassTB.Password)
            .FirstOrDefault();

            if (loginTb.Text.Length > 0) 
            {
                if (PassTB.Password.Length > 0)       
                {              
                    
                    if (string.IsNullOrWhiteSpace(loginTb.Text))
                    {
                        MessageBox.Show("Пользователя не найден");     
                    }
                    else MessageBox.Show("Пользователь авторизовался");
                }
                else MessageBox.Show("Введите пароль"); 
            }
            else MessageBox.Show("Введите логин"); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowRegistration windowRegistration = new WindowRegistration();
            windowRegistration.Show();
            this.Close();   
        }

        private void loginTb_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            
        }

        private void loginTb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (loginTb.Text == "Username")
            {
                loginTb.Clear();
            }
        }

        private void loginTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(loginTb.Text))
            {
                loginTb.Text = "Username";
            }
        }

        private void PassTB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PassTB.Password == "Password")
            {
                PassTB.Clear();
            }
        }

        private void PassTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(PassTB.Password))
            {
                PassTB.Password = "Password";
            }
        }
    }
}


