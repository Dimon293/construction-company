   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   *    $ConstructionCompany.AddMaterialUsing   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	     � WindowStartupLocation$  CenterOwner=�5   	    � Title$5 /Использование материалов��5	   	   $��Center=�6*    � 
ResizeMode$ NoResize=�6G    � WindowStyle$ 
ToolWindow=�6]   $��482.997��6v   $��223.967��6�    � Icon$ Icons/main.png��6�    � 	Resources 5
       �� 
TargetType   
ToolButton �� 	Resources �� Property	 �� Value��%�  &	        �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��BitmapScalingMode$	 HighQuality=�6H   �� 5       �@��EdgeMode$	 Unspecified=�6?   5      5      .�5      ��  �@�Cursor$
	 Hand��6'   �� 5       � ��
	 ���� 6+   �� 5       � ��$	 24��6'   �� 5       � ��$	 24��6&   �� 5       � ��$	 0q�60   �� 5       �@��CornerRadius$	 4��64   5      5      .��5      � $��0,0,0,-3q�6   
 � RowDefinitions
 5   
   �� 5      $	��246 �6    � ColumnDefinitions 5    
   �� 5!      $��0 �6   �� 5"      $	��547 �6   .+�5%   
   �� -   5         ��Name$ button_addmaterialusing��5%      $��384,0,123,68q�62   $��40��6I   $��Center=�6U   $��Bottom=�6y   $��40��6�   #��[  6�   $��1��6�    � ToolTip$ Добавить��6�   .��5&      �� $��Icons/ok.png��6   $��
0, 0, 0, 0q�6*   5'      �� 5)   
   -   5         ��Name$ comboBox_MaterialName��5)      $	��Top=�6R   $��111,10,123,0q�6j   $��1��6�   $��26��6�   $��Center=�6�   $��16(�6�    �� 
IsEditable .  �� Text 63   �� *MaterialName+6�   �� 5+   
   -   5         ��Name$ textBox_Count��5+      $��26��6@    �� TextWrapping$
 Wrap=�6L   $	��Top=�6`   $��111,42,123,0q�6x   $��1��6�   $��Center=�6�    J� RenderTransformOrigin$ 0.462,0.487&�6�   $��16(�6�   ��6)   �� *Count+6�   (  "System.Windows.Controls.DatePicker  5,   
   $��1��68   $��111,73,123,0q�6H   $	��Top=�6^   $��26��6v   $
��Left=�6�   $��Center=�6�   $ 0.436,0.474&�6�   $��14(�6�      Text 6   �� *Date+ �� Mode$ TwoWay=�6�   �� 5/   
   -   5         ��Name$ countingPrice��5/      $��2��6'   $
��Left=�6;   $��111,104,0,0q�6V   $	��Top=�6k   $	��313��6�   $��26��6�   
���������6�   �� *Price+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 51   
   $��Материал��6   $	��Top=�6#   $��10,10,455,0q�6;   $��26��6P   $��1��6\   �� 52   
   $��Количество��6   $	��Top=�6%   $��10,42,455,0q�6=   $��26��6R   $��1��6^   �� 53   
   $��Дата��6   $	��Top=�6   $��10,73,455,0q�67   $��26��6L   $��1��6X   �� 54   
   $��Стоимость��6   $	��Top=�6$   $��10,104,455,0q�6<   $��26��6R   $��1��6^   �� 56   
   -   5        $ button_addbrigade��56      $��1��6,   $��
429,10,0,0q�6<   $	��Top=�6P   #��[  6h   $ 0.571,0.133&�6�   $��26��6�   $��26��6�   $
��Left=�6�   $2 ,Добавить новый материал��6�   .��57      �� $��Icons/add.png��6   $��
0, 0, 0, 0q�6+   58      5;      5<      