   M S B A M L   `   `   `  ����K  Gairshow(indexer), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:airshow_indexer_airshow_indexer_  5   	       airshow_indexer_.Basket   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:airshow_indexer_     5   	     � Title$  Basket��5   	   $	��450��6   $	��800��6%   .��5	      � .+�5
   
   �� $��50 50 400 50q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ AirplaneDataGrid��5         AutoGenerateColumns$ False��61      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6)      
IsReadOnly$
 True��6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Name+6P     5      $ Price in Dollars��6)   $
 True��6]    6C   �� *price+6]   5      5      �� 5   
   -   5         ��Name$ TextBlockBasket��5      $
��Left=�6-   $��
459,55,0,0q�6H   $�� ��6\   $
��Wrap=�6d   $	��Top=�6x   �� 5   
   -   5        $��Button��5      $��618,309,5,5q�6"   $	��100��6M   $	��150��6Z   5      5      