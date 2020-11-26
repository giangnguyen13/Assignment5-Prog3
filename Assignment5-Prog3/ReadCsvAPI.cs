using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
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
        public static List<Patient> ReadDataFromCsv(string fileLocation)
        {
            List<Patient> patients = new List<Patient>();
            try
            {
                var csvTable = new DataTable();

                using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(fileLocation)), true))
                {
                    csvTable.Load(csvReader);
                }

                for (int i = 0; i < 3/*csvTable.Rows.Count*/; i++)
                {
                    Patient patient = new Patient();
                    patient.Name = csvTable.Rows[i][0].ToString();
                    patient.Gender = csvTable.Rows[i][1].ToString();
                    patient.Age = Convert.ToInt32(csvTable.Rows[i][2]);//.ToString()
                    patient.Height = Convert.ToDouble(csvTable.Rows[i][3]);
                    patient.Weight = Convert.ToDouble(csvTable.Rows[i][4]);

                    patients.Add(patient);
                    //for (int j = 0; j < csvTable.Columns.Count; j++)
                    //{
                    //    x += csvTable.Rows[i][j].ToString() + ",";//Console.Write();
                    //}
                }
                return patients;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return patients;
            }
        }
    }
}
