   M S B A M L   `   `   `  ���� D  @ScrcpyGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ScrcpyGUI	ScrcpyGUI      ScrcpyGUI.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:ScrcpyGUI     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  	ScrcpyGUI�� � Icon$A ;D:\.Perso\Dev\Logiciels\ScrcpyGUI\ScrcpyGUI\Assets\icon.png�� � SizeToContent$ WidthAndHeight=�.���� $��10q�.+��� $��70��$��10q�$A��;D:\.Perso\Dev\Logiciels\ScrcpyGUI\ScrcpyGUI\Assets\icon.png���� $	��0,5q� �� Orientation$ 
Horizontal=�.+��� $	��0,5q�.+��� $ 
Horizontal=�.+��� -    ��Name$ always_on_top_checkbox��$��5,5,10,5q�$��Always on top��   RoundCheckBox#���    d� 	IsChecked �� *AlwaysOnTopChecked+ �� Mode$ OneWayToSource=��� $ 
Horizontal=�.+��� -   $ max_fps_checkbox��$��5,5,10,5q�$��Max FPS��#���    �� *MaxFPSChecked+$ OneWayToSource=��� -   $��50��$��Center=�  RoundTextBox#���   �� TextAlignment$ Right=�{���  �� ElementName$ max_fps_checkbox��	 �� Path$	 	IsChecked����� *MaxFPSValue+$ OneWayToSource=��� $��5,5,10,5q�$��	Print FPS��#���    �� *PrintFPSChecked+$ OneWayToSource=��� .+��� $ 
Horizontal=�.+��� -   $ crop_checkbox��$��5,5,10,5q�$
��Crop��#���    �� *CropChecked+$ OneWayToSource=��� $��5,5,10,5q�Width:Height:x:y�� $��Center=�y��� *CropVisibility+.+��� $��Right=�$ 
Horizontal=�.+��� $��5,5,10,5q�Width�� -   $��50��$��Center=�#���  $ Right=�{��� $ crop_checkbox��$	 	IsChecked����� *CropWidthValue+$ OneWayToSource=��� $��Right=�$ 
Horizontal=�.+��� $��5,5,10,5q�Height�� -   $��50��$��Center=�#���  $ Right=�{��� $ crop_checkbox��$	 	IsChecked����� *CropHeightValue+$ OneWayToSource=��� $��Right=�$ 
Horizontal=�.+��� $��5,5,10,5q�
Offset x�� -   $��50��$��Center=�#���  $ Right=�{��� $ crop_checkbox��$	 	IsChecked����� *
CropXValue+$ OneWayToSource=��� $��Right=�$ 
Horizontal=�.+��� $��5,5,10,5q�
Offset y�� -   $��50��$��Center=�#���  $ Right=�{��� $ crop_checkbox��$	 	IsChecked����� *
CropYValue+$ OneWayToSource=��� $��5q�.+��� $ 
Horizontal=�.+��� -	   $ window_title_checkbox��$��5,5,10,5q�$��Window Title��#���    �� *WindowTitleChecked+$ OneWayToSource=��� $��50��$��Center=�#���  $ Right=�{��� $ window_title_checkbox��$	 	IsChecked����� *WindowTitleValue+$ OneWayToSource=��� $ 
Horizontal=�.+��� -
   $  window_borderless_checkbox��$��5,5,10,5q�$��Window borderless��#���    �� *WindowBorderlessChecked+$ OneWayToSource=��� $ 
Horizontal=�.+��� -   $ fullscreen_checkbox��$��5,5,10,5q�$��
Fullscreen��#���    �� *FullscreenChecked+$ OneWayToSource=��� $ 
Horizontal=�.+��� -   $ no_control_checkbox��$��5,5,10,5q�$��
No control��#���    �� *NoControlChecked+$ OneWayToSource=��� $ 
Horizontal=�.+��� -   $ stay_awake_checkbox��$��5,5,10,5q�$��
Stay awake��#���    �� *StayAwakeChecked+$ OneWayToSource=��� $ 
Horizontal=�.+��� -   $ show_touches_checkbox��$��5,5,10,5q�$��Show touches��#���    �� *ShowTouchesChecked+$ OneWayToSource=��� $ 
Horizontal=�.+��� -   $ max_size_checkbox��$��5,5,10,5q�$��Max size��#���    �� *MaxSizeChecked+$ OneWayToSource=��� -   $��50��$��Center=�#���  $ Right=�{��� $ max_size_checkbox��$	 	IsChecked����� *MaxSizeValue+$ OneWayToSource=��� $ 
Horizontal=�.+��� -   $ max_bit_rate_checkbox��$��5,5,10,5q�$��Max bit rate��#���    �� *MaxBitRateChecked+$ OneWayToSource=��� -   $��50��$��Center=�#���  $ Right=�{��� $ max_bit_rate_checkbox��$	 	IsChecked����� *MaxBitRateValue+$ OneWayToSource=��� -   $	��150��  RoundButton#���  .��Launch Scrcpy