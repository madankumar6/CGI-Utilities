using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word_Extractor;
using Word_Extractor.Interfaces;
using Word_Extractor.Interfaces.Concrete;
using System.IO;

namespace CGI_Utilities.UI
{
    public partial class Word_Extractor : Form
    {
        string inputFileName = "";
        string inputFileNameWithPath = "";
        public int StartingPosition { get; set; }
        public int NoOfCharacters { get; set; }
        public string InputFileName { get; set; }
        public string extractedWords { get; set; }

        IWordExtractor wordExtractor = null;

        public Word_Extractor()
        {
            InitializeComponent();

            wordExtractor = new WordExtractor();
        }

        private void Word_Extractor_Load(object sender, EventArgs e)
        {
            //Configure Open File Dialog..
            ofdInputFile.Multiselect = false;
            ofdInputFile.Title = "Select the Input File to extract words...!";
        }

        private void btnInputFileBrowse_Click(object sender, EventArgs e)
        {
            
            DialogResult ofdInputFileDialogResult = ofdInputFile.ShowDialog();

            if (ofdInputFileDialogResult == System.Windows.Forms.DialogResult.OK)
            {
                inputFileName = ofdInputFile.FileName;
                lblInputFileName.Text = ofdInputFile.SafeFileName;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var fileContent = File.ReadAllBytes(inputFileName);
            extractedWords = wordExtractor.ProcessFile(fileContent, (int)nudStartingPosition.Value+1, (int)nudNoOfCharacters.Value, OutputFileType.Excel);
            MessageBox.Show("Completed the processing");
        }

        private void btnExportWords_Click(object sender, EventArgs e)
        {
            wordExtractor.ExportExtractedWords(OutputFileType.Excel);
            MessageBox.Show("Completed");
        }
    }
}
