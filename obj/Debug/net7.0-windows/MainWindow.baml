   M S B A M L   `   `   `  ����B  >MyCards, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MyCards.ViewModelsMyCards.ViewModels  5   	       MyCards.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:MyCards.ViewModels     5   	     � Title$  
MainWindow��5   	   $	��700��6   $
��1000��6)   ���#1C2F3E.��5	      � .+�5
   
   �  � RowDefinitions 5      �� 5      $��50 �6    6.   �� 5      6"    � ColumnDefinitions 5      �� 5      $	��250 �6#   61   �� 5      6%   .+�5      �� $��2��6   $
��Left=�6*   $	��250��6E   ���#14212B.+�5      �� -   5         ��Name$ My_Cards��5      $��	0,100,0,0q�6+   $
��Left=�6>   $��20,0,0,0q�6`   
������ 
������ $��50��6�   .��6�   Meine Karten6�   �� 5      -   5        $ Add_Category��5      
������ $
��Left=�6H   $��20,0,0,0q�6j   
������ $��50��6�   .��6�   
Kategorien6�   �� 5      -   5        $ add_Card��5      
������ $
��Left=�6D   $��20,0,0,0q�6f   
������ $��50��6�   
�������.��6�   Karten hinzufügen6�   �� 5      -   5        $ 
My_Profile��5      
������ $
��Left=�6F   $��20,0,0,0q�6h   
������ $��50��6�   .��6�   Mein Profil6�   5      � 5      $��2��6   $	��Top=�6'   $��50��6?   ���#233C4F 5      �� 5      $	��200 �6'   65   �� 5      6)   �� 5       $	��120 �6'   65   .+�5"      �� $��0��6   $��10q�6(   $��Center=�64   $
��Bold"�6O   $��20(�6a   .��6o   Karteikarten6}   �� 5#      $��1��6    �� Orientation$ 
Horizontal=�6-   $��Center=�6F   $��Right=�6a   .+�5$      �� $
��Bold"�6   .��6.   Hallo,66   �� 5%      -   5         ��Name$ lbl_Name��5%      $
��Bold"�6.   5&      �� 5'      -   5        $ logout��5'      
������ $��2��6C   $��40��6S   $	��100��6_   $��Right=�6k   $��Center=�6�   
��� E��.��6�   	Ausloggen6�   5(       � 5,      -   5          �Name$ ContentFrame��5,      $��1��6*   $��1��6:   $��10, 20q�6G     � NavigationUIVisibility$ Hidden=�6W   5.      5/      50      