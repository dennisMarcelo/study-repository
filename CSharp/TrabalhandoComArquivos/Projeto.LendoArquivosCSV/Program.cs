using System;
using System.Linq;
using ClosedXML.Excel;
using System.Globalization;
using Projeto.LendoArquivosCSV.Entities;

namespace Projeto.LendoArquivosCSV
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> CSVPathFiles = GetPathCSVFiles();

            int quantityPlanilha = 1;
            foreach (string path in CSVPathFiles)
            {
                using(var xls = new XLWorkbook(path))
                {
                    var spreadsheet = xls.Worksheets.First(w => w.Name == "Plan1"); // Nome da planilha
                    var totalLines = spreadsheet.Rows().Count();

                    List<Sale> sales = new List<Sale>();

                    for (int l = 2; l <= totalLines; l++)
                    {
                        try
                        {
                            string product = spreadsheet.Cell($"A{l}").Value.ToString();
                            double price = double.Parse(spreadsheet.Cell($"B{l}").Value.ToString(), CultureInfo.InvariantCulture);
                            int qtt = int.Parse(spreadsheet.Cell($"C{l}").Value.ToString());

                            sales.Add(new Sale(product, price, qtt));
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }

                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Plan1");
                        worksheet.Cell("A1").Value = "Product";
                        worksheet.Cell("B1").Value = "Total Price";

                        int line = 2;
                        foreach (Sale sale in sales)
                        {
                            worksheet.Cell($"A{line}").Value = sale.Product;
                            worksheet.Cell($"B{line}").Value = sale.TotalPrice().ToString("N2", CultureInfo.InvariantCulture);
                            line ++;
                        }
                        workbook.SaveAs($@"C:\Users\denni\Documents\5-Aprendizado\CSharp\TrabalhandoComArquivos\Projeto.LendoArquivosCSV\XLSXFiles\out\summary{quantityPlanilha}.xlsx");
                    }

                }
                quantityPlanilha++;
            }

            Console.WriteLine("Completed");
        }

        private static List<string> GetPathCSVFiles()
        {
            //Console.Write("please, inform where is the .xlsx file: ");
            string path = @"C:\Users\denni\Documents\5-Aprendizado\CSharp\TrabalhandoComArquivos\Projeto.LendoArquivosCSV\XLSXFiles";
            
            List<string> pathFilesCSV = new List<string>(Directory.EnumerateFiles(path, "*.xlsx", SearchOption.TopDirectoryOnly));
            
            return pathFilesCSV;
        }
    }
}
