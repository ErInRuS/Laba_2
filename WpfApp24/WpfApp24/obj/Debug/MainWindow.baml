   M S B A M L   `   `   `  ����C  ?WpfApp24, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp24WpfApp24  5   	       WpfApp24.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp24     5   	   -   5          �Name$  
windowMain��5   	    � Title$ 
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   .+�5      �� $��20(�6   $
��Name��6"   �� 5      -   5         ��Name$ nameUser��5      $��20(�6(   66   �� 5      $��20(�6   $��Phone number��6"   �� 5      -   5        $ numberPhone��5      $��20(�6+   69   �� 5      -   5         ��Name$ bSubmit��5      $��10q�6&   $��20(�63   $��Submit��6A   6R   �� 5      -   5        $ bReset��5      $��10q�6%   $��20(�62   $��Reset��6@   6P   �� 5      -   5        $ bRandom��5      $��10q�6&   $��20(�63   $��Random��6A   6R   �� 5      -   5         ��Name$
 meta��5      �� 5      -   5        $ listBool��5      5      �� 5   
   $��1��6   .+�5      �� -	   5         ��Name$ 	ListUsers��5      $��20(�6*    �� View 5      �� 5      .P�5      ��  �� Width$	 200��6)   $
��Name��65   	 �� DisplayMemberBinding	 6C   �� 
 �� Path$

 Name��� 5      $	 200��6)   $��Number��65   	 6E   �� $
 Numer�5       5"      5#      5$      5%      