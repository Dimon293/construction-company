   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   G(clr-namespace:ConstructionCompany.ModelsConstructionCompany.Models  5   	   !    ConstructionCompany.ObjectW   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	   ;models(clr-namespace:ConstructionCompany.Models     5   	     � Title$  Объекты��5	   	   $��287.862��6   $��644.956��6*    � Icon$ Icons/main.png��6:    � 	Resources 5
       �� 
TargetType   
ToolButton �� 	Resources �� Property �� Value��%�  &	        �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��BitmapScalingMode$ HighQuality=�6H   �� 5       �@��EdgeMode$ Unspecified=�6?   5      5      .�5      ��  �@�Cursor$
 Hand��6'   �� 5       � ��
 ���� 6+   �� 5       � ��$ 24��6'   �� 5       � ��$ 24��6&   �� 5       � ��$ 0q�60   �� 5       �@��CornerRadius$ 4��64   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��107 �6   �� 5       � RowDefinitions 5   
   �� 5       .+�5#   
   �� -   5        	 ��Name$	 	AddObject��5#      
 J� RenderTransformOrigin$
 4.942,2.617&�6$   $	��Top=�6H   $��26��6`   $��26��6l   #��[  6w   $��10,6,0,0q�6�   $
��Left=�6�   
������� � ToolTip$# Добавить объект��6�   .��5$      �� $��Icons/add.png��6   $��
0, 0, 0, 0q�6+   5%      �� 5&   
   -   5        $	 
EditObject��5&      $��41,5,0,0q�6%   $	��Top=�67   $��26��6O   $
 -1.569,0.283&�6[   #��[  6�   $
��Left=�6�   $��26��6�   $# Изменить объект��6�   .��5'      �� $��Icons/edit.png��6   $��
0, 0, 0, 0q�6,   5(      �� 5)   
   -   5        $	 DeleteObject��5)      #��[  6'   $��72,6,0,0q�6L   $
 0.453,-4.25&�6^   $	��Top=�6�   $��26��6�   $
��Left=�6�   $��26��6�   $! Удалить объект��6�   .��5*      �� $��Icons/del.png��6   $��
0, 0, 0, 0q�6+   5+      �� 5-   
   $��26��6    �� TextWrapping$
 Wrap=�6   $ Поиск объект��6r   $	��Top=�6�   $��0,5,10,0q�6�   $��16(�6�   $��1��6�   ��62   �� *
FilterText+ �� UpdateSourceTrigger$ PropertyChanged=�6�   &   System.Windows.Controls.DataGrid  5.   
   -   5          Name$ ObjectDG��5.      $��10,36,10,10q�6%      AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�5/   F      SelectionUnit$ FullRow=�50         HeadersVisibility$ Column=�6I   $��14(�6d   $��2��6r   
���������6+   �� *Items+   Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Адрес��6A      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	Address+6P     54      $ Площадь��6>   $ 1* 6O    6%   �� *Area+6O     55      $ Тип объекта��6H   $ 1* 6]    6%   �� *ObjectTypeName+6]     56      $ Заказчик��6F   $ 1* 6X    6%   �� *CustomerName+6X   58      5<      5=      