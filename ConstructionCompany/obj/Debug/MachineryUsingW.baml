   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   G(clr-namespace:ConstructionCompany.ModelsConstructionCompany.Models  5   	   )    #ConstructionCompany.MachineryUsingW   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	   ;Models(clr-namespace:ConstructionCompany.Models     5   	     � WindowStartupLocation$  CenterOwner=�5	       � Title$/ )Использование техники��5
   	   $��505.862��6'   $��561.552��68    � Icon$ Icons/main.png��6H    � 	Resources 5       �� 
TargetType   
ToolButton �� 	Resources �� Property �� Value��%�  &	        �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��BitmapScalingMode$ HighQuality=�6H   �� 5       �@��EdgeMode$ Unspecified=�6?   5      5      .�5      ��  �@�Cursor$
 Hand��6'   �� 5       � ��
 ���� 6+   �� 5       � ��$ 24��6'   �� 5       � ��$ 24��6&   �� 5       � ��$ 0q�60   �� 5       �@��CornerRadius$ 4��64   5      5      .��5      � $��0,0,2,0q�6    � RowDefinitions 5   
   �� 5      $��47 �6   �� 5      $
��162* �6   �� 5      $��38 �6   �� 5       $��47 �6   �� 5!      $
��181* �6   	 � ColumnDefinitions	 5#   
   �� 5$      �� 5%      .+�5(   
   &   System.Windows.Controls.DataGrid  -   5        
  Name$
 MachineryDG��5(      $��
10,1,10,10q�6(      AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�5*   ;      SelectionUnit$ FullRow=�5+      $��1��6{   
�������   HeadersVisibility$ Column=�6�   $��14(�6�   $��1��6�   ��6%   �� *'%SelectedItem.MachineryUsingCollection+ �� ElementName$ 
BrigadesDG��   Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ Тип��6K      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *MachineryTypeName+6X     5.      $ Название��6>   $ 1* 6P    6%   �� *Name+6P   51      �� 52   
   $-��'Используемая техника��6   $��10,7,0,0q�6/   $	��Top=�6A   $	��237��6Y   $��36��6e   $��16(�6q   $��1��6   $
��Left=�6�     53   
   -   5        $
 
BrigadesDG��53      $��
10,1,10,10q�6'    .   . $ Single=�55   ;   $ FullRow=�56      $��1��6X   
�������$ Column=�6x   $��14(�6�   $��4��6�   ��6%   �� *BrigadeMachineryCollection+ 57        58      $ Название��6E   $ 1* 6W    6%   �� *BrigadeName+6W     59      $ Вид работы��6B   $ 1* 6V    6%   �� *
WorkName+6V   5<        5=   
   -   5        $
 MachineryLeftDG��5=      $��
10,0,10,10q�6,    .   . $ Single=�5?   ;   $ FullRow=�5@      $��1��6Q   $��4��6a   
�������$ Column=�6�   $��14(�6�   ��6%   �� *MachineryCollection+ 5A        5B      $ Тип��6K   $ 1* 6X    6%   �� *MachineryTypeName+6X     5C      $ Название��6>   $ 1* 6P    6%   �� *Name+6P   5E      �� 5F   
   $$��Бригады в заказе��6   $��	10,7,98,0q�6+   $	��Top=�6>   $��36��6V   $��16(�6b   �� 5G   
   $)��#Оставшаяся техника��6   $��	10,5,10,0q�6-   $	��Top=�6@   $��1��6X   $��37��6h   $��16(�6t   $��3��6�   �� 5H   
   -   5         ��Name$  AddMachineryInOrderBrigade��5H      $��
53,0,174,0q�65   #��[  6I   $��33��6m    J� RenderTransformOrigin$ -0.143,-0.9&�6x   $��38��6�   $��2��6�   $��1��6�   $
��Left=�6�   $	��Top=�6	   � ToolTip$A ;Добавить технику в используемую��6!  .��5I      �� $��Icons/leftA.png��6   $��
0, 0, 0, 0q�6-   $��28��6A   $��28��6M   $ 0.5,0.5&�6X   $��Right=�6x   z�5J      V� 5K      .~�5L      �� �� 5M      �� 5N       �� Angle$ 90Q�6*   T� 5O      5P      5R      5S      �� 5T   
   -   5        $" DelMachineryFromOrderBrigade��5T      $��0,0,53,0q�67   #��[  6I   $��33��6m   $ -0.143,-0.9&�6x   $��38��6�   $��2��6�   $	��Top=�6�   $��1��6�   $��Right=�6�   $= 7Добавить технику в оставшуюся��6$  .��5U      �� $��Icons/rightA.png��6   $��
0, 0, 0, 0q�6.   $��28��6B   $��28��6N   $ 0.5,0.5&�6Y   z�5V      V� 5W      .~�5X      �� �� 5Y      �� 5Z      $ 90Q�6*   T� 5[      5\      5^      5_      �� 5`   
   -   5        $ button_ExpertClass��5`      $��
219,1,10,0q�6-   $	��Top=�6A   $
��Auto��6Y   $��47��6f   #��[  6�   $L FАвтоматическое распределение техники��6�   $��2��6�   .��5a      �� $��Icons/ma.png��6   $��
0, 0, 0, 0q�6*   $��47��6>   $��47��6J   $ 0.5,0.5&�6U   5b      5d      5e      