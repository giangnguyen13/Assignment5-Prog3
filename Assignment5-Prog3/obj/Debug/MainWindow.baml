   M S B A M L   `   `   `  ����L  HAssignment5-Prog3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Assignment5_Prog3Assignment5_Prog3  5   	   "    Assignment5_Prog3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Assignment5_Prog3     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridDisplay��5
         AutoGenerateColumns .  $
��Left=�6H   $	��144��6c   $��	20,21,0,0q�6p   $	��Top=�6�   $	��752��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Symbol��6@      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Symbol+6P     5      $ ReleaseDate��6U   $ * 6j    6%   �� *ReleaseDate+ �� StringFormat$ d��6j     5      $ * 6N   $
 Open��6X    6%   �� *Open+$ C��6X     5      $ * 6N   $
 High��6X    6%   �� *High+$ C��6X     5      $ * 6N   $	 Low��6X    6%   �� *Low+$ C��6X     5      $ * 6P   $ Close��6Z    6%   �� *Close+$ C��6Z   5        5   
   -   5        $ dataGridSearch��5       .  $
��Left=�6G   $	��147��6b   $��
20,252,0,0q�6o   $	��Top=�6�   $	��752��6�    5        5      $ Symbol��6@   $ * 6P    6%   �� *Symbol+6P     5      $ ReleaseDate��6U   $ * 6j    6%   �� *ReleaseDate+$ d��6j     5      $ * 6N   $
 Open��6X    6%   �� *Open+$ C��6X     5      $ * 6N   $
 High��6X    6%   �� *High+$ C��6X     5      $ * 6N   $	 Low��6X    6%   �� *Low+$ C��6X     5      $ * 6P   $ Close��6Z    6%   �� *Close+$ C��6Z   5      �� 5   
   -   5         ��Name$ buttonSearch��5      $��Search��6'   $
��Left=�68   $��415,188,0,0q�6S   $	��Top=�6h   $	��110��6�   $��34��6�   6�   �� 5   
   -   5        	 ��Name$	 textBoxSearch��5      $
��Left=�6)   $��34��6D   $��178,188,0,0q�6P   
 �� TextWrapping$

 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��193��6�   � 5    
   -   5         �Name$ progressBar��5       $
��Left=�6+   $��34��6F   $��570,188,0,0q�6R   $	��Top=�6g   $	��175��6   5!      5"      