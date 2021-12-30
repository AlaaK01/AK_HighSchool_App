namespace AK_HighSchool_App.screen
{
    partial class A
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvstudent = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comgpa = new System.Windows.Forms.ComboBox();
            this.comstudytype = new System.Windows.Forms.ComboBox();
            this.comstudycategory = new System.Windows.Forms.ComboBox();
            this.comage = new System.Windows.Forms.ComboBox();
            this.CBgpa = new System.Windows.Forms.CheckBox();
            this.CBstudytype = new System.Windows.Forms.CheckBox();
            this.CBstudycategory = new System.Windows.Forms.CheckBox();
            this.CBage = new System.Windows.Forms.CheckBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.CBlastname = new System.Windows.Forms.CheckBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.CBfirstname = new System.Windows.Forms.CheckBox();
            this.CBallstudents = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.deletestudent = new System.Windows.Forms.Button();
            this.comdeletestudent = new System.Windows.Forms.ComboBox();
            this.buteditstudent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comselectstudent = new System.Windows.Forms.ComboBox();
            this.txteditstudent = new System.Windows.Forms.TextBox();
            this.commodification = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(-1, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1517, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "===========================================================================";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(376, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 93);
            this.label1.TabIndex = 8;
            this.label1.Text = "S T U D E N T S";
            // 
            // dgvstudent
            // 
            this.dgvstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudent.Location = new System.Drawing.Point(12, 344);
            this.dgvstudent.Name = "dgvstudent";
            this.dgvstudent.RowHeadersWidth = 62;
            this.dgvstudent.RowTemplate.Height = 33;
            this.dgvstudent.Size = new System.Drawing.Size(1070, 472);
            this.dgvstudent.TabIndex = 10;
            this.dgvstudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstudent_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comgpa);
            this.groupBox1.Controls.Add(this.comstudytype);
            this.groupBox1.Controls.Add(this.comstudycategory);
            this.groupBox1.Controls.Add(this.comage);
            this.groupBox1.Controls.Add(this.CBgpa);
            this.groupBox1.Controls.Add(this.CBstudytype);
            this.groupBox1.Controls.Add(this.CBstudycategory);
            this.groupBox1.Controls.Add(this.CBage);
            this.groupBox1.Controls.Add(this.txtlastname);
            this.groupBox1.Controls.Add(this.CBlastname);
            this.groupBox1.Controls.Add(this.txtfirstname);
            this.groupBox1.Controls.Add(this.CBfirstname);
            this.groupBox1.Controls.Add(this.CBallstudents);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Location = new System.Drawing.Point(1113, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 535);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comgpa
            // 
            this.comgpa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comgpa.FormattingEnabled = true;
            this.comgpa.Location = new System.Drawing.Point(196, 470);
            this.comgpa.Name = "comgpa";
            this.comgpa.Size = new System.Drawing.Size(168, 33);
            this.comgpa.TabIndex = 31;
            // 
            // comstudytype
            // 
            this.comstudytype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comstudytype.FormattingEnabled = true;
            this.comstudytype.Location = new System.Drawing.Point(196, 389);
            this.comstudytype.Name = "comstudytype";
            this.comstudytype.Size = new System.Drawing.Size(168, 33);
            this.comstudytype.TabIndex = 30;
            this.comstudytype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // comstudycategory
            // 
            this.comstudycategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comstudycategory.FormattingEnabled = true;
            this.comstudycategory.Location = new System.Drawing.Point(196, 321);
            this.comstudycategory.Name = "comstudycategory";
            this.comstudycategory.Size = new System.Drawing.Size(168, 33);
            this.comstudycategory.TabIndex = 29;
            this.comstudycategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // comage
            // 
            this.comage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comage.FormattingEnabled = true;
            this.comage.Location = new System.Drawing.Point(196, 242);
            this.comage.Name = "comage";
            this.comage.Size = new System.Drawing.Size(168, 33);
            this.comage.TabIndex = 28;
            this.comage.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CBgpa
            // 
            this.CBgpa.AutoSize = true;
            this.CBgpa.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBgpa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CBgpa.Location = new System.Drawing.Point(6, 475);
            this.CBgpa.Name = "CBgpa";
            this.CBgpa.Size = new System.Drawing.Size(80, 28);
            this.CBgpa.TabIndex = 24;
            this.CBgpa.Text = "GPA";
            this.CBgpa.UseVisualStyleBackColor = true;
            // 
            // CBstudytype
            // 
            this.CBstudytype.AutoSize = true;
            this.CBstudytype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBstudytype.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBstudytype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CBstudytype.Location = new System.Drawing.Point(6, 394);
            this.CBstudytype.Name = "CBstudytype";
            this.CBstudytype.Size = new System.Drawing.Size(133, 28);
            this.CBstudytype.TabIndex = 22;
            this.CBstudytype.Text = "Study Type";
            this.CBstudytype.UseVisualStyleBackColor = true;
            // 
            // CBstudycategory
            // 
            this.CBstudycategory.AutoSize = true;
            this.CBstudycategory.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBstudycategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CBstudycategory.Location = new System.Drawing.Point(6, 326);
            this.CBstudycategory.Name = "CBstudycategory";
            this.CBstudycategory.Size = new System.Drawing.Size(177, 28);
            this.CBstudycategory.TabIndex = 20;
            this.CBstudycategory.Text = "Study Category";
            this.CBstudycategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CBstudycategory.UseVisualStyleBackColor = true;
            // 
            // CBage
            // 
            this.CBage.AutoSize = true;
            this.CBage.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CBage.Location = new System.Drawing.Point(6, 247);
            this.CBage.Name = "CBage";
            this.CBage.Size = new System.Drawing.Size(73, 28);
            this.CBage.TabIndex = 18;
            this.CBage.Text = "Age";
            this.CBage.UseVisualStyleBackColor = true;
            this.CBage.CheckedChanged += new System.EventHandler(this.CBage_CheckedChanged);
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(196, 165);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(168, 31);
            this.txtlastname.TabIndex = 17;
            this.txtlastname.TextChanged += new System.EventHandler(this.txtlastname_TextChanged);
            // 
            // CBlastname
            // 
            this.CBlastname.AutoSize = true;
            this.CBlastname.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBlastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CBlastname.Location = new System.Drawing.Point(6, 168);
            this.CBlastname.Name = "CBlastname";
            this.CBlastname.Size = new System.Drawing.Size(139, 28);
            this.CBlastname.TabIndex = 16;
            this.CBlastname.Text = "Last Name";
            this.CBlastname.UseVisualStyleBackColor = true;
            this.CBlastname.CheckedChanged += new System.EventHandler(this.CBlastname_CheckedChanged);
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(196, 93);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(168, 31);
            this.txtfirstname.TabIndex = 15;
            this.txtfirstname.TextChanged += new System.EventHandler(this.txtfirstname_TextChanged_1);
            // 
            // CBfirstname
            // 
            this.CBfirstname.AutoSize = true;
            this.CBfirstname.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBfirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CBfirstname.Location = new System.Drawing.Point(6, 96);
            this.CBfirstname.Name = "CBfirstname";
            this.CBfirstname.Size = new System.Drawing.Size(141, 28);
            this.CBfirstname.TabIndex = 14;
            this.CBfirstname.Text = "First Name";
            this.CBfirstname.UseVisualStyleBackColor = true;
            this.CBfirstname.CheckedChanged += new System.EventHandler(this.CBfirstname_CheckedChanged_1);
            // 
            // CBallstudents
            // 
            this.CBallstudents.AutoSize = true;
            this.CBallstudents.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBallstudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CBallstudents.Location = new System.Drawing.Point(6, 30);
            this.CBallstudents.Name = "CBallstudents";
            this.CBallstudents.Size = new System.Drawing.Size(155, 28);
            this.CBallstudents.TabIndex = 0;
            this.CBallstudents.Text = "All  Students";
            this.CBallstudents.UseVisualStyleBackColor = true;
            this.CBallstudents.CheckedChanged += new System.EventHandler(this.CBallstudents_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(1220, 763);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 53);
            this.button1.TabIndex = 12;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 48);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add A New Student";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // deletestudent
            // 
            this.deletestudent.BackColor = System.Drawing.Color.Transparent;
            this.deletestudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletestudent.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletestudent.ForeColor = System.Drawing.Color.White;
            this.deletestudent.Location = new System.Drawing.Point(12, 219);
            this.deletestudent.Name = "deletestudent";
            this.deletestudent.Size = new System.Drawing.Size(258, 50);
            this.deletestudent.TabIndex = 14;
            this.deletestudent.Text = "Delete A Student";
            this.deletestudent.UseVisualStyleBackColor = false;
            this.deletestudent.Click += new System.EventHandler(this.deletestudent_Click);
            // 
            // comdeletestudent
            // 
            this.comdeletestudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comdeletestudent.FormattingEnabled = true;
            this.comdeletestudent.Location = new System.Drawing.Point(12, 291);
            this.comdeletestudent.Name = "comdeletestudent";
            this.comdeletestudent.Size = new System.Drawing.Size(258, 33);
            this.comdeletestudent.TabIndex = 29;
            this.comdeletestudent.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_3);
            // 
            // buteditstudent
            // 
            this.buteditstudent.BackColor = System.Drawing.Color.OldLace;
            this.buteditstudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buteditstudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buteditstudent.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buteditstudent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buteditstudent.Location = new System.Drawing.Point(24, 30);
            this.buteditstudent.Name = "buteditstudent";
            this.buteditstudent.Size = new System.Drawing.Size(195, 148);
            this.buteditstudent.TabIndex = 32;
            this.buteditstudent.Text = "Edit A Sudent";
            this.buteditstudent.UseVisualStyleBackColor = false;
            this.buteditstudent.Click += new System.EventHandler(this.buteditstudent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.buteditstudent);
            this.groupBox2.Controls.Add(this.comselectstudent);
            this.groupBox2.Controls.Add(this.txteditstudent);
            this.groupBox2.Controls.Add(this.commodification);
            this.groupBox2.Location = new System.Drawing.Point(293, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 205);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(588, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 26);
            this.label8.TabIndex = 45;
            this.label8.Text = "Write your Edit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(588, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 26);
            this.label7.TabIndex = 44;
            this.label7.Text = "Modification Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(588, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 26);
            this.label9.TabIndex = 43;
            this.label9.Text = "Select a Student";
            // 
            // comselectstudent
            // 
            this.comselectstudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comselectstudent.FormattingEnabled = true;
            this.comselectstudent.Location = new System.Drawing.Point(272, 30);
            this.comselectstudent.Name = "comselectstudent";
            this.comselectstudent.Size = new System.Drawing.Size(282, 33);
            this.comselectstudent.TabIndex = 42;
            this.comselectstudent.SelectedIndexChanged += new System.EventHandler(this.comselectstudent_SelectedIndexChanged);
            // 
            // txteditstudent
            // 
            this.txteditstudent.Location = new System.Drawing.Point(272, 148);
            this.txteditstudent.Multiline = true;
            this.txteditstudent.Name = "txteditstudent";
            this.txteditstudent.Size = new System.Drawing.Size(282, 42);
            this.txteditstudent.TabIndex = 41;
            this.txteditstudent.TextChanged += new System.EventHandler(this.txteditstudent_TextChanged);
            // 
            // commodification
            // 
            this.commodification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commodification.FormattingEnabled = true;
            this.commodification.Location = new System.Drawing.Point(272, 93);
            this.commodification.Name = "commodification";
            this.commodification.Size = new System.Drawing.Size(282, 33);
            this.commodification.TabIndex = 40;
            this.commodification.SelectedIndexChanged += new System.EventHandler(this.commodification_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1197, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 40);
            this.label5.TabIndex = 34;
            this.label5.Text = "Find Students";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(26, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 63);
            this.button3.TabIndex = 35;
            this.button3.Text = "Back To Main Menu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1501, 833);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comdeletestudent);
            this.Controls.Add(this.deletestudent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvstudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "A";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label1;
        private DataGridView dgvstudent;
        private GroupBox groupBox1;
        private CheckBox CBallstudents;
        private Button button1;
        private CheckBox CBgpa;
        private CheckBox CBstudytype;
        private CheckBox CBstudycategory;
        private CheckBox CBage;
        private TextBox txtlastname;
        private CheckBox CBlastname;
        private TextBox txtfirstname;
        private CheckBox CBfirstname;
        private ComboBox comage;
        private ComboBox comstudycategory;
        private ComboBox comstudytype;
        private ComboBox comgpa;
        private Button button2;
        private Button deletestudent;
        private ComboBox comdeletestudent;
        private Button buteditstudent;
        private GroupBox groupBox2;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label9;
        private ComboBox comselectstudent;
        private TextBox txteditstudent;
        private ComboBox commodification;
        private Button button3;
    }
}