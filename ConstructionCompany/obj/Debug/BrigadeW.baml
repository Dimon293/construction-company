   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   G(clr-namespace:ConstructionCompany.ModelsConstructionCompany.Models  5   	   "    ConstructionCompany.BrigadeW   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	   ;models(clr-namespace:ConstructionCompany.Models     5   	     � WindowStartupLocation$  CenterOwner=�5	   	    � Title$ Бригады��5
   	   $��287.862��6   $��644.956��6*    � Icon$ Icons/main.png��6:    � 	Resources 5       �� 
TargetType   
ToolButton �� 	Resources �� Property �� Value��%�  &	        �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��BitmapScalingMode$ HighQuality=�6H   �� 5       �@��EdgeMode$ Unspecified=�6?   5      5      .�5      ��  �@�Cursor$
 Hand��6'   �� 5       � ��
 ���� 6+   �� 5       � ��$ 24��6'   �� 5       � ��$ 24��6&   �� 5       � ��$ 0q�60   �� 5       �@��CornerRadius$ 4��64   5      5      .��5      �  � RowDefinitions 5   
   �� 5      	 � ColumnDefinitions	 5   
   �� 5       $	��108 �6   �� 5!      .+�5#   
   �� $��26��6   
 �� TextWrapping$

 Wrap=�6    � ToolTip$ 
Поиск��6r   $	��Top=�6�   $��0,5,10,0q�6�   $��16(�6�   $��1��6�   ��62   �� *
FilterText+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5$   
   -   5         ��Name$ AddMaterial��5$       J� RenderTransformOrigin$ 4.942,2.617&�6&   $	��Top=�6b   $��26��6z   #��[  6�   $��26��6�   $��11,6,0,0q�6�   $
��Left=�6�   $% Добавить бригаду��6�   .��5%      �� $��Icons/add.png��6   $��
0, 0, 0, 0q�6+   5&      �� 5'   
   -   5        $ EditMaterial��5'      $��42,5,0,0q�6'   $	��Top=�69   $��26��6Q   $ -1.569,0.283&�6]   #��[  6�   $
��Left=�6�   $��26��6�   $% Изменить бригаду��6�   .��5(      �� $��Icons/edit.png��6   $��
0, 0, 0, 0q�6,   5)      �� 5*   
   -   5        $ DeleteMaterial��5*      $��73,6,0,0q�6*   #��[  6<   $ 0.453,-4.25&�6`   $	��Top=�6�   $��26��6�   $
��Left=�6�   $��26��6�   $# Удалить бригаду��6�   .��5+      �� $��Icons/del.png��6   $��
0, 0, 0, 0q�6+   5,      &   System.Windows.Controls.DataGrid  5.   
   -   5          Name$ 	BrigadeDG��5.      $��10,36,10,10q�6&      AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�6i      SelectionUnit$ FullRow=�5/      
�������   HeadersVisibility$ Column=�6\   $��2��6w   $��14(�6�   ��6+   �� *Items+   Columns 50      0  *System.Windows.Controls.DataGridTextColumn  51      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6>      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Name+6P     52      $ Бригадир��6G   $ 1* 6Y    6%   �� *BrigadierName+6Y     53      $ Вид работы��6B   $ 1* 6V    6%   �� *
WorkName+6V   55      59      5;      