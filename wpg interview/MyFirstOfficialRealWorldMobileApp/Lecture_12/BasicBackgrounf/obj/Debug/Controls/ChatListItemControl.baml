   M S B A M L   `   `   `  ����C  ?LetsMeet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:LetsMeetLetsMeet  5      H DLetsMeet.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:LetsMeet.Core;assembly=LetsMeet.CoreLetsMeet.Core 5      "    LetsMeet.ChatListItemControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:LetsMeet     5      Ccore2clr-namespace:LetsMeet.Core;assembly=LetsMeet.Core     5      $��60��5	        � 	Resources  5         MainContainer �� 
TargetType �� Property �� Value �� 
TargetType ��Name  BackGroundColorWhiteBrush �Name # BackGroundColorTransparentBrush � ColumnDefinitions  BackGroundColorRedBrush �� 	Converter*   $LetsMeet.BooleanToVisiblityConverter	 �� ConverterParameter
 �� Padding �� RelativeSource �� CornerRadius*   $LetsMeet.StringToColorValueConverter  
LatoSubham  FontSizeLarge  FontSizeRegular  BackGroundColorBlueBrush  FontSizeSmaller �� Triggers :� RoutedEvent  	 BackGroundColorVeryLightBlue	 �� To g� Duration �� 
TargetName �� TargetProperty 
 BackGroundColorTransparent �� Value �� Binding �� 
TargetName % !BackGroundColorVeryLightBlueBrush��%!  &	        7  7  7  7  7  7  7  7  7 	 7 
 7  �� 5   
   " ��6&   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ 
BackGround��6!   8��  ._�5      � $ 	Container��6    8��  5      �� 5   "   $
��Auto �63   �� 5   "   $
��Auto �63   �� 5   "   $��* �63   .+�5      �� $��0��6%   $��5��5   &   8�� y�5   %   �� *IsNewMessage+   $
	 True��5   &   �� 5      $��1��6%   $
 8q�65   ._�5   "   �� ��6)   �� *ActualHeight+ �� *Self+ 5       �� *ActualHeight+ �� *Self+��5!      �� *ProfilePictureRGB+   ._�5#   &   �� 8�� 8�� $��Center=�5%       $��Center=�5&       ��5'      �� *InitialProfileText+5)   #   5*      �� 5+      $��2��6%   $
 8q�65   ._�5-   "   �� .+�5.   &   �� 8�� 8�� ��50       �� *Name+�� 51   &   8�� 
�������$��CharacterEllipsis=�54       ��53       �� *	Message+54       56   #   57      58      59       5:      :� 5;      $ 
MouseEnter��6+   .[�5<   "   �� .��5=   &   �� .��5?   *   �� 8  $ 0:0:0.3D�6l   $ 	Container��6�   $ Background.Color�6�   5@   '   5A   #   5B      :� 5D      $ 
MouseLeave��6+   .[�5E   "   �� .��5F   &   �� .��5G   *   �� 8 	 $ 0:0:0.3D�6j   $ 	Container��6~   $ Background.Color�6�   5H   '   5I   #   5J      �� 5L      $
 True��6I    6*   �� *
IsSelected+.a�5M   "   �� $ 
BackGround��6?   8 
  � ��6W   5N      5P      5S      5T      5U      .��5W      �� #��[  6   5Z      