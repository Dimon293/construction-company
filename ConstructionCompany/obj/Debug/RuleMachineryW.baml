   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   G(clr-namespace:ConstructionCompany.ModelsConstructionCompany.Models  5   	   (    "ConstructionCompany.RuleMachineryW   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	   ;Models(clr-namespace:ConstructionCompany.Models     5   	     � WindowStartupLocation$  CenterOwner=�5	       � Title$&  Бригады и техника��5
   	   $��340.572��6#   $��554.956��64    � Icon$ Icons/main.png��6D    � 	Resources 5       �� 
TargetType   
ToolButton �� 	Resources �� Property �� Value��%�  &	        �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��BitmapScalingMode$ HighQuality=�6H   �� 5       �@��EdgeMode$ Unspecified=�6?   5      5      .�5      ��  �@�Cursor$
 Hand��6'   �� 5       � ��
 ���� 6+   �� 5       � ��$ 24��6'   �� 5       � ��$ 24��6&   �� 5       � ��$ 0q�60   �� 5       �@��CornerRadius$ 4��64   5      5      .��5      � $��0,0,0,-1q�6    � RowDefinitions 5   
   �� 5      $��37 �6   �� 5      �� 5      $��73 �6   	 � ColumnDefinitions	 5!   
   �� 5"      $
��274* �6   �� 5#      $
��195* �6   �� 5$      $��70.101 �6   �� 5%      $��7.899 �6   .+�5(   
   &   System.Windows.Controls.DataGrid  -   5        
  Name$
 WorksDG��5(      $��10,2,9,0q�6$      AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�5*   ;      SelectionUnit$ FullRow=�5+      $��1��6Y   
�������   HeadersVisibility$ Column=�6y   $��14(�6�   ��6%   �� *WorkWithMachineryCollection+   Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ Вид работы��6B      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
WorkName+6V     5.      $ Бригада��6E   $ 1* 6V    6%   �� *BrigadeName+6V   50        51   
   -   5        $
 MachineryDG��51      $��9,2,2,0q�6(    .   . $ Single=�53   ;   $ FullRow=�54      $��1��6s   
�������$ Column=�6�   $��14(�6�   $��1��6�   $��2��6�   ��6%   �� *" SelectedItem.MachineryCollection+ �� ElementName$ WorksDG�� 55        56      $ Название��6>   $ 1* 6P    6%   �� *Name+6P   58      �� 59   
   $��Бригада��6   $
��Left=�6"   $	��Top=�6=   $	��254��6U   $��34��6a   $��14(�6m   $��10,0,0,0q�6{   �� 5:   
   $��Техника��6   $��	10,0,89,0q�6"   $	��Top=�65   $��34��6M   $��1��6Y   $��14(�6i   �� 5;   
   -   5         ��Name$ button_DelMachinery��5;      $��34,3,4,2q�6/    J� RenderTransformOrigin$ 0.453,-4.25&�6B   #��[  6f   $��32��6�   $
��Auto��6�    � ToolTip$# Удалить технику��6�   $��2��6�   $��Center=�6�   .��5<      �� $��Icons/del.png��6   $��
0, 0, 0, 0q�6+   $	��Top=�6?   $��24��6W   $��24��6b   5=      �� 5>   
   -   5        $ button_AddMachinery��5>      $��3,3,0,2q�6/   $ 0.453,-4.25&�6A   #��[  6e   $
��Auto��6�   $
��Left=�6�   $��32��6�   $% Добавить технику��6�   $��2��6�   .��5?      �� $��Icons/add.png��6   $��
0, 0, 0, 0q�6+   $��Center=�6?   $��24��6Z   $��24��6e   5@      �� 5A   
   -   5        $ button_Success��5A      $��2��6)   $
��Left=�69   $��10,1,0,0q�6T   $��2��6f   $	��Top=�6s   $��50��6�   $��50��6�   #��[  6�   .��5B      �� $��Icons/ok.png��6   $��
0, 0, 0, 0q�6*   5C      5D      5E      