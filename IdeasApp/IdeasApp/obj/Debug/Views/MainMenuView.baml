   M S B A M L   `   `   `  ����C  ?IdeasApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:IdeasApp.ViewsIdeasApp.Views  5   	   !    IdeasApp.Views.MainMenuView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:IdeasApp.Views     5   	   $	��400��5   	   $	��750��6   ���	#FF00E8FF  � Cursor$	  Pen��5	       $y�Visible=�5
   	   $��0,0,0,0q�6   .��5      � ��5   
   �� 5       �� ImageSource$ /Images/bg.png��6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��/Images/logo.png��6   $��1��5      $��2��6    $��3��6-   $
��None=�6>   $��Center=�5      �� 5    
   $��1��6   $��0��6%   $��Center=�62    �� Orientation$ 
Horizontal=�6O   $��0,10,0,0q�6h    J� Effect 5!      3  -System.Windows.Media.Effects.DropShadowEffect  5"         Opacity$	 0.3Q�6#   .+�5$      �� $��Import��6   $��1��6&   $��5��66   $��Center=�6C   $	��100��5%      $��30��6    $��Candara Light)�6/   $��18(�6J      RoundButtonTemplate#��[  6X   
���������5&      �� 5'       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5(      � 	 � Color$	 	#FF26ACA6��6'   
 � Offset$
 0Q�69   � 5)      $	 	#FFB9E8E8��6'   $
 1Q�69   5*      5,      �� 5-      $��Calendar��6   $��1��6(   $��5��68   $��Center=�6E   $	��100��5.      $��Candara Light)�6    $��18(�6;   #��[  6I   ��5/      �� 50      $ 0.5,1&�6*   $ 0.5,0&�6;   .��51      � $	 	#FF26ACA6��6'   $
 0Q�69   � 52      $	 	#FFB9E8E8��6'   $
 1Q�69   53      55      �� 56      $��Export��6   $��1��6&   $��5��66   $��Center=�6C   $	��100��57      $��Candara Light)�6    $��18(�6;   #��[  6I   ��58      �� 59      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5:      � $	 	#FF26ACA6��6'   $
 0Q�69   � 5;      $	 	#FFB9E8E8��6'   $
 1Q�69   5<      5>      5@      �� 5B   
   -   5         ��Name$ LoadTasksList��5B      $��	Organizer��6(   $��1��6<   $��5��6L   $��Center=�6Y   $��50��5C      $	��150��6    $��Candara Light)�6/   $��20(�6J   #��[  6X    J� RenderTransformOrigin$ 0.5,0.5&�6�   ��5D      �� 5E      $ 0.5,1&�6&   $ 0.5,0&�67   .��5F      � $	 	#FF26ACA6��6#   $
 0Q�65   � 5G      $	 	#FF88EFFF��6#   $
 1Q�65   5H       5J        5K      $	 0.5Q�6#   5M      �� 5N   
   -   5         ��Name$ 
ActiveItem��5N      $��0��6-   $��0��6=   $��3��6J   $��8��6^    � IsSharedSizeScope . 6o   5O      5P      