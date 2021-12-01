
namespace MBDecompiler
{
    partial class frmMBTrooperDecompiler
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBrowseMSOutputFile = new System.Windows.Forms.Button();
            this.txtMSOutputPYFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnBrowseItemIDFile = new System.Windows.Forms.Button();
            this.txtMBItemKindsID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseTrooperText = new System.Windows.Forms.Button();
            this.txtMBTrooperText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkIsGenerateIDFile = new System.Windows.Forms.CheckBox();
            this.btnBrowseFactionIDFiles = new System.Windows.Forms.Button();
            this.txtMBFactionIDFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.browseSkillIDFiles = new System.Windows.Forms.Button();
            this.txtMBSkillIDFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(612, 528);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(167, 61);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBrowseMSOutputFile
            // 
            this.btnBrowseMSOutputFile.Location = new System.Drawing.Point(685, 156);
            this.btnBrowseMSOutputFile.Name = "btnBrowseMSOutputFile";
            this.btnBrowseMSOutputFile.Size = new System.Drawing.Size(94, 29);
            this.btnBrowseMSOutputFile.TabIndex = 14;
            this.btnBrowseMSOutputFile.Text = "Browse";
            this.btnBrowseMSOutputFile.UseVisualStyleBackColor = true;
            this.btnBrowseMSOutputFile.Click += new System.EventHandler(this.btnBrowseMSOutputFile_Click);
            // 
            // txtMSOutputPYFile
            // 
            this.txtMSOutputPYFile.Location = new System.Drawing.Point(208, 157);
            this.txtMSOutputPYFile.Name = "txtMSOutputPYFile";
            this.txtMSOutputPYFile.ReadOnly = true;
            this.txtMSOutputPYFile.Size = new System.Drawing.Size(471, 27);
            this.txtMSOutputPYFile.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "MS Output File:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 191);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(769, 326);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // btnBrowseItemIDFile
            // 
            this.btnBrowseItemIDFile.Location = new System.Drawing.Point(685, 48);
            this.btnBrowseItemIDFile.Name = "btnBrowseItemIDFile";
            this.btnBrowseItemIDFile.Size = new System.Drawing.Size(94, 29);
            this.btnBrowseItemIDFile.TabIndex = 10;
            this.btnBrowseItemIDFile.Text = "Browse";
            this.btnBrowseItemIDFile.UseVisualStyleBackColor = true;
            this.btnBrowseItemIDFile.Click += new System.EventHandler(this.btnBrowseItemIDFile_Click);
            // 
            // txtMBItemKindsID
            // 
            this.txtMBItemKindsID.Location = new System.Drawing.Point(208, 49);
            this.txtMBItemKindsID.Name = "txtMBItemKindsID";
            this.txtMBItemKindsID.ReadOnly = true;
            this.txtMBItemKindsID.Size = new System.Drawing.Size(471, 27);
            this.txtMBItemKindsID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "MountBlade Item ID File:";
            // 
            // btnBrowseTrooperText
            // 
            this.btnBrowseTrooperText.Location = new System.Drawing.Point(685, 12);
            this.btnBrowseTrooperText.Name = "btnBrowseTrooperText";
            this.btnBrowseTrooperText.Size = new System.Drawing.Size(94, 29);
            this.btnBrowseTrooperText.TabIndex = 18;
            this.btnBrowseTrooperText.Text = "Browse";
            this.btnBrowseTrooperText.UseVisualStyleBackColor = true;
            this.btnBrowseTrooperText.Click += new System.EventHandler(this.btnBrowseTrooperText_Click);
            // 
            // txtMBTrooperText
            // 
            this.txtMBTrooperText.Location = new System.Drawing.Point(208, 13);
            this.txtMBTrooperText.Name = "txtMBTrooperText";
            this.txtMBTrooperText.ReadOnly = true;
            this.txtMBTrooperText.Size = new System.Drawing.Size(471, 27);
            this.txtMBTrooperText.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "MountBlade Troops:";
            // 
            // chkIsGenerateIDFile
            // 
            this.chkIsGenerateIDFile.AutoSize = true;
            this.chkIsGenerateIDFile.Checked = true;
            this.chkIsGenerateIDFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsGenerateIDFile.Location = new System.Drawing.Point(12, 528);
            this.chkIsGenerateIDFile.Name = "chkIsGenerateIDFile";
            this.chkIsGenerateIDFile.Size = new System.Drawing.Size(146, 24);
            this.chkIsGenerateIDFile.TabIndex = 19;
            this.chkIsGenerateIDFile.Text = "Generate ID File";
            this.chkIsGenerateIDFile.UseVisualStyleBackColor = true;
            // 
            // btnBrowseFactionIDFiles
            // 
            this.btnBrowseFactionIDFiles.Location = new System.Drawing.Point(685, 87);
            this.btnBrowseFactionIDFiles.Name = "btnBrowseFactionIDFiles";
            this.btnBrowseFactionIDFiles.Size = new System.Drawing.Size(94, 29);
            this.btnBrowseFactionIDFiles.TabIndex = 22;
            this.btnBrowseFactionIDFiles.Text = "Browse";
            this.btnBrowseFactionIDFiles.UseVisualStyleBackColor = true;
            this.btnBrowseFactionIDFiles.Click += new System.EventHandler(this.btnBrowseFactionIDFiles_Click);
            // 
            // txtMBFactionIDFile
            // 
            this.txtMBFactionIDFile.Location = new System.Drawing.Point(208, 88);
            this.txtMBFactionIDFile.Name = "txtMBFactionIDFile";
            this.txtMBFactionIDFile.ReadOnly = true;
            this.txtMBFactionIDFile.Size = new System.Drawing.Size(471, 27);
            this.txtMBFactionIDFile.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "MountBlade Faction ID File:";
            // 
            // browseSkillIDFiles
            // 
            this.browseSkillIDFiles.Location = new System.Drawing.Point(685, 123);
            this.browseSkillIDFiles.Name = "browseSkillIDFiles";
            this.browseSkillIDFiles.Size = new System.Drawing.Size(94, 29);
            this.browseSkillIDFiles.TabIndex = 25;
            this.browseSkillIDFiles.Text = "Browse";
            this.browseSkillIDFiles.UseVisualStyleBackColor = true;
            this.browseSkillIDFiles.Click += new System.EventHandler(this.browseSkillIDFiles_Click);
            // 
            // txtMBSkillIDFile
            // 
            this.txtMBSkillIDFile.Location = new System.Drawing.Point(208, 124);
            this.txtMBSkillIDFile.Name = "txtMBSkillIDFile";
            this.txtMBSkillIDFile.ReadOnly = true;
            this.txtMBSkillIDFile.Size = new System.Drawing.Size(471, 27);
            this.txtMBSkillIDFile.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "MountBlade Skill ID File:";
            // 
            // frmMBTrooperDecompiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.browseSkillIDFiles);
            this.Controls.Add(this.txtMBSkillIDFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBrowseFactionIDFiles);
            this.Controls.Add(this.txtMBFactionIDFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkIsGenerateIDFile);
            this.Controls.Add(this.btnBrowseTrooperText);
            this.Controls.Add(this.txtMBTrooperText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBrowseMSOutputFile);
            this.Controls.Add(this.txtMSOutputPYFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnBrowseItemIDFile);
            this.Controls.Add(this.txtMBItemKindsID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMBTrooperDecompiler";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MB 1.011 Trooper Decompiler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBrowseMSOutputFile;
        private System.Windows.Forms.TextBox txtMSOutputPYFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnBrowseItemIDFile;
        private System.Windows.Forms.TextBox txtMBItemKindsID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseTrooperText;
        private System.Windows.Forms.TextBox txtMBTrooperText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkIsGenerateIDFile;
        private System.Windows.Forms.Button btnBrowseFactionIDFiles;
        private System.Windows.Forms.TextBox txtMBFactionIDFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button browseSkillIDFiles;
        private System.Windows.Forms.TextBox txtMBSkillIDFile;
        private System.Windows.Forms.Label label5;
    }
}