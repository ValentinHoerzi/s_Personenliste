   M S B A M L   `   `   `  ����H  DPersonenliste, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PersonenlistePersonenliste  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       Personenliste.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Personenliste     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   -   5          � Title$  
MainWindow��5
   	   $	��548��6   $	��800��6)   .��5      � .+�5   
   ]� .+�5      o� $	��Top=�6   .@�5      m� $��_File��6   .@�5      m� -   5        $��_Open��5      6.   m� 5      -   5        $��_Save��5      6.   5      5      5      �� 5   
   -   5        $��	btnSubmit��5      $
��Left=�5      $��
266,31,0,0q�6,   $	��Top=�6@   $��75��6X   $��69��6c   .��5      �� $��images.jpeg��6   5      �� 5   
   $��
Firstname:��6   $
��Left=�5      $��	50,28,0,0q�6+   $	��Top=�6>   �� 5   
   $��	Lastname:��6   $
��Left=�5       $��50                ,73,0,0q�6+   $	��Top=�5!      �� 5#   
   -   5        $��txtFirstname��5#      $
��Vali��5$      $
��Left=�5%      $��23��6(   $��
117,31,0,0q�64    �� TextWrapping$
 Wrap=�6H   $	��Top=�6\   $	��120��6t   �� 5'   
   -   5        $��txtLastname��5'      $��Hörzi��5(      $
��Left=�5)      $��23��6(   $��
117,76,0,0q�64   $
 Wrap=�6H   $	��Top=�6\   $	��120��6t   (  "System.Windows.Controls.DatePicker  5+   
   -   5        $��
datePicker��5+      
 �� Now   SelectedDate# Z 5,      $
��Left=�5-      $��
50,122,0,0q�6(   $	��Top=�6<   $	��187��6T   �� 5/   
   $��Gender��6   $
��Left=�6#   $��54��6>   $��
50,177,0,0q�6J   $	��Top=�6^   $	��123��6v   .��50      �� $
��Left=�6   $��30��64   $��-2,1,0,0q�6@   $	��Top=�6R   $	��100��6j    J� RenderTransformOrigin$ 
0.52,0.712&�6v   .+�51      	� -   5        $��rdbMale��51      $
��Male��52       d� 	IsChecked$
 TrueY�53      	� 54      -	   5        $��	rdbFemale��54      $��Female��55      56      57      �� 58   
   -
   5        $��btnDeleteSelection��58      $��Delete Selection��59      $
��Left=�6(   $��252,177,0,0q�6C   $	��Top=�6X   $��89��6p   6{   �� 5:   
   -   5        $��chDriversLicense��5:      $��Drivers License��5;      $
��Left=�6'   $��210,256,0,0q�6B   $	��Top=�6W   $	��131��6o   �� 5=   
   -   5        $��	txtSearch��5=      $��23��5>      $
 Wrap=�6   $	��120��6-   $��117,299,555,195q�69   6R   �� 5@   
   -   5        $��listBox��5@      $
��Left=�5A      $	��464��6(   $��
362,31,0,0q�65   $	��Top=�6I   $	��421��6a   5C      �� 5D   
   $��Search��6   $
��Left=�5E      $��
50,299,0,0q�6(   $	��Top=�6<   $��27��6T   �� 5G   
   $��
Search for��6   $
��Left=�6'   $��54��6B   $��
50,336,0,0q�6N   $	��Top=�6b   $	��123��6z   .��5H      �� $
��Left=�6   $��30��64   $��-2,1,0,0q�6@   $	��Top=�6R   $	��100��6j   $ 
0.52,0.712&�6v   .+�5I      	� -   5         	�Name$ rdbFirstname��5I      $��	Firstname��5J      $
 TrueY�5K      	� 5L      -   5        $ rdbLastname��5L      $��Lastname��5M      5N      5O      �� 5Q   
   -   5        $��listBoxSearch��5Q      $	��100��5R      $��50,395,555,22q�6    69   5S      5T      