   M S B A M L   `   `   `  ����C  ?projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:projekat.View.Dialogsprojekat.View.Dialogs  5   	   )    #projekat.View.Dialogs.AllergensList   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:projekat.View.Dialogs     5   	     � Title$  AllergensList��5   	   $	��768��6   $
��1024��6,   .��5	      � -   5        $
��1024��5	      $	��768��6   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF12AEE2��6    � Offset$ 0Q�61   � 5      $ 	#FF50E6AF��6   $ 1Q�61   5      .+�5   
   �� 
���   �$��0q�6%   
�������$
��Left=�6L   $	��492��6g   $��520,168,0,0q�6t   $	��Top=�6�   $	��390��6�    �� CornerRadius$ 15��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridXAML��5      $��Center=�6)   $
��Left=�6M   $	��552��6h   $��112,108,0,0q�6u   $	��Top=�6�   $	��302��6�   $   HorizontalScrollBarVisibility$ Disabled=�6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader	 �� 
TargetType
 �� Property �� Value*  $System.Windows.Controls.DataGridCell��%�  '        '      �� 5      "	  6   .�5      �� 
 � �� �	#FFEAE8E863   �� 5      
 � ��$ 18"�63   �� 5      
 � ��$ Regular"�63   �� 5      
 � ��$ 
0, 0, 1, 2q�68   �� 5      
 � ��
 �   �64   �� 5      
 � ��$ Center=�6C   5      �� 5      "	  6   .�5      �� 
 �@��TextAlignment$ Center=�6@   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5!      $
 Name��6%   $	 200 6L    63   �� *Name+6L   5#      �� 5$   
   -   5         ��Name$ addBtn��5$      $��Add new Allergen��6"   $��0q�6=   $
��Left=�6Q   $��580,274,0,0q�6l   $	��Top=�6�   $	��270��6�   $��74��6�   $��18(�6�   ���	#FFEAE8E8 5%      ��%^   '��       �� 5&      "	 ��6   .�5'      �� 
 �@��CornerRadius$ 7��65   5(      5)      5*      �� 5+   
   -   5        $ editBtn��5+      $��Edit Allergen��6"   $��0q�6:   $
��Left=�6N   $��580,389,0,0q�6i   $	��Top=�6~   $	��270��6�   $��74��6�   $��18(�6�   ���	#FFEAE8E8 5,      ��%^   '��       �� 5-      "	 ��6   .�5.      �� 
 �@��CornerRadius$ 7��65   5/      50      51      �� 52   
   -   5        $ 	removeBtn��52      $��Remove Allergen��6%   $��0q�6?   $
��Left=�6S   $��580,502,0,0q�6n   $	��Top=�6�   $	��270��6�   $��74��6�   $��18(�6�   ���	#FFEAE8E8 53      ��%^   '��       �� 54      "	 ��6   .�55      �� 
 �@��CornerRadius$ 7��65   56      57      58      o� 59   
   $
��Left=�6   $��45��6*   $	��Top=�66   $
��1024��6N   ��5:      �� 5;      .R�5<      ]� $��Stretch=�6    5=      .@�5?      m� -   5         m�Name$ profile��5?      $��Profile��6(   
�������$��45��6L   6X   m� 5@      -   5        $ appoint��5@      $��Appointments��6)   
�������$��45��6R   6^   m� 5A      -   5        $	 req��5A      $��Request a time off��6$   
�������$��45��6S   6_   m� 5B      -	   5        $ patinfo��5B      $��Patient's info��6(   
�������$��45��6S   6_   m� 5C      -
   5        $ appmed��5C      $��Approve medications��6'   
�������$��45��6W   6c   m� 5D      -   5        $ logout��5D      $��Log out��6'   
�������$��45��6K   $��0q�6l   $��Right=�6w   5E      �� 5F   
   $
��Left=�6   $	��108��6+   $��668,108,0,0q�68   $	��Top=�6M   $	��108��6e   $(��"/projekat;component/img/no-gmo.png��6q    J� RenderTransformOrigin$ 0.3,0.46&�6�   5G      5H      