   M S B A M L   `   `   `  ����  WpfApplication2     WpfApplication2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Fitness Guru��5   	   $	��600��6   $	��690��6+   
������� � Icon$ flexions.png��6N    � 	Resources 5       �� 
TargetType �� Property �� Value��%  '��       �� 5   
   " ��6   .�5	      ��  � ��$ 10q�6(   �� 5
       � ��$ 10q�6'   �� 5       � �� 5      �� 5      .R�5      �� $
��Bold"�65   $��12(�6G   
���   ���6$   �� 6U   5      5      5      5      .��5      � $��0,64,0,8q�6    � RowDefinitions 5   
   �� 5      $��0 �6   �� 5      $
��Auto �6   �� 5      $��0* �6   �� 5      .+�5   
   �� $��5,-60,12,240q�6   $��Personal Information��6)   $��4��6G   
�������$��2q�6p   
���   �.��5      � $��0,-4,15,-46q�6    � ColumnDefinitions 5      �� 5      $
��auto �6'   �� 5      $��2* �6'    5#      �� 5$      $��5 �6$   �� 5%      $
��Auto �6$   �� 5&      $
��Auto �6$   �� 5'      $
��Auto �6$   �� 5(      $
��Auto �6$   �� 5)      $
��Auto �6$   �� 5*      $
��Auto �6$   �� 5+      $
��Auto �6$   �� 5,      $
��Auto �6$   �� 5-      $
��Auto �6$   �� 5.      $
��Auto �6$   .+�52      �� -   5        	 ��Name$	 firstNameTxt��52      
 �� 	MaxLength$
 50��60   $��23��6?   $��1��6L   $��1��6\    �� TextWrapping$
 Wrap=�6i   $�� ��6}   $��0,0,11,0q�6�   �� 53      $��	FirstName��6   $��0��6,   $��1��6<   $��23��6I   �� 54      -   5        $	 lastNameTxt��54      $
 50��6/   $��23��6>   $��1��6K   $��2��6[   $
 Wrap=�6h   $�� ��6|   $��0,0,11,0q�6�   �� 55      $��LastName��6   $��0��6+   $��2��6;   $��23��6H   �� 56      $#��Date of Birth(year/month/day)��6   $��0��6@   $��3��6P   $��2��6]   $��
0,10,310,0q�6q   �� 57      -   5         ��Name$ yrCombo��57      $
��Left=�6,   $��
122,22,0,0q�6G   $��3��6[   $��54��6h   $��1��6�   $��23��6�   $	��Top=�6�   �� 59      -   5        $ mntCmb��59      $��1��6+   $
��Left=�6;   $��
210,21,0,0q�6V   $��3��6j   $��57��6w   $��24��6�   $	��Top=�6�   .@�5:      �� $	��Jan��6#   �� 5;      $	��Feb��6#   �� 5<      $	��Mar��6#   �� 5=      $	��Apr��6#   �� 5>      $	��May��6#   �� 5?      $	��Jun��6#   �� 5@      $	��Jul��6#   �� 5A      $	��Aug��6#   �� 5B      $	��Sep��6#   �� 5C      $	��Oct��6#   �� 5D      $	��Nov��6#   �� 5E      $	��Dec��6#   5F      �� 5G      -   5        $ dayCmb��5G      {�.  $��1��6=   $
��Left=�6M   $��
302,21,0,0q�6h   $��3��6|   $��53��6�   $��23��6�   $	��Top=�6�   �� 5H      $��Address��6   $��0��6*   $��4��6:   $��23��6G   �� 5I      -   5        $	 
addressTxt��5I      $
 50��6.   $��23��6=   $��1��6J   $��4��6Z   $
 Wrap=�6g   $�� ��6{   $��0,1,11,1q�6�   �� 5J      $
��City��6   $��0��6'   $��5��67   $��23��6D   �� 5K      -   5        $	 cityTxt��5K      $
 50��6+   $��23��6:   $��1��6G   $��5��6W   $
 Wrap=�6d   $�� ��6x   $��0,1,11,1q�6�   �� 5L      $��Province��6   $��0��6+   $��6��6;   $��23��6H   �� 5M      -	   5        $ provinceCmb��5M      $��1��60   $
��Left=�6@   $��6��6\   $	��120��6i   $��20��6u   .@�5N      �� -
   5        $
��cbp1��5N   #   .��6/   ON63   �� 5O      -   5        $
��cbp2��5O   #   .��6/   BC63   �� 5P      -   5        $
��cbp3��5P   #   .��6/   AB63   �� 5Q      -   5        $
��cbp4��5Q   #   .��6/   SA63   �� 5R      -   5        $
��cbp5��5R   #   .��6/   MB63   �� 5S      -   5        $
��cbp6��5S   #   .��6/   NU63   �� 5T      -   5        $
��cbp7��5T   #   .��6/   PE63   �� 5U      -   5        $
��cbp8��5U   #   .��6/   NB63   �� 5V      -   5        $
��cbp9��5V   #   .��6/   SK63   �� 5W      -   5        $��cbp10��5W   #   .��60   YT64   �� 5X      -   5        $��cbp11��5X   #   .��60   NS64   �� 5Y      -   5        $��cbp12��5Y   #   .��60   QC64   �� 5Z      -   5        $��cbp13��5Z   #   .��60   NL64   5[      �� 5]      $��Postal Code��6   $��0��6.   $��7��6>   $��23��6K   �� 5^      -   5        $	 postalCodeTxt��5^      $
 7��61   $��23��6?   $��1��6L   $��7��6\   $
 Wrap=�6i   $�� ��6}   $��0,1,11,1q�6�   �� 5_      $��
Comments: ��6   $��0��6.   $��8��6>   $��23��6K   �� 5`      -   5        $	 
commentTxt��5`      $
 Wrap=�6.   $�� ��6B   $��0��6K   $��10��6[   $��
0,3,10,-59q�6i   $��2��6}   5a      5b      �� 5c   
   $��Fitness Program��6   $��10,255,12,0q�6-   $	��Top=�6B   $	��162��6Z   $��3��6g   
���   �$��2q�6�   
�������.��5d      � $��	5,3,-5,-3q�6    5e      �� 5f      $
��Auto �6'   �� 5g      $��* �6'    5j      �� 5k      $��1 �6$   �� 5l      $��20 �6$   .+�5o      �� $��Trainer��6   $��0��6*   $��1��6:   $��23��6G   $	��Top=�6S   �� 5p      -   5        $ 
trainercmb��5p      $��23��6/    �� Text$ TextBox��6;   $��1��6J   $��1��6Z   $	��Top=�6g   $��	0,0,41,-2q�6   .@�5q      �� $��Fayomi Austin��6#   �� 5r      $��Leo Cole��6#   �� 5s      $��Young Einsten��6#   �� 5t      $��Power Alden��6#   �� 5u      $��Mira Den��6#   �� 5v      $��Baram��6#   �� 5w      $��Tanya Tagaq��6#   �� 5x      $��Shawn MenDes��6#   �� 5y      $��Susan Aglukark��6#   �� 5z      $��Carolyn Arends��6#   5{      �� 5}      $��Program Level��6   $
��Left=�62   $��87��6M   $��
9,30,0,-96q�6Y   $��1��6m   $	��Top=�6z   $��2��6�   
���   �$��1q�6�   .��5~      �� .+�5      	� -   5         	�Name$ beginerRadio��5   &   $��Beginer��6<   	� 5�      -   5        $ experienceRadio��5�   &   $��Experienced��6?   	� 5�      -   5        $ highPerformanceRadio��5�   &   $��High Performance��6D   5�      5�      �� 5�      $��1��6   $��Billing Information��6+   $��90��6I   $��288,27,84,-96q�6U   $��1��6l   $	��Top=�6y   
���   �$��1q�6�   .��5�      �� .+�5�      �� -   5         ��Name$ bankChk��5�   #   $��Bank Account Direct Debit��64   �� 5�      -   5        $ mntChk��5�   #   $��Monthly��63   �� 5�      -   5        $ 	annualChk��5�   #   $��Annual membership contact��66   5�      5�      5�      5�      �� 5�   
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   $��30��6J   $��4��6V   $��Bottom=�6g   $	��175��6�   $��0,0,10,6q�6�   .+�5�      �� -    5         ��Name$ okButton��5�      $��OK��6'   $��80��64   $��21��6?   6K   �� 5�      -!   5        $ cancelButton��5�      $��Cancel��6+   $��70��6<   $��21��6G   $��25,0,0,4q�6S   $��Bottom=�6e   6�   5�      5�      5�      