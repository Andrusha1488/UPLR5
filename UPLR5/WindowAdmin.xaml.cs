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
    public partial class WindowAdmin : Window
    {
        ProductsTableAdapter products = new ProductsTableAdapter();
        OrdersTableAdapter orders = new OrdersTableAdapter();
        Product_BrandTableAdapter product_brand = new Product_BrandTableAdapter();
        Product_CategoriesTableAdapter product_categories = new Product_CategoriesTableAdapter();
        Store_AddressTableAdapter store_address = new Store_AddressTableAdapter();
        StorageTableAdapter storage = new StorageTableAdapter();
        PaymentTableAdapter payment = new PaymentTableAdapter();
        EmployeesTableAdapter employees = new EmployeesTableAdapter();
        ProvidersTableAdapter providers = new ProvidersTableAdapter();
        Ordered_ProductsTableAdapter ordered_products = new Ordered_ProductsTableAdapter();
        public WindowAdmin()
        {
            InitializeComponent();
            ProductsDataGrid.ItemsSource = products.GetData();
            OrdersDataGrid.ItemsSource = orders.GetData();
            Product_BrandDataGrid.ItemsSource = product_brand.GetData();
            Product_CategoriesDataGrid.ItemsSource = product_categories.GetData();
            Store_AddressDataGrid.ItemsSource = store_address.GetData();
            StorageDataGrid.ItemsSource = storage.GetData();
            PaymentDataGrid.ItemsSource = payment.GetData();
            EmployeesDataGrid.ItemsSource = employees.GetData();
            ProvidersDataGrid.ItemsSource = providers.GetData();
            Ordered_ProductsDataGrid.ItemsSource = ordered_products.GetData();
        }

        private void DataGridsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (DataGridsComboBox.SelectedIndex)
            {
                case 0:
                    ProductsDataGrid.Visibility = Visibility.Visible;
                    OrdersDataGrid.Visibility = Visibility.Collapsed;
                    Product_BrandDataGrid.Visibility = Visibility.Collapsed;
                    Product_CategoriesDataGrid.Visibility = Visibility.Collapsed;
                    Store_AddressDataGrid.Visibility = Visibility.Collapsed;
                    StorageDataGrid.Visibility = Visibility.Collapsed;
                    PaymentDataGrid.Visibility = Visibility.Collapsed;
                    EmployeesDataGrid.Visibility = Visibility.Collapsed;
                    ProvidersDataGrid.Visibility = Visibility.Collapsed;
                    Ordered_ProductsDataGrid.Visibility = Visibility.Collapsed;
                    Tbx1.Visibility = Visibility.Visible;
                    Tbx2.Visibility = Visibility.Visible;
                    Tbx3.Visibility = Visibility.Visible;
                    Tbx4.Visibility = Visibility.Visible;
                    Tbx5.Visibility = Visibility.Visible;
                    PasswordAdmin.Visibility = Visibility.Collapsed;
                    break;
                case 1:
                    ProductsDataGrid.Visibility = Visibility.Collapsed;
                    OrdersDataGrid.Visibility = Visibility.Visible;
                    Product_BrandDataGrid.Visibility = Visibility.Collapsed;
                    Product_CategoriesDataGrid.Visibility = Visibility.Collapsed;
                    Store_AddressDataGrid.Visibility = Visibility.Collapsed;
                    StorageDataGrid.Visibility = Visibility.Collapsed;
                    PaymentDataGrid.Visibility = Visibility.Collapsed;
                    EmployeesDataGrid.Visibility = Visibility.Collapsed;
                    ProvidersDataGrid.Visibility = Visibility.Collapsed;
                    Ordered_ProductsDataGrid.Visibility = Visibility.Collapsed;
                    Tbx1.Visibility = Visibility.Visible;
                    Tbx2.Visibility = Visibility.Visible;
                    Tbx3.Visibility = Visibility.Visible;
                    Tbx4.Visibility = Visibility.Visible;
                    Tbx5.Visibility = Visibility.Visible;
                    PasswordAdmin.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    ProductsDataGrid.Visibility = Visibility.Collapsed;
                    OrdersDataGrid.Visibility = Visibility.Collapsed;
                    Product_BrandDataGrid.Visibility = Visibility.Visible;
                    Product_CategoriesDataGrid.Visibility = Visibility.Collapsed;
                    Store_AddressDataGrid.Visibility = Visibility.Collapsed;
                    StorageDataGrid.Visibility = Visibility.Collapsed;
                    PaymentDataGrid.Visibility = Visibility.Collapsed;
                    EmployeesDataGrid.Visibility = Visibility.Collapsed;
                    ProvidersDataGrid.Visibility = Visibility.Collapsed;
                    Ordered_ProductsDataGrid.Visibility = Visibility.Collapsed;
                    Tbx1.Visibility = Visibility.Visible;
                    Tbx2.Visibility = Visibility.Visible;
                    Tbx3.Visibility = Visibility.Collapsed;
                    Tbx4.Visibility = Visibility.Collapsed;
                    Tbx5.Visibility = Visibility.Collapsed;
                    PasswordAdmin.Visibility = Visibility.Collapsed;
                    break;
                case 3:
                    ProductsDataGrid.Visibility = Visibility.Collapsed;
                    OrdersDataGrid.Visibility = Visibility.Collapsed;
                    Product_BrandDataGrid.Visibility = Visibility.Collapsed;
                    Product_CategoriesDataGrid.Visibility = Visibility.Visible;
                    Store_AddressDataGrid.Visibility = Visibility.Collapsed;
                    StorageDataGrid.Visibility = Visibility.Collapsed;
                    PaymentDataGrid.Visibility = Visibility.Collapsed;
                    EmployeesDataGrid.Visibility = Visibility.Collapsed;
                    ProvidersDataGrid.Visibility = Visibility.Collapsed;
                    Ordered_ProductsDataGrid.Visibility = Visibility.Collapsed;
                    Tbx1.Visibility = Visibility.Visible;
                    Tbx2.Visibility = Visibility.Collapsed;
                    Tbx3.Visibility = Visibility.Collapsed;
                    Tbx4.Visibility = Visibility.Collapsed;
                    Tbx5.Visibility = Visibility.Collapsed;
                    PasswordAdmin.Visibility = Visibility.Collapsed;
                    break;
                case 4:
                    ProductsDataGrid.Visibility = Visibility.Collapsed;
                    OrdersDataGrid.Visibility = Visibility.Collapsed;
                    Product_BrandDataGrid.Visibility = Visibility.Collapsed;
                    Product_CategoriesDataGrid.Visibility = Visibility.Collapsed;
                    Store_AddressDataGrid.Visibility = Visibility.Visible;
                    StorageDataGrid.Visibility = Visibility.Collapsed;
                    PaymentDataGrid.Visibility = Visibility.Collapsed;
                    EmployeesDataGrid.Visibility = Visibility.Collapsed;
                    ProvidersDataGrid.Visibility = Visibility.Collapsed;
                    Ordered_ProductsDataGrid.Visibility = Visibility.Collapsed;
                    Tbx1.Visibility = Visibility.Visible;
                    Tbx2.Visibility = Visibility.Collapsed;
                    Tbx3.Visibility = Visibility.Collapsed;
                    Tbx4.Visibility = Visibility.Collapsed;
                    Tbx5.Visibility = Visibility.Collapsed;
                    PasswordAdmin.Visibility = Visibility.Collapsed;
                    break;
                case 5:
                    ProductsDataGrid.Visibility = Visibility.Collapsed;
                    OrdersDataGrid.Visibility = Visibility.Collapsed;
                    Product_BrandDataGrid.Visibility = Visibility.Collapsed;
                    Product_CategoriesDataGrid.Visibility = Visibility.Collapsed;
                    Store_AddressDataGrid.Visibility = Visibility.Collapsed;
                    StorageDataGrid.Visibility = Visibility.Visible;
                    PaymentDataGrid.Visibility = Visibility.Collapsed;
                    EmployeesDataGrid.Visibility = Visibility.Collapsed;
                    ProvidersDataGrid.Visibility = Visibility.Collapsed;
                    Ordered_ProductsDataGrid.Visibility = Visibility.Collapsed;
                    Tbx1.Visibility = Visibility.Visible;
                    Tbx2.Visibility = Visibility.Visible;
                    Tbx3.Visibility = Visibility.Visible;
                    Tbx4.Visibility = Visibility.Collapsed;
                    Tbx5.Visibility = Visibility.Collapsed;
                    PasswordAdmin.Visibility = Visibility.Collapsed;
                    break;
                case 6:
                    ProductsDataGrid.Visibility = Visibility.Collapsed;
                    OrdersDataGrid.Visibility = Visibility.Collapsed;
                    Product_BrandDataGrid.Visibility = Visibility.Collapsed;
                    Product_CategoriesDataGrid.Visibility = Visibility.Collapsed;
                    Store_AddressDataGrid.Visibility = Visibility.Collapsed;
                    StorageDataGrid.Visibility = Visibility.Collapsed;
                    PaymentDataGrid.Visibility = Visibility.Visible;
                    EmployeesDataGrid.Visibility = Visibility.Collapsed;
                    ProvidersDataGrid.Visibility = Visibility.Collapsed;
                    Ordered_ProductsDataGrid.Visibility = Visibility.Collapsed;
                    Tbx1.Visibility = Visibility.Visible;
                    Tbx2.Visibility = Visibility.Collapsed;
                    Tbx3.Visibility = Visibility.Collapsed;
                    Tbx4.Visibility = Visibility.Collapsed;
                    Tbx5.Visibility = Visibility.Collapsed;
                    PasswordAdmin.Visibility = Visibility.Collapsed;
                    break;
                case 7:
                    ProductsDataGrid.Visibility = Visibility.Collapsed;
                    OrdersDataGrid.Visibility = Visibility.Collapsed;
                    Product_BrandDataGrid.Visibility = Visibility.Collapsed;
                    Product_CategoriesDataGrid.Visibility = Visibility.Collapsed;
                    Store_AddressDataGrid.Visibility = Visibility.Collapsed;
                    StorageDataGrid.Visibility = Visibility.Collapsed;
                    PaymentDataGrid.Visibility = Visibility.Collapsed;
                    EmployeesDataGrid.Visibility = Visibility.Visible;
                    ProvidersDataGrid.Visibility = Visibility.Collapsed;
                    Ordered_ProductsDataGrid.Visibility = Visibility.Collapsed;
                    Tbx1.Visibility = Visibility.Visible;
                    Tbx2.Visibility = Visibility.Collapsed;
                    PasswordAdmin.Visibility = Visibility.Visible;
                    Tbx3.Visibility = Visibility.Visible;
                    Tbx4.Visibility = Visibility.Collapsed;
                    Tbx5.Visibility = Visibility.Collapsed;
                    break;
                case 8:
                    ProductsDataGrid.Visibility = Visibility.Collapsed;
                    OrdersDataGrid.Visibility = Visibility.Collapsed;
                    Product_BrandDataGrid.Visibility = Visibility.Collapsed;
                    Product_CategoriesDataGrid.Visibility = Visibility.Collapsed;
                    Store_AddressDataGrid.Visibility = Visibility.Collapsed;
                    StorageDataGrid.Visibility = Visibility.Collapsed;
                    PaymentDataGrid.Visibility = Visibility.Collapsed;
                    EmployeesDataGrid.Visibility = Visibility.Collapsed;
                    ProvidersDataGrid.Visibility = Visibility.Visible;
                    Ordered_ProductsDataGrid.Visibility = Visibility.Collapsed;
                    Tbx1.Visibility = Visibility.Visible;
                    Tbx2.Visibility = Visibility.Visible;
                    Tbx3.Visibility = Visibility.Collapsed;
                    Tbx4.Visibility = Visibility.Collapsed;
                    Tbx5.Visibility = Visibility.Collapsed;
                    PasswordAdmin.Visibility = Visibility.Collapsed;
                    break;
                case 9:
                    ProductsDataGrid.Visibility = Visibility.Collapsed;
                    OrdersDataGrid.Visibility = Visibility.Collapsed;
                    Product_BrandDataGrid.Visibility = Visibility.Collapsed;
                    Product_CategoriesDataGrid.Visibility = Visibility.Collapsed;
                    Store_AddressDataGrid.Visibility = Visibility.Collapsed;
                    StorageDataGrid.Visibility = Visibility.Collapsed;
                    PaymentDataGrid.Visibility = Visibility.Collapsed;
                    EmployeesDataGrid.Visibility = Visibility.Collapsed;
                    ProvidersDataGrid.Visibility = Visibility.Collapsed;
                    Ordered_ProductsDataGrid.Visibility = Visibility.Visible;
                    Tbx1.Visibility = Visibility.Visible;
                    Tbx2.Visibility = Visibility.Visible;
                    Tbx3.Visibility = Visibility.Visible;
                    Tbx4.Visibility = Visibility.Collapsed;
                    Tbx5.Visibility = Visibility.Collapsed;
                    PasswordAdmin.Visibility = Visibility.Collapsed;
                    break;
            }
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
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            bool ContainsLetter(string input)
            {
                return input.Any(char.IsLetter);
            }

            bool ContainsSymbol(string input)
            {
                return input.Any(char.IsSymbol);
            }

            bool ContainsNumber(string input)
            {
                return input.Any(char.IsDigit);
            }



            if (ProductsDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsNumber(Tbx1.Text) || Convert.ToInt32(Tbx1.Text) <= 0)
                {
                    Tbx1.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx2.Text) || Convert.ToInt32(Tbx2.Text) <= 0)
                {
                    Tbx2.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx4.Text) || Convert.ToInt32(Tbx4.Text) <= 0)
                {
                    Tbx4.Text = string.Empty;
                }
                else
                {
                    products.InsertQuery1(Convert.ToInt32(Tbx1.Text), Convert.ToInt32(Tbx2.Text), Tbx3.Text, Convert.ToInt32(Tbx4.Text), Tbx5.Text);
                    ProductsDataGrid.ItemsSource = products.GetData();
                }
            }
            if (OrdersDataGrid.Visibility == Visibility.Visible)
            {
                string input = Tbx5.Text;
                DateTime date;
                if (!DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    Tbx5.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx1.Text) || Convert.ToInt32(Tbx1.Text) <= 0)
                {
                    Tbx1.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx2.Text) || Convert.ToInt32(Tbx2.Text) <= 0)
                {
                    Tbx2.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx3.Text) || Convert.ToInt32(Tbx3.Text) <= 0)
                {
                    Tbx3.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx4.Text) || Convert.ToInt32(Tbx4.Text) <= 0)
                {
                    Tbx4.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx5.Text))
                {
                    Tbx5.Text = string.Empty;
                }

                else
                {
                    orders.InsertQuery2(Convert.ToInt32(Tbx1.Text), Convert.ToInt32(Tbx2.Text), Convert.ToInt32(Tbx3.Text), Convert.ToInt32(Tbx4.Text), Tbx5.Text);
                    OrdersDataGrid.ItemsSource = orders.GetData();
                }
            }
            if (Product_BrandDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsNumber(Tbx2.Text) || Convert.ToInt32(Tbx2.Text) <= 0 || Convert.ToInt32(Tbx2.Text) > 2024)
                {
                    Tbx2.Text = string.Empty;
                }
                else
                {
                    product_brand.InsertQuery3(Tbx1.Text, Convert.ToInt32(Tbx2.Text));
                    Product_BrandDataGrid.ItemsSource = product_brand.GetData();
                }
            }
            if (Product_CategoriesDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsLetter(Tbx1.Text))
                {
                    Tbx1.Text = string.Empty;
                }
                else
                {
                    product_categories.InsertQuery4(Tbx1.Text);
                    Product_CategoriesDataGrid.ItemsSource = product_categories.GetData();
                }
            }
            if (Store_AddressDataGrid.Visibility == Visibility.Visible)
            {
                store_address.InsertQuery5(Tbx1.Text);
                Store_AddressDataGrid.ItemsSource = store_address.GetData();
            }
            if (StorageDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsNumber(Tbx1.Text) || Convert.ToInt32(Tbx1.Text) <= 0)
                {
                    Tbx1.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx2.Text) || Convert.ToInt32(Tbx2.Text) <= 0)
                {
                    Tbx2.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx3.Text) || Convert.ToInt32(Tbx3.Text) <= 0)
                {
                    Tbx3.Text = string.Empty;
                }
                else
                {
                    storage.InsertQuery6(Convert.ToInt32(Tbx1.Text), Convert.ToInt32(Tbx2.Text), Convert.ToInt32(Tbx3.Text));
                    StorageDataGrid.ItemsSource = storage.GetData();
                }
            }
            if (PaymentDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsLetter(Tbx1.Text))
                {
                    Tbx1.Text = string.Empty;
                }
                else
                {

                    payment.InsertQuery7(Tbx1.Text);
                    PaymentDataGrid.ItemsSource = payment.GetData();
                }
            }
            if (EmployeesDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsLetter(Tbx3.Text))
                {
                    Tbx3.Text = string.Empty;
                }
                else
                {
                    employees.InsertQuery8(Tbx1.Text, Convert.ToString(ComputeSHA256Hash(PasswordAdmin.Password)), Tbx3.Text);
                    EmployeesDataGrid.ItemsSource = employees.GetData();
                }
            }
            if (ProvidersDataGrid.Visibility == Visibility.Visible)
            {
                string input = Tbx2.Text;
                Regex regex = new Regex(@"^8\d{10}$");
                if (!regex.IsMatch(input) || !ContainsNumber(Tbx2.Text))
                {
                    Tbx2.Text = string.Empty;
                }
                else
                {
                    providers.InsertQuery9(Tbx1.Text, Tbx2.Text);
                    ProvidersDataGrid.ItemsSource = providers.GetData();

                }
            }
            if (Ordered_ProductsDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsNumber(Tbx1.Text) || Convert.ToInt32(Tbx1.Text) <= 0)
                {
                    Tbx1.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx2.Text) || Convert.ToInt32(Tbx2.Text) <= 0)
                {
                    Tbx2.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx3.Text) || Convert.ToInt32(Tbx3.Text) <= 0)
                {
                    Tbx3.Text = string.Empty;
                }
                else
                {
                  
                    ordered_products.InsertQuery10(Convert.ToInt32(Tbx1.Text), Convert.ToInt32(Tbx2.Text), Convert.ToInt32(Tbx3.Text));
                    Ordered_ProductsDataGrid.ItemsSource = ordered_products.GetData();

                }


            }
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            bool ContainsLetter(string input)
            {
                return input.Any(char.IsLetter);
            }

            bool ContainsSymbol(string input)
            {
                return input.Any(char.IsSymbol);
            }

            bool ContainsNumber(string input)
            {
                return input.Any(char.IsDigit);
            }

            if (ProductsDataGrid.Visibility == Visibility.Visible)
            {
                object ID1 = (ProductsDataGrid.SelectedItem as DataRowView).Row[0];
                if (!ContainsNumber(Tbx1.Text) || Convert.ToInt32(Tbx1.Text) <= 0)
                {
                    Tbx1.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx2.Text) || Convert.ToInt32(Tbx2.Text) <= 0)
                {
                    Tbx2.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx4.Text) || Convert.ToInt32(Tbx4.Text) <= 0)
                {
                    Tbx4.Text = string.Empty;
                }
                else
                {
                    products.UpdateQuery1(Convert.ToInt32(Tbx1.Text), Convert.ToInt32(Tbx2.Text), Tbx3.Text, Convert.ToInt32(Tbx4.Text), Tbx5.Text, Convert.ToInt32(ID1));
                    ProductsDataGrid.ItemsSource = products.GetData();
                }
            }
            if (OrdersDataGrid.Visibility == Visibility.Visible)
            {
                object ID2 = (OrdersDataGrid.SelectedItem as DataRowView).Row[0];
                string input = Tbx5.Text;
                DateTime date;
                if (!DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    Tbx5.Text = string.Empty;
                }
                if (!ContainsNumber(Tbx1.Text) || Convert.ToInt32(Tbx1.Text) <= 0)
                {
                    Tbx1.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx2.Text) || Convert.ToInt32(Tbx2.Text) <= 0)
                {
                    Tbx2.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx3.Text) || Convert.ToInt32(Tbx3.Text) <= 0)
                {
                    Tbx3.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx4.Text) || Convert.ToInt32(Tbx4.Text) <= 0)
                {
                    Tbx4.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx5.Text))
                {
                    Tbx5.Text = string.Empty;
                }

                else
                {
                    orders.UpdateQuery2(Convert.ToInt32(Tbx1.Text), Convert.ToInt32(Tbx2.Text), Convert.ToInt32(Tbx3.Text), Convert.ToInt32(Tbx4.Text), Tbx5.Text, Convert.ToInt32(ID2));
                    OrdersDataGrid.ItemsSource = orders.GetData();
                }
            }
            if (Product_BrandDataGrid.Visibility == Visibility.Visible)
            {

                object ID3 = (Product_BrandDataGrid.SelectedItem as DataRowView).Row[0];
                if (!ContainsNumber(Tbx2.Text) || Convert.ToInt32(Tbx2.Text) <= 0 || Convert.ToInt32(Tbx2.Text) > 2024)
                {
                    Tbx2.Text = string.Empty;
                }
                else
                {
                    product_brand.UpdateQuery3(Tbx1.Text, Convert.ToInt32(Tbx2.Text), Convert.ToInt32(ID3));
                    Product_BrandDataGrid.ItemsSource = product_brand.GetData();
                }
            }
            if (Product_CategoriesDataGrid.Visibility == Visibility.Visible)
            {
                object ID4 = (Product_CategoriesDataGrid.SelectedItem as DataRowView).Row[0];
                if (!ContainsLetter(Tbx1.Text))
                {
                    Tbx1.Text = string.Empty;
                }
                else
                {
                    product_categories.UpdateQuery4(Tbx1.Text, Convert.ToInt32(ID4));
                    Product_CategoriesDataGrid.ItemsSource = product_categories.GetData();
                }
            }
            if (Store_AddressDataGrid.Visibility == Visibility.Visible)
            {
                object ID5 = (Store_AddressDataGrid.SelectedItem as DataRowView).Row[0];

                store_address.UpdateQuery5(Tbx1.Text, Convert.ToInt32(ID5));
                Store_AddressDataGrid.ItemsSource = store_address.GetData();

            }
            if (StorageDataGrid.Visibility == Visibility.Visible)
            {
                object ID6 = (StorageDataGrid.SelectedItem as DataRowView).Row[0];
                if (!ContainsNumber(Tbx1.Text) || Convert.ToInt32(Tbx1.Text) <= 0)
                {
                    Tbx1.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx2.Text) || Convert.ToInt32(Tbx2.Text) <= 0)
                {
                    Tbx2.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx3.Text) || Convert.ToInt32(Tbx1.Text) <= 0)
                {
                    Tbx3.Text = string.Empty;
                }
                else
                {
                    storage.UpdateQuery6(Convert.ToInt32(Tbx1.Text), Convert.ToInt32(Tbx2.Text), Convert.ToInt32(Tbx3.Text), Convert.ToInt32(ID6));
                    StorageDataGrid.ItemsSource = storage.GetData();
                }

            }
            if (PaymentDataGrid.Visibility == Visibility.Visible)
            {
                object ID7 = (PaymentDataGrid.SelectedItem as DataRowView).Row[0];
                if (!ContainsLetter(Tbx1.Text))
                {
                    Tbx1.Text = string.Empty;
                }
                else
                {

                    payment.UpdateQuery7(Tbx1.Text, Convert.ToInt32(ID7));
                    PaymentDataGrid.ItemsSource = payment.GetData();
                }
            }
            if (EmployeesDataGrid.Visibility == Visibility.Visible)
            {
                object ID8 = (EmployeesDataGrid.SelectedItem as DataRowView).Row[0];
                if (!ContainsLetter(Tbx3.Text))
                {
                    Tbx3.Text = string.Empty;
                }
                else
                {
                    employees.UpdateQuery8(Tbx1.Text, Convert.ToString(ComputeSHA256Hash(PasswordAdmin.Password)), Tbx3.Text, Convert.ToInt32(ID8));
                    EmployeesDataGrid.ItemsSource = employees.GetData();
                }
            }
            if (ProvidersDataGrid.Visibility == Visibility.Visible)
            {
                object ID9 = (ProvidersDataGrid.SelectedItem as DataRowView).Row[0];
                string input = Tbx2.Text;
                Regex regex = new Regex(@"^8\d{10}$");
                if (!regex.IsMatch(input) || !ContainsNumber(Tbx2.Text))
                {
                    Tbx2.Text = string.Empty;
                }
                else
                {
                    providers.UpdateQuery9(Tbx1.Text, Tbx2.Text, Convert.ToInt32(ID9));
                    ProvidersDataGrid.ItemsSource = providers.GetData();
                }
            }
            if (Ordered_ProductsDataGrid.Visibility == Visibility.Visible)
            {
                object ID10 = (Ordered_ProductsDataGrid.SelectedItem as DataRowView).Row[0];
                if (!ContainsNumber(Tbx1.Text) || Convert.ToInt32(Tbx1.Text) <= 0)
                {
                    Tbx1.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx2.Text) || Convert.ToInt32(Tbx2.Text) <= 0)
                {
                    Tbx2.Text = string.Empty;
                }
                else if (!ContainsNumber(Tbx3.Text) || Convert.ToInt32(Tbx3.Text) <= 0)
                {
                    Tbx3.Text = string.Empty;
                }
                else
                {
                    ordered_products.UpdateQuery10(Convert.ToInt32(Tbx1.Text), Convert.ToInt32(Tbx2.Text), Convert.ToInt32(Tbx3.Text), Convert.ToInt32(ID10));
                    Ordered_ProductsDataGrid.ItemsSource = ordered_products.GetData();

                }


            }
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (ProductsDataGrid.Visibility == Visibility.Visible)
            {
                object ID1 = (ProductsDataGrid.SelectedItem as DataRowView).Row[0];
                products.DeleteQuery1(Convert.ToInt32(ID1));
                ProductsDataGrid.ItemsSource = products.GetData();
            }
            if (OrdersDataGrid.Visibility == Visibility.Visible)
            {
                object ID2 = (OrdersDataGrid.SelectedItem as DataRowView).Row[0];
                orders.DeleteQuery2(Convert.ToInt32(ID2));
                OrdersDataGrid.ItemsSource = orders.GetData();
            }
            if (Product_BrandDataGrid.Visibility == Visibility.Visible)
            {
                object ID3 = (Product_BrandDataGrid.SelectedItem as DataRowView).Row[0];
                product_brand.DeleteQuery3(Convert.ToInt32(ID3));
                Product_BrandDataGrid.ItemsSource = product_brand.GetData();
            }
            if (Product_CategoriesDataGrid.Visibility == Visibility.Visible)
            {
                object ID4 = (Product_CategoriesDataGrid.SelectedItem as DataRowView).Row[0];
                product_categories.DeleteQuery4(Convert.ToInt32(ID4));
                Product_CategoriesDataGrid.ItemsSource = product_categories.GetData();
            }
            if (Store_AddressDataGrid.Visibility == Visibility.Visible)
            {
                object ID5 = (Store_AddressDataGrid.SelectedItem as DataRowView).Row[0];
                store_address.DeleteQuery5(Convert.ToInt32(ID5));
                Store_AddressDataGrid.ItemsSource = store_address.GetData();
            }
            if (StorageDataGrid.Visibility == Visibility.Visible)
            {
                object ID6 = (StorageDataGrid.SelectedItem as DataRowView).Row[0];
                storage.DeleteQuery6(Convert.ToInt32(ID6));
                StorageDataGrid.ItemsSource = storage.GetData();
            }
            if (PaymentDataGrid.Visibility == Visibility.Visible)
            {
                object ID7 = (PaymentDataGrid.SelectedItem as DataRowView).Row[0];
                payment.DeleteQuery7(Convert.ToInt32(ID7));
                PaymentDataGrid.ItemsSource = payment.GetData();
            }
            if (EmployeesDataGrid.Visibility == Visibility.Visible)
            {
                object ID8 = (EmployeesDataGrid.SelectedItem as DataRowView).Row[0];
                employees.DeleteQuery8(Convert.ToInt32(ID8));
                EmployeesDataGrid.ItemsSource = employees.GetData();
            }
            if (ProvidersDataGrid.Visibility == Visibility.Visible)
            {
                object ID9 = (ProvidersDataGrid.SelectedItem as DataRowView).Row[0];
                providers.DeleteQuery9(Convert.ToInt32(ID9));
                ProvidersDataGrid.ItemsSource = providers.GetData();
            }
            if (Ordered_ProductsDataGrid.Visibility == Visibility.Visible)
            {
                object ID10 = (Ordered_ProductsDataGrid.SelectedItem as DataRowView).Row[0];
                ordered_products.DeleteQuery10(Convert.ToInt32(ID10));
                Ordered_ProductsDataGrid.ItemsSource = ordered_products.GetData();
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Window adminWindow = Window.GetWindow(this); 
            adminWindow.Close();
        }



    }


}

