   M S B A M L   `   `   `  ����C  ?projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:projekat.View.Dialogsprojekat.View.Dialogs  5   	   (    "projekat.View.Dialogs.AppointmView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:projekat.View.Dialogs     5   	     � Title$  AppointmView��5   	   $��796.5��6   $��1044.5��6-   .��5	      � -   5        $
��1024��5	      $	��768��6   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF12AEE2��6    � Offset$ 0Q�61   � 5      $ 	#FF50E6AF��6   $ 1Q�61   5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridXAML��5      $��Center=�6)   $
��Left=�6M   $	��492��6h   $��	30,98,0,0q�6u   $	��Top=�6�   $	��962��6�   $   HorizontalScrollBarVisibility$ Disabled=�6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType	 �� Property
 �� Value*  $System.Windows.Controls.DataGridCell��%�  '        '      �� 5      "  6   .�5      �� 	 � ��
 �	#FFEAE8E863   �� 5      	 � ��$
 18"�63   �� 5      	 � ��$
 Regular"�63   �� 5      	 � ��$
 
0, 0, 1, 2q�68   �� 5      	 � ��

 �   �64   �� 5      	 � ��$
 Center=�6C   5      �� 5      "  6   .�5      �� 	 �@��TextAlignment$
 Center=�6@   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 25 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5       $ Start��6%   $	 125 6|    64   �� *StartAppointment+ �� StringFormat$ dd/MM/yyyy hh:mm tt��6|     5!      $	 End��6%   $	 125 6w    62   �� *EndAppointment+$ dd/MM/yyyy hh:mm tt��6w     5"      $ Doctor's Name��6%   $	 120 6[    6<   �� *
DoctorName+6[     5#      $ Doctor's Surname��6%   $	 120 6a    6?   �� *DoctorSurname+6a     5$      $ Patient's Username��6%   $	 120 6e    6A   �� *PatientUsername+6e     5%      $ Patient's Name��6%   $	 120 6]    6=   �� *PatientName+6]     5&      $ Patient's Surname��6%   $	 120 6c    6@   �� *PatientSurname+6c     5'      $ 	Room name��6%   $ 80 6U    68   �� *
RoomName+6U   5)      �� 5*   
   -   5        $��addBtn��5*      $��Add new Appointment��6    $��0q�6>   $
��Left=�6R   $��
30,645,0,0q�6m   $	��Top=�6�   $	��270��6�   $��60��6�   $��18(�6�   ���	#FFEAE8E8 5+      ��%^   '��       �� 5,      " ��6   .�5-      �� 	 �@��CornerRadius$
 7��65   5.      5/      50      �� 51   
   -   5        $��editBtn��51      $��Edit Appointment��6    $��0q�6;   $
��Left=�6O   $��377,645,0,0q�6j   $	��Top=�6   $	��270��6�   $��60��6�   $��18(�6�   ���	#FFEAE8E8 52      ��%^   '��       �� 53      " ��6   .�54      �� 	 �@��CornerRadius$
 7��65   55      56      57      �� 58   
   -   5        $��	removeBtn��58      $��Remove Appointment��6#   $��0q�6@   $
��Left=�6T   $��722,645,0,0q�6o   $	��Top=�6�   $	��270��6�   $��60��6�   $��18(�6�   ���	#FFEAE8E8 59      ��%^   '��       �� 5:      " ��6   .�5;      �� 	 �@��CornerRadius$
 7��65   5<      5=      5>      o� 5?   
   $
��Left=�6   $��45��6*   $	��Top=�66   $
��1014��6N   ��5@      �� 5A      .R�5B      ]� $��Stretch=�6    5C      .@�5E      m� -   5        $��Profile��5E      
�������$��45��6;   6G   m� 5F      -   5        $��Appointments��5F      
�������$��45��6@   $	��Top=�6L   {�.  6}   m� 5G      -   5        $��Request a time off��5G      
�������$��45��6F   6R   m� 5H      -	   5        $��Patient's info��5H      
�������$��45��6B   6N   m� 5I      -
   5        $��Approve Medications��5I      
�������$��45��6G   6S   m� 5J      -   5        $��	Anamnesis��5J      
�������$��45��6=   6I   m� 5K      -   5        $��Log out��5K      
�������$��45��6;   $��0q�6G   $��Right=�6R   6n   5L      5M      5N      