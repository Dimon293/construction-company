   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   G(clr-namespace:ConstructionCompany.ModelsConstructionCompany.Models  5   	   !    ConstructionCompany.WorkerW   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	   ;models(clr-namespace:ConstructionCompany.Models     5   	     � WindowStartupLocation$  CenterOwner=�5	   	    � Title$ Работники��5
   	   $��287.862��6   $��644.956��6,    � Icon$ Icons/main.png��6<    � 	Resources 5       �� 
TargetType   
ToolButton �� 	Resources �� Property �� Value��%�  &	        �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��BitmapScalingMode$ HighQuality=�6H   �� 5       �@��EdgeMode$ Unspecified=�6?   5      5      .�5      ��  �@�Cursor$
 Hand��6'   �� 5       � ��
 ���� 6+   �� 5       � ��$ 24��6'   �� 5       � ��$ 24��6&   �� 5       � ��$ 0q�60   �� 5       �@��CornerRadius$ 4��64   5      5      .��5      � $��0,0,-2,0q�6    � RowDefinitions 5   
   �� 5      	 � ColumnDefinitions	 5    
   �� 5!      $	��105 �6   �� 5"      $
��266* �6   �� 5#      .+�5%   
   �� -   5        
 ��Name$
 	AddWorker��5%       J� RenderTransformOrigin$ 4.942,2.617&�6$   $	��Top=�6H   $��26��6`   $��26��6l   #��[  6w   $��11,6,0,0q�6�   $
��Left=�6�    � ToolTip$) #Добавить работника��6�   .��5&      �� $��Icons/add.png��6   $��
0, 0, 0, 0q�6+   5'      �� 5(   
   -   5        $
 
EditWorker��5(      $��42,5,0,0q�6%   $	��Top=�67   $��26��6O   $ -1.569,0.283&�6[   #��[  6�   $
��Left=�6�   $��26��6�   $) #Изменить работника��6�   .��5)      �� $��Icons/edit.png��6   $��
0, 0, 0, 0q�6,   5*      �� 5+   
   -   5        $
 DeleteWorker��5+      #��[  6'   $��73,6,0,0q�6K   $ 0.453,-4.25&�6]   $	��Top=�6�   $��26��6�   $
��Left=�6�   $��26��6�   $' !Удалить работника��6�   .��5,      �� $��Icons/del.png��6   $��
0, 0, 0, 0q�6+   5-      �� 5.   
   $��26��6    �� TextWrapping$
 Wrap=�6   $	��Top=�62   $��1,5,10,0q�6J   $��16(�6\   $��1��6j   $ 
Поиск��6�   ��6z   �� *
FilterText+ �� UpdateSourceTrigger$ PropertyChanged=�6�   &   System.Windows.Controls.DataGrid  5/   
   -   5          Name$ 	WorkersDG��5/      $��10,36,10,10q�6&   $��2��6;      AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�50   E      SelectionUnit$ FullRow=�51         HeadersVisibility$ Column=�6I   
���   �$��14(�6w   
���������6+   �� *Items+   Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ Бригада��6E      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *BrigadeName+6V     55      $ Фамилия��6B   $ 1* 6S    6%   �� *
LastName+6S     56      $ Имя��6C   $ 1* 6P    6%   �� *	FirstName+6P     57      $ Отчество��6D   $ 1* 6V    6%   �� *
Patronymic+6V     58      $ Дата рождения��6B   $ 1* 6Y    6%   �� *
Birthday+6Y     59      $ Паспорт��6H   $ 1* 6Y    6%   �� *PassportNumber+6Y     5:      $ 
Адрес��6A   $ 1* 6P    6%   �� *	Address+6P     5;      $ Телефон��6?   $ 1* 6P    6%   �� *Phone+6P     5<      $ Опыт��6D   $ 1* 6R    6%   �� *
Experience+6R   5>      5D      5F      