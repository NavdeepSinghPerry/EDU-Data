   M S B A M L   `   `   `  ����J  FBasicBackgrounf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BasicBackgrounfBasicBackgrounf  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source   	BaseStyle �� 
TargetType �� Property �� Value  
LatoSubham'   !System.Windows.Shell.WindowChrome  HoverlessButton �� BasedOn  closeButton �� 
TargetType ��Name �� Triggers	 :� RoutedEvent  BackGroundColorRed	
 �� To g� Duration �� 
TargetName �� TargetProperty  BackGroundColorTransparent J� SnapsToDevicePixels �� CornerRadius  BackGroundColorYellowBrush ��Name �� ContentStringFormat �� ContentStringFormat  BackGroundColorBlue  BackGroundColorGreen �� From 	 BackGroundColorLightGray 
 BackGroundColorYellow  TextBoxStyle1-  'System.Windows.Input.KeyboardNavigation ��Name P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      'localclr-namespace:BasicBackgrounf  5        5      �� 5   
   $ Colors.xaml?�6   �� 5   
   $ 
Fonts.xaml?�6   %
  &	        7  &	 �     7   &	 ]    7   7  7  '�� �    7  7  7  7  7 	 7  7  7 
 &	 n    �� 5      " ��6   .�5   
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
MouseEnter��6'   .[�5$      �� .��5%   "   �� .��5&   &   �� 8
  $ 0:0:0.8D�6^   $ closeButtonBorder��6r   $ Background.Color�6�   5'   #   5(      5)      :� 5+      $	 
MouseLeave��6'   .[�5,      �� .��5-   "   �� .��5.   &   �� 8
  $ 0:0:0.8D�6f   $ closeButtonBorder��6z   $ Background.Color�6�   5/   #   50      51      53      55      57      �� 59      " ��6   .�5:   
   ��  � �� 5;      �� 5<      " ��6"   .R�5=      �� $ border��6   #��z��5>      #��z��5?       . $ 10��5A      8��  ._�5C      �� $ contentPresenter��6+   #��z��6E   #��z��6y   # z 6�   |�.  #��z��6�   #��z��6.  ��. # z 6l  #��z��6�  5D       5E      :� 5F      $	 
MouseEnter��6'   .[�5G      �� .��5H   "   �� .��5I   &   �� 8
  $ 0:0:0.5D�6_   $ border��6r   $ Background.Color�6�   5J   #   5K      5L      :� 5M      $	 
MouseLeave��6'   .[�5N      �� .��5O   "   �� .��5P   &   �� 8  $ 0:0:2D�6b   $ border��6s   $ Background.Color�6�   �� 5Q   &   8
  $ 0:0:2D�6_   $ border��6p   $ Background.Color�6�   �� 5R   &   8
  $ 0:0:2D�6d   $ border��6u   $ Background.Color�6�   �� 5S   &   8
  $ 0:0:2D�6^   $ border��6o   $ Background.Color�6�   �� 5T   &   8
  $ 0:0:2D�6f   $ border��6w   $ Background.Color�6�   �� 5U   &   8
  $ 0:0:2D�6a   $ border��6r   $ Background.Color�6�   5V   #   5W      5X      5[      5]      5^      �� 5`      " ��6"   .�5a   
   ��  � ��# � ��6'   �� 5b   
    � ��# � ��6'   �� 5c   
    � ��$ 1q�6,   �� 5d   
    �@ TabNavigation$
 None=�6=   �� 5e   
    � ��$
 Left=�67   �� 5f   
    �@�FocusVisualStyle 6-   Z� �� 5g   
    �@J�	AllowDrop . 6&   �� 5h   
    �@��PanningMode$ VerticalFirst=�65   �� 5i   
    �@��IsFlicksEnabled .  63   �� 5j   
    � �� 5k      �� 5l      " ��6"   .R�5m      �� $ border��6   #��z��6-   #��z��6Y   #��z��6�    . ._�5n      �� $ PART_ContentHost��6'   |�.  $��Hidden=�6S   $��Hidden=�6z   5o       5p      P� 5q       � {� .  . �5r      �� $ border��68    �@J�Opacity$
 0.56Q�6L   5s      P� 5t       �@J�IsMouseOver . 5v      5y      5{       5|   
   ]� 5}       5~      �� 5      + �@��#IsInactiveSelectionHighlightEnabled . 6O   �� 5�       �@��IsSelectionActive .  6=   ./�5�      ��  �@��SelectionBrush# � /�63   5�      5�      5�      