   M S B A M L   `   `   `  ����G  CBookstoreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BookstoreAppBookstoreApp  5   	       BookstoreApp.Book_Order   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BookstoreApp     5   	     � Title$  
Book_Order��5   	   $��757.2��6   $��904.4��6+   .��5	      � ���	#FFFFEFE7$��0,0,0,-19.8q�6"   $
��Left=�67   $	��894��6R    � ColumnDefinitions 5
   
   �� 5      $
��515* �6   �� 5      $
��378* �6   .+�5   
   �� -   5         ��Name$ groupBox_Copy��5      $��	
Payment��6*   $
��Left=�6E   $	��215��6`   $��8,55,0,0q�6m   $	��Top=�6   $	��361��6�   $��1��6�   $��16(�6�   $
��Bold"�6�   ��5      �� 5       �� Color$ 	#FFF1D2A5��6"    �� Opacity$	 0.5Q�64   5      �� 5   
   -   5        $ groupBox��5      $��
Book Details��6%   $
��Left=�6E   $	��220��6`   $��	10,50,0,0q�6m   $	��Top=�6�   $	��507��6�   $��2��6�   $��16(�6�   $
��Bold"�6�   ��5      �� 5      $ 	#FFF5D8D8��6"   $	 0.5Q�64   5      �� 5   
   -   5         ��Name$ 	cbbidbook��5      $
��Left=�6&   $��140,123,0,0q�6A   $	��Top=�6V   $	��175��6n   $��24��6�   �� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��
29,130,0,0q�6B   $
��Wrap=�6V   $>��8เลขประจำตัวหนังสือ :��6j   $	��Top=�6�   $��16��6�   $	��106��6�   $��14(�6�   �� 5   
   -   5        $ textBlock_Copy��5      $
��Left=�6,   $��47.1,117,0,0q�6G   $
��Wrap=�6]   $;��5เลขประจำตัวลูกค้า :��6q   $	��Top=�6�   $��20��6�   $��99��6�   $��1��6�   $��14(�6�   �� 5   
   -   5        $ cbbidcus��5      $
��Left=�6%   $��167.1,112,0,0q�6@   $	��Top=�6W   $	��174��6o   $��27��6{   $��1��6�   �� 5   
   -   5         ��Name$ txtunit��5      $
��Left=�6#   $��25��6>   $��167.1,172,0,0q�6J    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $��56��6�   $��1��6�   �� 5   
   -   5        $ textBlock_Copy1��5      $
��Left=�6-   $��
44,172,0,0q�6H   $
��Wrap=�6\   $A��;จำนวนหนังสือที่ซื้อ :��6p   $	��Top=�6�   $��18��6�   $	��102��6�   $��1��6�   $��14(�6�   �� 5   
   -	   5        $ 
textBlock1��5      $
��Left=�6(   $��
47,202,0,0q�6C   $
��Wrap=�6W   $��ราคารวม :��6k   $	��Top=�6|   $��14(�6�   $��23��6�   $��71��6�   $��1��6�   �� 5    
   -
   5        $ txtbtotleprice��5       $
��Left=�6,   $��167,202,0,0q�6G   $
��Wrap=�6\   $��00000��6p   $	��Top=�6}   $��56��6�   $��14(�6�   $��23��6�   $��1��6�   �� 5!   
   -   5        $ textBlock1_Copy1��5!      $
��Left=�6.   $��238,202,0,0q�6I   $
��Wrap=�6^   $��
บาท ��6r   $	��Top=�6~   	 J� RenderTransformOrigin$	 -0.59,0.564&�6�   $��14(�6�   $��23��6�   $��32��6�   $��1��6�   �� 5"   
   -   5        
 ��Name$
 btncalculate��5"      $	��Buy��6'   $
��Left=�65   $��290,223,0,0q�6P   $	��Top=�6e   $��64��6}   $��36��6�   $��22(�6�   $��1��6�   ��5#      �� 5$      $ 	#FFFF8865��6"   $	 0.5Q�64   5&      &   System.Windows.Controls.DataGrid  5'   
   -   5          Name$ dataGrid��5'      $
��Left=�6%   $	��446��6@   $��
10,275,0,0q�6M   $	��Top=�6a   $	��874��6y   ��. $��2��6�   �� 5(   
   -   5        $ textBlock1_Copy2��5(      $
��Left=�6.   $��213,234,0,0q�6I   $
��Wrap=�6^   $��
บาท ��6r   $	��Top=�6~   $��20��6�   $��25��6�   $��14(�6�   �� 5)   
   -   5        $ textBlock1_Copy3��5)      $
��Left=�6.   $��
73,234,0,0q�6I   $
��Wrap=�6]   $��ราคา :��6q   $	��Top=�6   $��20��6�   $��32��6�   $��14(�6�   �� 5*   
   -   5        $ 	txtbprice��5*      $
��Left=�6'   $��112,234,0,0q�6B   $
��Wrap=�6W   $��00000��6k   $	��Top=�6x   $��82��6�   $��20��6�   $��14(�6�   �� 5+   
   -   5        $ textBlock_Copy2��5+      $
��Left=�6-   $��
77,169,0,0q�6H   $
��Wrap=�6\   $)��#ชื่อหนังสือ :��6p   $	��Top=�6�   $��16��6�   $��57��6�   $��14(�6�   �� 5,   
   -   5        $ txtnamebook��5,      $
��Left=�6)   $��140,169,0,0q�6D   $
��Wrap=�6Y   $��.........................��6m   $	��Top=�6�   $	��269��6�   $��16��6�   $��14(�6�   �� 5-   
   -   5        $ textBlock_Copy3��5-      $
��Left=�6-   $��
72,208,0,0q�6H   $
��Wrap=�6\   $&�� รายละเอียด :��6p   $	��Top=�6�   $��17��6�   $��63��6�   $��14(�6�   �� 5.   
   -   5        $ 	txtdetail��5.      $
��Left=�6'   $��140,208,0,0q�6B   $
��Wrap=�6W   $��.............��6k   $	��Top=�6�   $	��269��6�   $��21��6�   $��14(�6�   �� 5/   
   -   5        $ textBlock1_Copy4��5/      $
��Left=�6.   $��238,172,0,0q�6I   $
��Wrap=�6^   $��เล่ม��6r   $	��Top=�6~   $��18��6�   $��63��6�   $��1��6�   $��14(�6�   �� 50   
   -   5        $

 Back��50      $
��Back��6   $
��Left=�6.   $��
243,23,0,0q�6I   $	��Top=�6]   $	��125��6u   $��27��6�   $��1��6�   ��51      �� 52      $ 	#FFAFF999��6"   $	 0.5Q�64   54      55      56      