   M S B A M L   `   `   `  ����R  NBloodBankWPFApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BloodBankWPFApplicationBloodBankWPFApplication  5   	   /    )BloodBankWPFApplication.AddBlockStockForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:BloodBankWPFApplication     5   	     � Title$$  Add New BlockStock Information��5   	   $	��450��60   $	��500��6=    � Icon$ .\images\b.png��6I    � 	Resources 5	         buttonHover �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property	 P� Value
 �� 
TargetName  textBox ��Name �� CornerRadius ��Name�� 5
   
   %0  &	        &	     �� 5      " ��6(   .�5      ��  � ��
 �   �6/   �� 5       � ��
 �����6/   �� 5       � �� 5      �� 5      " ��6*   .R�5      �� $��border��6%   #��z��63   ._�5   "   �� $��Center=�63   $��Center=�6P   5       5      P� 5   "    � ��	 . . �5   &   �� $
 border��6-    � ��
 �  ��6X   5   #   P� 5   "    �@J�IsMouseOver	 . . �5   &   ��  � ��
 �����6C   �� 5   &    � ��
 �   �6C   5   #   5      5       5!      �� 5"      " ��6   .�5#      ��  � ��$ Stretch=�66   �� 5$       � ��$ Center=�6=   �� 5%       � �� �#0006/   �� 5&       � ��$ 15(�6-   �� 5'       � �� 5(      �� 5)      " ��6*   .R�5*      �� $ border��6%   $ 5��5+   %   
�������$��1q�5-   %   ���#fff._�50   "   �� $ PART_ContentHost��6/   |�.  $��Hidden=�52   1   $��Hidden=�53   1   54       55      P� 56   "    �@J�IsMouseOver	 . . �57   &   �� $
 border��6D    � ��
 �  ��6X   �� 58   &    � ��
 �  ��6C   5:   #   P� 5;   "    �@J�	IsFocused	 . . �5<   &   ��  � ��
 �   �6C   �� 5=   &   $
 border��6D    � ��
 ��  �6X   5>   #   5@      5B      5C      5D      .��5G      � .+�5H   
   ��  �� Orientation$ Vertical=�6   $��Center=�6,   $	��500��6I   .+�5I      �� 
�������$	��570��62   .+�5J      � $��10q�6    � ColumnDefinitions 5K      �� 5L      $��* �6+   �� 5M      $��2* �6+    � RowDefinitions 5O      �� 5P      $��50 �6(   �� 5Q      $��50 �6(   �� 5R      $��50 �6(   �� 5S      $��50 �6(   �� 5T      $��50 �6(   .+�5V      �� $��Blood Bank Name��6   $��0��66   $��0��6C   $��Right=�6S   $��15(�6o   $��Center=�6}   $��DemiBold"�6�   �� 5W      -   5         ��Name$ txtBloodBankName��5W      $��0��6:   $��1��6G   $��30��6W   $	��250��6c   $��Center=�6o   #��[ 6�   6�   �� 5Y      $��Blood Group��6   $��1��62   $��0��6?   $��Right=�6O   $��15(�6k   $��Center=�6y   $��DemiBold"�6�   �� 5Z      -   5        $��cmbBloodGroup��5Z      $��15(�64   $��Medium"�6B   $��1��6V   $��1��6c   $��30��6s   $	��106��6   $
��Left=�6�   $��
35,10,0,10q�6�   .@�5[      �� $	��AB+��6'    �� 
IsSelected . 6I   �� 5\      $	��AB-��6'   67   �� 5]      $��O+��6'   66   �� 5^      $��O-��6'   66   �� 5_      $��B+��6'   66   �� 5`      $��B-��6'   66   �� 5a      $��A+��6'   66   �� 5b      $��A-��6'   66   5c      �� 5e      $��Number If Bottles��6   $��2��68   $��0��6E   $��Right=�6U   $��15(�6q   $��Center=�6   $��DemiBold"�6�   �� 5f      -   5        $ txtNoOfBottles��5f      $��2��67   $��1��6D   $��30��6T   $	��250��6`   $��Center=�6l   #��[ 6�   6�   �� 5h      $
��City��6   $��3��6+   $��0��68   $��Right=�6H   $��15(�6d   $��Center=�6r   $��DemiBold"�6�   �� 5i      -   5        $ txtCity��5i      $��3��60   $��1��6=   $��30��6M   $	��250��6Y   $��Center=�6e   #��[ 6�   6�   �� 5k      $��Phone Number��6   $��4��63   $��0��6@   $��Right=�6P   $��15(�6l   $��Center=�6z   $��DemiBold"�6�   �� 5l      -   5        $ txtPhone��5l      $��4��61   $��1��6>   $��30��6N   $	��250��6Z   $��Center=�6f   #��[ 6�   6�   5m      � 5n      $��30q�6    5o      �� 5p      �� 5q      .+�5s      �� -   5         ��Name$ btnSave��5s      $��0��6D   $��Right=�6T   $
��Save��6p   $	��111��6   $��40��6�   $��20(�6�   $
��Bold"�6�   ���#FFE4E1
���   �6�   �� 5t      -   5        $ 	btnUpdate��5t      $��Update��6H   $��1��6Y   $
��Left=�6i   $	��101��6�   $��40��6�   $��20(�6�   $
��Bold"�6�   
���  ��
������$��33,0,0,0q�6�   5v      5w      5x      5y      5z      