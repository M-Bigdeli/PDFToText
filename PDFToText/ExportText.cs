using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.util;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Bytescout.PDFRenderer;

namespace PDFToText
{
    public partial class ExportText : Form
    {
        public PdfReader PDF_READER;
        private RasterRenderer PDF_DOC;
        public ExportText(string PDF_PATH)
        {
            InitializeComponent();
            OpenPFD.ActiveForm.Hide();
            this.PDF_READER = new PdfReader(PDF_PATH);
            numberOfPages.Text = PDF_READER.NumberOfPages.ToString();
            selectedPageNumber.Maximum = PDF_READER.NumberOfPages;
            
            PDF_DOC = new RasterRenderer();
            // PDF_DOC.RegistrationName = "demo";
            // PDF_DOC.RegistrationKey = "demo";
            PDF_DOC.LoadDocumentFromFile(PDF_PATH);
            change_page_image();
        }

        private void change_page_image()
        {
            float page_height = PDF_READER.GetPageSize((int)selectedPageNumber.Value).Height;
            float page_width = PDF_READER.GetPageSize((int)selectedPageNumber.Value).Width;
            if (page_height > page_width)
            {
                selectedPage.Width = Convert.ToInt32(500 / (page_height / page_width));
                selectedPage.Left = Convert.ToInt32(this.Width / 2 - selectedPage.Width / 2);
            }
            else
            {
                selectedPage.Height = Convert.ToInt32(500 / (page_width / page_height));
                selectedPage.Top = Convert.ToInt32(this.Height / 2 - selectedPage.Height / 2);
            }

            selectedPage.BackgroundImage = null;
            selectedPage.BackgroundImage = PDF_DOC.GetImage((int)selectedPageNumber.Value - 1, 500);
        }

        private void selectedPageNumber_ValueChanged(object sender, EventArgs e)
        {
            change_page_image();
        }
    }
}