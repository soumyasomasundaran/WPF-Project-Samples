   M S B A M L   `   `   `  ����D  @ModernVPN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ModernVPN	ModernVPN  5   	       ModernVPN.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ModernVPN     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   
������  � AllowsTransparency$
 True��5
   	    � 
ResizeMode$ 	CanResize=�5   	    � WindowStyle$
 None=�5   	   .��5      ]� ���#1E1E1E$��7q�6%   .+�5   
   �� $��28��6   ���#252525$	��Top=�5   &   ._�5      �  � ColumnDefinitions 5      �� 5      �� 5      $	��100 �6'   .+�5      �� $��Surfhub 3.2.4��6   $��Consolas)�5      
�������$��Center=�5      $��Center=�5      $��	100 0 0 0q�5      5      �� 5       $��1��6    �� Orientation$ 
Horizontal=�6-   $��Right=�5!      $��4 0 0 0q�5"      .+�5#      �� $��-��6   �� 5$      $	��□��6   �� 5%      $��x��6   5&      5(      5)      �� 5+   
   $��48��6   $
��Left=�5,      ���#252525��5.      �� 5/       �� Triggers 50      :� 51       :� RoutedEvent$ Border.MouseEnter��6'   [�52      �� 53   "   .��54   &   �� .��55   *   W�  �� TargetProperty$ (Border.Width)�56   -   		 W� To	 1206X   
 g� Duration$
 0:0:.1D�6a   6u   57   '   58   #   5;      :� 5=      $ Border.MouseLeave��6'   [�5>      �� 5?   "   .��5@   &   �� .��5A   *   W� $ (Border.Width)�5B      	 486@   $
 0:0:.1D�6H   6\   5C   '   5D   #   5G      5I      5M      5O      5P      