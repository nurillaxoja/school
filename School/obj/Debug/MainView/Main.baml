   M S B A M L   `   `   `  ����A  =School, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:School.MainViewSchool.MainView  5   	       School.MainView.Main   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:School.MainView     5   	   -   5          �Name$  
MainWindow��5   	    � Title$
 Main��5   	   $	��700��6   $
��1000��6#   ���#04c582.��5
      ��  
  Border#��[  6   $��20q�6-   $��5q�69    �� CornerRadius$ 20��6M   ._�5      ]� .+�5   
   � $	��Top=�6   $	�� 50��6$   $	��Top=�61   $��0 10 0 0q�6I    � ColumnDefinitions 5      �� 5      6%   �� 5      6%   .+�5      �� $��0��6   $��Stretch=�6$   
�������$��25(�6Z   $��20 0 0 0q�6h   .��6z   Menu6�   �� 5      -   5         ��Name$ lblName��5      $��1��6%   $��Stretch=�65   
�������$��Right=�6k   $��25(�6�   $��0 0 20 0q�6�   .��6�   User6�   5      �� 5   
   $
��Left=�6   $
��Left=�6+   $	��170��6F   $��	 10 0 0 0q�6R   .+�5      �� -   5         ��Name$ 
btnProfile��5        btn_default#��[ 6)   $��50��6N   $��	0 50 0 10q�6Z   .��6�   	Profile6�   �� 5      -   5        $ btnClass��5      #��[ 6'   $��50��6L   $
��0 10q�6X   .��6z   Class6�   �� 5      -   5        $ btnLog��5      #��[ 6%   $��50��6J   $
��0 10q�6V   .��6u   Log6z   �� 5      -   5        $ btnExit��5      #��[ 6&   $��50��6K   $
��0 10q�6W   .��6w   Exit6}   5       � 5   
   -   5          �Name$ 	MainFrame��5      $��	20 0 20 0q�6#     � NavigationUIVisibility$ Hidden=�67     � Source$ ../../Pages/profile.xaml?�6W   6{   5      5      5       