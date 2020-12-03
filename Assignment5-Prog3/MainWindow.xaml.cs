using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Assignment5_Prog3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<StockData> stockDatas;
        public MainWindow()
        {
            InitializeComponent();
        }

        /*
         * Get file location which file is placed same folder as solution
         * 
         * @param string fileName
         * 
         * @return string fileLocation
         */
        private string GetCsvFileLocation(string fileName)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string fileLocation = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\" + fileName;
            return fileLocation;
        }

        private async void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            progressBarSearchLoading.Visibility = Visibility.Visible;
            progressBarSearchLabel.Visibility = Visibility.Visible;

            await Task.Run(() => {
                Thread.Sleep(2000);
            });

            var query = from stock in stockDatas
                        where stock.Symbol == textBoxSearch.Text.ToString().ToUpper()
                        orderby stock.ReleaseDate ascending
                        select new { stock.Symbol,
                            stock.ReleaseDate,
                            stock.Open,
                            stock.High,
                            stock.Low,
                            stock.Close
                        };

            dataGridSearch.ItemsSource = query;
            dataGridSearch.Items.Refresh();

            progressBarSearchLoading.Visibility = Visibility.Hidden;
            progressBarSearchLabel.Visibility = Visibility.Hidden;
            MessageBox.Show($"Number of records found: {query.Count()}");
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            stockDatas = ReadCsvAPI.ReadDataFromCsv(GetCsvFileLocation("stockData.csv"));
            Thread.Sleep(2000);
            dataGridDisplay.ItemsSource = stockDatas;
            progressBarMainLabel.Visibility = Visibility.Hidden;
            progressBarMainLoading.Visibility = Visibility.Hidden;
        }
    }
}
