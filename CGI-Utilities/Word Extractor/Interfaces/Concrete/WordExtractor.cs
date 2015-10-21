using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using OfficeOpenXml;
using OfficeOpenXml.Style;


namespace Word_Extractor.Interfaces.Concrete
{
    public class WordExtractor : IWordExtractor
    {
        public bool IsProcessCompleted { get; set; }
        public int StartingPosition { get; set; }
        public int NoOfCharacters { get; set; }
        public string InputFileName { get; set; }
        StringBuilder extractedWords = null;

        public void ReadFile(System.IO.Stream inputStream)
        {
            throw new NotImplementedException();
        }

        public string ExtractWordsFromFile(int startingPosition, int endingPosition)
        {
            throw new NotImplementedException();
        }

        public void WriteFile(OutputFileType outputFileType)
        {
            throw new NotImplementedException();
        }

        public string ProcessFile(System.IO.Stream inputStream, int startingPosition, int numberOfCharacters, OutputFileType outputFileType)
        {
            throw new NotImplementedException();
        }

        public string ProcessFile(byte[] fileContent, int startingPosition, int numberOfCharacters, OutputFileType outputFileType)
        {
            IsProcessCompleted = false;
            MemoryStream fileInputStream = new MemoryStream(fileContent);
            extractedWords = new StringBuilder();

            using (StreamReader reader = new StreamReader(fileInputStream))
            {
                string currentLine = "";

                while ((currentLine = reader.ReadLine()) != null)
                {
                    extractedWords.Append(currentLine.Substring(startingPosition, numberOfCharacters) + "\r");
                }
            }

            IsProcessCompleted = true;
            return extractedWords.ToString();
        }

        public void ExportExtractedWords(OutputFileType outputFileType)
        {
            if (!IsProcessCompleted || extractedWords == null)
                return;

            switch (outputFileType)
            {
                case OutputFileType.Text:
                    break;
                case OutputFileType.Excel:
                    ExportToExcel();
                    break;
                case OutputFileType.PDF:
                    break;
                default:
                    break;
            }
        }

        private void ExportToExcel()
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                int rowIndex = 1;
                int colIndex = 1;

                //Workbook Properties..
                package.Workbook.Properties.Author = "Madankumar.A";
                package.Workbook.Properties.Company = "CGI Information Systems & Management Consultants Pvt. Ltd.,";
                package.Workbook.Properties.Title = "Extracted Words";

                //Worksheet
                package.Workbook.Worksheets.Add("Extracted Words");
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Extracted Words"];
                worksheet.Name = "Extracted Words";

                do
                {
                    // Set the background colours
                    var cell = worksheet.Cells[rowIndex, colIndex];
                    var fill = cell.Style.Fill;
                    fill.PatternType = ExcelFillStyle.Solid;
                    fill.BackgroundColor.SetColor(Color.BlanchedAlmond);
                    colIndex++;
                }
                while (colIndex != 4);

                rowIndex = 2;
                colIndex = 1;

                worksheet.Cells[1, 1].Value = "Extracted Words";

                foreach (var item in extractedWords.ToString().Split(new char[] { '\r' }))
                {
                    worksheet.Cells[rowIndex++, colIndex].Value = item;
                }

                Byte[] bin = package.GetAsByteArray();
                File.WriteAllBytes(@"C:\Users\madankumar.angusamy\Desktop\Report.xlsx", bin);
            }
        }
    }
}
