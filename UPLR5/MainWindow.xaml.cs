using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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
using UPLR5.FitnessCentreDataSetTableAdapters;

namespace UPLR5
{
    public partial class MainWindow : Window
    {
        EmployeesTableAdapter employees = new EmployeesTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }
        private static StringBuilder ComputeSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder;
            }
        }
        
        private void Button_Authorize(object sender, RoutedEventArgs e)
        {
            var allLogins = employees.GetData().Rows;
            bool credentialsFound = false;

            for (int i = 0; i < allLogins.Count; i++)
            {

            StringBuilder hashpassword = ComputeSHA256Hash(Password.Password);

                if (allLogins[i][1].ToString() == Login.Text && 
                    allLogins[i][2].ToString() == hashpassword.ToString())
                {
                    int roleID = (int)allLogins[i][0];
                    credentialsFound = true;

                    switch (roleID)
                    {
                        case 1:
                            WindowAdmin admin = new WindowAdmin();
                            admin.Show();
                            break;
                        case 2:
                            WindowKassa kassa = new WindowKassa();
                            kassa.Show();
                            break;

                    }
                }
            }
            if (!credentialsFound)
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }


}

