   M S B A M L   `   `   `  ����F  BElevatorSim, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ElevatorSim.ViewsElevatorSim.Views  5      ?$clr-namespace:ElevatorSim.ViewModelsElevatorSim.ViewModels  5      $    ElevatorSim.Views.ElevatorView   5      Z VDevExpress.Mvvm.UI, Version=22.1.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:ElevatorSim.Views     5      ;
viewmodels$clr-namespace:ElevatorSim.ViewModels     5      .��5
      �   � RowDefinitions  5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� 
���   �$��0��6#   ��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      �� 5       �� Binding 6&   �� *CurrentFloor+ �� Value 16G   .a�5      ��  �� Property � �� �� Value
 ����65   5      �� 5       6&   �� *CurrentFloor+ 26G   .a�5      ��  � ��
 � � �65   5      5      5       �� 5"   
   $��Elevator��6   $��0��6$    �� TextAlignment$ Center=�61   $��15(�6H   $
��Bold"�6V   �� 5$   
   
���   �$��1��6#   ��5%      �� 5&      " ��6    5'      �� 5(       6&   �� *ActiveFloor[2]+ True6I   .a�5)      ��  � ��
 ����65   5*      �� 5+       6&   �� *ActiveFloor[2]+	 False6I   .a�5,      ��  � ��
 � � �65   5-      5/      51      �� 53   
   
���   �$��2��6#   ��54      �� 55      " ��6    56      �� 57       6&   �� *ActiveFloor[3]+ True6I   .a�58      ��  � ��
 ����65   59      �� 5:       6&   �� *ActiveFloor[3]+	 False6I   .a�5;      ��  � ��
 � � �65   5<      5>      5@      �� 5B   
   
���   �$��3��6#   ��5C      �� 5D      " ��6    5E      �� 5F       6&   �� *ActiveFloor[4]+ True6I   .a�5G      ��  � ��
 ����65   5H      �� 5I       6&   �� *ActiveFloor[4]+	 False6I   .a�5J      ��  � ��
 � � �65   5K      5M      5O      �� 5Q   
   
���   �$��4��6#   ��5R      �� 5S      " ��6    5T      �� 5U       6&   �� *ActiveFloor[5]+ true6I   .a�5V      ��  � ��
 ����65   5W      �� 5X       6&   �� *ActiveFloor[5]+	 false6I   .a�5Y      ��  � ��
 � � �65   5Z      5\      5^      5_      5`      