   M S B A M L   `   `   `  ����C  ?LetsMeet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:LetsMeetLetsMeet  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source   	BaseStyle �� 
TargetType �� Property �� Value  
LatoSubham'   !System.Windows.Shell.WindowChrome  HoverlessButton �� BasedOn  closeButton �� 
TargetType ��Name �� Triggers	 :� RoutedEvent  BackGroundColorRed	
 �� To g� Duration �� 
TargetName �� TargetProperty  BackGroundColorTransparent J� SnapsToDevicePixels �� CornerRadius  BackGroundColorYellowBrush ��Name �� ContentStringFormat �� ContentStringFormat  BackGroundColorBlue  BackGroundColorYellow 	 TextBoxStyle1-  'System.Windows.Input.KeyboardNavigation ��Name P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value 
 chatButtons  BackGroundColorBlueBrush  FontAwesome  BackGroundColorLightBlue�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5       localclr-namespace:LetsMeet  5        5      �� 5   
   $ Colors.xaml?�6   �� 5   
   $ 
Fonts.xaml?�6   %�  &	        7  &	 �     7   &	 ]    7   7  7  '�� �    7  7  7  &		 �    &	
     7   7  7  7  7  �� 5      " ��6   .�5   
   ��  � ��
 ���� 6'   �� 5   
    � ��8   6'   �� 5   
    � ��$ 0q�6,   �� 5   
     �@  IsHitTestVisibleInChrome . 6B   5      �� 5      " ��6$   8   .�5   
   ��  � ��$ 0q�6,   �� 5   
    � ��
 ���� 6'   �� 5   
    � ��$ 5q�6$   5      �� 5      " ��6    8   .�5   
   ��  � �� 5      �� 5      " ��6"   .R�5      �� $ closeButtonBorder��6   #��z��68   ._�5       �� #��z��6$   $��Center=�6E   $��Center=�6b   6   5!       5"      :� 5#      $	 
MouseEnter��6'   .[�5$      �� .��5%   "   �� .��5'   &   �� 8
  $ 0:0:0.3D�6^   $ closeButtonBorder��6r   $ Background.Color�6�   5(   #   5)      5*      :� 5,      $	 
MouseLeave��6'   .[�5-      �� .��5.   "   �� .��5/   &   �� 8
  $ 0:0:0.3D�6f   $ closeButtonBorder��6z   $ Background.Color�6�   50   #   51      52      54      56      58      �� 5:      " ��6   .�5;   
   ��  � �� 5<      �� 5=      " ��6"   .R�5>      �� $ border��6   #��z��5?      #��z��5@       . $ 10��5B      8��  ._�5D      �� $ contentPresenter��6+   #��z��6E   #��z��6y   # z 6�   |�.  #��z��6�   #��z��6.  ��. # z 6l  #��z��6�  5E       5F      :� 5G      $	 
MouseEnter��6'   .[�5H      �� .��5I   "   �� .��5J   &   �� 8
  $ 0:0:0.5D�6_   $ border��6r   $ Background.Color�6�   5K   #   5L      5M      :� 5N      $	 
MouseLeave��6'   .[�5O      �� .��5P   "   �� .��5Q   %   �� 8
  $ 0:0:0.5D�6`   $ border��6s   $ Background.Color�6�   5R   #   5S      5T      5W      5Y      5Z      �� 5\      " ��6"   .�5]   
   ��  � ��# � ��6'   �� 5^   
    � ��# � ��6'   �� 5_   
    � ��$ 1q�6,   �� 5`   
    �@ TabNavigation$
 None=�6=   �� 5a   
    � ��$
 Left=�67   �� 5b   
    �@�FocusVisualStyle 6-   Z� �� 5c   
    �@J�	AllowDrop . 6&   �� 5d   
    �@��PanningMode$ VerticalFirst=�65   �� 5e   
    �@��IsFlicksEnabled .  63   �� 5f   
    � �� 5g      �� 5h      " ��6"   .R�5i      �� $ border��6   #��z��6-   #��z��6Y   #��z��6�    . ._�5j      �� $ PART_ContentHost��6'   |�.  $��Hidden=�6S   $��Hidden=�6z   5k       5l      P� 5m       � {� .  . �5n      �� $ border��68    �@J�Opacity$
 0.56Q�6L   5o      P� 5p       �@J�IsMouseOver . 5r      5u      5w       5x   
   ]� 5y       5z      �� 5{      + �@��#IsInactiveSelectionHighlightEnabled . 6O   �� 5|       �@��IsSelectionActive .  6=   ./�5~      ��  �@��SelectionBrush# � /�63   5      5�      �� 5�      " ��6    8   .�5�   
   ��  � ��8  6'   �� 5�   
    � ��8  6'   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� $ chatButtonBorder��6   #��z��67   ._�5�      � .+�5�      (� .��5�   "   �� #��z��6,   |�.  #��z��5�   (   #��z��5�   (   #��z��5�   (   # z 5�   (   #��z��5�   (   5�      5�      5�       5�      :� 5�      $	 
MouseEnter��6'   .[�5�      �� .��5�   "   �� .��5�   &   �� 8
  $ 0:0:0.8D�6d   $ chatButtonBorder��6x   $ Background.Color�6�   5�   #   5�      5�      :� 5�      $	 
MouseLeave��6'   .[�5�      �� .��5�   "   �� .��5�   &   �� 8
  $ 0:0:0.8D�6_   $ chatButtonBorder��6s   $ Background.Color�6�   5�   #   5�      5�      5�      5�      5�      5�      