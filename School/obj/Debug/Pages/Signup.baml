   M S B A M L   `   `   `  ����A  =School, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:School.PagesSchool.Pages  5          School.Pages.Signup   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:School.Pages     5        N� Title$  Signup��5	      .��5      ��  �� CornerRadius$ 30��6   ���#2e3137$��30q�64   ._�5   
   �� $��30q�6   .+�5      �� 
�������$��Center=�6'   $��0 0 0 0q�6D   $��40(�6U   .��6c   	Sign Up6l   �� 5      6   �� 5      
�������$
��Left=�6'   $��	20 10 0 0q�6B   $��20(�6U   .��6c   Enter your name6t   �� 5      -   5         ��Name$ txtName��5      $
��20 0q�6'   $��30��65   ���#545d6a
�������$��16(�6i   $��Center=�6w   6�   �� 5      
�������$
��Left=�6'   $��	20 10 0 0q�6B   $��20(�6U   .��6c   Enter your User name6y   �� 5      -   5        $ txtUserName��5      $
��20 0q�6+   $��30��69   ���#545d6a
�������$��16(�6m   $��Center=�6{   6�   �� 5      
�������$
��Left=�6'   $��	20 10 0 0q�6B   $��20(�6U   .��6c   Enter your Password6x   G� 5      -   5         G�Name$ pswPassword��5      $
��20 0q�6/   $��30��6=   ���#545d6a
�������$��16(�6q   $��Center=�6   6�   �� 5       �� Orientation$ 
Horizontal=�6   $��
20 10 20 0q�62   .+�5      �� 
�������$
��Left=�6+   $��20(�6F   .��6T   Enter your gender6g   	� 5      -   5         	�Name$
 male��5       	� 	GroupName$ Gender��6,   $��Center=�6?   $
��15 0q�6Z   
�������$��16(�6{   .��6�   Male6�   	� 5      -   5        $ femail��5      $ Gender��6.   $��Center=�6A   $
��15 0q�6\   
�������$��16(�6}   .��6�   Femail6�   5      �� 5      $ 
Horizontal=�6   .+�5      �� 
�������$
��Left=�6+   $��	20 10 0 0q�6F   $��20(�6Y   .��6g   Enter your date of Birth6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ 
datePicker��5         DataPickerSignUp#��[  61   $��Center=�6[   $��	20 10 0 0q�6~   6�   5      �� 5      $ 
Horizontal=�6   .+�5      �� 
�������$
��Left=�6+   $��	20 10 0 0q�6F   $��20(�6Y   .��6g   Enter your photo6y   �� 5       -   5         ��Name$ btnLoadImage��5       $	��140��6/   $��30��6;   $��18(�6G   ���#545d6a
�������$��Bottom=�6}   $��30 0 0 0q�6�   .��6�   
Load image6�   5!      �� 5"      $ 
Horizontal=�6   $��
20 20 20 0q�62   .+�5#      �� -   5        $ btnSave��5#      $	��200��6*   $��	30 0 10 0q�69   ���#545d6a
�������.��6�   Save6�   �� 5$      -	   5        $ 	btnCancel��5$      $	��200��6,   $��35��6;   $��	20 0 10 0q�6G   ���#545d6a
�������.��6�   Cancel6�   5%      5&      5'      5)      