   M S B A M L   `   `   `  ����B  >MyCards, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MyCards.ViewModelsMyCards.ViewModels  5          MyCards.Pages.AddCategory   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:MyCards.ViewModels     5        N� Title$  AddCategory��5	       N� 
Background
 ����  � DataContext 5      *  $MyCards.ViewModels.CategoryViewModel  5   
   6$   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   �  � ColumnDefinitions 5      �� 5      $	��120 �6#   61   �� 5      6%   �� 5      $	��300 �6#   61    5      �� 5      6"   .+�5      �� $��Center=�6   .��6/   Neue Kategorie:6@   �� 5      -   5         ��Name$ txtBox_Category��5      $��35��6u   $��1��6�   $
��20,0q�6�   ��6/   �� *myCategory.Name+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      -   5         ��Name$ btn_Add_Category��5      $��2��6/   
������ .��6w   Hinzufügen6�   5      �� 5    
   $��1��6   
������ $��Disabled=�6]   ��6    �� *
Categories+��5!      �� 5"      .R�5#      �  � Orientation$ 
Horizontal=�6    5$      ��5&      �� 5'      .R�5(      � $��	wrapPanel��6    .+�5)      �� 	 ��Name$	 border��6!   $	��200��61   $	��200��6>   $	��5,8q�6J   
��� � �
 �� CornerRadius$
 10��6j    J� RenderTransformOrigin$ 0.5,0.5&�6|   ._�5*      ]�  ]�Name$ 	dockPanel��6(   .+�5+   "   �� $��btn_Edit��6)   -   5        $	��Top=�5+   9   
������ $��40��6g   $��35��6r   $��Right=�6�   .��5,   &   �� .+�5-   *   ��  ��Name$ img_Edit��6G   $��40��60   $��35��6;   $��/Pages/edit.png��6Y   5.   '   5/   #   �� 50   "    ��Name$ lbl_Card��6(   $��20(�6:   $��Center=�6a   $��Center=�6~   ��6H   �� *Name+6~   51      52      53      54      56      57      58      