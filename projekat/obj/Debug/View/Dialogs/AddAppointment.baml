   M S B A M L   `   `   `  ����C  ?projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:projekat.View.Dialogsprojekat.View.Dialogs  5   	   *    $projekat.View.Dialogs.AddAppointment   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:projekat.View.Dialogs     5   	     � Title$  AddAppointment��5   	   $	��768��6    $
��1024��6-   .��5	      � -   5        $
��1024��5	      $	��768��6   .+�5
   
   �� 
���   �$��0q�6%   
�������$
��Left=�6L   $	��650��6g   $��
213,45,0,0q�6t   $	��Top=�6�   $	��583��6�    �� CornerRadius$ 15��6�   �� 5   
   $��Add Appointment��6   $
��Left=�6*   $	��Top=�6E    J� RenderTransformOrigin$ -0.325,0.543&�6]   $��40(�6�   $��Calibri)�6�   $
��Bold"�6�   $��350,101,0,0q�6�   $��60��6�   $	��309��6�   �� 5   
   $��Appointment ID:��6   $��270,227,609,501q�6*   $��18(�6C   �� 5   
   $��Start:��6   $��360,279,609,449q�6!   $��18(�6:   $ -0.061,1.444&�6H   �� 5   
   $
��End:��6   $��368,333,609,395q�6   $��18(�68   �� 5   
   $��Doctor:��6   $��342,385,609,343q�6"   $��18(�6;   �� 5   
   $��Patient:��6   $��342,437,609,291q�6#   $��18(�6<   �� 5   
   $��
Room name:��6   $��301,489,609,239q�6%   $��18(�6>   �� 5   
   -   5         ��Name$ Rooms��5      $��Center=�6"   $��15(�6D   $
��Left=�6R   $��415,489,0,0q�6m   $	��331��6�   $��40��6�    �� Text$  ��6�   $	��Top=�6�   ��5      �� 5      .R�5      �� �� 6!   �6%   �� *Name+6>   5      5      �� 5   
   -   5         ��Name$	 tb3��5      $��Center=�6   $
��Left=�6A   $��40��6\   $��415,333,0,0q�6h    �� TextWrapping$
 Wrap=�6}   $�� ��6�   $	��Top=�6�   $	��331��6�   $��15(�6�   �� 5   
   -   5        $	 tb2��5      $��Center=�6   $
��Left=�6A   $��40��6\   $��415,279,0,0q�6h   $
 Wrap=�6}   $�� ��6�   $	��Top=�6�   $	��331��6�   $��15(�6�   �� 5   
   -   5        $	 tb1��5      $��Center=�6   $
��Left=�6A   $��40��6\   $��415,227,0,0q�6h   $
 Wrap=�6}   $�� ��6�   $	��Top=�6�   $	��331��6�   {�.  $��15(�6�   �� 5   
   -   5        $
��Done��5      ���	#FF01A1D6
�������$��0q�6J   $
��Left=�6^   $��380,585,0,0q�6y   $	��Top=�6�   $	��250��6�   $��60��6�   $��20(�6�    � 	Resources 5       �� 
TargetType	 �� Property
 �� Value��%^   '��       �� 5      " ��6   .�5      �� 	 �@��CornerRadius$
 7��65   5       5!      5"      �� 5#   
   -   5        $ Doctors��5#      $��Center=�6$   $��15(�6F   $
��Left=�6T   $��415,385,0,0q�6o   $	��331��6�   $��40��6�   $  ��6�   $	��Top=�6�   ��5$      �� 5%      .R�5&      �� �� 6!   �6%   �� *Name+6>   5'      5)      �� 5*   
   -   5        $ Patients��5*      $��Center=�6%   $��15(�6G   $
��Left=�6U   $��415,437,0,0q�6p   $	��331��6�   $��40��6�   $  ��6�   $	��Top=�6�   ��5+      �� 5,      .R�5-      �� �� 6!   �6%   �� *Name+6>   5.      50      �� 51   
   -	   5         ��Name$ errormessage��51   ;   $��23��6   $
��Left=�6    $�� ��6R   $	��Top=�6Z   $	��250��6r   $��380,547,0,0q�6~    J� OpacityMask
 �<�����	#FFE5572C6�   ��52   
   �� 53       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��54      �  � Color$ 	#FF12AEE2��6    � Offset$ 0Q�61   � 55      $ 	#FF50E6AF��6   $ 1Q�61   56      58      59      