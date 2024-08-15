namespace PDFToText
{
    partial class OpenPFD
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
            this.selectFileLable = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // selectFileLable
            // 
            this.selectFileLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectFileLable.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFileLable.Location = new System.Drawing.Point(12, 175);
            this.selectFileLable.Name = "selectFileLable";
            this.selectFileLable.Size = new System.Drawing.Size(358, 100);
            this.selectFileLable.TabIndex = 0;
            this.selectFileLable.Text = "Plese drag and drop your pdf file or click for select your file.";
            this.selectFileLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectFileLable.Click += new System.EventHandler(this.selectFileLable_Click);
            // 
            // openFile
            // 
            this.openFile.Filter = "PDF files (*.pdf)|*.pdf";
            // 
            // OpenPFD
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.selectFileLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OpenPFD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenPFD";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.OpenPFD_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.OpenPFD_DragEnter);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.OpenFileDialog openFile;

        private System.Windows.Forms.Label selectFileLable;

        #endregion
    }
}