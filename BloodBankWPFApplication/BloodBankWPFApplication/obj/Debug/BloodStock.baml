   M S B A M L   `   `   `  ����R  NBloodBankWPFApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BloodBankWPFApplicationBloodBankWPFApplication  5   	   (    "BloodBankWPFApplication.BloodStock   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:BloodBankWPFApplication     5   	   -   5          � Title$"  Blood Bank Management System��5
   	   $	��740��6.   $
��1400��6;    � Icon$ .\images\b.png��6H   $��Stretch=�6^    � 	Resources 5         buttonHover �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property	 P� Value
 �� 
TargetName�� 5   
   %#  &	        �� 5      " ��6(   .�5      ��  � ��
 �   �6/   �� 5       � ��
 �����6/   �� 5       � �� 5      �� 5      " ��6*   .R�5      �� $��border��6%   #��z��63   ._�5   "   �� $��Center=�63   $��Center=�6P   5       5      P� 5   "    � ��	 . . �5   &   �� $
 border��6-    � ��
 �  ��6X   5   #   P� 5   "    �@J�IsMouseOver	 . . �5   &   ��  � ��
 �����6C   �� 5   &    � ��
 �   �6C   5   #   5       5"      5#      5%      .��5(      � ��5)   
   �� 5*       �� EndPoint$ 	0.504,1.5&�6"    �� 
StartPoint$ 
0.504,0.03&�67   .��5+      �  � Color$ DarkRed��6    � Offset$ 0Q�6/   � 5,      $ #ff5757��6   $ 0.567Q�6/   5-      .+�5/   
   ��  �� Orientation$ Vertical=�6   .+�50      �� $ 
Horizontal=�6   $��10q�62   .+�51      �� $��.\images\logo.png��6   $��50��63   $��50��6?   6L   �� 52      $(��"Give The Gift of Life Donate Blood��6   $��35(�6F   $
��Bold"�6T   $��Italic$�6f   $��5q�6y   
������� J� Effect 53      3  -System.Windows.Media.Effects.DropShadowEffect  54         ShadowDepth$ 5Q�55         	Direction$	 330Q�56         Color$ Black��57         Opacity$	 0.5Q�58         
BlurRadius$ 4Q�59      5;      5<      �� 5>      $��2q�6   
���  ��6)   o� 5?      $��23(�6   $
��Bold"�6!   $��Georgia)�63   $��Italic$�6H   $��Center=�6[   $
��1400��6x   $��70��6�   
���   �.@�5A      m� ��5B      �� 5C      -   5         ��Name$ btnHome��5C   !   #��[  62   $��Center=�6W   $
��Home��6r   $	��250��6�   $��70��6�   5E      m� 5F      ��5G      �� 5H      -   5        $ btnRegister��5H   !   #��[  66   $��Register As Donor��6[   $	��250��6�   $��70��6�   5J      m� 5K      ��5L      �� 5M      -   5        $ btnSearchBlood��5M   !   #��[  69   $��Search Blood��6_   $	��250��6�   $��70��6�   5O      m� 5P      ��5Q      �� 5R      -   5        $ btnBloodStock��5R   !   #��[  68   $	��250��6]   $��70��6i   .��5S      �� $��	Underline{�6(   Blood Stock6Q   5T      5V      m� 5W      ��5X      �� 5Y      -   5        $ btnRequestBlood��5Y   !   #��[  6:   $��Request Blood��6_   $	��250��6�   $��70��6�   5[      5]      �� 5^      $��2q�6   
���  ��6)   5_      � 5`   
   .+�5a      �� $ Vertical=�6   $��Center=�60   $
��1050��6M   $��	0,160,0,0q�6Z   .+�5b      �� 
�������$	��570��66   .+�5c      �� $��Blood Stock��6   
���  ��$��Georgia)�6G   $��Italic$�6\   $��Center=�6o   $��20(�6�   $
��Bold"�6�   $��20q�6�   6�   �� 5d      $ 
Horizontal=�6!   $��	550,0,0,0q�6:   .+�5e      �� -   5        $ btnAddBlockStock��5e   !   $	��Add��6Z   $��45��6h   $��20(�6t   $
��Bold"�6�   
���  ��
������$	��112��6�   $��10q�6�   �� 5f      -   5        $ 	btnUpdate��5f   !   $��Update��6L   $��45��6]   $��20(�6i   $
��Bold"�6w   
���  ��
������$	��114��6�   �� 5g      -	   5        $ 	btnDelete��5g   !   $��Delete��6L   $��45��6]   $��20(�6i   $
��Bold"�6w   
���  ��
������$	��118��6�   $��10q�6�   5i      5j      5k      5l      � 5m   
   $	��220q�6   $
��auto��6   $
��auto��6*   $��Center=�67    � ColumnDefinitions 5n      �� 5o      $
��411* �6#   �� 5p      $	��25* �6#   �� 5q      $	��24* �6#   �� 5r      $
��492* �6#   .+�5t      &   System.Windows.Controls.DataGrid  -
   5          Name$ bloodStockDataGrid��5t   =   $��15(�6      AutoGenerateColumns .     AlternatingRowBackground
 ���f�$��44,78,42,-157q�6�   "   VerticalScrollBarVisibility$
 Auto=�6�   $   HorizontalScrollBarVisibility$
 Auto=�6�   $��4��6      
IsReadOnly .     CanUserDeleteRows . ��6%   ��    ColumnHeaderStyle 5u      �� 5v      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5w      ��  � ��$
 Bold"�67   �� 5x       � �� �#DC143C67   �� 5y       � ��
 �����67   �� 5z       � ��$ Georgia)�67   �� 5{       � ��$ 40��63   5|          Columns  5~      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn!   Header$! Id��6)   "   Width5  /System.Windows.Controls.DataGridLengthConverter$" 50 6V   1  +System.Windows.Controls.DataGridBoundColumn#   Binding# 65   �� *bloodStockId+6c     5�      $! Blood Bank Name��6)   $	" 200 6`   # 6B   �� *	bloodBank+6n     5�      $! Blood Group��6)   $	" 100 6]   # 6>   �� *
bloodGroup+6k     5�      $! No of Bottles��6)   $	" 150 6d   # 6@   �� *numberOfBottles+6r     5�      $
! City��6)   $	" 150 6P   # 67   �� *city+6^     5�      $! Phone��6)   $	" 150 6T   # 68   �� *	phoneNo+6b   5�      5�      5�      5�      