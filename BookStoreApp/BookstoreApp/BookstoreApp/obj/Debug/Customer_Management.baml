   M S B A M L   `   `   `  ����G  CBookstoreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BookstoreAppBookstoreApp  5   	   &     BookstoreApp.Customer_Management   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BookstoreApp     5   	     � Title$  Customer_Management��5   	   $	��450��6%   $	��800��62   .��5	      � ���	#FFE7F8FA.+�5
   
   �� -   5         ��Name$ bg��5
      ���	#FFF4F4F5$
��Left=�61   $	��130��6L   $��	10,48,0,0q�6Y   ���	#FFE7F8FA$	��Top=�6   $	��772��6�   �� 5   
   -   5         ��Name$ txtcusid��5      $
��Left=�6$   $��23��6?   $��
146,74,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��234��6�   �� 5   
   -   5        $ 
txtcusName��5      $
��Left=�6&   $��23��6A   $��
505,73,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��261��6�   �� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��	24,75,0,0q�6B   $
��Wrap=�6U   $	��Top=�6i   $��Customer ID:��6�   $
��Bold"�6�   $��14(�6�   �� 5   
   -   5        $ textBlock_Copy��5      $
��Left=�6,   $��
393,74,0,0q�6G   $
��Wrap=�6[   $	��Top=�6o   $��Name-Surname:��6�   $
��Bold"�6�   $��14(�6�   �� 5   
   -   5        $ 
txtaddress��5      $
��Left=�6&   $��28��6A   $��
88,106,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��292��6�   �� 5   
   -   5        $ textBlock_Copy1��5      $
��Left=�6-   $��
27,106,0,0q�6H   $
��Wrap=�6\   $	��Top=�6p   $��Address:��6�   $
��Bold"�6�   $��14(�6�    J� RenderTransformOrigin$ 1.139,0.587&�6�   �� 5   
   -   5        $ txtemail��5      $
��Left=�6$   $��23��6?   $��441,110,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��325��6�   �� 5   
   -	   5        $ textBlock_Copy2��5      $
��Left=�6-   $��393,110,0,0q�6H   $
��Wrap=�6]   $	��Top=�6q   $��Email :��6�   $
��Bold"�6�   $��14(�6�   �� 5   
   -
   5         ��Name$ 	btnsearch��5      $��Search��6$   $
��Left=�65   $��
694,14,0,0q�6P   $	��Top=�6d   $��72��6|   $��23��6�   ��5      �� 5       �� Color$ 	#FFD4CFCF��6"    �� Opacity$	 0.5Q�64   5      �� 5   
   -   5        $ txtserch��5      $
��Left=�6$   $��23��6?   $��
458,14,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��216��6�   �� 5   
   -   5        $	 add��5      $	��Add��6   $
��Left=�6,   $��487,191,0,0q�6G   $	��Top=�6\   $��70��6t   $��30��6   $��16(�6�   ��5      �� 5      $ 	#FF0C8917��6"   $	 0.5Q�64   5      &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dataGrid��5      $
��Left=�6%   $	��148��6@   $��
10,240,0,0q�6M   $	��Top=�6a   $	��772��6y   
�������
   MinColumnWidth$
 60Q�6�   �� 5    
   -   5        $ adjust��5       $
��Edit��6!   $��562,191,0,0q�60   $	��Top=�6E   $��30��6]   $��16(�6~   $��70��6�   $
��Left=�6�   ��5!      �� 5"      $ 	#FFEBFF04��6"   $	 0.5Q�64   5$      �� 5%   
   -   5        $
 back��5%      $
��Back��6   $
��Left=�6.   $��669,393,0,0q�6I   $	��Top=�6^   $	��113��6v   $��24��6�   $
��Bold"�6�   ��5&      �� 5'      $ 	#FFCECECE��6"   $	 0.5Q�64   5)      �� 5*   
   -   5        $ remove��5*      $��Remove��6!   $
��Left=�62   $��637,191,0,0q�6M   $	��Top=�6b   $��70��6z   $��30��6�   $��16(�6�   ��5+      �� 5,      $ 	#FFF44747��6"   $	 0.5Q�64   5.      �� 5/   
   -   5        $ refresh��5/      $��Refresh��6"   $
��Left=�64   $��712,191,0,0q�6O   $	��Top=�6d   $��70��6|   $��30��6�   $��16(�6�   ��50      �� 51      $ 	#FFF3B577��6"   $	 0.5Q�64   53      55      56      