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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStartItemDecompiler_Click(object sender, EventArgs e)
        {
            Hide();
            frmMBItemDecompiler frmMBItemDecompiler = new frmMBItemDecompiler();
            frmMBItemDecompiler.ShowDialog();
            Show();
        }

        private void btnStartTrooperDecompiler_Click(object sender, EventArgs e)
        {
            Hide();
            frmMBTrooperDecompiler frmMBTrooperDecompiler = new frmMBTrooperDecompiler();
            frmMBTrooperDecompiler.ShowDialog();
            Show();
        }

        private void btnMBTextIDGenerator_Click(object sender, EventArgs e)
        {
            Hide();
            frmMBTextIDGenerator frmMBTextIDGenerator = new frmMBTextIDGenerator();
            frmMBTextIDGenerator.ShowDialog();
            Show();
        }
    }
}
