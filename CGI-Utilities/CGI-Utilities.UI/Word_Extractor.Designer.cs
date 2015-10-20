namespace CGI_Utilities.UI
{
    partial class Word_Extractor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wordExtarctorTitle = new System.Windows.Forms.Label();
            this.lblStartingPosition = new System.Windows.Forms.Label();
            this.lblNoOfCharacters = new System.Windows.Forms.Label();
            this.lblFileInput = new System.Windows.Forms.Label();
            this.nudStartingPosition = new System.Windows.Forms.NumericUpDown();
            this.nudNoOfCharacters = new System.Windows.Forms.NumericUpDown();
            this.btnInputFileBrowse = new System.Windows.Forms.Button();
            this.lblInputFileName = new System.Windows.Forms.Label();
            this.lblExportDocumentType = new System.Windows.Forms.Label();
            this.cbxExportDocumentType = new System.Windows.Forms.ComboBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.ofdInputFile = new System.Windows.Forms.OpenFileDialog();
            this.btnExportWords = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartingPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfCharacters)).BeginInit();
            this.SuspendLayout();
            // 
            // wordExtarctorTitle
            // 
            this.wordExtarctorTitle.AutoSize = true;
            this.wordExtarctorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordExtarctorTitle.Location = new System.Drawing.Point(145, 25);
            this.wordExtarctorTitle.Name = "wordExtarctorTitle";
            this.wordExtarctorTitle.Size = new System.Drawing.Size(156, 25);
            this.wordExtarctorTitle.TabIndex = 0;
            this.wordExtarctorTitle.Text = "Word Extarctor";
            // 
            // lblStartingPosition
            // 
            this.lblStartingPosition.AutoSize = true;
            this.lblStartingPosition.Location = new System.Drawing.Point(52, 111);
            this.lblStartingPosition.Name = "lblStartingPosition";
            this.lblStartingPosition.Size = new System.Drawing.Size(83, 13);
            this.lblStartingPosition.TabIndex = 1;
            this.lblStartingPosition.Text = "Starting Position";
            // 
            // lblNoOfCharacters
            // 
            this.lblNoOfCharacters.AutoSize = true;
            this.lblNoOfCharacters.Location = new System.Drawing.Point(52, 143);
            this.lblNoOfCharacters.Name = "lblNoOfCharacters";
            this.lblNoOfCharacters.Size = new System.Drawing.Size(90, 13);
            this.lblNoOfCharacters.TabIndex = 1;
            this.lblNoOfCharacters.Text = "No. of Characters";
            // 
            // lblFileInput
            // 
            this.lblFileInput.AutoSize = true;
            this.lblFileInput.Location = new System.Drawing.Point(52, 83);
            this.lblFileInput.Name = "lblFileInput";
            this.lblFileInput.Size = new System.Drawing.Size(23, 13);
            this.lblFileInput.TabIndex = 1;
            this.lblFileInput.Text = "File";
            // 
            // nudStartingPosition
            // 
            this.nudStartingPosition.Location = new System.Drawing.Point(173, 111);
            this.nudStartingPosition.Name = "nudStartingPosition";
            this.nudStartingPosition.Size = new System.Drawing.Size(120, 20);
            this.nudStartingPosition.TabIndex = 2;
            // 
            // nudNoOfCharacters
            // 
            this.nudNoOfCharacters.Location = new System.Drawing.Point(173, 143);
            this.nudNoOfCharacters.Name = "nudNoOfCharacters";
            this.nudNoOfCharacters.Size = new System.Drawing.Size(120, 20);
            this.nudNoOfCharacters.TabIndex = 3;
            // 
            // btnInputFileBrowse
            // 
            this.btnInputFileBrowse.Location = new System.Drawing.Point(307, 78);
            this.btnInputFileBrowse.Name = "btnInputFileBrowse";
            this.btnInputFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnInputFileBrowse.TabIndex = 4;
            this.btnInputFileBrowse.Text = "Browse";
            this.btnInputFileBrowse.UseVisualStyleBackColor = true;
            this.btnInputFileBrowse.Click += new System.EventHandler(this.btnInputFileBrowse_Click);
            // 
            // lblInputFileName
            // 
            this.lblInputFileName.AutoSize = true;
            this.lblInputFileName.Location = new System.Drawing.Point(170, 83);
            this.lblInputFileName.Name = "lblInputFileName";
            this.lblInputFileName.Size = new System.Drawing.Size(97, 13);
            this.lblInputFileName.TabIndex = 1;
            this.lblInputFileName.Text = "-- No File Chosen --";
            // 
            // lblExportDocumentType
            // 
            this.lblExportDocumentType.AutoSize = true;
            this.lblExportDocumentType.Location = new System.Drawing.Point(52, 183);
            this.lblExportDocumentType.Name = "lblExportDocumentType";
            this.lblExportDocumentType.Size = new System.Drawing.Size(114, 13);
            this.lblExportDocumentType.TabIndex = 5;
            this.lblExportDocumentType.Text = "Export document Type";
            // 
            // cbxExportDocumentType
            // 
            this.cbxExportDocumentType.FormattingEnabled = true;
            this.cbxExportDocumentType.Location = new System.Drawing.Point(172, 180);
            this.cbxExportDocumentType.Name = "cbxExportDocumentType";
            this.cbxExportDocumentType.Size = new System.Drawing.Size(121, 21);
            this.cbxExportDocumentType.TabIndex = 6;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(150, 234);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // ofdInputFile
            // 
            this.ofdInputFile.FileName = "openFileDialog1";
            // 
            // btnExportWords
            // 
            this.btnExportWords.Location = new System.Drawing.Point(231, 234);
            this.btnExportWords.Name = "btnExportWords";
            this.btnExportWords.Size = new System.Drawing.Size(75, 23);
            this.btnExportWords.TabIndex = 7;
            this.btnExportWords.Text = "Export";
            this.btnExportWords.UseVisualStyleBackColor = true;
            this.btnExportWords.Click += new System.EventHandler(this.btnExportWords_Click);
            // 
            // Word_Extractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 323);
            this.Controls.Add(this.btnExportWords);
            this.Controls.Add(this.cbxExportDocumentType);
            this.Controls.Add(this.lblExportDocumentType);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnInputFileBrowse);
            this.Controls.Add(this.nudNoOfCharacters);
            this.Controls.Add(this.nudStartingPosition);
            this.Controls.Add(this.lblNoOfCharacters);
            this.Controls.Add(this.lblInputFileName);
            this.Controls.Add(this.lblFileInput);
            this.Controls.Add(this.lblStartingPosition);
            this.Controls.Add(this.wordExtarctorTitle);
            this.Name = "Word_Extractor";
            this.Text = "Word_Extractor";
            this.Load += new System.EventHandler(this.Word_Extractor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStartingPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfCharacters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordExtarctorTitle;
        private System.Windows.Forms.Label lblStartingPosition;
        private System.Windows.Forms.Label lblNoOfCharacters;
        private System.Windows.Forms.Label lblFileInput;
        private System.Windows.Forms.NumericUpDown nudStartingPosition;
        private System.Windows.Forms.NumericUpDown nudNoOfCharacters;
        private System.Windows.Forms.Button btnInputFileBrowse;
        private System.Windows.Forms.Label lblInputFileName;
        private System.Windows.Forms.Label lblExportDocumentType;
        private System.Windows.Forms.ComboBox cbxExportDocumentType;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.OpenFileDialog ofdInputFile;
        private System.Windows.Forms.Button btnExportWords;

    }
}