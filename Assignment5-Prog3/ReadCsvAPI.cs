using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment5_Prog3
{
    public static class ReadCsvAPI
    {
        /*
         * Get data from .csv file, then convert to list of Object
         * 
         * @param fileLocation  .csv file location
         * 
         * @return List<Object>
         * */
        //public static List<Patient> ReadDataFromCsv2(string fileLocation)
        //{
        //    List<Patient> patients = new List<Patient>();
        //    try
        //    {
        //        var csvTable = new DataTable();

        //        using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(fileLocation)), true))
        //        {
        //            csvTable.Load(csvReader);
        //        }

        //        for (int i = 0; i < 3/*csvTable.Rows.Count*/; i++)
        //        {
        //            Patient patient = new Patient();
        //            patient.Name = csvTable.Rows[i][0].ToString();
        //            patient.Gender = csvTable.Rows[i][1].ToString();
        //            patient.Age = Convert.ToInt32(csvTable.Rows[i][2]);//.ToString()
        //            patient.Height = Convert.ToDouble(csvTable.Rows[i][3]);
        //            patient.Weight = Convert.ToDouble(csvTable.Rows[i][4]);

        //            patients.Add(patient);
        //            //for (int j = 0; j < csvTable.Columns.Count; j++)
        //            //{
        //            //    x += csvTable.Rows[i][j].ToString() + ",";//Console.Write();
        //            //}
        //        }
        //        return patients;
        //    }
        //    catch (Exception exp)
        //    {
        //        Console.WriteLine(exp.Message);
        //        return patients;
        //    }
        //}

        public static List<StockData> ReadDataFromCsv(string fileLocation)
        {
            List<StockData> stockDatas = new List<StockData>();
            try
            {
                var csvTable = new DataTable();

                using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(fileLocation)), true))
                {
                    csvTable.Load(csvReader);
                }
                for (int i = 0; i < csvTable.Rows.Count; i++)
                {
                    StockData stockData = new StockData();
                    stockData.Symbol = csvTable.Rows[i][0].ToString();
                    stockData.ReleaseDate = DateTime.Parse(csvTable.Rows[i][1].ToString());
                    stockData.Open = ConvertToCurrencyFromString(csvTable.Rows[i][2].ToString());
                    stockData.High = ConvertToCurrencyFromString(csvTable.Rows[i][3].ToString());
                    stockData.Low = ConvertToCurrencyFromString(csvTable.Rows[i][4].ToString());
                    stockData.Close = ConvertToCurrencyFromString(csvTable.Rows[i][5].ToString());
                    //remove negative record
                    if (stockData.Open < 0 || stockData.High < 0 || stockData.Low < 0 || stockData.Close < 0)
                    {
                        continue;
                    }
                    stockDatas.Add(stockData);
                }

                // Replica the long task because > 3000 rows is not long enough
                Thread.Sleep(5000);

                return stockDatas;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return stockDatas;
            }
        }

        private static double ConvertToCurrencyFromString(string input)
        {
            string correctStringFormat = input.Replace("$", "");
            double currency = Convert.ToDouble(correctStringFormat);
            return currency;
        }
    }
}
