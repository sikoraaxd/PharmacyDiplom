   M S B A M L   `   `   `  ����I  EPharmacyDiplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:PharmacyDiplom.MVVM.ViewPharmacyDiplom.MVVM.View  5      )    #PharmacyDiplom.MVVM.View.PharmsView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:PharmacyDiplom.MVVM.View     5      
������   � 	Resources  5         	TilePanel K� IsItemsHost �� 
TargetType �� Property �� Value��%�   &	        '�� 8     7   �� 5   
   .R�5      � $
 True��6   5      �� 5   
   " ��6   .�5      ��  � ��8   6+   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��180 �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��2��5      
������ ���#2F3136$��0,0,0,2q�5"      5$      �� 5%   
   $��0��6   $��0��5&      $��Center=�5'      $
��Left=�5(       �� Orientation$ 
Horizontal=�5)      .+�5*      �� -   5         ��Name$ 	priceSort��5.      $	��120��5*      $��25��5+      $��10,0,0,0q�5,      	 �� SelectedIndex$	 0��5-      $��14(�5/      6'   �� 50      -   5        $ nameSort��54      $	��120��50      $��25��51      $��10,0,0,0q�52      $	 0��53      $��14(�55      6'   56      �� 58   
   $��0��6   $��1��59      $	��120��5:      $��25��5;      $��14(�5<      .��6   Фильтр5>      �� 5B   
   $��1��6   $��0��5C      .+�5D      �� -   5        
 ��Name$
 PharmacyBox��5D      
������ 
������ $��Disabled=�5G      $	��439��5H        PharmacyItem#��[ 5I      ��5J      �� *Pharms+5K      5L      �� 5N   
   $��1��6   $��1��5O      5P      5Q      5R      