   M S B A M L   `   `   `  ����C  ?projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:projekat.View.Dialogsprojekat.View.Dialogs  5   	   !    projekat.View.Dialogs.AMeds   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:projekat.View.Dialogs     5   	     � Title$  AMeds��5   	   $	��763��6   $
��1024��6$   .��5	      � $
��1024��6   $	��768��6   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF12AEE2��6    � Offset$ 0Q�61   � 5      $ 	#FF50E6AF��6   $ 1Q�61   5      .+�5   
   o� $
��Left=�6   $��45��6*   $	��Top=�66   $
��1014��6N   ��5      �� 5      .R�5      ]� $��Stretch=�6    5      .@�5      m� -   5        $��Profile��5      
�������$��45��6;   6G   m� 5      -   5        $��Appointments��5      
�������$��45��6@   6L   m� 5      -   5        $��Request a time off��5      
�������$��45��6F   6R   m� 5      -   5        $��Patient's info��5      
�������$��45��6B   6N   m� 5      -   5        $��Approve Medications��5      
�������$��45��6G   6S   m� 5      -   5        $��	Anamnesis��5      
�������$��45��6=   $	��Top=�6I   6a   m� 5      -   5        $��Log out��5      
�������$��45��6;   $��0q�6G   $��Right=�6R   6n   5      �� 5   
   
���   �$��0q�6%   
�������$
��Left=�6L   $	��497��6g   $��520,163,0,0q�6t   $	��Top=�6�   $	��390��6�    �� CornerRadius$ 15��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridXAML��5      $��Center=�6)   $
��Left=�6M   $	��552��6h   $��112,108,0,0q�6u   $	��Top=�6�   $	��302��6�   $   HorizontalScrollBarVisibility$ Disabled=�6�    � 	Resources 5       =  7System.Windows.Controls.Primitives.DataGridColumnHeader	 �� 
TargetType
 �� Property �� Value*  $System.Windows.Controls.DataGridCell��%�  '        '      �� 5!      "	  6   .�5"      �� 
 � �� �	#FFEAE8E863   �� 5#      
 � ��$ 18"�63   �� 5$      
 � ��$ Regular"�63   �� 5%      
 � ��$ 
0, 0, 1, 2q�68   �� 5&      
 � ��
 �   �64   �� 5'      
 � ��$ Center=�6C   5(      �� 5)      "	  6   .�5*      �� 
 �@��TextAlignment$ Center=�6@   5+      5,         Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5/      $
 Name��6%   $	 200 6L    63   �� *Name+6L   51      �� 52   
   -	   5         ��Name$
 tbl1��52       �� TextAlignment$ Justify=�6"   $
��Left=�6:   $	��268��6U   $��569,343,0,0q�6b   $��15(�6w   $
��Wrap=�6�   $	��Top=�6�   $	��292��6�   �� 53   
   $��Ingredients��6   $
��Left=�6&   $	��Top=�6A    J� RenderTransformOrigin$ -0.325,0.543&�6Y   $��40(�6~   $��Calibri)�6�   $
��Bold"�6�   $��617,263,0,0q�6�   $��60��6�   $	��200��6�   �� 54   
   $
��Left=�6   $	��110��6+   $��660,108,0,0q�68   $	��Top=�6M   $	��110��6e   $��/img/pills.png��6q   55      56      