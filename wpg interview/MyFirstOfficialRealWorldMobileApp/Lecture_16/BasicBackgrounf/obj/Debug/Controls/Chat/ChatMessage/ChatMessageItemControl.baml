   M S B A M L   `   `   `  ����C  ?LetsMeet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:LetsMeetLetsMeet  5      H DLetsMeet.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:LetsMeet.Core;assembly=LetsMeet.CoreLetsMeet.Core 5      %    LetsMeet.ChatMessageItemControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:LetsMeet     5      Ccore2clr-namespace:LetsMeet.Core;assembly=LetsMeet.Core     5      .��5      ��   �� Padding$  10q�6    #  BackGroundColorTransparentBrush#��[  5      ._�5   
   � ��6   �� *
SentByMe+ �� 	Converter +   %LetsMeet.SentByMeToAlignmentConverter   � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $	��Top=�5      $
��Left=�5      
���"�"�$��35��5      ��5      �� *ActualWidth+ �� RelativeSource �� *Self+ �� CornerRadius 5      �� *ActualHeight+ �� *Self+y�5      �� *
SentByMe+ *   $LetsMeet.BooleanToVisiblityConverter  ._�5       �� $��Center=�6   $��Center=�5!      
���������5#      �� *
Initials+68   5$      �� 5&      -   5        $��
TextBubble��5'      $��	25 10 0 0q�5(      $ 10��5*      ��5)      �� *
SentByMe+   ��5+      �� *
SentByMe+ ,   &LetsMeet.SentByMeToBackgroundConverter   � Triggers 5-      :� 5.       :� RoutedEvent$ 
MouseEnter��6#   .[�5/      �� .��50      ��  �� 
TargetName$ Details��51   &    �� TargetProperty$ Opacity�52   &   .��53   "   W� 		 W� To$	 1X�62   
 g� Duration$
 
00:00:00.5D�69   54      56      57      :� 59      $ 
MouseLeave��6#   .[�5:      �� .��5;      �� $ Details��5<   &   $ Opacity�5=   &   .��5>   "   W� $	 0X�62   $
 
00:00:00.5D�69   5?      5A      5B      ._�5F      ��   FontSizeRegular#��[ 6    �� Padding$ 10q�5G      $
��Left=�5H      $��Center=�5I        BackGroundColorBlueBrush#��[ 5K        LatoBoldSubham#��[ 5L      ��5J      �� *	Message+5L      5M      F� 5N      $��0,49.596,10,15.404q�6   "�����    �@����� ��;G    	$��3��5R   k   ��5P   .   �� *
SentByMe+   ��5R      �� *
SentByMe+   6k   �� 5U      -   5        $��Details��5W       J� Opacity$ 0Q�5V      $��2��5X       �� Orientation$ 
Horizontal=�6!   ��5Y      �� *
SentByMe+    �� ConverterParameter$
 True��.+�5\      �� $��	30 0 15 0q�5^       ! BackGroundColorLightGrayBrush#��[ 5`      ��5_      �� *MessageSentTime+ )   #LetsMeet.TimeToDisplayTimeConverter  5`      �� 5d        WordDarkBlueBrush#��[ 5f      $��Right=�5g      ��5e      �� *MessageReadTime+ &    LetsMeet.DateToReadTimeConverter  5g      5j      5l      5m      5n      