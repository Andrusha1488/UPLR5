   M S B A M L   `   `   `  ����@  <UPLR5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UPLR5UPLR5  5   	       UPLR5.WindowAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:UPLR5     5   	     � Title$  WindowAdmin��5   	   $	��450��6   $	��800��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Center=�6   $��Right=�60   5      �� 5   
   -   5        $��Добавить��5      $��2��6;   �� 5   
   -   5        $��Изменить��5      $��3��6;   �� 5   
   -   5        $��Удалить��5      $��4��6:   &   System.Windows.Controls.DataGrid  5      -   5          Name$ ProductsDataGrid��5      $y�	Collapsed=�61     5   
   -   5        $ OrdersDataGrid��5      $y�	Collapsed=�6+     5   
   -   5        $ Product_BrandDataGrid��5      $y�	Collapsed=�62     5   
   -   5        $  Product_CategoriesDataGrid��5      $y�	Collapsed=�67     5    
   -   5        $ Store_AddressDataGrid��5       $y�	Collapsed=�62     5!   
   -	   5        $ StorageDataGrid��5!      $y�	Collapsed=�6,     5"   
   -
   5        $ PaymentDataGrid��5"      $y�	Collapsed=�6,     5#   
   -   5        $ EmployeesDataGrid��5#      $y�	Collapsed=�6.     5$   
   -   5        $ ProvidersDataGrid��5$      $y�	Collapsed=�6.     5%   
   -   5        $ Ordered_ProductsDataGrid��5%      $y�	Collapsed=�65   �� 5'   
   -   5         ��Name$ DataGridsComboBox��5'      $��Bottom=�6d   $��Center=�6   $��0��6�   .@�5(      �� $��Products��6   �� 5)      $��Orders��6   �� 5*      $��Product_Brands��6   �� 5+      $��Product_Categories��6   �� 5,      $��Store_Address��6   �� 5-      $��Storage��6   �� 5.      $��Payment��6   �� 5/      $��	Employees��6   �� 50      $��	Providers��6   �� 51      $��Ordered_Products��6   52      �� 54   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Bottom=�6K   $��1��6f   .+�55      �� -   5         ��Name$
 Tbx1��55      $%��Введите значение��6$   �� 56      -   5        $
 Tbx2��56      $%��Введите значение��6$   �� 57      -   5        $ TbxIdP��57      $%��Введите значение��6&   $y�	Collapsed=�6>   G� 58      -   5         G�Name$ PasswordAdmin��58      $��40��61   $y�	Collapsed=�6<   �� 59      -   5        $
 Tbx3��59      $%��Введите значение��6$   �� 5:      -   5        $
 Tbx4��5:      $%��Введите значение��6$   �� 5;      -   5        $
 Tbx5��5;      $%��Введите значение��6$   �� 5<      -   5        $4��.Вернуться на авторизацию��5<      $��1��6S   5?      5@      5A      