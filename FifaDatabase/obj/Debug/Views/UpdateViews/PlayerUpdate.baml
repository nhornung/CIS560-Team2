   M S B A M L   `   `   `  ����G  CFifaDatabase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FifaDatabase.ModelsFifaDatabase.Models  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      7 clr-namespace:FifaDatabase.ViewsFifaDatabase.Views  5      %    FifaDatabase.Views.PlayerUpdate   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      3enums!clr-namespace:FifaDatabase.Models     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9system&clr-namespace:System;assembly=mscorlib     5      2local clr-namespace:FifaDatabase.Views     5        � 	Resources  5         positionEnums S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%y   &	        S� 5   
   $ 	GetValues��63   "  6J    5      M� 5      $ enums:PositionEnum��6   5      5      .��5      � ���	#FFB4B4B4 � RowDefinitions 5   
   �� 5      $	��23* �6   �� 5      $	��67* �6   .+�5   
   �� $��1q�6   $
��Left=�6%   $��86��6@   $	��Top=�6L   $	��980��6d    �� CornerRadius$ 18��6p   ���	#FFCF8484._�5      �� $��180,18,179,19.433q�6   $
��Wrap=�63   
�������$��Century Gothic)�6Z   $��40(�6v    �� TextAlignment$ Center=�6�   �� 6�   $�Player��6�   �� 6�   �� 6�   6�   5      �� 5   
   -   5        $��Submit��5      $
��Left=�6"   $��61��6=   $��624,111.6,0,0q�6I   $	��Top=�6`   $	��111��6x   $��1��6�   6�   �� 5   
   -   5         ��Name$ NameSearchTextBox��5      $
��Left=�6H   $��38��6c   $��103,29.6,0,0q�6o   	 �� TextWrapping$
	 Wrap=�6�   $	��Top=�6�   $	��405��6�   $��Century Gothic)�6�   $��18(�6�   
 K� ZIndex$
 3��6�   $��Center=�6  $��1��6\  ��6-   ��  �� Path$
 Name���6�   Z� 6\  �� 5   
   -   5         ��Name$ TextBoxBorder��5      $��1q�6(   $
��Left=�6<   $��36��6W   $��103,29.6,0,0q�6c   $	��Top=�6y   $	��405��6�   $ 10��6�   
�������$��1��6�   �� 5   
   -   5         ��Name$ WeightSlider��5       �� AutoToolTipPlacement$ TopLeft=�6'    �� AutoToolTipPrecision$ 0��6F   $
��Left=�6_   $��23��6z   $��237,124.6,0,0q�6�   $	��Top=�6�   $	��113��6�   ���	#FF515151���	#FF8AD4FF � SmallChange$ 1Q�6�    � Maximum$	 100Q�6    � Minimum$ 55Q�6   � LargeChange$ 5Q�6   � Cursor$
 Hand��6+  $��23(�69   � Value$ 0Q�6G  {�. $��1��6b  �� 5   
   -   5         ��Name$ AgeText_Copy2��5      $
��Left=�6+   $��26��6F   $��260,87.6,0,0q�6R   $
��Wrap=�6h   $��Weight��6|   $	��Top=�6�   $��78��6�   $��Century Gothic)�6�   ���	#FFCF5555$ Center=�6�   $��20(�6�    J� RenderTransformOrigin$ 0.791,2.194&�6  $��1��6)  �� 5    
   -   5        $ HeightSlider��5       $ TopLeft=�6'   $ 0��6F   $
��Left=�6_   $��23��6z   $��240,227.6,0,0q�6�   $	��Top=�6�   $	��110��6�   ���	#FF515151���	#FF8AD4FF$ 1Q�6�   $	 220Q�6   $	 155Q�6  $ 5Q�6  $
 Hand��6,  $��23(�6:  $ 0Q�6H  {�. $��1��6c  �� 5!   
   -   5        $ AgeText_Copy3��5!      $
��Left=�6+   $��25��6F   $��265,162.6,0,0q�6R   $
��Wrap=�6i   $��Height��6}   $	��Top=�6�   $��73��6�   $��Century Gothic)�6�   ���	#FFCF5555$ Center=�6�   $��20(�6�   $��1��6  �� 5"   
   -   5         ��Name$ PositionBox��5"      $
��Left=�6f   $��31��6�   $��110,227.6,0,0q�6�   $	��Top=�6�   $	��105��6�   $��1��6�   ��6(   ��  �� Source# [  6�   �� 5#   
   -	   5        $ AgeText_Copy��5#      $
��Left=�6*   $��26��6E   $��116,172.6,0,0q�6Q   $
��Wrap=�6h   $��Position��6|   $	��Top=�6�   $��84��6�   $��Century Gothic)�6�   ���	#FFCF5555$ Center=�6�   $��20(�6�   $��1��6  �� 5$   
   -
   5        $ AgeText_Copy4��5$      $
��Left=�6+   $��26��6F   $��107,1.6,0,0q�6R   $
��Wrap=�6g   $��Search Player Name��6{   $	��Top=�6�   $	��218��6�   $��Century Gothic)�6�   ���	#FFCF5555$ Center=�6�   $��20(�6  $��1��6  (  "System.Windows.Controls.DatePicker  5%   
   -   5          Name$ AgeDatePicker��5%      $��115,122.6,785,150q�6,   $	��100��6G   $��1��6S      SelectedDate 6`   �� $	 Age��� 5&   
   -   5        $ AgeText_Copy1��5&      $
��Left=�6+   $��26��6F   $��105,86.6,0,0q�6R   $
��Wrap=�6h   $��
Birth Date��6|   $	��Top=�6�   $	��115��6�   $��Century Gothic)�6�   ���	#FFCF5555$ Center=�6�   $��20(�6�   $ 0.791,2.194&�6
  $��1��6.  �� 5'   
   -   5        $ FaintLetteringText��5'      $
��Left=�60   $��26��6K   $��110,36.6,0,0q�6W   $
��Wrap=�6m   $��Enter Name...��6�   $	��Top=�6�   $	��218��6�   $��Century Gothic)�6�   
�������$
 Left=�6�   $��20(�6  $��1��6  5*      5+      