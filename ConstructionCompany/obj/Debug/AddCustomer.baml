   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   %    ConstructionCompany.AddCustomer   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	     � WindowStartupLocation$  CenterOwner=�5   	    � Title$) #Добавить заказчика��5	   	   $��Center=�6$    � 
ResizeMode$ NoResize=�6A    � WindowStyle$ 
ToolWindow=�6W   $	��509��6p   $��251.634��6|    � Icon$ Icons/main.png��6�    � 	Resources 5
       �� 
TargetType   
ToolButton �� 	Resources �� Property	 �� Value��%�  &	        �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��BitmapScalingMode$	 HighQuality=�6H   �� 5       �@��EdgeMode$	 Unspecified=�6?   5      5      .�5      ��  �@�Cursor$
	 Hand��6'   �� 5       � ��
	 ���� 6+   �� 5       � ��$	 24��6'   �� 5       � ��$	 24��6&   �� 5       � ��$	 0q�60   �� 5       �@��CornerRadius$	 4��64   5      5      .��5      � $��0,0,0,2q�6   
 � RowDefinitions
 5   
   �� 5      $	��209 �6    � ColumnDefinitions 5    
   �� 5!      $��0* �6   �� 5"      $	��107 �6   �� 5#      $	��393 �6   .+�5&   
   �� -   5         ��Name$ button_addcustomer��5&      $��
341,0,13,5q�6-   $��40��6B   $��Center=�6N   $��Bottom=�6r   $��40��6�   #��[  6�   $��2��6�    � ToolTip$ Добавить��6�   .��5'      �� $��Icons/ok.png��6   $��
0, 0, 0, 0q�6*   5(      �� 5)   
   $��26��6-    �� TextWrapping$
 Wrap=�69   $	��Top=�6M   $��	0,10,13,0q�6e   $��2��6x   $��Center=�6�   $��16(�6�   ��6   �� *
LastName+6�   �� 5*   
   $��26��6-   $
 Wrap=�69   $	��Top=�6M   $��	0,41,13,0q�6e   $��2��6x   $��Center=�6�   $��16(�6�   ��6   �� *	FirstName+6�   �� 5+   
   $��26��6.   $
 Wrap=�6:   $	��Top=�6N   $��	0,72,13,0q�6f   $��2��6y   $��Center=�6�   $��16(�6�   ��6   �� *
Patronymic+6�   �� 5,   
   $��26��6*   $
 Wrap=�66   $	��Top=�6J   $��
0,103,13,0q�6b   $��2��6v   $��Center=�6�   $��16(�6�   ��6   �� *Phone+6�   �� 5-   
   $��26��6)   $
 Wrap=�65   $	��Top=�6I   $��
0,134,13,0q�6a   $��2��6u   $��Center=�6�   $��16(�6�   ��6   �� *Email+6�   �� 5.   
   $��Имя��6   $	��Top=�6   $��	10,41,0,0q�66   $��26��6I   $��1��6U   �� 5/   
   $��Фамилия��6   $	��Top=�6"   $��	10,10,0,0q�6:   $��26��6M   $��1��6Y   �� 50   
   $��Телефон��6   $	��Top=�6"   $��
10,103,0,0q�6:   $��26��6N   $��1��6Z   �� 51   
   $��Отчество��6   $	��Top=�6#   $��	10,72,0,0q�6;   $��26��6N   $��1��6Z   �� 52   
   $��Эл. почта��6   $	��Top=�6$   $��
10,134,0,0q�6<   $��26��6P   $��1��6\   54      55      