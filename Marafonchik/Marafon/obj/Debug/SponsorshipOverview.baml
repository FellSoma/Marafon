   M S B A M L   `   `   `  ����B  >Marafon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MarafonMarafon  5   	   !    Marafon.SponsorshipOverview   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Marafon     5   	     � Title$  SponsorshipOverview��5   	   $��490.8��6%   $	��800��64   .��5	      � .+�5
   
   �� ���	#FF3E3E3E$��0,0,1.6,390.6q�6)   ._�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��
Назад��5      $��25��5      $��45��5      $��10q�5      6!   �� 5      ���#FFFF$
��Bold"�5      $��25(�5      $��Center=�5      $��MARATHON SKILLS 2016��5      �� 5      -   5        $��Logout��5      $��25��5      $��45��5      $��	360,0,0,0q�5      $��Right=�5      61   5       5!      �� 5"   
   ���	#FF3E3E3E$��Center=�6)   $��0,430,1.6,-0.6q�6F   $	��792��6^   ._�5#      �� $��12(�5$      $��Center=�5%      $S��M18 дней 8 часов и 17 минут до старта марафона!��5&      ���	#FFC9C9C9$
��Wrap=�5(      $��244,10,246,0q�5)      $	��302��5*       �� TextAlignment$ Center=�5+      5,      �� 5-   
   $
��Left=�6   $��
242,71,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��28��6o   $	��274��6{   ���	#FF656565$��22(�6�   $��Arial)�6�   $ Center=�6�   �� 6�   $0�*Регистрация на марафон��6�   �� 6�   6  �� 5.   
   $
��Left=�6   $��183,157,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��50��6p   $	��390��6|   ���	#FF656565$��22(�6�   $��Arial)�6�   $ Center=�6�   �� 6�   $C�=Благотворительные организации: 10��6�   �� 6  �� 6  $?�9Всего спонсорских взносов: $94,450��6  �� 6C  �� 6O  6V  �� 5/   
   $
��Left=�6   $��150,125,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��20��6p   $	��109��6|   ���	#FF656565$��14(�6�   $��Arial)�6�   $
 Left=�6�   �� 6�   $!�Отсортировать:��6�   �� 6�   6�   �� 50   
   $
��Left=�6   $��264,122,0,0q�6.   $	��Top=�6C   $	��196��6[   �� 51   
   $��Сортировка��6   $
��Left=�6&   $��491,124,0,0q�6A   $	��Top=�6V   $	��115��6n   $��Arial)�6z   $��28��6�   ���	#FFF2F2F26�   &   System.Windows.Controls.DataGrid  52   
   -   5          Name$ 
phonesGrid��52      $
��Left=�6'   $	��213��6B   $��132,212,0,0q�6O   $	��Top=�6d   $	��523��6|      	RowHeight$ 30Q�53         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6    
�������   RowBackground
 �����   AlternatingRowBackground
 �����   Columns 56      4  .System.Windows.Controls.DataGridTemplateColumn  57      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Логотип��6)   
   CellTemplate
 58      �� 59      .R�5:      �� $��Logo.png��6$   5;      5=      5?      5@      5A      