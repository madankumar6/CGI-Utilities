namespace CGI_Utilities.UI
{
    partial class CGI_Utilities_ParentUI
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
            this.menuStripCGIUtilities = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordExtractorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCGIUtilities.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripCGIUtilities
            // 
            this.menuStripCGIUtilities.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.utilitiesToolStripMenuItem});
            this.menuStripCGIUtilities.Location = new System.Drawing.Point(0, 0);
            this.menuStripCGIUtilities.MdiWindowListItem = this.utilitiesToolStripMenuItem;
            this.menuStripCGIUtilities.Name = "menuStripCGIUtilities";
            this.menuStripCGIUtilities.Size = new System.Drawing.Size(292, 24);
            this.menuStripCGIUtilities.TabIndex = 1;
            this.menuStripCGIUtilities.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordExtractorToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // wordExtractorToolStripMenuItem
            // 
            this.wordExtractorToolStripMenuItem.Name = "wordExtractorToolStripMenuItem";
            this.wordExtractorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wordExtractorToolStripMenuItem.Text = "Word Extractor";
            this.wordExtractorToolStripMenuItem.Click += new System.EventHandler(this.wordExtractorToolStripMenuItem_Click);
            // 
            // CGI_Utilities_ParentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.menuStripCGIUtilities);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripCGIUtilities;
            this.Name = "CGI_Utilities_ParentUI";
            this.Text = "CGI-Utilities";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripCGIUtilities.ResumeLayout(false);
            this.menuStripCGIUtilities.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripCGIUtilities;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordExtractorToolStripMenuItem;
    }
}

