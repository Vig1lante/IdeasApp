   M S B A M L   `   `   `  ����C  ?IdeasApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:IdeasApp.ViewsIdeasApp.Views  5   	   !    IdeasApp.Views.AddEntryView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   .localclr-namespace:IdeasApp.Views     5   	     � Title$  AddEntryView��5   	    � WindowStartupLocation$ CenterScreen=�6    � SizeToContent$ WidthAndHeight=�5   	   ��5      �� 5   
    �� ImageSource$ bg.png��6    j� Stretch$
 None=�6*   .��5
      � $��15q�6    � ColumnDefinitions 5   
   �� 5      $	��400 �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � 	 � Color$	 	#FF25A89C��6#   
 � Offset$
 0Q�65   � 5      $	 	#FF92ECF5��6#   $
 1Q�65   5      .+�5      �� $��New record details��6   
�������$��Center=�5   +   $��Center=�6H   $��20(�5      $
��Bold"�6&   $��Candara)�68   5      �� 5   
   $��1��6   .+�5       �� $��Category��6   $��Candara light)�6(   $��15(�6C   �� 5!      -   5         ��Name$ categoryInput��5!      ��6-   �� *NewEntryCategory+ �� Mode$ TwoWay=�6^   �� 5"      $��TaskName��6   $��Candara light)�6(   $��15(�6C   �� 5#      -   5        $ taskNameInput��5#      ��6-   �� *NewEntryTaskName+$ TwoWay=�6^   �� 5$      $��Deadline��6   $��Candara light)�6(   $��15(�6C   �� 5%      -   5        $ deadlineInput��5%      6/   �� 5&      $��Priority��6   $��Candara light)�6(   $��15(�6C   �� 5'      -   5        $ priorityInput��5'      ��6-   �� *NewEntryPriority+$ TwoWay=�6^   �� 5(      $��Estimated Time��6   $��Candara light)�6.   $��15(�6I   �� 5)      -   5        $ estTimeInput��5)      ��6,   �� *NewEntryEstTime+$ TwoWay=�6\   5*      �� 5+   
   -   5         ��Name$ AddButton_Click��5+      $��2��6*   $��Center=�67   $��75��5,      $��Candara Light)�6   $��20(�6:   $��Center=�6H      RoundButtonTemplate#��[  5-      $��36��6>   $��164,0,155,-10q�6J   $��81��6a    J� Effect 5.      3  -System.Windows.Media.Effects.DropShadowEffect  5/         Opacity$	 0.3Q�6#   ��51      �� 52      $ ADD.png��6   54      55      56      