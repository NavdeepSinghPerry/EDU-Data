   M S B A M L   `   `   `  ����E  ACustom Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Custom_Wpf
Custom_Wpf  5   	       Custom_Wpf.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Custom_Wpf     5   	     � Icon$  Images/icon.ico��5   	    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ 
MainWindow��5   	   $	��350��6    � WindowStyle$
 None=�6)   $	��525��6<    � 	Resources 5         Custom_Wpf.MainWindow �� 
TargetType �� Property �� Value	 �� 
TargetType
 ��Name �� Padding �� FallbackValue   ForegroundLightBrush �� CornerRadius J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Opacity � RowDefinitions K� ZIndex � ColumnDefinitions  systemIconButton��%7  '        7   7  �� 5   
   "  6   .�5      ��  � �� 5      �� 5      "	 �6&   .R�5      �� $
 	Container��6"    65   �� *OuterMarginSizeThickness+$ 10��._�5      � .+�5   "   �� 8��   6)   �� *WindowCornerRadius+ 5   &     5    *   $ 0Q�6;   $	 0.5Q�6K   6[   5"   #   � 5$   "    5%   &   �� 5&   *   ��68   �� *TitleHeightGridLength+�� 5'   *   $
��Auto �68   6H   �� 5(   *   $��* �68   6E   .+�5*   &   � $��0��6+   $ 1��6<    5+   *   �� 5,   .   $
��Auto �6?   �� 5-   .   $��* �6?   �� 5.   .   $
��Auto �6?   .+�52   *   �� $��0��61   8�� ��6l   �� *MenuCommand+.��53   .   �� $��/Images/logo-small.png��64   6V   54   +   56   '   57   #   58      59      5:      5<      5=      5>      '  !System.Windows.Shell.WindowChrome   WindowChrome 5?        5@   
      GlassFrameThickness$	 200q�5C         ResizeBorderThickness 5A      �� *ResizeBorderThickness+   CaptionHeight 5B      �� *TitleHeight+5C      .��5G      � 
���"�"�5I      5J      