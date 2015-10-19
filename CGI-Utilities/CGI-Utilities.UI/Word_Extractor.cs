using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CGI_Utilities.UI
{
    public partial class Word_Extractor : Form
    {
        string inputFileName = "";

        public Word_Extractor()
        {
            InitializeComponent();
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

        }
    }
}
