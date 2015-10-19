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
    public partial class CGI_Utilities_ParentUI : Form
    {
        public CGI_Utilities_ParentUI()
        {
            InitializeComponent();
        }

        private void wordExtractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Word_Extractor wordExtractorForm = new Word_Extractor();
            wordExtractorForm.MdiParent = this;
            wordExtractorForm.Show();
        }

    }
}
