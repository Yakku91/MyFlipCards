   M S B A M L   `   `   `  ����B  >MyCards, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MyCards.ViewModelsMyCards.ViewModels  5          MyCards.Pages.MyCards   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:MyCards.ViewModels     5        N� Title$  MyCards��5	       � DataContext 5
      &    MyCards.ViewModels.CardViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   �  � ColumnDefinitions 5      �� 5      $	��120 �6#   61   �� 5      $	��500 �6#   61   �� 5      6%    5      �� 5      6"   .+�5      �� -   5        $	��ddd��5      $��Center=�6   .��6:   	Kategorie6E   �� 5      -   5         ��Name$ comboBox_Categories��5       �� DisplayMemberPath$
 Name��6W    �� SelectedValuePath$ Id��6p    �� SelectedIndex$ 0��6�   $��35��6�   $��1��6�   $
��20,0q�6�   ��64   �� *
Categories+ �� SelectedItem 6�   �� *
MyCategory+6!  5      �� 5   
   $��1��6   
������ $��Disabled=�6X   ��6    �� *Cards+��5       �� 5!      .R�5"      � 	 � Orientation$	 
Horizontal=�6    5#      ��5%      �� 5&      .R�5'      � $��	wrapPanel��6    .+�5(      �� 
 ��Name$
 border��6<   -   5        $	��0,5q�5(   L   $	��200��6Y   $	��200��6f   
��� � � �� CornerRadius$ 10��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ._�5)      ]�  ]�Name$ 	dockPanel��6(   .+�5*   "   �� $��
btn_Delete��6)   -   5        $	��Top=�5*   ;   
������ $��30��6i   $��30��6t   $��Right=�6�   .��5+   &   �� .+�5,   *   ��  ��Name$ 
img_Delete��6G   $��20��60   $��30��6;   $��/Pages/delete-button.png��6[   5-   '   5.   #   �� 5/   "    ��Name$ lbl_Card��6(   $��20(�6:   $��Center=�6b   $��Center=�6   ��6H   �� *Front+6   50      51      52      53      55      56      57      