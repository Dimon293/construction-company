   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   G(clr-namespace:ConstructionCompany.ModelsConstructionCompany.Models  5   	   O,clr-namespace:ConstructionCompany.ViewModelsConstructionCompany.ViewModels  5   	   (    "ConstructionCompany.MaterialUsingW   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	   ;Models(clr-namespace:ConstructionCompany.Models     5   	   C
ViewModels,clr-namespace:ConstructionCompany.ViewModels     5   	     � WindowStartupLocation$  CenterOwner=�5       � Title$5 /Использование материалов��5   	   $��251.862��6*   $��566.318��6;    � Icon$ Icons/main.png��6K    � 	Resources 5       �� 
TargetType   
ToolButton �� 	Resources �� Property �� Value��%�  &	        �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��BitmapScalingMode$ HighQuality=�6H   �� 5       �@��EdgeMode$ Unspecified=�6?   5      5      .�5      ��  �@�Cursor$
 Hand��6'   �� 5       � ��
 ���� 6+   �� 5       � ��$ 24��6'   �� 5       � ��$ 24��6&   �� 5       � ��$ 0q�60   �� 5       �@��CornerRadius$ 4��64   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��31 �6   �� 5       	 � ColumnDefinitions	 5"   
   �� 5#      $
��247* �6   �� 5$      $��35 �6   �� 5%      $
��276* �6   .+�5(   
   &   System.Windows.Controls.DataGrid  -   5        
  Name$
 BrigadesInOrderDG��5(      $��	10,2,4,10q�6.      AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�5*   ;      SelectionUnit$ FullRow=�5+      $��1��6X   
�������   HeadersVisibility$ Column=�6x   $��14(�6�   $��2��6�   ��6%   �� *BrigadeMaterialsCollection+   Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6E      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *BrigadeName+6W     5.      $ Вид работы��6B   $ 1* 6V    6%   �� *
WorkName+6V   51        52   
   -   5        $
 MaterialsInOrderBrigadeDG��52      $��	4,2,10,10q�66    .   . $ Single=�54   ;   $ FullRow=�55      $��2��6�   $��1��6�   
�������$��14(�6�   $ Column=�6�   ��6%   �� *'%SelectedItem.MaterialsCountCollection+ �� ElementName$ BrigadesInOrderDG�� 56        57      $ Название��6>   $ 1* 6P    6%   �� *Name+6P     58      $ Количество��6?   $ 1* 6S    6%   �� *Count+6S   5:      �� 5;   
   $$��Бригады в заказе��6   $
��Left=�6+   $��10,1,0,0q�6F   $	��203��6X   $��29��6d   $��14(�6p   $	��Top=�6~   $��Center=�6�   �� 5<   
   $-��'Заказанные материалы��6   $��4,1,88,0q�6/   $	��Top=�6A   $��2��6Y   $��29��6i   $��14(�6u   �� 5=   
   -   5         ��Name$ AddMaterial��5=      $��2��6&   $��	235,0,0,0q�66   $	��Top=�6I   #��[  6a   $��30��6�   $
��Left=�6�   $��30��6�    � ToolTip$5 /Добавить материал в заказ��6�   .��5>      �� $��Icons/add.png��6   $��
0, 0, 0, 0q�6+   5?      �� 5@   
   -   5        $ button_ExpertClass��5@      $��	2.5,0,4,0q�6-   $
��Auto��6@   $��31��6M   $	��Top=�6Y   #��[  6q   $F @Автоматическая закупка материалов��6�   $��1��6�   .��5A      �� $��Icons/ep.png��6   $��
0, 0, 0, 0q�6*   $��26��6>   $��24��6J   5B      5D      5E      