   M S B A M L   `   `   `  ����G  CBookstoreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BookstoreAppBookstoreApp  5   	       BookstoreApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BookstoreApp     5   	     � Title$  G-Book BookShop_Manager��5   	   $	��450��6)   $	��800��66   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��386* �6   �� 5      $	��11* �6   .+�5   
   �� -   5         ��Name$ 
background��5      ���	#FF46D1BE$
��Left=�69   $	��420��6T   $��
0,0,-0.4,0q�6a   
���   �$	��Top=�6�   $	��794��6�   $��2��6�   �� 5   
   -   5         ��Name$ logoApp��5      $
��Left=�6!   $	��125��6<   $��
56,141,0,0q�6I   $	��Top=�6]   $	��217��6u   $��BookLogo.png��6�   �� 5   
   -   5         ��Name$ WelcomeText��5      $
��Left=�6)   $��40��6D   $��	56,96,0,0q�6P   $
��Wrap=�6c   $��WELCOME to...��6w   $	��Top=�6�   $	��193��6�   $��18(�6�   $��Italic$�6�    �� TextAlignment$ Center=�6�   �� 5   
   -   5        $
 Name��5      $
��Left=�6"   $��87��6=   $��	0,271,0,0q�6I   $
��Wrap=�6\   $	��Top=�6p   $	��339��6�   $��24(�6�   ���	#FFDC623F$ Center=�6�   $
��Bold"�6�   �� 6�   $�G-BOOK��6�   �� 6�   �� 6  $� BookShop_Manager��6  6#  �� 5   
   $
��Left=�6   $	��360��6/   $��
401,35,0,0q�6<   ���	#FF46D1BE$	��Top=�6c   $	��360��6{   ���	#7FFFFFFF6�   �� 5   
   -   5        $ 	Name_Copy��5      $
��Left=�6'   $��46��6B   $��
529,61,0,0q�6N   $
��Wrap=�6b   $	��Top=�6v   $	��128��6�   $��32(�6�   
���   �$ Center=�6�   $��LOGIN��6�   $
��Bold"�6�   ��6�   Z� �� 5   
   -   5        $ 
Name_Copy1��5      $
��Left=�6(   $��46��6C   $��401,141,0,0q�6O   $
��Wrap=�6d   $	��Top=�6x   $	��128��6�   $��18(�6�   
���   �$ Center=�6�   $��	Username:��6�   ��6�   Z� �� 5   
   -   5        $ 
Name_Copy2��5      $
��Left=�6(   $��46��6C   $��401,209,0,0q�6O   $
��Wrap=�6d   $	��Top=�6x   $	��128��6�   $��18(�6�   
���   �$ Center=�6�   $��	Password:��6�   ��6�   Z� �� 5   
   -   5         ��Name$ signinButton��5      $��Sign in��6'   $
��Left=�69   $��44��6T   $��500,298,0,0q�6`   $	��Top=�6u   $	��175��6�   
�������$��16(�6�   6�   �� 5   
   -	   5         ��Name$ passwordText��5      $
��Left=�6(   $��34��6C   $��529,209,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $��please type password here��6x   $	��Top=�6�   $	��170��6�   6�   �� 5   
   -
   5        $ usernameText��5      $
��Left=�6(   $��34��6C   $��529,141,0,0q�6O   $
 Wrap=�6d   $��please type username here��6x   $	��Top=�6�   $	��170��6�   6�   �� 5   
   -   5        $ forgotButton��5      $"��Forgot Username or Password?��6'   $
��Left=�6N   $��455,357,0,0q�6i   $	��Top=�6~   $	��257��6�   $��28��6�   ���	#00000000���	#000000006�   5      5      