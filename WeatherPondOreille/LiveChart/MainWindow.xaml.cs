using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using WeatherPondClass.Controller;
using WeatherPondClass.Model;

namespace LiveChart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            SeriesCollection = new SeriesCollection();
        }

        private void DisplayGraphicBtn_Click(object sender, RoutedEventArgs e)
        {
            this.TempLabel.Visibility = Visibility.Hidden;

            string dateStart = this.DateStartTextBox.Text;
            string timeStart = this.TimeStartTextBox.Text;

            string dateEnd = this.DateEndTextBox.Text;
            string timeEnd = this.TimeEndTextBox.Text;

            DateAndTime dt = new DateAndTime();
            string startDateAndTime = dt.ReadUserDateAndTime(dateStart, timeStart);
            string endDateAndTime = dt.ReadUserDateAndTime(dateEnd, timeEnd);

            SeriesCollection.Clear();
            this.DisplayGraph(startDateAndTime, endDateAndTime);
        }

        public void DisplayGraph(string startDateAndTime, string endDateAndTime)
        {
            WeatherPondClass.Controller.Menu menu = new WeatherPondClass.Controller.Menu();
            ReadTextFiles rd = new ReadTextFiles();

            List<WeatherItem> weatherItems = menu.ProcessUserDateAndTime(startDateAndTime, endDateAndTime);
            weatherItems = menu.PointsToGraphic(weatherItems);

            ChartValues<double> weatherValues = new ChartValues<double>();
            Labels = new string[weatherItems.Count];

            for (int i = 0; i < weatherItems.Count; i++)
            {
                Labels[i] = weatherItems[i].Date;
                weatherValues.Add(weatherItems[i].BarometricPress);
            }

            LineSeries lineSeries = new LineSeries();
            lineSeries.Title = "Barometric pressure";
            lineSeries.Values = weatherValues;

            this.GraphicLabels.Labels = Labels;

            SeriesCollection.Add(lineSeries);
            YFormatter = value => $"{value} Pa";
            DataContext = this;

            this.Graphic.Visibility = Visibility.Visible;
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
