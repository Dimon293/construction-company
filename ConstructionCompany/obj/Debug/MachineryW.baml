   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   G(clr-namespace:ConstructionCompany.ModelsConstructionCompany.Models  5   	   $    ConstructionCompany.MachineryW   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	   ;models(clr-namespace:ConstructionCompany.Models     5   	     � WindowStartupLocation$  CenterOwner=�5	   	    � Title$ Техника��5
   	   $��287.862��6   $��644.956��6*    � Icon$ Icons/main.png��6:    � 	Resources 5       �� 
TargetType   
ToolButton �� 	Resources �� Property �� Value��%�  &	        �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��BitmapScalingMode$ HighQuality=�6H   �� 5       �@��EdgeMode$ Unspecified=�6?   5      5      .�5      ��  �@�Cursor$
 Hand��6'   �� 5       � ��
 ���� 6+   �� 5       � ��$ 24��6'   �� 5       � ��$ 24��6&   �� 5       � ��$ 0q�60   �� 5       �@��CornerRadius$ 4��64   5      5      .��5      �  � RowDefinitions 5   
   �� 5      	 � ColumnDefinitions	 5   
   �� 5       $	��106 �6   �� 5!      .+�5#   
   �� -   5        
 ��Name$
 AddMachinery��5#       J� RenderTransformOrigin$ 4.942,2.617&�6'   #��[  6K   $	��Top=�6o   $��26��6�   $��26��6�   $��11,6,0,0q�6�   $
��Left=�6�    � ToolTip$% Добавить технику��6�   .��5$      �� $��Icons/add.png��6   $��
0, 0, 0, 0q�6+   5%      �� 5&   
   -   5        $
 EditMachinery��5&      $��42,5,0,0q�6(   $	��Top=�6:   $��26��6R   #��[  6^   $ -1.569,0.283&�6�   $
��Left=�6�   $��26��6�   $% Изменить технику��6�   .��5'      �� $��Icons/edit.png��6   $��
0, 0, 0, 0q�6,   5(      �� 5)   
   -   5        $
 DeleteMachinery��5)      $��73,6,0,0q�6+   $ 0.453,-4.25&�6>   $	��Top=�6b   #��[  6z   $��26��6�   $
��Left=�6�   $��26��6�   $# Удалить технику��6�   .��5*      �� $��Icons/del.png��6   $��
0, 0, 0, 0q�6+   5+      �� 5-   
   $��26��6    �� TextWrapping$
 Wrap=�6   $ 
Поиск��6r   $	��Top=�6�   $��1��6�   $��0,5,10,0q�6�   $��16(�6�   ��62   �� *
FilterText+ �� UpdateSourceTrigger$ PropertyChanged=�6�   &   System.Windows.Controls.DataGrid  5.   
   -   5          Name$ MachineryDG��5.      $��10,36,10,10q�6(   $��2��6=      AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�5/   F      SelectionUnit$ FullRow=�50      
�������   HeadersVisibility$ Column=�6\   $��14(�6w   ��6+   �� *Items+   Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ Тип техники��6K      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *MachineryTypeName+6`     54      $ Название��6>   $ 1* 6P    6%   �� *Name+6P   56      57      58      