using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnloadimages_Click(object sender, EventArgs e)
        {


            imageList1.Images.Clear();
            listView1.Clear();
            oFD1.InitialDirectory = "C:\\";
            oFD1.Title = "Open an Image File";
            oFD1.Filter = "JPEGS|.jpg|GIFS|.gif";
            var ofdResults = oFD1.ShowDialog();
            if (ofdResults == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            try
            {
                int num_of_files = oFD1.FileName.Length;
                string[] aryFilePaths = new string[num_of_files];
                int counter = 0;
                foreach (string single_file in oFD1.FileNames)
                {
                    aryFilePaths[counter] = single_file;
                    imageList1.Images.Add(Image.FromFile(single_file));
                    counter++;
                    // MessageBox.Show(single_file);
                }
                listView1.LargeImageList = imageList1;
                for (int i = 0; i < counter; i++)
                {
                   }
                {

                }

                {
                }
                }
private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


