   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.TwoWayBinding   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  TwoWayBinding��5   	   $	��450��6   $	��800��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��10,0,0,0q�6    $
��Left=�62   $��1��6M   $��My Category��6Z   $��Center=�6p   $
��Bold"�6�   $��24(�6�   $��62��6�   �� 5   
   $��1��6   $��5q�6    $
��Left=�6+   $��2��6F   $��
Categories��6S   $��Center=�6h   $��18(�6�   �� 5   
   -   5         ��Name$ combo��5      $��1��6"   $��5,0,0,5q�62   $
��Left=�6C   $��3��6^    �� Text$ Search Category��6k   $��Bottom=�6�   $	��300��6�   $��2��6�   $��12(�6�   $��5q�6�   $��Verdana)�6  �� 5   
   $��1��6   $��10,157,0,191q�6    $
��Left=�66   $��7��6Q   $��Recipes��6^   $��Center=�6p   $��18(�6�    J� RenderTransformOrigin$ 
0.57,2.849&�6�   �� 5    
   $��1��6   $��10,214,0,138q�6"   $
��Left=�68   $��7��6S   $��Search Recipe��6`   $��Center=�6u   $	��300��6�   $��12(�6�   $��5q�6�   $��30��6�   �� 5!   
   $��Recipe Title��6   $��1��6'   $��7��67   $��5q�6D   $��Center=�6O   $��Bottom=�6l   &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ empDg��5"      $
��Left=�6"   $	��126��6=   $	��Top=�6J   $	��678��6b      
IsReadOnly . $��5,10,0,0q�6�   $��7��6�   $��1��6�   $��12(�6�   $��Verdana)�6�      	RowHeight$ 25Q�6�   5$      5%      