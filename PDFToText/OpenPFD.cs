using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFToText
{
    public partial class OpenPFD : Form
    {
        public OpenPFD()
        {
            InitializeComponent();
        }

        private void OpenPFD_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 1)
            {
                Console.WriteLine(files[0]);
            }
        }

        private void OpenPFD_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Link;
        }

        private void selectFileLable_Click(object sender, EventArgs e)
        {
            openFile.DefaultExt = ".neurometer";
            openFile.ShowDialog();
            Console.WriteLine(openFile.FileName);
        }
    }
}