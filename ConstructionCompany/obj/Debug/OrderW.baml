   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   G(clr-namespace:ConstructionCompany.ModelsConstructionCompany.Models  5   	        ConstructionCompany.OrderW   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	   ;models(clr-namespace:ConstructionCompany.Models     5   	     � Title$  Заказы��5	   	   $��287.862��6   $��644.956��6)    � Icon$ Icons/main.png��69    � 	Resources 5
       �� 
TargetType   
ToolButton �� 	Resources �� Property �� Value��%�  &	        �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��BitmapScalingMode$ HighQuality=�6H   �� 5       �@��EdgeMode$ Unspecified=�6?   5      5      .�5      ��  �@�Cursor$
 Hand��6'   �� 5       � ��
 ���� 6+   �� 5       � ��$ 24��6'   �� 5       � ��$ 24��6&   �� 5       � ��$ 0q�60   �� 5       �@��CornerRadius$ 4��64   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��205 �6   �� 5       � RowDefinitions 5   
   �� 5       .+�5#   
   �� -   5        	 ��Name$	 AddOrder��5#      
 J� RenderTransformOrigin$
 4.942,2.617&�6#   $	��Top=�6H   $��26��6`   $��26��6l   #��[  6w   $��10,6,0,0q�6�   $
��Left=�6�    � ToolTip$! Добавить заказ��6�   .��5$      �� $��Icons/add.png��6   $��
0, 0, 0, 0q�6+   5%      �� 5&   
   -   5        $	 	EditOrder��5&      $��41,5,0,0q�6$   $	��Top=�66   $��26��6N   $
 -1.569,0.283&�6Z   #��[  6   $
��Left=�6�   $��26��6�   $! Изменить заказ��6�   .��5'      �� $��Icons/edit.png��6   $��
0, 0, 0, 0q�6,   5(      �� 5)   
   -   5        $	 DeleteOrder��5)      #��[  6&   $��72,6,0,0q�6K   $
 0.453,-4.25&�6]   $	��Top=�6�   $��26��6�   $
��Left=�6�   $��26��6�   $+ %Редактировать заказ��6�   .��5*      �� $��Icons/del.png��6   $��
0, 0, 0, 0q�6+   5+      �� 5,   
   -   5        $	 BuyMachineryOrder��5,      #��[  6,   $��	165,6,0,0q�6Q   $
 0.453,-4.25&�6d   $	��Top=�6�   $��26��6�   $
��Left=�6�   $��26��6�   $H BРаспределение строительной техники��6�   .��5-      �� $��Icons/ma.png��6   $��
0, 0, 0, 0q�6*   5.      �� 5/   
   -   5        $	 BuyMaterialOrder��5/      #��[  6+   $��	134,6,0,0q�6P   $
 0.453,-4.25&�6c   $	��Top=�6�   $��26��6�   $
��Left=�6�   $��26��6�   $5 /Использование материалов��6�   .��50      �� $��Icons/buy.png��6   $��
0, 0, 0, 0q�6+   51      �� 52   
   -   5        $	 AddBrigadeWorkOrder��52      #��[  6.   $��	103,6,0,0q�6S   $
 0.453,-4.25&�6f   $	��Top=�6�   $��26��6�   $
��Left=�6�   $��26��6�   $- 'Распределение бригад��6�   .��53      �� $��Icons/w.png��6   $��
0, 0, 0, 0q�6)   54      �� 55   
   $��26��6    �� TextWrapping$
 Wrap=�6   $	��Top=�62   $��0,5,10,0q�6J   $��16(�6\   $��1��6j   $ 
Поиск��6�   ��6z   �� *
FilterText+ �� UpdateSourceTrigger$ PropertyChanged=�6�   &   System.Windows.Controls.DataGrid  56   
   -   5          Name$ OrderDG��56      $��10,36,10,10q�6$      AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�57   F      SelectionUnit$ FullRow=�58      
�������   HeadersVisibility$ Column=�6\   $��14(�6w   $��2��6�   ��6+   �� *Items+   Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ Объект��6G      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ObjectAddress+6W     5<      $ Дата начала��6C   $ 1* 6X    6%   �� *	StartDate+6X     5=      $! Дата окончания��6A   $ 1* 6Y    6%   �� *	EndDate+6Y     5>      $ Цена��6?   $ 1* 6M    6%   �� *Price+6M     5?      $ Описание��6>   $ 1* 6P    6%   �� *Note+6P   5A      5F      5G      