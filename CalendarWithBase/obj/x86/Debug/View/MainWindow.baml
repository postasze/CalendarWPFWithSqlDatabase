   M S B A M L   `   `   `  ����K  GCalendarWithBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CalendarWithBase.ViewCalendarWithBase.View  5   	   G(clr-namespace:CalendarWithBase.ViewModelCalendarWithBase.ViewModel  5   	   &     CalendarWithBase.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   1v#clr-namespace:CalendarWithBase.View     5   	   7vm(clr-namespace:CalendarWithBase.ViewModel     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   ��6h   �� *
FontType+��6�   �� *WindowColor+ � DataContext 5      4   .CalendarWithBase.ViewModel.MainWindowViewModel  5	   
    � 	Resources 5      0   *CalendarWithBase.View.WidthToSizeConverter   WidthToSizeConverter��%   &	          5   
   6!   5      .��5      � -   5        $��MainGrid��5       5   
    �� 
TargetType �� Property �� Value �� 	Converter �� ElementName �� Path��%i  '��       7   '��     7   '�� �    7   �� 5      " ��6   .�5      ��  � ��$ 
1, 1, 1, 1q�6+   �� 5       � �� 6,   �� *ButtonCommandProperty+�� 5       � �� 6-   �� 8   $ MainGrid��$ ActualWidth��� 5       � �� 6/   �� *ButtonColor+5      �� 5      " ��6   .�5      ��  � ��$ Stretch=�68   �� 5       � ��$ Stretch=�66   �� 5       � ��$ Center=�6?   �� 5       � ��$ Center=�6=   �� 5       � ��$ 
1, 1, 1, 1q�6+   �� 5       � �� 6/   �� *GeneralLabelColor+�� 5       � �� 6-   �� 8   $ MainGrid��$ ActualWidth�5       �� 5!      " ��6   .�5"      ��  � ��$ 1q�6+   �� 5#       � ��$ 
0, 0, 0, 0q�6,   �� 5$       � �� 6-   �� 8   $ MainGrid��$ ActualWidth�5%      5&      	 � ColumnDefinitions	 5'   
   �� 5(      $��1* �6   �� 5)      $��2* �6   �� 5*      $��2* �6   �� 5+      $��2* �6   �� 5,      $��2* �6   �� 5-      $��2* �6   �� 5.      $��2* �6   �� 5/      $��2* �6   �� 50      $��1* �6   
 � RowDefinitions
 52   
   �� 53      $��1* �6   �� 54      $��2* �6   �� 55      $��2* �6   �� 56      $��2* �6   �� 57      $��2* �6   �� 58      $��1* �6   .+�5:   
   �� -   5        $��Button_prev_1��5:      $
��prev��6&   $��0��6>   $��0��6N   $
��prev��6[   �� 5;   
   -   5        $��Button_prev_2��5;      $
��prev��6&   $��8��6>   $��0��6N   $
��prev��6[   �� 5<   
   -   5        $��Button_next_1��5<      $
��next��6&   $��0��6>   $��5��6N   $
��next��6[   �� 5=   
   -   5        $��Button_next_2��5=      $
��next��6&   $��8��6>   $��5��6N   $
��next��6[   �� 5>   
   $��Monday��6   $��1��6!   $��0��61   �� 5?   
   $��Tuesday��6   $��2��6"   $��0��62   �� 5@   
   $��	Wednesday��6   $��3��6$   $��0��64   �� 5A   
   $��Thursday��6   $��4��6#   $��0��63   �� 5B   
   $��Friday��6   $��5��6!   $��0��61   �� 5C   
   $��Saturday��6   $��6��6#   $��0��63   �� 5D   
   $��Sunday��6   $��7��6!   $��0��61   �� 5E   
   $��Monday��6   $��1��6!   $��5��61   �� 5F   
   $��Tuesday��6   $��2��6"   $��5��62   �� 5G   
   $��	Wednesday��6   $��3��6$   $��5��64   �� 5H   
   $��Thursday��6   $��4��6#   $��5��63   �� 5I   
   $��Friday��6   $��5��6!   $��5��61   �� 5J   
   $��Saturday��6   $��6��6#   $��5��63   �� 5K   
   $��Sunday��6   $��7��6!   $��5��61   �� 5L   
   $��0��67   $��1��6G   ��6   �� *WeekLabelsArray[0]+6G   �� 5M   
   $��0��67   $��2��6G   ��6   �� *WeekLabelsArray[1]+6G   �� 5N   
   $��0��67   $��3��6G   ��6   �� *WeekLabelsArray[2]+6G   �� 5O   
   $��0��67   $��4��6G   ��6   �� *WeekLabelsArray[3]+6G   �� 5P   
   $��8��67   $��1��6G   ��6   �� *WeekLabelsArray[0]+6G   �� 5Q   
   $��8��67   $��2��6G   ��6   �� *WeekLabelsArray[1]+6G   �� 5R   
   $��8��67   $��3��6G   ��6   �� *WeekLabelsArray[2]+6G   �� 5S   
   $��8��67   $��4��6G   ��6   �� *WeekLabelsArray[3]+6G   �� 5T   
   $��1��6   $��1��6%   .+�5U      �� -   5         ��Name$ Label1��5U      $��23��6J   $��10(�6V   $	��0.7q�6�   
���   ���6$   �� *DayLabelsArray[0]+��6d   �� *DayLabelBackgroundsArray[0]+6�   �� 5V      -   5         ��Name$ StackPanel1��5V       J� InputBindings 5W      d� 5X       �� CommandParameter$ 1��6P    d� MouseAction$ LeftDoubleClicke�6e    �� Command 6#   �� *EditEventCommandProperty+6e   5Z      �� 5[      -	   5        $��EmptySpace1��5[      $	��200��6'   
������� 5\      d� 5]      $ 1��6O   $ LeftDoubleClicke�6d    6#   �� *AddEventCommandProperty+6d   5_      5`      �� 5a   
   $��2��6   $��1��6%   .+�5b      �� -
   5        $ Label2��5b      $��23��6J   $��10(�6V   $	��0.7q�6�   
���   ���6$   �� *DayLabelsArray[1]+��6d   �� *DayLabelBackgroundsArray[1]+6�   �� 5c      -   5        $ StackPanel2��5c       5d      d� 5e      $ 2��6P   $ LeftDoubleClicke�6e    6#   �� *EditEventCommandProperty+6e   5g      �� 5h      -   5        $��EmptySpace2��5h      $	��200��6'   
������� 5i      d� 5j      $ 2��6O   $ LeftDoubleClicke�6d    6#   �� *AddEventCommandProperty+6d   5l      5m      �� 5n   
   $��3��6   $��1��6%   .+�5o      �� -   5        $ Label3��5o      $��23��6J   $��10(�6V   $	��0.7q�6�   
���   ���6$   �� *DayLabelsArray[2]+��6d   �� *DayLabelBackgroundsArray[2]+6�   �� 5p      -   5        $ StackPanel3��5p       5q      d� 5r      $ 3��6P   $ LeftDoubleClicke�6e    6#   �� *EditEventCommandProperty+6e   5t      �� 5u      -   5        $��EmptySpace3��5u      $	��200��6'   
������� 5v      d� 5w      $ 3��6O   $ LeftDoubleClicke�6d    6#   �� *AddEventCommandProperty+6d   5y      5z      �� 5{   
   $��4��6   $��1��6%   .+�5|      �� -   5        $ Label4��5|      $��23��6J   $��10(�6V   $	��0.7q�6�   
���   ���6$   �� *DayLabelsArray[3]+��6d   �� *DayLabelBackgroundsArray[3]+6�   �� 5}      -   5        $ StackPanel4��5}       5~      d� 5      $ 4��6P   $ LeftDoubleClicke�6e    6#   �� *EditEventCommandProperty+6e   5�      �� 5�      -   5        $��EmptySpace4��5�      $	��200��6'   
������� 5�      d� 5�      $ 4��6O   $ LeftDoubleClicke�6d    6#   �� *AddEventCommandProperty+6d   5�      5�      �� 5�   
   $��5��6   $��1��6%   .+�5�      �� -   5        $ Label5��5�      $��23��6J   $��10(�6V   $	��0.7q�6�   
���   ���6$   �� *DayLabelsArray[4]+��6d   �� *DayLabelBackgroundsArray[4]+6�   �� 5�      -   5        $ StackPanel5��5�       5�      d� 5�      $ 5��6P   $ LeftDoubleClicke�6e    6#   �� *EditEventCommandProperty+6e   5�      �� 5�      -   5        $��EmptySpace5��5�      $	��200��6'   
������� 5�      d� 5�      $ 5��6O   $ LeftDoubleClicke�6d    6#   �� *AddEventCommandProperty+6d   5�      5�      �� 5�   
   $��6��6   $��1��6%   .+�5�      �� -   5        $ Label6��5�      $��23��6J   $��10(�6V   $	��0.7q�6�   
���   ���6$   �� *DayLabelsArray[5]+��6d   �� *DayLabelBackgroundsArray[5]+6�   �� 5�      -   5        $ StackPanel6��5�       5�      d� 5�      $ 6��6P   $ LeftDoubleClicke�6e    6#   �� *EditEventCommandProperty+6e   5�      �� 5�      -   5        $��EmptySpace6��5�      $	��200��6'   
������� 5�      d� 5�      $ 6��6O   $ LeftDoubleClicke�6d    6#   �� *AddEventCommandProperty+6d   5�      5�      �� 5�   
   $��7��6   $��1��6%   .+�5�      �� -   5        $ Label7��5�      $��23��6J   $��10(�6V   $	��0.7q�6�   
���   ���6$   �� *DayLabelsArray[6]+��6d   �� *DayLabelBackgroundsArray[6]+6�   �� 5�      -   5        $ StackPanel7��5�       5�      d� 5�      $ 7��6P   $ LeftDoubleClicke�6e    6#   �� *EditEventCommandProperty+6e   5�      �� 5�      -   5        $��EmptySpace7��5�      $	��200��6'   
������� 5�      d� 5�      $ 7��6O   $ LeftDoubleClicke�6d    6#   �� *AddEventCommandProperty+6d   5�      5�      �� 5�   
   $��1��6   $��2��6%   .+�5�      �� -   5        $ Label8��5�      $��23��6J   $��10(�6V   $	��0.7q�6�   
���   ���6$   �� *DayLabelsArray[7]+��6d   �� *DayLabelBackgroundsArray[7]+6�   �� 5�      -   5        $ StackPanel8��5�       5�      d� 5�      $ 8��6P   $ LeftDoubleClicke�6e    6#   �� *EditEventCommandProperty+6e   5�      �� 5�      -   5        $��EmptySpace8��5�      $	��200��6'   
������� 5�      d� 5�      $ 8��6O   $ LeftDoubleClicke�6d    6#   �� *AddEventCommandProperty+6d   5�      5�      �� 5�   
   $��2��6   $��2��6%   .+�5�      �� -   5        $ Label9��5�      $��23��6J   $��10(�6V   $	��0.7q�6�   
���   ���6$   �� *DayLabelsArray[8]+��6d   �� *DayLabelBackgroundsArray[8]+6�   �� 5�      -    5        $ StackPanel9��5�       5�      d� 5�      $ 9��6P   $ LeftDoubleClicke�6e    6#   �� *EditEventCommandProperty+6e   5�      �� 5�      -!   5        $��EmptySpace9��5�      $	��200��6'   
������� 5�      d� 5�      $ 9��6O   $ LeftDoubleClicke�6d    6#   �� *AddEventCommandProperty+6d   5�      5�      �� 5�   
   $��3��6   $��2��6%   .+�5�      �� -"   5        $ Label10��5�      $��23��6K   $��10(�6W   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[9]+��6e   �� *DayLabelBackgroundsArray[9]+6�   �� 5�      -#   5        $ StackPanel10��5�       5�      d� 5�      $ 10��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   5�      �� 5�      -$   5        $��EmptySpace10��5�      $	��200��6(   
������� 5�      d� 5�      $ 10��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5�      5�      �� 5�   
   $��4��6   $��2��6%   .+�5�      �� -%   5        $ Label11��5�      $��23��6L   $��10(�6X   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[10]+��6f   �� *DayLabelBackgroundsArray[10]+6�   �� 5�      -&   5        $ StackPanel11��5�       5�      d� 5�      $ 11��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   5�      �� 5�      -'   5        $��EmptySpace11��5�      $	��200��6(   
������� 5�      d� 5�      $ 11��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5�      5�      �� 5�   
   $��5��6   $��2��6%   .+�5�      �� -(   5        $ Label12��5�      $��23��6L   $��10(�6X   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[11]+��6f   �� *DayLabelBackgroundsArray[11]+6�   �� 5�      -)   5        $ StackPanel12��5�       5�      d� 5�      $ 12��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   5�      �� 5�      -*   5        $��EmptySpace12��5�      $	��200��6(   
������� 5�      d� 5�      $ 12��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5�      5�      �� 5�   
   $��6��6   $��2��6%   .+�5�      �� -+   5        $ Label13��5�      $��23��6L   $��10(�6X   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[12]+��6f   �� *DayLabelBackgroundsArray[12]+6�   �� 5�      -,   5        $ StackPanel13��5�       5�      d� 5�      $ 13��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   5�      �� 5�      --   5        $��EmptySpace13��5�      $	��200��6(   
������� 5�      d� 5�      $ 13��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5�      5�      �� 5�   
   $��7��6   $��2��6%   .+�5�      �� -.   5        $ Label14��5�      $��23��6L   $��10(�6X   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[13]+��6f   �� *DayLabelBackgroundsArray[13]+6�   �� 5�      -/   5        $ StackPanel14��5�       5      d� 5     $ 14��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   5     �� 5     -0   5        $��EmptySpace14��5     $	��200��6(   
������� 5     d� 5     $ 14��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5     5	     �� 5
  
   $��1��6   $��3��6%   .+�5     �� -1   5        $ Label15��5     $��23��6L   $��10(�6X   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[14]+��6f   �� *DayLabelBackgroundsArray[14]+6�   �� 5     -2   5        $ StackPanel15��5      5     d� 5     $ 15��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   5     �� 5     -3   5        $��EmptySpace15��5     $	��200��6(   
������� 5     d� 5     $ 15��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5     5     �� 5  
   $��2��6   $��3��6%   .+�5     �� -4   5        $ Label16��5     $��23��6L   $��10(�6X   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[15]+��6f   �� *DayLabelBackgroundsArray[15]+6�   �� 5     -5   5        $ StackPanel16��5      5     d� 5     $ 16��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   5     �� 5     -6   5        $��EmptySpace16��5     $	��200��6(   
������� 5     d� 5      $ 16��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5"     5#     �� 5$  
   $��3��6   $��3��6%   .+�5%     �� -7   5        $ Label17��5%     $��23��6L   $��10(�6X   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[16]+��6f   �� *DayLabelBackgroundsArray[16]+6�   �� 5&     -8   5        $ StackPanel17��5&      5'     d� 5(     $ 17��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   5*     �� 5+     -9   5        $��EmptySpace17��5+     $	��200��6(   
������� 5,     d� 5-     $ 17��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5/     50     �� 51  
   $��4��6   $��3��6%   .+�52     �� -:   5        $ Label18��52     $��23��6L   $��10(�6X   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[17]+��6f   �� *DayLabelBackgroundsArray[17]+6�   �� 53     -;   5        $ StackPanel18��53      54     d� 55     $ 18��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   57     �� 58     -<   5        $��EmptySpace18��58     $	��200��6(   
������� 59     d� 5:     $ 18��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5<     5=     �� 5>  
   $��5��6   $��3��6%   .+�5?     �� -=   5        $ Label19��5?     $��23��6L   $��10(�6X   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[18]+��6f   �� *DayLabelBackgroundsArray[18]+6�   �� 5@     ->   5        $ StackPanel19��5@      5A     d� 5B     $ 19��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   5D     �� 5E     -?   5        $��EmptySpace19��5E     $	��200��6(   
������� 5F     d� 5G     $ 19��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5I     5J     �� 5K  
   $��6��6   $��3��6%   .+�5L     �� -@   5        $ Label20��5L     $��23��6L   $��10(�6X   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[19]+��6f   �� *DayLabelBackgroundsArray[19]+6�   �� 5M     -A   5        $ StackPanel20��5M      5N     d� 5O     $ 20��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   5Q     �� 5R     -B   5        $��EmptySpace20��5R     $	��200��6(   
������� 5S     d� 5T     $ 20��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5V     5W     �� 5X  
   $��7��6   $��3��6%   .+�5Y     �� -C   5        $ Label21��5Y     $��23��6L   $��10(�6X   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[20]+��6f   �� *DayLabelBackgroundsArray[20]+6�   �� 5Z     -D   5        $ StackPanel21��5Z      5[     d� 5\     $ 21��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   5^     �� 5_     -E   5        $��EmptySpace21��5_     $	��200��6(   
������� 5`     d� 5a     $ 21��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5c     5d     �� 5e  
   $��1��6   $��4��6%   .+�5f     �� -F   5        $ Label22��5f     $��23��6L   $��10(�6X   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[21]+��6f   �� *DayLabelBackgroundsArray[21]+6�   �� 5g     -G   5        $ StackPanel22��5g      5h     d� 5i     $ 22��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   5k     �� 5l     -H   5        $��EmptySpace22��5l     $	��200��6(   
������� 5m     d� 5n     $ 22��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5p     5q     �� 5r  
   $��2��6   $��4��6%   .+�5s     �� -I   5        $ Label23��5s     $��23��6L   $��10(�6X   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[22]+��6f   �� *DayLabelBackgroundsArray[22]+6�   �� 5t     -J   5        $ StackPanel23��5t      5u     d� 5v     $ 23��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   5x     �� 5y     -K   5        $��EmptySpace23��5y     $	��200��6(   
������� 5z     d� 5{     $ 23��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5}     5~     �� 5  
   $��3��6   $��4��6%   .+�5�     �� -L   5        $ Label24��5�     $��23��6L   $��10(�6X   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[23]+��6f   �� *DayLabelBackgroundsArray[23]+6�   �� 5�     -M   5        $ StackPanel24��5�      5�     d� 5�     $ 24��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   5�     �� 5�     -N   5        $��EmptySpace24��5�     $	��200��6(   
������� 5�     d� 5�     $ 24��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5�     5�     �� 5�  
   $��4��6   $��4��6%   .+�5�     �� -O   5        $ Label25��5�     $��23��6L   $��10(�6X   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[24]+��6f   �� *DayLabelBackgroundsArray[24]+6�   �� 5�     -P   5        $ StackPanel25��5�      5�     d� 5�     $ 25��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   5�     �� 5�     -Q   5        $��EmptySpace25��5�     $	��200��6(   
������� 5�     d� 5�     $ 25��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5�     5�     �� 5�  
   $��5��6   $��4��6%   .+�5�     �� -R   5        $ Label26��5�     $��23��6L   $��10(�6X   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[25]+��6f   �� *DayLabelBackgroundsArray[25]+6�   �� 5�     -S   5        $ StackPanel26��5�      5�     d� 5�     $ 26��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   5�     �� 5�     -T   5        $��EmptySpace26��5�     $	��200��6(   
������� 5�     d� 5�     $ 26��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5�     5�     �� 5�  
   $��6��6   $��4��6%   .+�5�     �� -U   5        $ Label27��5�     $��23��6L   $��10(�6X   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[26]+��6f   �� *DayLabelBackgroundsArray[26]+6�   �� 5�     -V   5        $ StackPanel27��5�      5�     d� 5�     $ 27��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   5�     �� 5�     -W   5        $��EmptySpace27��5�     $	��200��6(   
������� 5�     d� 5�     $ 27��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5�     5�     �� 5�  
   $��7��6   $��4��6%   .+�5�     �� -X   5        $ Label28��5�     $��23��6L   $��10(�6X   $	��0.7q�6�   
���   ���6%   �� *DayLabelsArray[27]+��6f   �� *DayLabelBackgroundsArray[27]+6�   �� 5�     -Y   5        $ StackPanel28��5�      5�     d� 5�     $ 28��6P   $ LeftDoubleClicke�6f    6#   �� *EditEventCommandProperty+6f   5�     �� 5�     -Z   5        $��EmptySpace28��5�     $	��200��6(   
������� 5�     d� 5�     $ 28��6O   $ LeftDoubleClicke�6e    6#   �� *AddEventCommandProperty+6e   5�     5�     5�     5�     