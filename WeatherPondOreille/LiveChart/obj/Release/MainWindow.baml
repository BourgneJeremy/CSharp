   M S B A M L   `   `   `  ���� U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  D @LiveChart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LiveChart	LiveChart    LiveChart.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     )localclr-namespace:LiveChart       � WindowStartupLocation$  CenterScreen=� � Title$ Weather Pond Oreille��$	��400��$
��1000��.��� .+�� $��0,10,-0.4,-9.6q�.+�#   LiveCharts.Wpf.CartesianChart  -     Name$ Graphic��$y�Hidden=�&    LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Right=�$��10,10,309,10q�   Series �� *SeriesCollection+   AxisY    LiveCharts.Wpf.Axis     Title$ Barometric pressure��   LabelFormatter �� *
YFormatter+   AxisX   -   	  Name$	 GraphicLabels��$
 Date��
   Labels
 �� *Labels+�� -    ��Name$ TitleWindow��$��Weather Pond Oreille��$��20(�$
��Left=�$��
712,20,0,0q�$	��Top=� J� RenderTransformOrigin$ 0.266,-0.391&�$��40��$	��218���� -   $ 	DateStart��$��13(�$��Date start (mm/dd/yyyy)��$
��Left=�$��
690,80,0,0q�$	��Top=�$��30��$	��150���� -   $ 	TimeStart��$��Time start (hh)��$��13(�$
��Left=�$��
866,81,0,0q�$	��Top=�$��99��$ 0.179,0.625&��� -    ��Name$ DateStartTextBox��$��
01/01/2012��$
��Left=�$��23��$��690,115,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��150���� -   $ TimeStartTextBox��$��0��$
��Left=�$��23��$��866,115,0,0q�$
 Wrap=�$	��Top=�$��87���� -   $ DateEnd��$��13(�$��Date end (mm/dd/yyyy)��$
��Left=�$��690,155,0,0q�$	��Top=�$	��150���� -	   $ TimeEnd��$��Time end (hh)��$��13(�$
��Left=�$��866,155,0,0q�$	��Top=�$��99���� -
   $ DateEndTextBox��$
��Left=�$��
04/06/2015��$��23��$��690,187,0,0q�$
 Wrap=�$	��Top=�$	��150���� -   $ TimeEndTextBox��$
��Left=�$��23��$��23��$��866,187,0,0q�$
 Wrap=�$	��Top=�$��87���� -    ��Name$ DisplayGraphicBtn��$��Display graphic��$
��Left=�$��690,256,0,0q�$	��Top=�$	��263��$��24���� -   $
 Quit��$
��Quit��$
��Left=�$��855,320,0,0q�$	��Top=�$��98���� $5��/Choose a date between 01/01/2012 and 04/06/2015��
����p��$
��Bold"�$
��Left=�$��
676,54,0,0q�$	��Top=�$	��318���� -   $ 	TempLabel��
����+��$5��/This graphic wills show the barometric pressure��$
��Left=�$��25(�$��
55,140,0,0q�$	��Top=�$ -4.943,0.188&�$��50��$	��550��