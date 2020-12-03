using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
using System.ComponentModel;

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

        private void Progress_Render(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;

            worker.RunWorkerAsync(); //starts progress tracker for the progress bar

            stockDatas = ReadCsvAPI.ReadDataFromCsv(GetCsvFileLocation("stockData.csv"));
            MessageBox.Show($"Count Row: {stockDatas.Count}");
            StockData a = stockDatas.FirstOrDefault();
            MessageBox.Show(a.ToString());
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i); //fake progress - needs to receive progress from ReadCSVAPI but its a static class
            }
            /*
            int progress;
            do
            {
                progress = Convert.ToInt32(ReadCsvAPI.progressValue * 100);
                (sender as BackgroundWorker).ReportProgress(progress);
            } while (progress <= 100)
            */
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loadingBar.Value = e.ProgressPercentage;
        }

    }
}
