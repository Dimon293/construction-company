   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   +    %ConstructionCompany.AddMachineryUsing   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	     � WindowStartupLocation$  CenterOwner=�5   	    � Title$/ )Использование техники��5	   	   $��Center=�6'    � 
ResizeMode$ NoResize=�6D    � WindowStyle$ 
ToolWindow=�6Z   $��452.497��6s   $��221.621��6�    � Icon$ Icons/main.png��6�    � 	Resources 5
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
   �� -   5         ��Name$ button_addmachineryusing��5%      $��384,0,123,68q�63   $��40��6J   $��Center=�6V   $��Bottom=�6z   $��40��6�   #��[  6�   $��1��6�    � ToolTip$ Добавить��6�   .��5&      �� $��Icons/ok.png��6   $��
0, 0, 0, 0q�6*   5'      �� 5+   
   -   5         ��Name$ comboBox_MachineryName��5+      $��26��6R   $	��Top=�6_   $��133,42,123,0q�6w   $��1��6�   $��Center=�6�    J� RenderTransformOrigin$ 0.462,0.487&�6�   $��16(�6�    �� Text 63   �� *MachineryName+6�   �� 5-   
   $��Тип техники��6   $	��Top=�6&   $��10,10,455,0q�6>   $��26��6S   $��1��6_   �� 5.   
   $'��!Свободная техника��6   $	��Top=�6,   $��10,42,419,0q�6D   $��26��6Y   $��1��6e   �� 5/   
   $��Дата начала��6   $	��Top=�6&   $��10,73,419,0q�6>   $��26��6S   $��1��6_   �� 50   
   $!��Дата окончания��6   $	��Top=�6)   $��10,105,419,0q�6A   $��26��6W   $��1��6c   (  "System.Windows.Controls.DatePicker  51   
   $	��Top=�6=   $��1��6U   $��133,73,123,0q�6e   $��26��6{   $��Center=�6�   $��16(�6�      Text 6   �� *	StartDate+ �� Mode$ TwoWay=�6�     52   
   $	��Top=�6=   $��1��6U   $��133,104,123,0q�6e   $��26��6|   $��Center=�6�   $��16(�6�    6   �� *	StartDate+$ TwoWay=�6�   �� 53   
   -   5        $ comboBox_TypeName��53      $	��Top=�6S   $��133,10,123,0q�6k   $��1��6�   $��26��6�   $��Center=�6�   $��16(�6�    6/   �� *MachineryTypeName+6�   56      57      