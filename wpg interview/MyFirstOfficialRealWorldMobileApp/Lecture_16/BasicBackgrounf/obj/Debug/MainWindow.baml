   M S B A M L   `   `   `  ����C  ?LetsMeet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:LetsMeetLetsMeet  5   	   H DLetsMeet.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:LetsMeet.Core;assembly=LetsMeet.CoreLetsMeet.Core 5   
       LetsMeet.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:LetsMeet     5   	   Ccore2clr-namespace:LetsMeet.Core;assembly=LetsMeet.Core     5   
     � AllowsTransparency  .  � WindowStyle$
 None=�5
   	    � Title$ 
MainWindow��5   	   $	��700��6   $	��900��6)   $	��500��5   	   $	��500��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         LetsMeet.MainWindow �� 
TargetType �� Property �� Value �� 
TargetType	 �� Padding
 ��Name !  BackGroundColorLightGrayBrush �� CornerRadius �� FallbackValue J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Opacity J� OpacityMask !� Visual �� ElementName � RowDefinitions � ColumnDefinitions  BackGroundColorWhiteBrush �� Orientation # BackGroundColorTransparentBrush �� RelativeSource   LetsMeet.ViewModeLocator   Instance �� Source �� 	Converter*   $LetsMeet.BooleanToVisiblityConverter �� ConverterParameter J� SnapsToDevicePixels  	BaseStyle J� IsHitTestVisible  closeButton  BackGroundColorBlueBrush��%�  '        7   7  7  7  7  7  7  �� 5   
   "  6   .�5      ��  � �� 5      �� 5      " �6&   .R�5      �� 	 6"   �� *InnerPadding+._�5      � .+�5   "   �� $
 	Container��6)   8��   5   )   �� *CornerRadiusValue+$ 10���� 5   "   
������� 6<   �� *CornerRadiusValue+$ 20�� 5   &     5   *   $ 0Q�6<   $	 0.5Q�6L   ._�5!   &   �  5#   *   !� 5$   .    6:   �� $ 	Container�� 5'   *   �� 5(   .   ��6<   �� *TitleHeight+$ 50���� 5)   .   $��* �6<   .+�5,   *   �  5-   .   �� 5.   2   $
��Auto �6C   �� 5/   2   $��* �6C   �� 50   2   $
��Auto �6C   .+�5J   .   � $��2��63    5K   2   �� 5L   6   $��* �6G   6S   �� 5M   6   $��* �6G   6S   �� 5N   6   $��* �6G   6S   .+�5Q   2   �� $
 
Container1��69   $��40��5R   5   8�� $ 70��5T   5   �� 5W   2   $ 
Horizontal=�6>   .+�5X   6   � .+�5Y   6   �� 8�� $��40��5\   :   $��0,3,10,3q�5_   �    5Z   :   �� *ActualHeight+ �� *Self+y�5]   <   �� *ApplicationVM.SideMenuVisible+# Z    $
 True�� 5a   :   !� 5b   >    6J   �� $ 
Container1��._�5g   :   �� $	��img��6Y   $��UniformToFill=�6@   $)��#.\Images\ProfilePicture\MyImage.png��6d   5i   7   �� 5j   :   $��10 0 0 5q�5k   ;   
���"�"�$��Right=�5n   =   $��Bottom=�5o   =   $��20��5p   :   $��20��5q   :    5l   :   �� *ActualHeight+ �� *Self+y�5r   <   �� *ApplicationVM.SideMenuVisible+# Z    $
 True�� 5v   >   !� 5w   B    6N   �� $ 
Container1��._�5y   >   �� $��Center=�6H   $��Center=�6c   F� 5z   B   $��11��5{   B   $��11��6M    .  
�������$��2��5~   @   F���Ѐ�  	= Ӏ�  	= ��- @KL @KL @]� �@KL @]� @KL ��-  � 	5   @   5�   ?   5�   ;   5�   7   �� 5�   6   8��  . $��30��6x   $��-��6�   �� 5�   6   8�� $��30��6a   $	��[ ]��6m   �� 5�   6   $��30��6=   8�� $��X��6m   5�   3   5�   /   5�   +   �� 5�   *   $��1��61   }�. 8�� ._�5�   .   �� #��z��6?   6e   5�   +   5�   '   5�   #   5�      5�      5�      5�      5�      5�      '  !System.Windows.Shell.WindowChrome   WindowChrome 5�        5�   
      GlassFrameThickness$ 0q�5�         ResizeBorderThickness 5�      �� *resizeBorderDistance+    CaptionHeight  5�      �� *captionHeight+5�      .��5�      �  5�   
   �� 5�      $
��Auto �6   �� 5�      $��* �6   ��5�   
   �� 5�      ! �� ImageSource$.! (/Images/Backgrounds/emoji-background.png��6   .+�5�   
      LetsMeet.PageHost  -   5        "  Name$" 	MainFrame��5�      $��1��5�      $��
0,0,-0.2,0q�5�      # � DataContext# 5�      �� *ApplicationVM.CurrentPage+# Z  1   +LetsMeet.ApplicationLoginPageValueConverter  $   CurrentPage$ 5�      �� 5�         LetsMeet.UserMenuControl  5�   
   �	   �LetsMeet.BaseAttachedProperty`2[[LetsMeet.AnimateSlideForLeft, LetsMeet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]% 	  Value% 6    �� *ApplicationVM.SideMenuVisible+# Z .��5�      
   LetsMeet.ChatListControl
  5�      5�      5�      