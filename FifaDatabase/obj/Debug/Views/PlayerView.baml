   M S B A M L   `   `   `  ����G  CFifaDatabase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FifaDatabase.ModelsFifaDatabase.Models  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      7 clr-namespace:FifaDatabase.ViewsFifaDatabase.Views  5      #    FifaDatabase.Views.PlayerView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      3enums!clr-namespace:FifaDatabase.Models     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9system&clr-namespace:System;assembly=mscorlib     5      2local clr-namespace:FifaDatabase.Views     5        � 	Resources  5         positionEnums S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%y   &	        S� 5   
   $ 	GetValues��63   "  6J    5      M� 5      $ enums:PositionEnum��6   5      5      .��5      � 
������� J� RenderTransformOrigin$ 0.512,0.434&�6"    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   .+�5   
   �� $��10,95,13.6,10q�6   
�������6(   �� 5   
   $��2��6   $��1q�6%   $
��Left=�69   $��86��6T   $	��Top=�6`   $	��995��6x    �� CornerRadius$ 18��6�   ���	#FFCF8484._�5      �� $��180,18,179,19.433q�6   $
��Wrap=�63   $��Players��6G   
�������$��Century Gothic)�6i   $��40(�6�    �� TextAlignment$ Center=�6�   5      �� 5   
   -   5        	 ��Name$	 AgeText_Copy2��5      $
��Left=�6+   $��26��6F   $��
20,225,0,0q�6R   $
��Wrap=�6f   $��Weight:��6z   $	��Top=�6�   $��85��6�   $��Century Gothic)�6�   ���	#FFCF5555$
 Left=�6�   $��20(�6�   $ 0.791,2.194&�6  �� 5   
   -   5        $	 AgeText_Copy3��5      $
��Left=�6+   $��27��6F   $��
20,285,0,0q�6R   $
��Wrap=�6f   $��Height:��6z   $	��Top=�6�   $��75��6�   $��Century Gothic)�6�   ���	#FFCF5555$
 Left=�6�   $��20(�6�   �� 5   
   -   5        $	 AgeText_Copy��5      $
��Left=�6*   $��26��6E   $��
20,165,0,0q�6Q   $
��Wrap=�6e   $��	Position:��6y   $	��Top=�6�   $��88��6�   $��Century Gothic)�6�   ���	#FFCF5555$
 Left=�6�   $��20(�6�   �� 5   
   -   5        $	 AgeText_Copy4��5      $
��Left=�6+   $��26��6F   $��
20,105,0,0q�6R   $
��Wrap=�6f   $��Player Name��6z   $	��Top=�6�   $	��208��6�   $��Century Gothic)�6�   ���	#FFCF5555$
 Left=�6�   $��20(�6�   $ 0.206,0.615&�6  �� 5    
   -   5        $	 AgeText_Copy1��5       $
��Left=�6+   $��27��6F   $��
20,345,0,0q�6R   $
��Wrap=�6f   $
��Age:��6z   $	��Top=�6�   $��75��6�   $��Century Gothic)�6�   ���	#FFCF5555$
 Left=�6�   $��20(�6�   &   System.Windows.Controls.DataGrid  5!   
   -   5        
  Name$
 PlayerDataGrid_Copy��5!         AlternatingRowBackground
 �����$
��Left=�6U   $	��250��6p   $��81.4,120,0,0q�6}   $	��Top=�6�   $	��410��6�   $��1��6�   �� 5"   
   -   5        $	 AgeText_Copy6��5"      $
��Left=�6+   $��26��6F   $��203.4,89,0,0q�6R   $
��Wrap=�6h   $��Game History��6|   $	��Top=�6�   $	��133��6�   $��Century Gothic)�6�   ���	#FFCF5555$
 Left=�6�   $��20(�6�   $��1��6
  �� 5#   
   -   5        $	 AgeText_Copy5��5#      $
��Left=�6+   $��26��6F   $��
20,135,0,0q�6R   $
��Wrap=�6f   $	��Top=�6�   $	��250��6�   $��Century Gothic)�6�   
�������$
 Left=�6�   $��20(�6�   $ 0.206,0.615&�6  ��6z   ��  �� Path$
 Name�6  �� 5$   
   -	   5        $	 AgeText_Copy7��5$      $
��Left=�6+   $��26��6F   $��
20,195,0,0q�6R   $
��Wrap=�6f   $	��Top=�6�   $	��250��6�   $��Century Gothic)�6�   
�������$
 Left=�6�   $��20(�6  $ 0.206,0.615&�6  ��6z   �� $ Position�6  �� 5%   
   -
   5        $	 AgeText_Copy8��5%      $
��Left=�6+   $��26��6F   $��
20,255,0,0q�6R   $
��Wrap=�6f   $	��Top=�6�   $	��240��6�   $��Century Gothic)�6�   
�������$
 Left=�6�   $��20(�6�   $ 0.206,0.615&�6  ��6z   �� $ Weight�6  �� 5&   
   -   5        $	 AgeText_Copy9��5&      $
��Left=�6+   $��26��6F   $��
20,315,0,0q�6R   $
��Wrap=�6f   $	��Top=�6�   $	��230��6�   $��Century Gothic)�6�   
�������$
 Left=�6�   $��20(�6�   $ 0.206,0.615&�6  ��6z   �� $ Height�6  �� 5'   
   -   5        $	 AgeText_Copy10��5'      $
��Left=�6,   $��26��6G   $��
20,375,0,0q�6S   $
��Wrap=�6g   $	��Top=�6�   $	��235��6�   $��Century Gothic)�6�   
�������$
 Left=�6�   $��20(�6�   $ 0.206,0.615&�6  ��6{   �� $	 Age�6  �� 5(   
   -   5         ��Name$
 Stat��5(      $��520,125,20,250q�6   $��1��67   $��Add Stat��6G   6Z   �� 5)   
   -   5        $ Modify��5)      $��521.4,230,20,145q�6!   $��1��6;   $��Modify��6K   6\   5*      5,      