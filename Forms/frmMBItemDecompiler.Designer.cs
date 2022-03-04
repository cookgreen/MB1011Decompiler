
namespace MBDecompiler
{
    partial class frmMBItemDecompiler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMBItemKindsText = new System.Windows.Forms.TextBox();
            this.btnBrowseItemKinds = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSOutputPYFile = new System.Windows.Forms.TextBox();
            this.btnBrowseMSOutputFile = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.chkGenerateIDFiles = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MountBlade Item Kinds:";
            // 
            // txtMBItemKindsText
            // 
            this.txtMBItemKindsText.Location = new System.Drawing.Point(210, 10);
            this.txtMBItemKindsText.Name = "txtMBItemKindsText";
            this.txtMBItemKindsText.ReadOnly = true;
            this.txtMBItemKindsText.Size = new System.Drawing.Size(471, 27);
            this.txtMBItemKindsText.TabIndex = 1;
            // 
            // btnBrowseItemKinds
            // 
            this.btnBrowseItemKinds.Location = new System.Drawing.Point(687, 9);
            this.btnBrowseItemKinds.Name = "btnBrowseItemKinds";
            this.btnBrowseItemKinds.Size = new System.Drawing.Size(94, 29);
            this.btnBrowseItemKinds.TabIndex = 2;
            this.btnBrowseItemKinds.Text = "Browse";
            this.btnBrowseItemKinds.UseVisualStyleBackColor = true;
            this.btnBrowseItemKinds.Click += new System.EventHandler(this.btnBrowseItemKinds_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 89);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(769, 326);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "MS Output File:";
            // 
            // txtMSOutputPYFile
            // 
            this.txtMSOutputPYFile.Location = new System.Drawing.Point(210, 48);
            this.txtMSOutputPYFile.Name = "txtMSOutputPYFile";
            this.txtMSOutputPYFile.ReadOnly = true;
            this.txtMSOutputPYFile.Size = new System.Drawing.Size(471, 27);
            this.txtMSOutputPYFile.TabIndex = 5;
            // 
            // btnBrowseMSOutputFile
            // 
            this.btnBrowseMSOutputFile.Location = new System.Drawing.Point(687, 47);
            this.btnBrowseMSOutputFile.Name = "btnBrowseMSOutputFile";
            this.btnBrowseMSOutputFile.Size = new System.Drawing.Size(94, 29);
            this.btnBrowseMSOutputFile.TabIndex = 6;
            this.btnBrowseMSOutputFile.Text = "Browse";
            this.btnBrowseMSOutputFile.UseVisualStyleBackColor = true;
            this.btnBrowseMSOutputFile.Click += new System.EventHandler(this.btnBrowseMSOutputFile_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(614, 426);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(167, 61);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chkGenerateIDFiles
            // 
            this.chkGenerateIDFiles.AutoSize = true;
            this.chkGenerateIDFiles.Checked = true;
            this.chkGenerateIDFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenerateIDFiles.Location = new System.Drawing.Point(13, 426);
            this.chkGenerateIDFiles.Name = "chkGenerateIDFiles";
            this.chkGenerateIDFiles.Size = new System.Drawing.Size(146, 24);
            this.chkGenerateIDFiles.TabIndex = 8;
            this.chkGenerateIDFiles.Text = "Generate ID File";
            this.chkGenerateIDFiles.UseVisualStyleBackColor = true;
            // 
            // frmMBItemDecompiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 499);
            this.Controls.Add(this.chkGenerateIDFiles);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBrowseMSOutputFile);
            this.Controls.Add(this.txtMSOutputPYFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnBrowseItemKinds);
            this.Controls.Add(this.txtMBItemKindsText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMBItemDecompiler";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MB 1.011 Item Decompiler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMBItemKindsText;
        private System.Windows.Forms.Button btnBrowseItemKinds;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMSOutputPYFile;
        private System.Windows.Forms.Button btnBrowseMSOutputFile;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkGenerateIDFiles;
    }
}

