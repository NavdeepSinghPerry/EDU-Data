   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   C ?BasicApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BasicAppBasicApp 5   	      BasicApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   (localclr-namespace:BasicApp     5   	     � WindowStyle$
  None=�5	   	    � Title$ 
MainWindow��5
   	   $	��600��6   $	��525��6)   $��0q�65    � 	Resources 5       �� 
TargetType �� Property �� Value   strHelloWorld��%�   '��       &	  y     �� 5   
   " ��6   .�5      �� 
ForVal�� � ��
 ��  �6;   �� 5       � ��$ 20(�6)   5      ��5   
   Hello, world!��6:   5      .��5      �� 
���   �$��1q�6"    �� Padding$ 5q�66   ._�5   
   �� .+�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� $��0,10,5,0q�6   $��0��6-   ��6>   �� *textt+�� 5      -   5         ��Name$ btnNav��5      $��0,10,5,0q�6,   $��1��6>   $��Reset��6N   
�������6^   �� 5      $��0,10,0,0q�6   $��2��6,   $��Refresh��6<   5       �� 5#      $��0,10,0,5q�6   $��Pulse Properties��6'   $
��Bold"�6B   �� 5%      .+�5&      �� $��Description��6   �� 5'      5(      �� 5*      .+�5+      �  5,      �� 5-      $��2* �6+   �� 5.      $��* �6+   	 � RowDefinitions	 51      �� 52      $��* �6(   �� 53      $��* �6(   �� 54      $��* �6(   �� 55      $��* �6(   .+�58      �� $��0��6!   $��0,10,5,0q�61   .+�59      �� $��Status��6    �� 5:      5;      �� 5=      $��1��6!   $��0,10,0,0q�61   .+�5>      �� $��Revision��6    �� 5?      5@      �� 5B      $��1��6!   $��2��6.   $��0,10,0,0q�6B   .+�5C      �� $��Part Number��6    �� 5D      5E      5F      5G      �� 5J      .��5K      � .+�5L      �� $��/Logo/icon.ico��6   $
��None=�60   �� 5M      .��6   
check me6#   5N      5O      �� 5P      $	��200��6   $��30��6!   .��5Q      �� �� 5R      
���  ��$��20(�6,   $
��Bold"�6:   .�6L   Hello5T       �� 5U      
����  �.�6*   Hello5W      5X      5Y      5Z      5\      5]      