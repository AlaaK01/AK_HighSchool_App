namespace AK_HighSchool_App.screen
{
    partial class Teachers
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comteachersstudents = new System.Windows.Forms.ComboBox();
            this.comteacherscourses = new System.Windows.Forms.ComboBox();
            this.CBteacher = new System.Windows.Forms.CheckBox();
            this.dgvteacher = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CBteacherscourses = new System.Windows.Forms.CheckBox();
            this.CBallteacher = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comeditteacher = new System.Windows.Forms.ComboBox();
            this.txteditteacher = new System.Windows.Forms.TextBox();
            this.comdeleteteacher = new System.Windows.Forms.ComboBox();
            this.comediteteacher2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteacher)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OldLace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(160, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 81);
            this.button1.TabIndex = 18;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1013, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 35);
            this.label3.TabIndex = 13;
            this.label3.Text = "Select Type of information:";
            // 
            // comteachersstudents
            // 
            this.comteachersstudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comteachersstudents.FormattingEnabled = true;
            this.comteachersstudents.Location = new System.Drawing.Point(256, 113);
            this.comteachersstudents.Name = "comteachersstudents";
            this.comteachersstudents.Size = new System.Drawing.Size(233, 33);
            this.comteachersstudents.TabIndex = 32;
            // 
            // comteacherscourses
            // 
            this.comteacherscourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comteacherscourses.FormattingEnabled = true;
            this.comteacherscourses.Location = new System.Drawing.Point(256, 68);
            this.comteacherscourses.Name = "comteacherscourses";
            this.comteacherscourses.Size = new System.Drawing.Size(233, 33);
            this.comteacherscourses.TabIndex = 29;
            // 
            // CBteacher
            // 
            this.CBteacher.AutoSize = true;
            this.CBteacher.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBteacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CBteacher.Location = new System.Drawing.Point(6, 118);
            this.CBteacher.Name = "CBteacher";
            this.CBteacher.Size = new System.Drawing.Size(205, 28);
            this.CBteacher.TabIndex = 26;
            this.CBteacher.Text = "Teacher\'s Students";
            this.CBteacher.UseVisualStyleBackColor = true;
            // 
            // dgvteacher
            // 
            this.dgvteacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvteacher.Location = new System.Drawing.Point(4, 171);
            this.dgvteacher.Name = "dgvteacher";
            this.dgvteacher.RowHeadersWidth = 62;
            this.dgvteacher.RowTemplate.Height = 33;
            this.dgvteacher.Size = new System.Drawing.Size(926, 463);
            this.dgvteacher.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(396, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 93);
            this.label1.TabIndex = 14;
            this.label1.Text = "T E C H E R S";
            // 
            // CBteacherscourses
            // 
            this.CBteacherscourses.AutoSize = true;
            this.CBteacherscourses.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBteacherscourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CBteacherscourses.Location = new System.Drawing.Point(6, 73);
            this.CBteacherscourses.Name = "CBteacherscourses";
            this.CBteacherscourses.Size = new System.Drawing.Size(197, 28);
            this.CBteacherscourses.TabIndex = 20;
            this.CBteacherscourses.Text = "Teacher\'s Cousese";
            this.CBteacherscourses.UseVisualStyleBackColor = true;
            // 
            // CBallteacher
            // 
            this.CBallteacher.AutoSize = true;
            this.CBallteacher.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBallteacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CBallteacher.Location = new System.Drawing.Point(6, 30);
            this.CBallteacher.Name = "CBallteacher";
            this.CBallteacher.Size = new System.Drawing.Size(154, 28);
            this.CBallteacher.TabIndex = 0;
            this.CBallteacher.Text = "All  Teachers";
            this.CBallteacher.UseVisualStyleBackColor = true;
            this.CBallteacher.CheckedChanged += new System.EventHandler(this.CBallteacher_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comteachersstudents);
            this.groupBox1.Controls.Add(this.comteacherscourses);
            this.groupBox1.Controls.Add(this.CBteacher);
            this.groupBox1.Controls.Add(this.CBteacherscourses);
            this.groupBox1.Controls.Add(this.CBallteacher);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Location = new System.Drawing.Point(969, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 290);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(-9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1517, 38);
            this.label2.TabIndex = 15;
            this.label2.Text = "===========================================================================";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OldLace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(63, 688);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 117);
            this.button2.TabIndex = 19;
            this.button2.Text = "Add A New Teacher";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comeditteacher
            // 
            this.comeditteacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comeditteacher.FormattingEnabled = true;
            this.comeditteacher.Location = new System.Drawing.Point(975, 624);
            this.comeditteacher.Name = "comeditteacher";
            this.comeditteacher.Size = new System.Drawing.Size(282, 33);
            this.comeditteacher.TabIndex = 30;
            this.comeditteacher.SelectedIndexChanged += new System.EventHandler(this.comeditteacher_SelectedIndexChanged);
            // 
            // txteditteacher
            // 
            this.txteditteacher.Location = new System.Drawing.Point(975, 688);
            this.txteditteacher.Multiline = true;
            this.txteditteacher.Name = "txteditteacher";
            this.txteditteacher.Size = new System.Drawing.Size(282, 42);
            this.txteditteacher.TabIndex = 31;
            // 
            // comdeleteteacher
            // 
            this.comdeleteteacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comdeleteteacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comdeleteteacher.FormattingEnabled = true;
            this.comdeleteteacher.Location = new System.Drawing.Point(529, 688);
            this.comdeleteteacher.Name = "comdeleteteacher";
            this.comdeleteteacher.Size = new System.Drawing.Size(332, 33);
            this.comdeleteteacher.TabIndex = 33;
            this.comdeleteteacher.SelectedIndexChanged += new System.EventHandler(this.comdeletteacher_SelectedIndexChanged);
            // 
            // comediteteacher2
            // 
            this.comediteteacher2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comediteteacher2.FormattingEnabled = true;
            this.comediteteacher2.Location = new System.Drawing.Point(975, 555);
            this.comediteteacher2.Name = "comediteteacher2";
            this.comediteteacher2.Size = new System.Drawing.Size(282, 33);
            this.comediteteacher2.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(1279, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 26);
            this.label6.TabIndex = 37;
            this.label6.Text = "Choose The Teacher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(1279, 631);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 26);
            this.label7.TabIndex = 38;
            this.label7.Text = "Select your Ghanging";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(1290, 704);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 26);
            this.label8.TabIndex = 39;
            this.label8.Text = "Write The Change";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1042, 751);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(390, 54);
            this.button4.TabIndex = 41;
            this.button4.Text = "Edit A Teacher";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(529, 751);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(332, 54);
            this.button5.TabIndex = 42;
            this.button5.Text = "Delete A  Teacher";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(34, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 63);
            this.button3.TabIndex = 43;
            this.button3.Text = "Back To Main Menu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1498, 849);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comediteteacher2);
            this.Controls.Add(this.comdeleteteacher);
            this.Controls.Add(this.txteditteacher);
            this.Controls.Add(this.comeditteacher);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvteacher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Teachers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvteacher)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label3;
        private ComboBox comteachersstudents;
        private ComboBox comteacherscourses;
        private CheckBox CBteacher;
        private DataGridView dgvteacher;
        private Label label1;
        private CheckBox CBteacherscourses;
        private CheckBox CBallteacher;
        private GroupBox groupBox1;
        private Label label2;
        private Button button2;
        private ComboBox comeditteacher;
        private TextBox txteditteacher;
        private ComboBox comdeleteteacher;
        private ComboBox comediteteacher2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button4;
        private Button button5;
        private Button button3;
    }
}