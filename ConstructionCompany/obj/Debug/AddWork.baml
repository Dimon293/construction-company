   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   !    ConstructionCompany.AddWork   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	     � WindowStartupLocation$  CenterOwner=�5   	    � Title$# Добавить работу��5	   	   $��Center=�6!    � 
ResizeMode$ NoResize=�6>    � WindowStyle$ 
ToolWindow=�6T   $��464.333��6m   $��189.843��6}    � Icon$ Icons/main.png��6�    � 	Resources 5
       �� 
TargetType   
ToolButton �� 	Resources �� Property	 �� Value��%�  &	        �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��BitmapScalingMode$	 HighQuality=�6H   �� 5       �@��EdgeMode$	 Unspecified=�6?   5      5      .�5      ��  �@�Cursor$
	 Hand��6'   �� 5       � ��
	 ���� 6+   �� 5       � ��$	 24��6'   �� 5       � ��$	 24��6&   �� 5       � ��$	 0q�60   �� 5       �@��CornerRadius$	 4��64   5      5      .��5      � $��0,0,0,0q�6   
 � RowDefinitions
 5   
   �� 5      $	��116 �6    � ColumnDefinitions 5    
   �� 5!      $��0* �6   �� 5"      $	��453 �6   .+�5%   
   �� -   5         ��Name$ button_addwork��5%      $��400,0,13,-26q�6)   $��40��6@   $��Center=�6L   $��Bottom=�6p   $��40��6�   #��[  6�   $��1��6�    � ToolTip$ Добавить��6�   .��5&      �� $��Icons/ok.png��6   $��
0, 0, 0, 0q�6*   5'      �� 5(   
   $��Тип работ��6   $	��Top=�6$   $��10,10,305,0q�6<   $��26��6Q   $��1��6]   �� 5)   
   -   5         ��Name$ comboBox_WorkTypeName��5)      $	��Top=�6P   $��148,10,13,0q�6h   $��1��6}   $��26��6�   $��Center=�6�   $��16(�6�    �� 
IsEditable .  �� Text 62   �� *WorkTypeName+6�   �� 5*   
   $��26��6,    �� TextWrapping$
 Wrap=�68   $	��Top=�6L   $��148,41,13,0q�6d   $��1��6y   $��Center=�6�   $��16(�6�   ��6   �� *
WorkName+6�   �� 5+   
   $,��&Стоимость (по тарифу)��6   $	��Top=�60   $��10,72,305,0q�6H   $��26��6]   $��1��6i   �� 5,   
   $��Название��6   $	��Top=�6#   $��10,41,305,0q�6;   $��26��6P   $��1��6\    J� RenderTransformOrigin$ 	0.5,1.218&�6l   �� 5-   
   $��26��6*   $
 Wrap=�66   $	��Top=�6J   $��148,72,13,0q�6b   $��1��6w   $��Center=�6�   $��16(�6�   ��6   �� *Tariff+6�   5/      50      