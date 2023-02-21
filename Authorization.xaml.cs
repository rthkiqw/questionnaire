using System;
using System.Collections.Generic;
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

namespace questionnaire
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Account account = new Account();
                account.login = tbLogin.Text.Trim();
                account.password = pbPassword.Password.Trim();
                if (account.GetAccount(account))
                {
                    MessageBox.Show("Все четко");
                }
                else
                {
                    MessageBox.Show("Все плохо");
                }
            }
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Account account = new Account();
                account.login = tbLogin.Text.Trim();
                account.password = pbPassword.Password.Trim();
                if (account.GetAccount(account))
                {
                    MessageBox.Show("Все четко");
                }
                else
                {
                    MessageBox.Show("Все плохо");
                }
            }
        }
    }
}
