   M S B A M L   `   `   `  ����C  ?projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:projekat.View.Dialogsprojekat.View.Dialogs  5   	   )    #projekat.View.Dialogs.AnamnesisView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:projekat.View.Dialogs     5   	     � Title$  AnamnesisView��5   	   $	��768��6   $
��1024��6,   .��5	      � -   5        $
��1024��5	      $	��768��6   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF12AEE2��6    � Offset$ 0Q�61   � 5      $ 	#FF50E6AF��6   $ 1Q�61   5      .+�5   
   o� $
��Left=�6   $��45��6*   $	��Top=�66   $
��1014��6N   ��5      �� 5      .R�5      ]� $��Stretch=�6    5      .@�5      m� -   5        $��Profile��5      
�������$��45��6;   6G   m� 5      -   5        $��Appointments��5      
�������$��45��6@   $	��Top=�6L   6d   m� 5      -   5        $��Request a time off��5      
�������$��45��6F   6R   m� 5      -   5        $��Patient's info��5      
�������$��45��6B   6N   m� 5      -   5        $��Approve Medications��5      
�������$��45��6G   6S   m� 5      -   5        $��	Anamnesis��5      
�������$��45��6=   {�.  6b   m� 5      -   5        $��Log out��5      
�������$��45��6;   $��0q�6G   $��Right=�6R   6n   5      �� 5   
   
���   �$��0q�6%   
�������$
��Left=�6L   $	��275��6g   $��	42,94,0,0q�6t   $	��Top=�6�   $	��450��6�    �� CornerRadius$ 15��6�   �� 5   
   $��Choose a patient��6   $
��Left=�6+   $	��Top=�6F    J� RenderTransformOrigin$ -0.325,0.543&�6^   $��40(�6�   $��Calibri)�6�   $
��Bold"�6�   $��120,112,0,0q�6�   $��60��6�   $	��292��6�   �� 5    
   -	   5         ��Name$ Patients��5       $
��Left=�6$   $	��152��6?   $��
96,177,0,0q�6L   $	��Top=�6`   $	��346��6x   ��5!      �� 5"      .R�5#      �� �� 6!   �6%   �� *Name+�� 6=   $� ��6A   �� 6L   �6P   �� *	Surname+�� 6k   $� ��6o   �� 6z   $�, ��6~   �� 6�   $� ��6�   �� 6�   �6�   �� *Gender+6�   5$       � ToolTip 5&      _� 5'      .��5(      ]� .+�5)      �� )'Choose a patient to write anamnesis for6M   5*      5+      5-      �� 5.   
   
���   �$��0q�6%   
�������$
��Left=�6L   $	��275��6g   $��
42,412,0,0q�6t   $	��Top=�6�   $	��450��6�   $ 15��6�   �� 5/   
   $��Choose an appointment��6   $
��Left=�60   $	��Top=�6K   $ -0.325,0.543&�6c   $��40(�6�   $��Calibri)�6�   $
��Bold"�6�   $��
60,430,0,0q�6�   $��60��6�   $	��410��6�   �� 50   
   
���   �$��0q�6%   
�������$
��Left=�6L   $	��528��6g   $��519,159,0,0q�6t   $	��Top=�6�   $	��450��6�   $ 15��6�   �� 51   
   $
��Left=�6   $	��130��6+   $��
678,94,0,0q�68   $	��Top=�6L   $	��130��6d   $1��+/projekat;component/img/medical-history.png��6p   �� 52   
   -
   5        	 ��Name$
	 tbl1��52      $
��Left=�6    $	��289��6;   $��560,255,0,0q�6H   
 �� TextAlignment$
 Justify=�6]    �� TextWrapping$
 Wrap=�6u   $�� ��6�   $��15(�6�   $	��Top=�6�   $	��364��6�   �� 53   
   -   5         ��Name$ addBtn��53      $��Create Anamnesis��6"   $��0q�6=   $
��Left=�6Q   $��610,574,0,0q�6l   $	��Top=�6�   $	��270��6�   $��74��6�   $��18(�6�   ���	#FF01A1D6
������� � 	Resources 54       �� 
TargetType �� Property �� Value��%^   '��       �� 55      " ��6   .�56      ��  �@��CornerRadius$ 7��65   57      58       59      _� 5:      .��5;      ]� .+�5<      �� 86Creating anamnesis with selected data and entered text6\   5=      5>      5@      &   System.Windows.Controls.DataGrid  5A   
   -   5          Name$ DataGridXAML��5A      $��Center=�6)   $
��Left=�6M   $	��153��6h   $��
96,495,0,0q�6u   $	��Top=�6�   $	��346��6�   $   HorizontalScrollBarVisibility$ Disabled=�6�    5B      =  7System.Windows.Controls.Primitives.DataGridColumnHeader*  $System.Windows.Controls.DataGridCell��%�  '        '      �� 5C      "  6   .�5D      ��  � �� �	#FFEAE8E863   �� 5E       � ��$ 18"�63   �� 5F       � ��$ Regular"�63   �� 5G       � ��$ 
0, 0, 1, 2q�68   �� 5H       � ��
 �   �64   �� 5I       � ��$ Center=�6C   5J      �� 5K      "  6   .�5L      ��  �@��TextAlignment$ Center=�6@   5M      5N         Columns 5O      0  *System.Windows.Controls.DataGridTextColumn  5P      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 20 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5Q      $ Doctor's Name��6%   $	 110 6[    6<   �� *
DoctorName+6[     5R      $ Doctor's Surname��6%   $	 110 6a    6?   �� *DoctorSurname+6a     5S      $ 	Room name��6%   $ 80 6U    68   �� *
RoomName+6U    5U      _� 5V      .��5W      ]� .+�5X      �� 53Choose patient's appointment to write anamnesis for6Y   5Y      5Z      5\      5]      5^      