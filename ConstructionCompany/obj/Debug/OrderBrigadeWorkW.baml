   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   G(clr-namespace:ConstructionCompany.ModelsConstructionCompany.Models  5   	   +    %ConstructionCompany.OrderBrigadeWorkW   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	   ;Models(clr-namespace:ConstructionCompany.Models     5   	     � WindowStartupLocation$  CenterOwner=�5	       � Title$- 'Распределение бригад��5
   	   $��505.862��6&   $��561.552��67    � Icon$ Icons/main.png��6G    � 	Resources 5       �� 
TargetType   
ToolButton �� 	Resources �� Property �� Value��%�  &	        �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��BitmapScalingMode$ HighQuality=�6H   �� 5       �@��EdgeMode$ Unspecified=�6?   5      5      .�5      ��  �@�Cursor$
 Hand��6'   �� 5       � ��
 ���� 6+   �� 5       � ��$ 24��6'   �� 5       � ��$ 24��6&   �� 5       � ��$ 0q�60   �� 5       �@��CornerRadius$ 4��64   5      5      .��5      � $��0,0,2,0q�6    � RowDefinitions 5   
   �� 5      $��47 �6   �� 5      $
��195* �6   �� 5      $��39 �6   �� 5       $
��194* �6   	 � ColumnDefinitions	 5"   
   �� 5#      $
��129* �6   �� 5$      $��34 �6   �� 5%      $
��130* �6   .+�5(   
   &   System.Windows.Controls.DataGrid  -   5        
  Name$
 WorksDG��5(      $��	0,1,10,10q�6$      AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�5*   ;      SelectionUnit$ FullRow=�5+      $��1��6X   
�������   HeadersVisibility$ Column=�6x   $��14(�6�   $��2��6�   ��6%   �� *WorkWithBrigadesCollection+   Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6B      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
WorkName+6T     5.      $ Стоимость��6@   $ 1* 6S    6%   �� *Tariff+6S   51      �� 52   
   $��Виды работ��6   $��1,7,0,0q�6%   $	��Top=�66   $	��257��6N   $��36��6Z   $��16(�6f   $��2��6t   $
��Left=�6�     53   
   -   5        $
 BrigadeInOrderDG��53      $��
10,1,33,10q�6-    .   . $ Single=�55   ;   $ FullRow=�56      $��1��6P   
�������$ Column=�6p   $��14(�6�   $��3��6�   $��2��6�   ��6%   �� *BrigadesCollection+ 57        58      $ Название��6>   $ 1* 6P    6%   �� *Name+6P     59      $ Вид работы��6B   $ 1* 6V    6%   �� *
WorkName+6V   5<        5=   
   -   5        $
 BrigadeLeftDG��5=      $��	1,1,10,10q�6*    .   . $ Single=�5?   ;   $ FullRow=�5@      $��2��6r   $��3��6�   
�������$ Column=�6�   $��14(�6�   ��6%   �� *!SelectedItem.BrigadesCollection+ �� ElementName$ WorksDG�� 5A        5B      $ Название��6>   $ 1* 6P    6%   �� *Name+6P     5C      $ Вид работы��6B   $ 1* 6V    6%   �� *
WorkName+6V   5E      �� 5F   
   $$��Бригады в заказе��6   $��	10,5,73,0q�6+   $	��Top=�6>   $��36��6V   $��16(�6b   �� 5G   
   $)��#Оставшиеся бригады��6   $��1,4,10,0q�6-   $	��Top=�6?   $��2��6W   $��31��6g   $��16(�6s   $��2��6�   �� 5H   
   -   5         ��Name$ AddBrigadeInOrder��5H      $��	1,157,0,0q�6,   #��[  6?   $	��Top=�6c   $
��Auto��6{    J� RenderTransformOrigin$ -0.143,-0.9&�6�   $��38��6�   $��1��6�   $��1��6�   .��5I      �� $��Icons/leftA.png��6   $��
0, 0, 0, 0q�6-   $��28��6A   $��28��6M    � ToolTip$3 -Добавить бригаду в заказ��6X   5J      �� 5K   
   -   5        $ DelBrigadeFromOrder��5K      $
��Left=�6.   $��	0,0,0,155q�6I   #��[  6\   $��Bottom=�6�   $��33��6�   $ -0.143,-0.9&�6�   $��38��6�   $��3��6�   $��1��6  $5 /Удалить бригаду из заказа��6  .��5L      �� $��Icons/rightA.png��6   $��
0, 0, 0, 0q�6.   $��28��6B   $��28��6N   5M      �� 5N   
   -   5        $ button_ExpertClass��5N      $��	209,0,2,0q�6-   $
��Auto��6@   $��47��6M   $	��Top=�6Y   #��[  6q   $F @Автоматическая закупка материалов��6�   .��5O      �� $��Icons/ep.png��6   $��
0, 0, 0, 0q�6*   $��47��6>   $��47��6J   5P      5Q      5R      