   M S B A M L   `   `   `  ����G  CFifaDatabase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FifaDatabase.ModelsFifaDatabase.Models  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      7 clr-namespace:FifaDatabase.ViewsFifaDatabase.Views  5      1    +FifaDatabase.Views.SearchViews.PlayerSearch   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      3enums!clr-namespace:FifaDatabase.Models     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9system&clr-namespace:System;assembly=mscorlib     5      2local clr-namespace:FifaDatabase.Views     5        � 	Resources  5         positionEnums S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%y   &	        S� 5   
   $ 	GetValues��63   "  6J    5      M� 5      $ enums:PositionEnum��6   5      5      .��5      � ���#e9e9e8.+�5   
   �� $��1q�6   $
��Left=�6%   $��86��6@   $	��Top=�6L   $
��1000��6d    �� CornerRadius$ 18��6q   ���	#FFCF8484._�5      �� $��180,18,179,19.433q�6   $
��Wrap=�63   $��Players��6G   
�������$��Century Gothic)�6i   $��40(�6�    �� TextAlignment$ Center=�6�   5      �� 5   
   -   5         ��Name$ NameSearchTextBox��5      $
��Left=�6-   $��37.261��6H   $��	3,117,0,0q�6X    �� TextWrapping$
 Wrap=�6k   $�� ��6   $	��Top=�6�   $	��405��6�   $��Century Gothic)�6�   $��18(�6�   	 K� ZIndex$	 3��6�   $��Center=�6�   ��6�   Z� 6  �� 5   
   -   5        
 ��Name$
 TextBoxBorder��5      $��1q�6(   $
��Left=�6<   $��36.464��6W   $��	3,117,0,0q�6g   $	��Top=�6z   $	��405��6�   $ 10��6�   
�������6�   �� 5   
   -   5         ��Name$ WeightSlider��5       �� AutoToolTipPlacement$ TopLeft=�6'    �� AutoToolTipPrecision$ 0��6F   $
��Left=�6_   $��23��6z   $��137,212,0,0q�6�   $	��Top=�6�   $	��113��6�   ���	#FF515151���	#FF8AD4FF � SmallChange$ 1Q�6�    � Maximum$	 100Q�6�    � Minimum$ 55Q�6   � LargeChange$ 5Q�6   � Cursor$
 Hand��6)  $��23(�67   � Value$	 150Q�6E  {�. 6Q  �� 5   
   -   5         ��Name$ AgeText_Copy2��5      $
��Left=�6+   $��26��6F   $��160,175,0,0q�6R   $
��Wrap=�6g   $��Weight��6{   $	��Top=�6�   $��78��6�   $��Century Gothic)�6�   ���	#FFCF5555$ Center=�6�   $��20(�6�    J� RenderTransformOrigin$ 0.791,2.194&�6  �� 5   
   -   5        $ HeightSlider��5      $ TopLeft=�6'   $ 0��6F   $
��Left=�6_   $��23��6z   $��140,339,0,0q�6�   $	��Top=�6�   $	��110��6�   ���	#FF515151���	#FF8AD4FF$ 1Q�6�   $	 220Q�6�   $	 155Q�6  $ 5Q�6  $
 Hand��6*  $��23(�68  $	 220Q�6F  {�. 6R  �� 5   
   -   5        $ AgeText_Copy3��5      $
��Left=�6+   $��25��6F   $��165,299,0,0q�6R   $
��Wrap=�6g   $��Height��6{   $	��Top=�6�   $��73��6�   $��Century Gothic)�6�   ���	#FFCF5555$ Center=�6�   $��20(�6�   �� 5   
   -   5         ��Name$ PositionBox��5      $
��Left=�6f   $��31��6�   $��
10,339,0,0q�6�   $	��Top=�6�   $	��105��6�   ��6(   ��  �� Source# [  6�   �� 5   
   -   5        $ AgeText_Copy��5      $
��Left=�6*   $��26��6E   $��
10,299,0,0q�6Q   $
��Wrap=�6e   $��Position��6y   $	��Top=�6�   $��84��6�   $��Century Gothic)�6�   ���	#FFCF5555$ Center=�6�   $��20(�6�   �� 5    
   -	   5        $ AgeText_Copy4��5       $
��Left=�6+   $��26��6F   $��7,89,0,0q�6R   $
��Wrap=�6d   $��Search Player Name��6x   $	��Top=�6�   $	��218��6�   $��Century Gothic)�6�   ���	#FFCF5555$ Center=�6�   $��20(�6   �� 5!   
   -
   5        $��Submit��5!      $
��Left=�6"   $��61��6=   $��289,240,0,0q�6I   $	��Top=�6^   $	��111��6v   6�   &   System.Windows.Controls.DataGrid  5"   
   -   5        $��PlayerDataGrid��5"      $
��Left=�6)      AlternatingRowBackground
 �����$	��260��6i   $��535,130,0,0q�6v   $	��Top=�6�   $	��445��6�   6�   (  "System.Windows.Controls.DatePicker  5#   
   -   5        $��AgeDatePicker��5#      $��10,205,863,180q�6*   �� 5$   
   -   5        $ AgeText_Copy1��5$      $
��Left=�6+   $��26��6F   $��	5,174,0,0q�6R   $
��Wrap=�6e   $��
Birth Date��6y   $	��Top=�6�   $	��115��6�   $��Century Gothic)�6�   ���	#FFCF5555$ Center=�6�   $��20(�6�   $ 0.791,2.194&�6  �� 5%   
   -   5        $ AgeText_Copy5��5%      $
��Left=�6+   $��26��6F   $��
730,95,0,0q�6R   $
��Wrap=�6f   $��Players��6z   $	��Top=�6�   $��80��6�   $��Century Gothic)�6�   ���	#FFCF5555$ Center=�6�   $��20(�6�   �� 5&   
   -   5        $ FaintLetteringText��5&      $
��Left=�60   $��26��6K   $��
10,124,0,0q�6W   $
��Wrap=�6k   $��Enter Name...��6   $	��Top=�6�   $	��218��6�   $��Century Gothic)�6�   
�������$
 Left=�6�   $��20(�6   5*      5+      