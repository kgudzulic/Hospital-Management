   M S B A M L   `   `   `  ����C  ?projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:projekat.View.Dialogsprojekat.View.Dialogs  5   	   C&clr-namespace:projekat.View.Componentsprojekat.View.Components  5   	   '    !projekat.View.Dialogs.DoctorLogin   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:projekat.View.Dialogs     5   	   =
components&clr-namespace:projekat.View.Components     5   	     � Title$  DoctorLogin��5	   	   $	��801��6   $
��1038��6*   .��5
      � -   5        $
��1024��5
      $	��765��6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF12AEE2��6    � Offset$ 0Q�61   � 5      $ 	#FF50E6AF��6   $ 1Q�61   5      .+�5   
   �� 
���   �$��0q�6%   
�������$
��Left=�6L   $	��440��6g   $��320,154,0,0q�6t   $	��Top=�6�   $	��384��6�    �� CornerRadius$ 15��6�   �� 5   
   $��Login��6   $
��Left=�6    $	��Top=�6;    J� RenderTransformOrigin$ -0.325,0.543&�6S   $��40(�6x   $��Calibri)�6�   $
��Bold"�6�   $��460,246,0,0q�6�   $��60��6�   $	��100��6�   �� 5   
   -   5         ��Name$	 tb1��5      $
��Left=�6   $��Center=�6:   $��38��6v   $��385,326,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��250��6�   $ 0.355,0.348&�6�   $��20(�6�   ��6\   �� *
Username+.��6  	 � 	Resources	 5      
 �� 
TargetType �� Property �� Value��%^   '��       �� 5      "
 ��6   .�5      ��  �@��CornerRadius$ 0��65   5      5      .��6!   ��5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      �� 6   6sys&clr-namespace:System;assembly=mscorlib     6   "
 ��6K    �� 	Resources 5         CueBannerBrush j� 
AlignmentX j� 
AlignmentY j� Stretch !� Visual��%�   &	        !� 5      $
 Left=�6=   $ Center=�6O   $
 None=�6c    5      �� 5   "   $��Username��6(   
�������$��15(�6M   5       5!       �� Triggers 5"      P� 5#       P� Property � �� �� Empty P� Value# Z 62   . �5$      ��  � ��# [  6;   5%      P� 5&       � �� 62   Z� . �5'      ��  � ��# [  6;   5(      P� 5)       �@J�IsKeyboardFocused . . �5*      ��  � ��
 �����6;   5+      5-      .��5.      5/      2   ,projekat.View.Components.BindablePasswordBox  50   
   -   5          Name$
 bpb1��50   )   2   ,projekat.View.Components.BindablePasswordBox#   IsKeyboardFocusWithinChanged$' !bpb1_IsKeyboardFocusWithinChanged��6�   $
��Left=�6�   $��385,380,0,0q�6�   $	��Top=�6�   $	��250��6�   $��38��6�   $��20(�6�      Password 67   �� *
Password+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 51   
   -   5        $��Login��51      $
��Left=�6!   $��0q�6<   ���	#FF01A1D6
�������$��385,460,0,0q�6z   $	��Top=�6�   $	��250��6�   $��50��6�   $��20(�6�   	 52      ��%^   '��       �� 53      "
 ��6   .�54      ��  �@��CornerRadius$ 7��65   55      56       � ToolTip 57      _� 58      .��59      ]� .+�5:      �� Click to login64   5;      5<      5>      �� 5?   
   $
��Left=�6   $	��108��6+   $��460,112,0,0q�68   $	��Top=�6M   $	��109��6e   $��/img/medical-team.png��6q   $ 0.3,0.46&�6�   �� 5@   
   -   5        $
��pass��5@      $��Password��6   $
��Left=�6/   $��385,380,0,0q�6J   $	��Top=�6_   $��38��6w   $��78��6�   $��15(�6�   
�������$��Center=�6�   �� 5A   
   -   5         ��Name$ errormessage��5A   ;   $��23��6   $
��Left=�6    $�� ��6R   $	��Top=�6Z   $	��250��6r   $��385,432,0,0q�6~    J� OpacityMask
 �<�����	#FFE5572C6�   5B      5C      