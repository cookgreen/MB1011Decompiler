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
    public partial class frmMBTrooperDecompiler : Form
    {
        private List<string> ItemIDFiles;

        public frmMBTrooperDecompiler()
        {
            InitializeComponent();
            ItemIDFiles = new List<string>();
        }

        private void btnBrowseTrooperText_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Trooper Text File|troops.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtMBTrooperText.Text = dialog.FileName;
            }
        }

        private void btnBrowseItemIDFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Decompiler Generated ID file|ID_Items.py";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtMBItemKindsID.Text = dialog.FileName;
            }
        }

        private void btnBrowseFactionIDFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Decompiler Generated ID file|ID_Factions.py";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtMBFactionIDFile.Text = dialog.FileName;
            }
        }

        private void browseSkillIDFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Decompiler Generated ID file|ID_Skills.py";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtMBSkillIDFile.Text = dialog.FileName;
            }
        }

        private void btnBrowseMSOutputFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Module System Trooper file|module_troopers.py";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtMSOutputPYFile.Text = dialog.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMBItemKindsID.Text) &&
                !string.IsNullOrEmpty(txtMBTrooperText.Text) &&
                !string.IsNullOrEmpty(txtMSOutputPYFile.Text)&&
                !string.IsNullOrEmpty(txtMBSkillIDFile.Text) &&
                !string.IsNullOrEmpty(txtMBFactionIDFile.Text))
            {
                //Read ID Files
                var itemIDFiles = readIDFiles(txtMBItemKindsID.Text);
                var factionIDFiles = readIDFiles(txtMBFactionIDFile.Text);
                var skillIDFiles = readIDFiles(txtMBSkillIDFile.Text);

                MBTrooperReader reader = new MBTrooperReader(txtMBTrooperText.Text, itemIDFiles, factionIDFiles, skillIDFiles);
                richTextBox1.Text = reader.ToMSPythonOutputFile(txtMSOutputPYFile.Text, chkIsGenerateIDFile.Checked);
            }
        }

        private Dictionary<int, string> readIDFiles(string idFile)
        {
            Dictionary<int, string> idFiles = new Dictionary<int, string>();

            using (StreamReader reader = new StreamReader(idFile))
            {
                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        string[] tokens = line.Split('=');
                        idFiles[int.Parse(tokens[1].Trim())] = tokens[0].Trim();
                    }
                }
            }

            return idFiles;
        }
    }
}
