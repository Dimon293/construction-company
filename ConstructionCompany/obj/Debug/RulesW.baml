   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   G(clr-namespace:ConstructionCompany.ModelsConstructionCompany.Models  5   	        ConstructionCompany.RulesW   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	   ;Models(clr-namespace:ConstructionCompany.Models     5   	     � WindowStartupLocation$  CenterOwner=�5	       � Title$' !Созданные правила��5
   	   $��272.002��6#   $��730.956��64    � Icon$ Icons/main.png��6D    � 	Resources 5       �� 
TargetType   
ToolButton �� 	Resources �� Property �� Value��%�  &	        �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��BitmapScalingMode$ HighQuality=�6H   �� 5       �@��EdgeMode$ Unspecified=�6?   5      5      .�5      ��  �@�Cursor$
 Hand��6'   �� 5       � ��
 ���� 6+   �� 5       � ��$ 24��6'   �� 5       � ��$ 24��6&   �� 5       � ��$ 0q�60   �� 5       �@��CornerRadius$ 4��64   5      5      .��5      � $��0,0,0,-2q�6    � RowDefinitions 5   
   �� 5      $��37 �6   �� 5      	 � ColumnDefinitions	 5    
   �� 5!      $
��121* �6   �� 5"      $	��84* �6   �� 5#      $��63 �6   �� 5$      $��5* �6   �� 5%      $	��81* �6   �� 5&      $��63 �6   �� 5'      $��5* �6   .+�5*   
   &   System.Windows.Controls.DataGrid  -   5        
  Name$
 WorksDG��5*      $��	10,2,9,13q�6$      AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�5,   ;      SelectionUnit$ FullRow=�5-      $��1��6M   
�������   HeadersVisibility$ Column=�6m   $��14(�6�   ��6%   �� *WorksCollection+   Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$ Вид работы��6B      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
WorkName+6V   52        53   
   -   5        $
 MaterialsCountDG��53      $��9,2,0,13q�6-    .   . $ Single=�55   ;   $ FullRow=�56      $��1��6s   
�������$ Column=�6�   $��14(�6�   $��1��6�   $��2��6�   ��6%   �� *" SelectedItem.MaterialsCollection+ �� ElementName$ WorksDG�� 57        58      $ Название��6>   $ 1* 6P    6%   �� *Name+6P   5:        5;   
   -   5        $
 MachineryDG��5;      $��10,2,0.25,13q�6(    .   . $ Single=�5=   ;   $ FullRow=�5>      $��1��6w   
�������$ Column=�6�   $��14(�6�   $��4��6�   $��2��6�   ��6%   �� *&$SelectedItem.MachineryTypeCollection+$ WorksDG�� 5?        5@      $ Тип техники��6B   $ 1* 6W    6%   �� *
TypeName+6W   5B      �� 5C   
   -   5         ��Name$ DeleteMaterial��5C      $��31,3,0,2q�6*    J� RenderTransformOrigin$ 0.453,-4.25&�6=   #��[  6a   $��32��6�   $
��Auto��6�    � ToolTip$% Удалить материал��6�   $��2��6�   $��Center=�6�   .��5D      �� $��Icons/del.png��6   $��
0, 0, 0, 0q�6+   $	��Top=�6?   $��24��6W   $��24��6b   5E      �� 5F   
   -   5        $ AddMaterial��5F      $��0,3,0,2q�6'   $ 0.453,-4.25&�69   #��[  6]   $
��Auto��6�   $
��Left=�6�   $��32��6�   $' !Добавить материал��6�   $��2��6�   .��5G      �� $��Icons/add.png��6   $��
0, 0, 0, 0q�6+   $��Center=�6?   $��24��6Z   $��24��6e   5H      �� 5I   
   -   5        $ AddMachinery��5I      $��0,3,0,2q�6(   $ 0.453,-4.25&�6:   #��[  6^   $
��Auto��6�   $
��Left=�6�   $��32��6�   $% Добавить технику��6�   $��5��6�   .��5J      �� $��Icons/add.png��6   $��
0, 0, 0, 0q�6+   $��26��6?   $��26��6J   $��Center=�6V   5K      �� 5L   
   -   5        $ DeleteMachinery��5L      $ 0.453,-4.25&�6+   $	��Top=�6O   #��[  6g   $��26��6�   $
��Auto��6�   $# Удалить технику��6�   $��5��6�   $��35,6,2,0q�6�   .��5M      �� $��Icons/del.png��6   $��
0, 0, 0, 0q�6+   $��24��6?   $��24��6J   $��Center=�6V   5N      �� 5P   
   $��Вид работы��6   $
��Left=�6%   $	��Top=�6@   $	��195��6X   $��34��6d   $��16(�6p   $��10,0,0,0q�6~   �� 5Q   
   $��Материалы��6   $��	10,0,61,0q�6$   $	��Top=�67   $��34��6O   $��1��6[   $��16(�6k   �� 5R   
   $��Техника��6   $��	12,1,77,0q�6"   $	��Top=�65   $��34��6M   $��4��6Y   $��16(�6i   5S      5T      