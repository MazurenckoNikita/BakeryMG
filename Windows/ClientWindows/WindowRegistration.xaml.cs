using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static Garuchava_Mazurenko_Bakery.ClassHelper.EFClass;

namespace Garuchava_Mazurenko_Bakery.Windows.ClientWindows
{
    /// <summary>
    /// Логика взаимодействия для WindowRegistration.xaml
    /// </summary>
    public partial class WindowRegistration : Window
    {
        public WindowRegistration()
        {
            InitializeComponent();
        }


        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Tb_login.Content.ToString()))
            {
                MessageBox.Show("Пустой логин");
                return;
            }

            ContextDB.UserAccount.Add(new DB.UserAccount()
            {
                Login = Tb_login.Content.ToString(),
                Password = PassTB.Password,
                Email = Tb_login.Content.ToString(),
            });
            ContextDB.SaveChanges();

                MessageBox.Show("OK");

            }
        }
    }

