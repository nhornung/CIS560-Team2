   M S B A M L   `   `   `  ����G  CFifaDatabase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FifaDatabase.ModelsFifaDatabase.Models  5      7 clr-namespace:FifaDatabase.ViewsFifaDatabase.Views  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	          FifaDatabase.Views.NavBar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      3enums!clr-namespace:FifaDatabase.Models     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:FifaDatabase.Views     5      9system&clr-namespace:System;assembly=mscorlib     5	        � 	Resources  5         table_enums S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName  eactions_enums��%�   &	        &	 m     S� 5   
   $ 	GetValues��61   "  6H    5      M� 5      $ enums:TableEnums��6   5      S� 5   
   $ 	GetValues��64   "  6K    5      M� 5      $ enums:ActionsEnums��6   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5       $��1* �6   �� 5!      $	��1*  �6   �� 5"      $��1* �6   �� 5#      $��1* �6   �� 5$      $��1* �6    � RowDefinitions 5(   
   �� 5)      $	��.5* �6   �� 5*      $��1* �6   .+�5,   
   �� -   5         ��Name$ CategoryCombo��5,      $
��Left=�6f   $	��119��6�   $��Century Gothic)�6�    �� Text$ Data Categories��6�   $	��Top=�6�   $��Center=�6�   $��Center=�6�   $��	76,15,0,0q�6  $��2��62  ��6*   �� 	 �� Source#	 [  62  �� 5-   
   -   5        $ QueryTypeCombo��5-      $
��Left=�6k   $��23��6�   $	��Top=�6�   $	��110��6�   $��Century Gothic)�6�   $ Action��6�   $��1��6�   $��Center=�6�   $��	65,15,0,0q�6  $��2��6%  ��6,   �� #	 [ 6%  �� 5/   
   $��5��6   $
��Left=�6(   $	��1.5��6C   $��38,33,0,-1.167q�6P   $��1��6h   $	��Top=�6u   $��907.333��6�   ���	#FFDC7E7E6�   �� 50   
   $��5��6   $
��Left=�6(   $	��1.5��6C   $��	38,-1,0,0q�6P   $	��Top=�6c   $��907.333��6{   ���	#FFDC7E7E6�   �� 51   
   -   5        $��Submit��51      $��2��6"   $
��Left=�62   $��33��6M   $��	26,10,0,0q�6Y   $��2��6l   $	��Top=�6}   $	��109��6�   6�   �� 52   
   
 �� Orientation$
 Vertical=�6    K� ZIndex$ 10��6,   $��4��6>   $��20,11,40,5.6q�6N   $��2��6d   .+�53      	� -   5         	�Name$	 Hot��53       	� 	GroupName$ report��6'   .��6X   Hot Hand 20106g   	� 54      -   5        $ Traits��54      $ report��6*   .��6V   Do Traits Matter 2010?6n   55      �� 56   
   $
 Vertical=�6   $ 10��6,   $��3��6>   $��195,12,185,4.6q�6R   $��2��6j   $��2��6z   .+�57      	� -   5        $ Views��57      $ report��6)   .��6T   Game Ratings6b   	� 58      -   5        $ Winning��58      $ report��6+   $��15.76��6>   $��Do Goals Matter?��6g   59      5;      5<      