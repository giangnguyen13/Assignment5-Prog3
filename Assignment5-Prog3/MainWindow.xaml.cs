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

namespace Assignment5_Prog3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Patient> patients;
        public MainWindow()
        {
            InitializeComponent();

            patients = ReadCsvAPI.ReadDataFromCsv(GetCsvFileLocation("biostats.csv"));
            foreach (Patient p in patients)
            {
                MessageBox.Show(p.ToString());
            }
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
            string fileLocation = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\" + fileName;//@"\biostats.csv";
            return fileLocation;
        }
    }
}
