   M S B A M L   `   `   `  ����U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5   	   D @LiveChart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LiveChart	LiveChart 5   	      LiveChart.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	   )localclr-namespace:LiveChart     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Weather Pond Oreille��5
   	   $	��400��5   	   $
��1000��5   	   .��5      � .+�5   
   � $��0,10,-0.4,-9.6q�6   .+�5      #   LiveCharts.Wpf.CartesianChart  -   5          Name$ Graphic��5   !   $y�Hidden=�5   !   &    LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Right=�5   !   $��10,10,309,10q�5   !      Series 5   !   �� *SeriesCollection+   AxisY 5         LiveCharts.Wpf.Axis     Title$ Barometric pressure��6      LabelFormatter 5      �� *
YFormatter+6G      AxisX 5        -   5        	  Name$	 GraphicLabels��5      $
 Date��5      
   Labels
 5      �� *Labels+6;   5      �� 5      -   5         ��Name$ TitleWindow��5      $��Weather Pond Oreille��5      $��20(�5       $
��Left=�5!      $��
712,20,0,0q�5"      $	��Top=�5#       J� RenderTransformOrigin$ 0.266,-0.391&�5$      $��40��5%      $	��218��5&      �� 5'      -   5        $ 	DateStart��5'      $��13(�5(      $��Date start (mm/dd/yyyy)��5)      $
��Left=�5*      $��
690,80,0,0q�5+      $	��Top=�5,      $��30��5-      $	��150��5.      �� 5/      -   5        $ 	TimeStart��5/      $��Time start (hh)��50      $��13(�51      $
��Left=�52      $��
866,81,0,0q�53      $	��Top=�54      $��99��55      $ 0.179,0.625&�56      �� 57      -   5         ��Name$ DateStartTextBox��57      $��
01/01/2012��58      $
��Left=�59      $��23��5:      $��690,115,0,0q�5;       �� TextWrapping$
 Wrap=�5<      $	��Top=�5=      $	��150��5>      �� 5?      -   5        $ TimeStartTextBox��5?      $��0��5@      $
��Left=�5A      $��23��5B      $��866,115,0,0q�5C      $
 Wrap=�5D      $	��Top=�5E      $��87��5F      �� 5G      -   5        $ DateEnd��5G      $��13(�5H      $��Date end (mm/dd/yyyy)��5I      $
��Left=�5J      $��690,155,0,0q�5K      $	��Top=�5L      $	��150��5M      �� 5N      -	   5        $ TimeEnd��5N      $��Time end (hh)��5O      $��13(�5P      $
��Left=�5Q      $��866,155,0,0q�5R      $	��Top=�5S      $��99��5T      �� 5U      -
   5        $ DateEndTextBox��5U      $
��Left=�5V      $��
04/06/2015��5W      $��23��5X      $��690,187,0,0q�5Y      $
 Wrap=�5Z      $	��Top=�5[      $	��150��5\      �� 5]      -   5        $ TimeEndTextBox��5]      $
��Left=�5^      $��23��5_      $��23��5`      $��866,187,0,0q�5a      $
 Wrap=�5b      $	��Top=�5c      $��87��5d      �� 5e      -   5         ��Name$ DisplayGraphicBtn��5e      $��Display graphic��5f      $
��Left=�5g      $��690,256,0,0q�5h      $	��Top=�5i      $	��263��5j      $��24��5k      5l      �� 5m      -   5        $
 Quit��5m      $
��Quit��5n      $
��Left=�5o      $��855,320,0,0q�5p      $	��Top=�5q      $��98��5r      5s      �� 5t      $5��/Choose a date between 01/01/2012 and 04/06/2015��6   
����p��$
��Bold"�5v      $
��Left=�5w      $��
676,54,0,0q�5x      $	��Top=�5y      $	��318��5z      5{      �� 5|   
   -   5        $ 	TempLabel��5|      
����+��$5��/This graphic wills show the barometric pressure��5~      $
��Left=�5      $��25(�5�      $��
55,140,0,0q�5�      $	��Top=�5�      $ -4.943,0.188&�5�      $��50��5�      $	��550��5�      5�      5�      