   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   #    ConstructionCompany.AddDateMU   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	     � Title$<  6Укажите временной промежуток��5   	   $	��161��6.   $��304.103��6;    � 
ResizeMode$ NoResize=�6K    � WindowStyle$ 
ToolWindow=�6a    � Icon$ Icons/main.png��6z    � 	Resources 5	       �� 
TargetType   
ToolButton �� 	Resources �� Property �� Value��%�  &	        �� 5
   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��BitmapScalingMode$ HighQuality=�6H   �� 5       �@��EdgeMode$ Unspecified=�6?   5      5      .�5      ��  �@�Cursor$
 Hand��6'   �� 5       � ��
 ���� 6+   �� 5       � ��$ 24��6'   �� 5       � ��$ 24��6&   �� 5       � ��$ 0q�60   �� 5       �@��CornerRadius$ 4��64   5      5      .��5      � $��	0,0,-3,-4q�6   .+�5   
   �� $��Дата начала��6   $	��Top=�6&   $��11,10,182,0q�6>   $��26��6S   �� 5   
   $!��Дата окончания��6   $	��Top=�6)   $��11,48,182,0q�6A   $��26��6V   (  "System.Windows.Controls.DatePicker  5   
   $	��Top=�6=   $��122,10,22,0q�6U   $��26��6j   $��Center=�6v   $��16(�6�   	   Text	 6   �� *	StartDate+
 �� Mode$
 TwoWay=�6�     5   
   $	��Top=�6;   $��122,48,22,0q�6S   $��26��6h   $��Center=�6t   $��16(�6�   	 6   �� *	EndDate+$
 TwoWay=�6�   �� 5   
   -   5        $
��Left=�5      #��[  6,    � ToolTip$ Добавить��6P   $��
235,79,0,0q�6c   $	��Top=�6w   $��44��6�   $��40��6�   .��5       �� $��Icons/ok.png��6   $��
0, 0, 0, 0q�6*   $��40��6>   $��40��6I   5!      5"      5#      