   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fT:clr-namespace:MahApps.Metro.Actions;assembly=MahApps.MetroMahApps.Metro.Actions  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35  �� MergedDictionaries �� Source   CustomFlyout ]�Name ��Name  MetroCircleButtonStyle �� RelativeSource �� AncestorType#    MahApps.Metro.Controls.Flyout �� Path �� Mode.  (System.Windows.Interactivity.Interaction   Triggers/  )System.Windows.Interactivity.EventTrigger	   	EventName.  (System.Windows.Interactivity.TriggerBase
   Actions/   )MahApps.Metro.Actions.SetFlyoutOpenAction   Value8  2System.Windows.Interactivity.TargetedTriggerAction   TargetObject J� OpacityMask j� Stretch !� Visual J� Clip � UseLayoutRounding �� Left
 �� Top �� Stretch ��Name  FlyoutHeaderFontSize �� Triggers �� Value �� Binding �� 
TargetName �� Property �� Value �� ScaleX �� Angle  FlyoutTemplate �� 
TargetType �Name'  !System.Windows.VisualStateManager    VisualStateGroups%  System.Windows.VisualStateGroup!   States   System.Windows.VisualState"   
Storyboard# ��Name$ g� 	BeginTime% �� TargetProperty& �� 
TargetName' O� KeyTime( �� 	KeySpline) O� Value* � FocusVisualStyle+ ��Name,    HeaderTemplate- �� Triggers. �� 
TargetType-	  'System.Windows.Input.KeyboardNavigation  FlyoutForegroundBrush  FlyoutBackgroundBrush�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      ;controls,http://metro.mahapps.com/winfx/xaml/controls   5      Factions:clr-namespace:MahApps.Metro.Actions;assembly=MahApps.Metro  5        5      �� 5   
   $G Apack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml?�6   �� 5	   
   $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6   %  &	       7  &	 �    '   �    7   7  �� 5      .R�5   
   ]� $ dpHeader��6   $��10,25,10,10q�5      $��Center=�5      ��. .+�5      �� $	 nav��6   $
��Left=�5      #���  5      $��40��5      $��40��5      $��Segoe UI Symbol)�5      $��16(�5      $��Bottom=�5      ��5      ��  �� "   $ CloseCommand�$ OneWay=�y�5      ��  �� *FindAncestor+"   $ CloseButtonVisibility���5      ��  �� "   $ 
Foreground� 5        5      $	 Click��6%   .
 5         .   5       ��  �� "   5!      5"      .��5%      �� $��20��6   $��15��5&      
������� 5(      !� 5)      $
 Fill=�6&    5*      �� 5+   "   $��48��6)   $��48��5,   )   4 ��        � ��    � �� ���     ���         .  .+�5/   &   F� $��31.6666��6+   $��31.6667��6;   $ 22.1666��6L   $ 22.1667��6b   $
 Fill=�50   +   
�������|��������<R��C�Z��@��=R��m5�����O���C��m5��Ѥ���n5��C0P������n5�H<R�����Z���CѬ<R\�������<R51   +   52   #   54      56      57      �� 58      $ PART_BackButton��59      8��  $��15,0,0,0q�5<      $��Center=�5=      ��58      �� y�5:      ��  �� *FindAncestor+"   $ TitleVisibility�5=      5>       5?   
   �� 5@      $
 Left��5B       5A      �� *
Position+ �� "   .a�5C      �� $	 nav��6    � ��$ Right=�5E      �� 5F      $ PART_BackButton��6    �@��TextAlignment$ Right=�5H      �� 5I      $ PART_BackButton��6    � ��$ 0,0,15,0q�5K      �� 5L      $	 nav��6    �@�LayoutTransform 5N      �� 5O      $ -1Q�6)   5Q      5R      �� 5S      $	 Top��5U       5T      �� *
Position+ �� "   .a�5V      �� $ dpHeader��6    � ��$ 10q�5X      �� 5Y      $	 nav��6    �@�LayoutTransform 5[      �� 5\      $	 -90Q�6*   5^      5_      �� 5`      $ Bottom��5b       5a      �� *
Position+ �� "   .a�5c      �� $ dpHeader��6    � ��$ 10q�5e      �� 5f      $	 nav��6    �@�LayoutTransform 5h      �� 5i      $ 90Q�6*   5k      5l      5n      �� 5p      "   5q      .R�5r   
   � $
 root��6   #��z��5s      #��z��5t      z�5u      T� 5v        5x        5y      .! 5z        Default��6"     5{      Hide��." 5|      �� $# HideStoryboard��6%   .��5}      U� $$ 00:00:00X�6<   $8% 2(UIElement.RenderTransform).(TranslateTransform.X)�5~   <   $
& root��5   <   .\�5�   "   �� $' 00:00:00.750��67   $( 0.25,1,0.05,1��5�   7   $) 0Q�5�   7   	hideFrame��5�   7   5�      U� 5�      $$ 00:00:00X�6<   $8% 2(UIElement.RenderTransform).(TranslateTransform.Y)�5�   <   $
& root��5�   <   .\�5�   "   �� $' 00:00:00.750��67   $( 0.25,1,0.05,1��5�   7   $) 0Q�5�   7   
hideFrameY��5�   7   5�      U� 5�      $$ 00:00:00X�6<   $% (UIElement.Opacity)�5�   <   $
& root��5�   <   .\�5�   "   �� $' 00:00:00.750��67   $( 0.25,1,0.05,1��5�   7   $) 0Q�5�   7   fadeOutFrame��5�   7   5�      5�      5�        5�      Show��." 5�      �� .��5�      U� $$ 00:00:00X�6<   $8% 2(UIElement.RenderTransform).(TranslateTransform.X)�5�   <   $
& root��5�   <   .\�5�   "   �� $' 00:00:00.750��67   $( 0.25,1,0.05,1��5�   7   $) 0Q�5�   7   	showFrame��5�   7   5�      U� 5�      $$ 00:00:00X�6<   $8% 2(UIElement.RenderTransform).(TranslateTransform.Y)�5�   <   $
& root��5�   <   .\�5�   "   �� $' 00:00:00.750��67   $( 0.25,1,0.05,1��5�   7   $) 0Q�5�   7   
showFrameY��5�   7   5�      U� 5�      $$ 00:00:00X�6<   $% (UIElement.Opacity)�5�   <   $
& root��5�   <   .\�5�   "   �� $' 00:00:00.750��67   $( 0.25,1,0.05,1��5�   7   $) 1Q�5�   7   5�      5�      5�        5�      
HideDirect��." 5�      �� .��5�      U� $$ 00:00:00X�6<   $8% 2(UIElement.RenderTransform).(TranslateTransform.X)�5�   <   $
& root��5�   <   .\�5�   "   �� $' 0��67   $) 0Q�5�   7   5�      U� 5�      $$ 00:00:00X�6<   $8% 2(UIElement.RenderTransform).(TranslateTransform.Y)�5�   <   $
& root��5�   <   .\�5�   "   �� $' 0��67   $) 0Q�5�   7   5�      U� 5�      $$ 00:00:00X�6<   $% (UIElement.Opacity)�5�   <   $
& root��5�   <   .\�5�   "   �� $' 0��67   $) 0Q�5�   7   5�      5�      5�        5�      
ShowDirect��." 5�      �� .��5�      U� $$ 00:00:00X�6<   $8% 2(UIElement.RenderTransform).(TranslateTransform.X)�5�   <   $
& root��5�   <   .\�5�   "   �� $' 0��67   $) 0Q�5�   7   5�      U� 5�      $$ 00:00:00X�6<   $8% 2(UIElement.RenderTransform).(TranslateTransform.Y)�5�   <   $
& root��5�   <   .\�5�   "   �� $' 0��67   $) 0Q�5�   7   5�      U� 5�      $$ 00:00:00X�6<   $% (UIElement.Opacity)�5�   <   $
& root��5�   <   .\�5�   "   �� $' 0��67   $) 1Q�5�   7   5�      5�      5�      5�      .+�5�      �� .u�5�      ]� |�.  * 6   Z� .+�5�      �� $+ PART_Header��6'   $	��Top=�5�   '   $��Header��5�   '   #��z, 5�   '   �� 5�      $+ PART_Content��6'   $��Bottom=�5�   '   5�      5�      5�      - 5�   
   �� 5�      $	 Top��5�       5�      �� *
Position+ �� *Self+.a�5�      �� $ PART_Header��6    � ��$
 Left=�5�      �� 5�      $ PART_Content��6    � ��$ Right=�5�      5�      �� 5�      $ Bottom��5�       5�      �� *
Position+ �� *Self+.a�5�      �� $ PART_Header��6    � ��$
 Left=�5�      �� 5�      $ PART_Content��6    � ��$ Right=�5�      5�      5      �� 5     ".   6   .�5  
   ��  � y�$ Hidden=�5     �� 5  
    �@	 ControlTabNavigation$ Cycle=�5     �� 5  
    �@	 TabNavigation$ Cycle=�5     �� 5	  
    �@	 DirectionalNavigation$ Cycle=�5
     �� 5  
    � ��$ Stretch=�5     �� 5  
    � ��$ Stretch=�5     �� 5  
    �@  HeaderTemplate8   5     �� 5  
    � ��8  5     �� 5  
    �@�FocusVisualStyle 5     Z� �� 5  
    � ��# �  5     �� 5  
    � ��# �  5     5     5     