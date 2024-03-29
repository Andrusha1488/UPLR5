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
using System.Windows.Shapes;
using UPLR5.FitnessCentreDataSetTableAdapters;

namespace UPLR5
{
    /// <summary>
    /// Логика взаимодействия для WindowKassa.xaml
    /// </summary>
    public partial class WindowKassa : Window
    {
        public WindowKassa()
        {
            InitializeComponent();
            ProductsDataGrid.ItemsSource = products.GetData();
            OrdersDataGrid.ItemsSource = orders.GetData();
            Product_BrandDataGrid.ItemsSource = product_brand.GetData();
            Product_CategoriesDataGrid.ItemsSource = product_categories.GetData();
            StorageDataGrid.ItemsSource = storage.GetData();
            PaymentDataGrid.ItemsSource = payment.GetData();
            Ordered_ProductsDataGrid.ItemsSource = ordered_products.GetData();
        }
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
        
        

        private void DataGridsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (DataGridsComboBox.SelectedIndex)
            {
                case 0:
                    ProductsDataGrid.Visibility = Visibility.Visible;
                    OrdersDataGrid.Visibility = Visibility.Collapsed;
                    Product_BrandDataGrid.Visibility = Visibility.Collapsed;
                    Product_CategoriesDataGrid.Visibility = Visibility.Collapsed;
                    StorageDataGrid.Visibility = Visibility.Collapsed;
                    PaymentDataGrid.Visibility = Visibility.Collapsed;
                    Ordered_ProductsDataGrid.Visibility = Visibility.Collapsed;
                    break;
                case 1:
                    ProductsDataGrid.Visibility = Visibility.Collapsed;
                    OrdersDataGrid.Visibility = Visibility.Visible;
                    Product_BrandDataGrid.Visibility = Visibility.Collapsed;
                    Product_CategoriesDataGrid.Visibility = Visibility.Collapsed;
                    StorageDataGrid.Visibility = Visibility.Collapsed;
                    PaymentDataGrid.Visibility = Visibility.Collapsed;
                    Ordered_ProductsDataGrid.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    ProductsDataGrid.Visibility = Visibility.Collapsed;
                    OrdersDataGrid.Visibility = Visibility.Collapsed;
                    Product_BrandDataGrid.Visibility = Visibility.Visible;
                    Product_CategoriesDataGrid.Visibility = Visibility.Collapsed;
                    StorageDataGrid.Visibility = Visibility.Collapsed;
                    PaymentDataGrid.Visibility = Visibility.Collapsed;
                    Ordered_ProductsDataGrid.Visibility = Visibility.Collapsed;
                    break;
                case 3:
                    ProductsDataGrid.Visibility = Visibility.Collapsed;
                    OrdersDataGrid.Visibility = Visibility.Collapsed;
                    Product_BrandDataGrid.Visibility = Visibility.Collapsed;
                    Product_CategoriesDataGrid.Visibility = Visibility.Visible;
                    StorageDataGrid.Visibility = Visibility.Collapsed;
                    PaymentDataGrid.Visibility = Visibility.Collapsed;
                    Ordered_ProductsDataGrid.Visibility = Visibility.Collapsed;
                    break;
                case 4:
                    ProductsDataGrid.Visibility = Visibility.Collapsed;
                    OrdersDataGrid.Visibility = Visibility.Collapsed;
                    Product_BrandDataGrid.Visibility = Visibility.Collapsed;
                    Product_CategoriesDataGrid.Visibility = Visibility.Collapsed;
                    StorageDataGrid.Visibility = Visibility.Visible;
                    PaymentDataGrid.Visibility = Visibility.Collapsed;
                    Ordered_ProductsDataGrid.Visibility = Visibility.Collapsed;
                    break;
                case 5:
                    ProductsDataGrid.Visibility = Visibility.Collapsed;
                    OrdersDataGrid.Visibility = Visibility.Collapsed;
                    Product_BrandDataGrid.Visibility = Visibility.Collapsed;
                    Product_CategoriesDataGrid.Visibility = Visibility.Collapsed;
                    StorageDataGrid.Visibility = Visibility.Collapsed;
                    PaymentDataGrid.Visibility = Visibility.Visible;
                    Ordered_ProductsDataGrid.Visibility = Visibility.Collapsed;
                    break;
                case 6:
                    ProductsDataGrid.Visibility = Visibility.Collapsed;
                    OrdersDataGrid.Visibility = Visibility.Collapsed;
                    Product_BrandDataGrid.Visibility = Visibility.Collapsed;
                    Product_CategoriesDataGrid.Visibility = Visibility.Collapsed;
                    StorageDataGrid.Visibility = Visibility.Collapsed;
                    PaymentDataGrid.Visibility = Visibility.Collapsed;
                    Ordered_ProductsDataGrid.Visibility = Visibility.Visible;
                    break;
            }
        }
            private void Button4_Click(object sender, RoutedEventArgs e)
            {
                Window Kassa = Window.GetWindow(this);
                Kassa.Close();
            }
    }
}
