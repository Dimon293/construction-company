   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   G(clr-namespace:ConstructionCompany.ModelsConstructionCompany.Models  5   	   '    !ConstructionCompany.OrderBrigadeW   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	   ;Models(clr-namespace:ConstructionCompany.Models     5   	     � WindowStartupLocation$  CenterOwner=�5	       � Title$7 1Бригады, выполняющие заказ��5
   	   $��251.862��6,   $��554.956��6=    � Icon$ Icons/main.png��6M    � 	Resources 5       �� 
TargetType   
ToolButton �� 	Resources �� Property �� Value��%�  &	        �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��BitmapScalingMode$ HighQuality=�6H   �� 5       �@��EdgeMode$ Unspecified=�6?   5      5      .�5      ��  �@�Cursor$
 Hand��6'   �� 5       � ��
 ���� 6+   �� 5       � ��$ 24��6'   �� 5       � ��$ 24��6&   �� 5       � ��$ 0q�60   �� 5       �@��CornerRadius$ 4��64   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��21 �6   �� 5      $	��52* �6   �� 5      $��99 �6   �� 5       $	��49* �6   	 � ColumnDefinitions	 5"   
   �� 5#      $
��128* �6   �� 5$      $��37 �6   �� 5%      $
��127* �6   .+�5(   
   &   System.Windows.Controls.DataGrid  -   5        
  Name$
 BrigadeInOrderDG��5(      $��	10,2,4,10q�6-      AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�5*   ;      SelectionUnit$ FullRow=�5+      $��3��6P   $��1��6a   
�������   HeadersVisibility$ Column=�6�   $��14(�6�   ��6%   �� *BrigadesCollection+   Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6>      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Name+6P     5.      $ Вид работы��6B   $ 1* 6V    6%   �� *
WorkName+6V   51        52   
   -   5        $
 BrigadeLeftDG��52      $��	4,2,10,10q�6*    .   . $ Single=�54   ;   $ FullRow=�55      $��2��6C   $��3��6S   $��1��6d   
�������$ Column=�6�   $��14(�6�   ��6%   �� *Items+ 56        57      $ Название��6>   $ 1* 6P    6%   �� *Name+6P     58      $ Вид работы��6B   $ 1* 6V    6%   �� *
WorkName+6V   5:      �� 5;   
   $$��Бригады в заказе��6   $
��Left=�6+   $��	10,-5,0,0q�6F   $	��Top=�6Y   $	��243��6q   $��26��6}   �� 5<   
   $)��#Оставшиеся бригады��6   $��4,-5,0,0q�6-   $	��Top=�6?   $��2��6W   $��26��6g   �� 5=   
   -   5         ��Name$ 
AddBrigade��5=      $
��Left=�6%   $��2,2,0,0q�6@   #��[  6Q   $	��Top=�6u   $��33��6�    J� RenderTransformOrigin$ -0.143,-0.9&�6�   $��38��6�   $��1��6�   $��2��6�   .��5>      �� $��Icons/leftA.png��6   $��
0, 0, 0, 0q�6-   $��28��6A   $��28��6M   5?      �� 5@   
   -   5        $ 
DelBrigade��5@      $
��Left=�6%   $��2,58,0,0q�6@   #��[  6R   $	��Top=�6v   $��33��6�   $ -0.143,-0.9&�6�   $��38��6�   $��1��6�   $��2��6�   .��5A      �� $��Icons/rightA.png��6   $��
0, 0, 0, 0q�6.   $��28��6B   $��28��6N   5B      5D      5E      