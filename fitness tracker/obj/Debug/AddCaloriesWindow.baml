   M S B A M L   `   `   `  ����  fitness tracker    fitness_tracker.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   $	��400��5   	   $	��600��6   
������   � 
ResizeMode$  NoResize=�6;    � AllowsTransparency .  � WindowStyle$
 None=�5   #    � WindowStartupLocation$ CenterScreen=�66   .��5      �� -   5        ���#cfd5e5 �� CornerRadius$ 40��5   "   $��2q�64   ���#ebedf3 �� Padding$ 10q�6^   ._�5	   
   �� $ 40��6   ��5
      �� 5       �� 
StartPoint$ 0.6,0&�6&    �� EndPoint$	 0,1&�69   .��5      �  � Color$ #6a5dae��6#   	 � Offset$	 0Q�63   � 5      $ #54479c��6#   $	 1Q�63   5      ._�5      � 
 � RowDefinitions
 5      �� 5      $��* �6$   61   �� 5      $��* �6$   61   �� 5      $��* �6$   61   .+�5      �� $��Type your calories here��6   
�������$��24(�6N   $��SemiBold"�6\   $��Center=�6r   $��Center=�6�   �� 5      $��1��6   $��10q�6*   .+�5      �� -   5         ��Name$ calories_add��5      ���#797295$	��300��6�   $��60��6�   {�. $
��Left=�6�   $��Center=�6�   $��10q�6�   .��6   � 	Resources 5       �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%�   '��       �� 5      " ��6$   .�5   "   ��  �@��CornerRadius$ 30��6A   6N    5    "   P� 5!   &    �@J�IsMouseOver . . �5"   *   ��  � �� �#A0A0A06G   5#   '   5%      5&      .��6-   5'      �� 5)      $��	0 20 0 10q�6    $��Center=�63   
�������$��13(�6c   $��SemiBold"�6q   .  (MahApps.Metro.IconPacks.PackIconMaterial  5*         Kind$ ExclamationThick=�60   
��� ���$��0 0 0 -2q�6\    Date is set automatically5,      5-      �� 5/      -   5         ��Name$ Button_calories_add��5/      $��Submit��66   
�������$��2��6Z      
menuButton#��[  6g   {�.  6�   50      56      57      58      