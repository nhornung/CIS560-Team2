   M S B A M L   `   `   `  ����G  CFifaDatabase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FifaDatabase.ModelsFifaDatabase.Models  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      7 clr-namespace:FifaDatabase.ViewsFifaDatabase.Views  5      %    FifaDatabase.Views.PlayerCreate   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      3enums!clr-namespace:FifaDatabase.Models     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9system&clr-namespace:System;assembly=mscorlib     5      2local clr-namespace:FifaDatabase.Views     5        � 	Resources  5         positionEnums S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%y   &	        S� 5   
   $ 	GetValues��63   "  6J    5      M� 5      $ enums:PositionEnum��6   5      5      .��5      � ���	#FFB4B4B4.+�5   
   �� $��1q�6   $
��Left=�6%   $��86.433��6@   $	��Top=�6P   $	��990��6h    �� CornerRadius$ 18��6t   ���	#FFCF8484._�5      �� $��180,18,179,19.433q�6   $
��Wrap=�63   
�������$��Century Gothic)�6Z   $��40(�6v    �� TextAlignment$ Center=�6�   �� 6�   $�Player��6�   �� 6�   �� 6�   6�   5      �� 5   
   -   5         ��Name$ NameTextBox��5      $
��Left=�6'   $��37��6B   $��50.4,116,0,0q�6N    �� TextWrapping$
 Wrap=�6d   $��Search Player Name��6x   $	��Top=�6�   $��357.6��6�   $��Century Gothic)�6�   $��18(�6�   	 K� ZIndex$	 3��6�   $��Center=�6	  ��6�   Z� 6	  �� 5   
   -   5        
 ��Name$
 TextBoxBorder��5      $��1q�6(   $
��Left=�6<   $��36.464��6W   $��50.4,117,0,0q�6g   $	��Top=�6}   $��357.6��6�   $ 10��6�   
�������6�   �� 5   
   -   5         ��Name$ WeightSlider��5       �� AutoToolTipPlacement$ TopLeft=�6'    �� AutoToolTipPrecision$ 0��6F   $
��Left=�6_   $��23��6z   $��250,179.031,0,-2.031q�6�   $	��Top=�6�   $	��153��6�   ���	#FF515151���	#FF8AD4FF � SmallChange$ 1Q�6�    � Maximum$ 95Q�6   � Minimum$ 56Q�6   � LargeChange$ 5Q�6!   � Cursor$
 Hand��61  $��23(�6?   � Value$ 15Q�6M  {�. 6X  �� 5   
   -   5         ��Name$ 
WeightText��5      $
��Left=�6(   $��25.567��6C   $��250,153.464,0,0q�6S   $
��Wrap=�6l   $��Weight��6�   $	��Top=�6�   $	��153��6�   $��Century Gothic)�6�   ���	#FFCF5555$ Center=�6�   $��20(�6�    J� RenderTransformOrigin$ 0.791,2.194&�6
  �� 5   
   -   5        $ HeightSlider��5      $ TopLeft=�6'   $ 0��6F   $
��Left=�6_   $��23��6z   $��494.667,173.234,0,0q�6�   $	��Top=�6�   $	��153��6�   ���	#FF515151���	#FF8AD4FF$ 1Q�6�   $	 220Q�6  $	 160Q�6  $ 5Q�6"  $
 Hand��62  $��23(�6@  $ 15Q�6N  {�. 6Y  �� 5   
   -   5        $ 
HeightText��5      $
��Left=�6(   $��25.567��6C   $��494.667,147.667,0,0q�6S   $
��Wrap=�6p   $��Height��6�   $	��Top=�6�   $	��153��6�   $��Century Gothic)�6�   ���	#FFCF5555$ Center=�6�   $��20(�6   �� 5   
   -   5         ��Name$ PositionBox��5      $
��Left=�6f   $��30.667��6�   $��419,117,0,0q�6�   $	��Top=�6�   $	��246��6�   ��6(   ��  �� Source# [  6�   �� 5   
   -   5        $ PositionText��5      $
��Left=�6*   $��25.567��6E   $��460.667,91.433,0,0q�6U   $
��Wrap=�6q   $��Position��6�   $	��Top=�6�   $	��153��6�   $��Century Gothic)�6�   ���	#FFCF5555$ Center=�6�   $��20(�6  �� 5    
   -	   5        $ PlayerNameText��5       $
��Left=�6,   $��25.567��6G   $��93,86.433,0,0q�6W   $
��Wrap=�6n   $��Enter Player Name��6�   $	��Top=�6�   $	��218��6�   $��Century Gothic)�6�   ���	#FFCF5555$ Center=�6�   $��20(�6	  �� 5!   
   -
   5        $��Submit��5!      $
��Left=�6"   $��61.234��6=   $��679.116,112,0,0q�6M   $	��Top=�6f   $��110.884��6~   6�   (  "System.Windows.Controls.DatePicker  5"   
   -   5        $��AgeDatePicker��5"      $��93,207.831,807,167.169q�6*   $	��100��6K   6Y   �� 5#   
   -   5        $ WeightText_Copy��5#      $
��Left=�6-   $��25.567��6H   $��50.4,159.261,0,0q�6X   $
��Wrap=�6r   $��
Birth Date��6�   $	��Top=�6�   $	��153��6�   $��Century Gothic)�6�   ���	#FFCF5555$ Center=�6�   $��20(�6  $ 0.791,2.194&�6  5'      5(      