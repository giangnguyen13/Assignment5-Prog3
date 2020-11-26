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
        public MainWindow()
        {
            InitializeComponent();

            //Console.WriteLine("Hello world");
            try
            {
                ReadCsv(@"H:\Programming3-project\biostats.csv");
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
            }
            //Console.ReadKey();
        }

        static void ReadCsv(string fileLocation)
        {
            //// open the file "data.csv" which is a CSV file without headers
            //using (var csv = new CachedCsvReader(new StreamReader("data.csv"), false))
            //{
            //    csv.Columns.Add(new Column { Name = "PriceDate", Type = typeof(DateTime) });
            //    csv.Columns.Add(new Column { Name = "OpenPrice", Type = typeof(decimal) });
            //    csv.Columns.Add(new Column { Name = "HighPrice", Type = typeof(decimal) });
            //    csv.Columns.Add(new Column { Name = "LowPrice", Type = typeof(decimal) });
            //    csv.Columns.Add(new Column { Name = "ClosePrice", Type = typeof(decimal) });
            //    csv.Columns.Add(new Column { Name = "Volume", Type = typeof(int) });

            //    // Field headers will now be picked from the Columns collection
            //    myDataGrid.DataSource = csv;
            //}
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(fileLocation)), true))
            {
                csvTable.Load(csvReader);
            }
            //foreach (var column in csvTable.Columns) 
            //{
            //    string Column1 = column.ToString();
            //    Console.WriteLine(Column1);
            //}

            //foreach (var row in csvTable.Rows)
            //{
            //    foreach (var column in csvTable.Columns)
            //    {
            //        string Column1 = column.ToString();
            //        Console.Write(Column1 + ",");
            //    }
            //    Console.WriteLine("");
            //}

            for (int i = 0; i < 2/*csvTable.Rows.Count*/; i++)
            {
                string x = "";
                for (int j = 0; j < csvTable.Columns.Count; j++)
                {
                    x += csvTable.Rows[i][j].ToString() + ",";//Console.Write();
                }

                if (true)//negative row
                {
                    //remove 
                }
                //Console.WriteLine("");
                MessageBox.Show(x);
            }


            // Similarly we can access the rows of the .csv file as ,

            //string Row1 = csvTable.Rows[0][0].ToString();
            //Console.WriteLine(Column1);
            //Console.WriteLine(Row1);
        }
    }
}
