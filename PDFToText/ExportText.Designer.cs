using System.ComponentModel;

namespace PDFToText
{
    partial class ExportText
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.pageNumber = new System.Windows.Forms.Label();
            this.selectedPageNumber = new System.Windows.Forms.NumericUpDown();
            this.numberOfPages = new System.Windows.Forms.Label();
            this.selectedPage = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPageNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // pageNumber
            // 
            this.pageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pageNumber.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pageNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.pageNumber.Location = new System.Drawing.Point(12, 12);
            this.pageNumber.Name = "pageNumber";
            this.pageNumber.Size = new System.Drawing.Size(500, 50);
            this.pageNumber.TabIndex = 1;
            this.pageNumber.Text = "Page                of    .";
            this.pageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedPageNumber
            // 
            this.selectedPageNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectedPageNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.selectedPageNumber.Location = new System.Drawing.Point(226, 22);
            this.selectedPageNumber.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            this.selectedPageNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.selectedPageNumber.Name = "selectedPageNumber";
            this.selectedPageNumber.Size = new System.Drawing.Size(70, 33);
            this.selectedPageNumber.TabIndex = 2;
            this.selectedPageNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.selectedPageNumber.ValueChanged += new System.EventHandler(this.selectedPageNumber_ValueChanged);
            // 
            // numberOfPages
            // 
            this.numberOfPages.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numberOfPages.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.numberOfPages.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.numberOfPages.Location = new System.Drawing.Point(329, 12);
            this.numberOfPages.Name = "numberOfPages";
            this.numberOfPages.Size = new System.Drawing.Size(61, 50);
            this.numberOfPages.TabIndex = 3;
            this.numberOfPages.Text = "9999";
            this.numberOfPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedPage
            // 
            this.selectedPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectedPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectedPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectedPage.Location = new System.Drawing.Point(12, 80);
            this.selectedPage.Name = "selectedPage";
            this.selectedPage.Size = new System.Drawing.Size(500, 500);
            this.selectedPage.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(500, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ExportText
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(524, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectedPage);
            this.Controls.Add(this.numberOfPages);
            this.Controls.Add(this.selectedPageNumber);
            this.Controls.Add(this.pageNumber);
            this.MinimumSize = new System.Drawing.Size(468, 647);
            this.Name = "ExportText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportText";
            ((System.ComponentModel.ISupportInitialize)(this.selectedPageNumber)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Panel selectedPage;

        private System.Windows.Forms.Label numberOfPages;

        private System.Windows.Forms.NumericUpDown selectedPageNumber;

        private System.Windows.Forms.Label pageNumber;

        #endregion
    }
}