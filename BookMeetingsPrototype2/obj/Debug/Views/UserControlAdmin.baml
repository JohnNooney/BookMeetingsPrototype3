   M S B A M L   `   `   `  ����Q  MBookMeetingsPrototype2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:BookMeetingsPrototype2.ViewsBookMeetingsPrototype2.Views  5      3    -BookMeetingsPrototype2.Views.UserControlAdmin   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:BookMeetingsPrototype2.Views     5      .��5	      � 
�������  � ColumnDefinitions  5
   
   �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      $	��.5* �6   .+�5   
   �� $��0��6   $��0��6!   $��4��6.   ���	#FFA0BED6$��20q�6V    �� CornerRadius$ 10��6b   �� 5   
   $��0��6   $��0��6$   $��Admin Settings��61   $��30q�6G   $��20(�6S   $
��Bold"�6a   $��Center=�6s   $��Center=�6�   �� 5   
   $��0��6   $��0��6%   $��Right=�62   $��30q�6N    �� Orientation$ 
Horizontal=�6Z   .+�5      �� $��	Account #��6   $��10(�6*   $
��Bold"�68   �� 5      $��10(�65   $
��Bold"�6C   ��6   �� *
User.EmpId+6C   5      �� 5   
   $��0��6   $��0��6!   $��Bottom=�61   $��30 30 30 35q�6L   
���   �6a   �� 5   
   -   5         ��Name$ comboBox��5      $��0��6R   $��0��6_   $��1��6o   $��Bottom=�6�   $��
30 30 30 0q�6�   ���	#FF5C99D6
�������.@�5      �� $��--Select a Category--��6    �� 
IsSelected . 6;   �� 5      -   5         ��Name$ roomsRecords��5   +   $��Rooms��6   6+   �� 5      -   5        $ employeeRecords��5   /   $��	Employees��6   6/   5       &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ dataGrid��5"      $��1��6%   $��0��62   $��2��6B   $��
30 10 30 0q�6S   ��.    CanUserAddRows . 6�   �� 5$   
   $��3��6   $��0��6"   $ 
Horizontal=�62   $��Center=�6K   $	��Top=�6h   .+�5%      �� -   5        	 ��Name$	 DeleteButton��5%      $��Delete��6F   $��10q�6W   $��Center=�6c   $��90��6�   
���  ��6�   �� 5&      -   5        $	 
SaveButton��5&      $
��Save��6B   $��10q�6Q   $��Center=�6]   $��90��6z   5'      5(      5)      