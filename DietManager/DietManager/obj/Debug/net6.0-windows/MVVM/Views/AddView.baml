   M S B A M L   `   `   `  ����F  BDietManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:DietManager.MVVM.ViewsDietManager.MVVM.Views  5      $    DietManager.MVVM.Views.AddView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:DietManager.MVVM.Views     5      
����p��.��5	      �   � ColumnDefinitions  5
   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $
��Left=�6   $��0��60   .+�5      �� $	��Add��6   $	��100��6$   ��60   �� *AddFoodCommand+6U   �� 5      $��Delete��6   $	��100��6'   65   5      &   System.Windows.Controls.DataGrid  5   
   $��1��6      AutoGenerateColumns$ False��6D   ��6#   �� *
FoodList+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Food��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� 5      �� 5   
   $��1��6   $��Center=�6$   $��Bottom=�6A   $	��200��6\    �� SelectedIndex$ 0��6�   ��6h   �� *
FoodList+6�   5      5      