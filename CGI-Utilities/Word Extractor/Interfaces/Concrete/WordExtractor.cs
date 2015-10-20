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

        public string ProcessFile(System.IO.Stream inputStream, int startingPosition, int endingPosition, OutputFileType outputFileType)
        {
            throw new NotImplementedException();
        }

        public string ProcessFile(byte[] fileContent, int startingPosition, int endingPosition, OutputFileType outputFileType)
        {
            MemoryStream fileInputStream = new MemoryStream(fileContent);
            extractedWords = new StringBuilder();

            using (StreamReader reader = new StreamReader(fileInputStream))
            {
                string currentLine = "";

                while ((currentLine = reader.ReadLine()) != null)
                {
                    extractedWords.Append(currentLine.Substring(startingPosition, endingPosition - startingPosition) + "\r");
                }
            }

            return extractedWords.ToString();
        }

        public void ExportExtractedWords(OutputFileType outputFileType)
        {
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
                ExcelWorksheet extractedWordsWorksheet = package.Workbook.Worksheets["Extracted Words"];
                extractedWordsWorksheet.Name = "Extracted Words";

                do
                {
                    // Set the background colours
                    var cell = extractedWordsWorksheet.Cells[rowIndex, colIndex];
                    var fill = cell.Style.Fill;
                    fill.PatternType = ExcelFillStyle.Solid;
                    fill.BackgroundColor.SetColor(Color.AliceBlue);
                    colIndex++;
                }
                while (colIndex != 4);

            }
        }
    }
}
