   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   %    ConstructionCompany.AddMaterial   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	     � WindowStartupLocation$  CenterOwner=�5   	    � Title$' !Добавить материал��5	   	   $��Center=�6#    � 
ResizeMode$ NoResize=�6@    � WindowStyle$ 
ToolWindow=�6V   $��467.753��6o   $��213.963��6    � Icon$ Icons/main.png��6�    � 	Resources 5
       �� 
TargetType   
ToolButton �� 	Resources �� Property	 �� Value��%�  &	        �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��BitmapScalingMode$	 HighQuality=�6H   �� 5       �@��EdgeMode$	 Unspecified=�6?   5      5      .�5      ��  �@�Cursor$
	 Hand��6'   �� 5       � ��
	 ���� 6+   �� 5       � ��$	 24��6'   �� 5       � ��$	 24��6&   �� 5       � ��$	 0q�60   �� 5       �@��CornerRadius$	 4��64   5      5      .��5      � $��0,0,0,-3q�6   
 � RowDefinitions
 5   
   �� 5      $	��146 �6    � ColumnDefinitions 5    
   �� 5!      $��0* �6   �� 5"      $	��132 �6   �� 5#      $	��330 �6   .+�5&   
   �� -   5         ��Name$ button_addmaterial��5&      $��276,0,13,-27q�6-   $��40��6D   $��Center=�6P   $��Bottom=�6t   $
��Auto��6�   #��[  6�   $��2��6�    � ToolTip$ Добавить��6�   .��5'      �� $��Icons/ok.png��6   $��
0, 0, 0, 0q�6*   5(      �� 5)   
   $��26��6(    �� TextWrapping$
 Wrap=�64   $	��Top=�6H   $��	4,10,13,0q�6`   $��2��6s   $��Center=�6�   $��16(�6�   ��6   �� *Name+6�   �� 5*   
   $��26��65   $
 Wrap=�6A   $	��Top=�6U   $��	4,41,13,0q�6m   $��2��6�   $��Center=�6�   $��16(�6�   ��6   �� *UnitOfMeasurement+6�   �� 5+   
   $��26��6(   $
 Wrap=�64   $	��Top=�6H   $��	4,72,13,0q�6`   $��2��6s   $��Center=�6�   $��16(�6�   ��6   �� *Area+6�   �� 5,   
   $��Название��6   $	��Top=�6#   $��	10,10,0,0q�6;   $��26��6N   $��1��6Z   �� 5-   
   $��Ед. измерения��6   $	��Top=�6(   $��	10,41,1,0q�6@   $��26��6S   $��1��6_   �� 5.   
   $%��Площадь покрытия��6   $	��Top=�6+   $��	10,72,0,0q�6C   $��26��6V   $��1��6b   �� 5/   
   $��26��6)   $
 Wrap=�65   $	��Top=�6I   $��
4,103,13,0q�6a   $��2��6u   $��Center=�6�   $��16(�6�   ��6   �� *Price+6�   �� 50   
   $��Стоимость��6   $	��Top=�6$   $��
10,103,0,0q�6<   $��26��6P   $��1��6\   51      52      