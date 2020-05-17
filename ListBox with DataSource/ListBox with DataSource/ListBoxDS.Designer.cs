namespace ListBox_with_DataSource
{
    partial class ListBoxDS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBoxDS));
            this.lbAll = new System.Windows.Forms.ListBox();
            this.btnAddToRedTeam = new System.Windows.Forms.Button();
            this.lbRedTeam = new System.Windows.Forms.ListBox();
            this.lbBlueTeam = new System.Windows.Forms.ListBox();
            this.btnAddToBlueTeam = new System.Windows.Forms.Button();
            this.btnSaveRedXml = new System.Windows.Forms.Button();
            this.btnSaveBlueXml = new System.Windows.Forms.Button();
            this.nudTeamSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbSelectedTeam = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAll
            // 
            this.lbAll.FormattingEnabled = true;
            this.lbAll.Location = new System.Drawing.Point(12, 12);
            this.lbAll.Name = "lbAll";
            this.lbAll.Size = new System.Drawing.Size(776, 56);
            this.lbAll.TabIndex = 0;
            // 
            // btnAddToRedTeam
            // 
            this.btnAddToRedTeam.FlatAppearance.BorderSize = 0;
            this.btnAddToRedTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToRedTeam.Image = ((System.Drawing.Image)(resources.GetObject("btnAddToRedTeam.Image")));
            this.btnAddToRedTeam.Location = new System.Drawing.Point(169, 74);
            this.btnAddToRedTeam.Name = "btnAddToRedTeam";
            this.btnAddToRedTeam.Size = new System.Drawing.Size(40, 40);
            this.btnAddToRedTeam.TabIndex = 1;
            this.btnAddToRedTeam.UseVisualStyleBackColor = true;
            this.btnAddToRedTeam.Click += new System.EventHandler(this.btnAddToRedTeam_Click);
            // 
            // lbRedTeam
            // 
            this.lbRedTeam.FormattingEnabled = true;
            this.lbRedTeam.Location = new System.Drawing.Point(12, 120);
            this.lbRedTeam.Name = "lbRedTeam";
            this.lbRedTeam.Size = new System.Drawing.Size(350, 95);
            this.lbRedTeam.TabIndex = 2;
            // 
            // lbBlueTeam
            // 
            this.lbBlueTeam.FormattingEnabled = true;
            this.lbBlueTeam.Location = new System.Drawing.Point(438, 120);
            this.lbBlueTeam.Name = "lbBlueTeam";
            this.lbBlueTeam.Size = new System.Drawing.Size(350, 95);
            this.lbBlueTeam.TabIndex = 3;
            // 
            // btnAddToBlueTeam
            // 
            this.btnAddToBlueTeam.FlatAppearance.BorderSize = 0;
            this.btnAddToBlueTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToBlueTeam.Image = ((System.Drawing.Image)(resources.GetObject("btnAddToBlueTeam.Image")));
            this.btnAddToBlueTeam.Location = new System.Drawing.Point(599, 74);
            this.btnAddToBlueTeam.Name = "btnAddToBlueTeam";
            this.btnAddToBlueTeam.Size = new System.Drawing.Size(40, 40);
            this.btnAddToBlueTeam.TabIndex = 4;
            this.btnAddToBlueTeam.UseVisualStyleBackColor = true;
            this.btnAddToBlueTeam.Click += new System.EventHandler(this.btnAddToBlueTeam_Click);
            // 
            // btnSaveRedXml
            // 
            this.btnSaveRedXml.BackColor = System.Drawing.Color.Red;
            this.btnSaveRedXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRedXml.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRedXml.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveRedXml.Location = new System.Drawing.Point(13, 222);
            this.btnSaveRedXml.Name = "btnSaveRedXml";
            this.btnSaveRedXml.Size = new System.Drawing.Size(349, 31);
            this.btnSaveRedXml.TabIndex = 5;
            this.btnSaveRedXml.Text = "Save to XML (Red team)";
            this.btnSaveRedXml.UseVisualStyleBackColor = false;
            this.btnSaveRedXml.Click += new System.EventHandler(this.btnSaveRedXml_Click);
            // 
            // btnSaveBlueXml
            // 
            this.btnSaveBlueXml.BackColor = System.Drawing.Color.Blue;
            this.btnSaveBlueXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBlueXml.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBlueXml.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveBlueXml.Location = new System.Drawing.Point(438, 222);
            this.btnSaveBlueXml.Name = "btnSaveBlueXml";
            this.btnSaveBlueXml.Size = new System.Drawing.Size(350, 31);
            this.btnSaveBlueXml.TabIndex = 5;
            this.btnSaveBlueXml.Text = "Save to XML (Blue team)";
            this.btnSaveBlueXml.UseVisualStyleBackColor = false;
            this.btnSaveBlueXml.Click += new System.EventHandler(this.btnSaveRedXml_Click);
            // 
            // nudTeamSize
            // 
            this.nudTeamSize.Location = new System.Drawing.Point(298, 94);
            this.nudTeamSize.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTeamSize.Name = "nudTeamSize";
            this.nudTeamSize.Size = new System.Drawing.Size(201, 20);
            this.nudTeamSize.TabIndex = 6;
            this.nudTeamSize.ValueChanged += new System.EventHandler(this.nudTeamSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quantity units in teams";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(262, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 52);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select team";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(176, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Blue team";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Red team";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lbSelectedTeam
            // 
            this.lbSelectedTeam.FormattingEnabled = true;
            this.lbSelectedTeam.Location = new System.Drawing.Point(12, 330);
            this.lbSelectedTeam.Name = "lbSelectedTeam";
            this.lbSelectedTeam.Size = new System.Drawing.Size(776, 108);
            this.lbSelectedTeam.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ListBoxDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.lbSelectedTeam);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudTeamSize);
            this.Controls.Add(this.btnSaveBlueXml);
            this.Controls.Add(this.btnSaveRedXml);
            this.Controls.Add(this.btnAddToBlueTeam);
            this.Controls.Add(this.lbBlueTeam);
            this.Controls.Add(this.lbRedTeam);
            this.Controls.Add(this.btnAddToRedTeam);
            this.Controls.Add(this.lbAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListBoxDS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.ListBoxDS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAll;
        private System.Windows.Forms.Button btnAddToRedTeam;
        private System.Windows.Forms.ListBox lbRedTeam;
        private System.Windows.Forms.ListBox lbBlueTeam;
        private System.Windows.Forms.Button btnAddToBlueTeam;
        private System.Windows.Forms.Button btnSaveRedXml;
        private System.Windows.Forms.Button btnSaveBlueXml;
        private System.Windows.Forms.NumericUpDown nudTeamSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox lbSelectedTeam;
        private System.Windows.Forms.Timer timer1;
    }
}

