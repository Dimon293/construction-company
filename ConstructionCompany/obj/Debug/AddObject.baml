   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   #    ConstructionCompany.AddObject   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	     � WindowStartupLocation$  CenterOwner=�5   	    � Title$# Добавить объект��5	   	   $��Center=�6!    � 
ResizeMode$ NoResize=�6>    � WindowStyle$ 
ToolWindow=�6T   $��503.468��6m   $��222.18��6}    � Icon$ Icons/main.png��6�    � 	Resources 5
       �� 
TargetType   
ToolButton �� 	Resources �� Property	 �� Value��%�  &	        �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��BitmapScalingMode$	 HighQuality=�6H   �� 5       �@��EdgeMode$	 Unspecified=�6?   5      5      .�5      ��  �@�Cursor$
	 Hand��6'   �� 5       � ��
	 ���� 6+   �� 5       � ��$	 24��6'   �� 5       � ��$	 24��6&   �� 5       � ��$	 0q�60   �� 5       �@��CornerRadius$	 4��64   5      5      .��5      � $	��196��6   $	��Top=�6   $��	0,0,-6,-2q�60   
 � RowDefinitions
 5   
   �� 5       � ColumnDefinitions 5    
   �� 5!      $��0* �6   �� 5"      .+�5%   
   �� -   5         ��Name$ button_addobject��5%      $��412,137,47,0q�6+   $��40��6B   $��Center=�6N   $	��Top=�6r   $��40��6�   #��[  6�   $��1��6�    � ToolTip$ Добавить��6�   .��5&      �� $��Icons/ok.png��6   $��
1, 1, 1, 1q�6*   5'      �� 5)   
   $��26��6+    �� TextWrapping$
 Wrap=�67   $	��Top=�6K   $��	96,7,47,0q�6c   $��1��6v   $��Center=�6�   $��16(�6�   ��6   �� *	Address+6�   �� 5*   
   $��26��6(   $
 Wrap=�64   $	��Top=�6H   $��
96,38,47,0q�6`   $��1��6t   $��Center=�6�   $��16(�6�   ��6   �� *Area+6�   �� 5+   
   -   5         ��Name$ comboBox_ObjectTypeName��5+      $	��Top=�6T   $��
96,69,47,0q�6l   $��1��6�   $��26��6�   $��Center=�6�   $��16(�6�    �� 
IsEditable .  �� Text 64   �� *ObjectTypeName+6�   �� 5,   
   -   5        $ comboBox_CustomerName��5,      $	��Top=�6P   $��96,100,47,0q�6h   $��1��6}   $��26��6�   $��Center=�6�   $��16(�6�    .  62   �� *CustomerName+6�   �� 5.   
   $��
Адрес��6   $	��Top=�6    $��
10,7,407,0q�68   $��26��6L   $��1��6X   �� 5/   
   $��Площадь��6   $	��Top=�6"   $��10,38,407,0q�6:   $��26��6O   $��1��6[   �� 50   
   $��Тип объекта��6   $	��Top=�6&   $��10,69,407,0q�6>   $��26��6S   $��1��6_   �� 51   
   $��Заказчик��6   $	��Top=�6#   $��10,100,407,0q�6;   $��26��6Q   $��1��6]   �� 53   
   -   5        $ button_addcustomer��53      $��1��6-   $��453,100,10,0q�6=   $	��Top=�6S   #��[  6k    J� RenderTransformOrigin$ 0.571,0.133&�6�   $��26��6�   $��26��6�   $6 0Добавить нового заказчика��6�   .��54      �� $��Icons/add.png��6   $��
1, 1, 1, 1q�6+   55      57      58      