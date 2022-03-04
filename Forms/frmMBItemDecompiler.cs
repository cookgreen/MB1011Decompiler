using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBDecompiler
{
    public partial class frmMBItemDecompiler : Form
    {
        public frmMBItemDecompiler()
        {
            InitializeComponent();
        }

        private void btnBrowseItemKinds_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Mod Item Kinds Text File|item_kinds1.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtMBItemKindsText.Text = dialog.FileName;
            }
        }

        private void btnBrowseMSOutputFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Module System Items File|module_items.py";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtMSOutputPYFile.Text = dialog.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMBItemKindsText.Text) && !string.IsNullOrEmpty(txtMSOutputPYFile.Text))
            {
                MBItemReader reader = new MBItemReader(txtMBItemKindsText.Text);
                var output = reader.ToMSPythonFile(txtMSOutputPYFile.Text, chkGenerateIDFiles.Checked);
                richTextBox1.Text = output;
            }
        }
    }
}
