   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ConstructionCompany.ModelsConstructionCompany.Models  5   	   9!clr-namespace:ConstructionCompanyConstructionCompany  5   	       ConstructionCompany.WorkW   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;models(clr-namespace:ConstructionCompany.Models     5   	   3local!clr-namespace:ConstructionCompany     5   	     � WindowStartupLocation$  CenterOwner=�5	   	    � Title$ Работы��5
   	   $��287.862��6   $��644.956��6)    � Icon$ Icons/main.png��69    � 	Resources 5       �� 
TargetType   
ToolButton �� 	Resources �� Property �� Value��%�  &	        �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��BitmapScalingMode$ HighQuality=�6H   �� 5       �@��EdgeMode$ Unspecified=�6?   5      5      .�5      ��  �@�Cursor$
 Hand��6'   �� 5       � ��
 ���� 6+   �� 5       � ��$ 24��6'   �� 5       � ��$ 24��6&   �� 5       � ��$ 0q�60   �� 5       �@��CornerRadius$ 4��64   5      5      .��5      �  � RowDefinitions 5   
   �� 5      	 � ColumnDefinitions	 5    
   �� 5!      $	��111 �6   �� 5"      .+�5$   
   �� -   5        
 ��Name$
 AddWork��5$       J� RenderTransformOrigin$ 4.942,2.617&�6"   $	��Top=�6F   #��[  6^   $��26��6�   $��26��6�   $��10,6,0,0q�6�   $
��Left=�6�    � ToolTip$# Добавить работу��6�   .��5%      �� $��Icons/add.png��6   $��
0, 0, 0, 0q�6+   5&      �� 5'   
   -   5        $
 EditWork��5'      $��41,5,0,0q�6#   $	��Top=�65   $��26��6M   $ -1.569,0.283&�6Y   $
��Left=�6~   #��[  6�   $��26��6�   $# Изменить работу��6�   .��5(      �� $��Icons/edit.png��6   $��
0, 0, 0, 0q�6,   5)      �� 5*   
   -   5        $
 
DeleteWork��5*      $��72,6,0,0q�6&   $ 0.453,-4.25&�68   #��[  6\   $	��Top=�6�   $��26��6�   $
��Left=�6�   $��26��6�   $! Удалить работу��6�   .��5+      �� $��Icons/del.png��6   $��
0, 0, 0, 0q�6+   5,      �� 5-   
   $��26��6    �� TextWrapping$
 Wrap=�6   $# Поиск работника��6s   $	��Top=�6�   $��0,5,10,0q�6�   $��16(�6�   $��1��6�   ��62   �� *
FilterText+ �� UpdateSourceTrigger$ PropertyChanged=�6�   &   System.Windows.Controls.DataGrid  5.   
   -   5          Name$ WorkDG��5.      $��10,36,10,10q�6#   $��2��68      AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�5/   E      SelectionUnit$ FullRow=�50         HeadersVisibility$ Column=�6I   $��14(�6d   
���������6+   �� *Items+   Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ Тип работ��6F      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *WorkTypeName+6Y     54      $ Название��6B   $ 1* 6T    6%   �� *
WorkName+6T     55      $* $Стоимость по тарифу��6@   $ 1* 6]    6%   �� *Tariff+6]   57      5:      5;      