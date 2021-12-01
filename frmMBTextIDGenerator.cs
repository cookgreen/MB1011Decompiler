using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBDecompiler
{
    public partial class frmMBTextIDGenerator : Form
    {
        public frmMBTextIDGenerator()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Mount&Blade Text Data file|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtMBTextFile.Text = dialog.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMBTextFile.Text) &&
                File.Exists(txtMBTextFile.Text))
            {
                MBGenerateStats stats;
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "MS Python ID File|*.py";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string str = MBUtility.GenerateTextIDFile(txtMBTextFile.Text, dialog.FileName, out stats);
                    if(stats == MBGenerateStats.Error)
                    {
                        MessageBox.Show("Error!");
                    }
                    else if(stats == MBGenerateStats.NotSupported)
                    {
                        MessageBox.Show("Not supported yet!");
                    }
                    else if(stats == MBGenerateStats.Success)
                    {
                        richTextBox1.Text = str;
                        MessageBox.Show("Done!");
                    }
                }
            }
        }
    }
}
