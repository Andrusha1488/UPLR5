   M S B A M L   `   `   `  ����@  <UPLR5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UPLR5UPLR5  5   	       UPLR5.WindowKassa   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:UPLR5     5   	     � Title$  WindowKassa��5   	   $	��450��6   $	��800��6*   .��5	      �  � RowDefinitions 5
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
   &   System.Windows.Controls.DataGrid  -   5          Name$ ProductsDataGrid��5      $y�	Collapsed=�6-     5   
   -   5        $ OrdersDataGrid��5      $y�	Collapsed=�6+     5   
   -   5        $ Product_BrandDataGrid��5      $y�	Collapsed=�62     5   
   -   5        $  Product_CategoriesDataGrid��5      $y�	Collapsed=�67     5   
   -   5        $ StorageDataGrid��5      $y�	Collapsed=�6,     5   
   -   5        $ PaymentDataGrid��5      $y�	Collapsed=�6,     5   
   -   5        $ Ordered_ProductsDataGrid��5      $y�	Collapsed=�65   �� 5   
   -   5        $4��.Вернуться на авторизацию��5      $��1��6K   �� 5   
   -	   5         ��Name$ DataGridsComboBox��5      $��Bottom=�6d   $��Center=�6   $��0��6�   .@�5       �� $��Products��6   �� 5!      $��Orders��6   �� 5"      $��Product_Brands��6   �� 5#      $��Product_Categories��6   �� 5$      $��Storage��6   �� 5%      $��Payment��6   �� 5&      $��Ordered_Products��6   5'      5(      5)      