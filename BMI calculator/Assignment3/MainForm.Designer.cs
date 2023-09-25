namespace Assignment3
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textInch = new System.Windows.Forms.TextBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.textCmFt = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.textMonth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioImperial = new System.Windows.Forms.RadioButton();
            this.radioMetric = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelCathegory = new System.Windows.Forms.Label();
            this.labelBMI = new System.Windows.Forms.Label();
            this.labelNormalWeight = new System.Windows.Forms.Label();
            this.labelNormalBMI = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelPaid = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonBMI = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textInch);
            this.groupBox1.Controls.Add(this.textWeight);
            this.groupBox1.Controls.Add(this.textCmFt);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BMI Calculator";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textInch
            // 
            this.textInch.Location = new System.Drawing.Point(205, 76);
            this.textInch.Name = "textInch";
            this.textInch.Size = new System.Drawing.Size(57, 23);
            this.textInch.TabIndex = 6;
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(130, 113);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(132, 23);
            this.textWeight.TabIndex = 5;
            // 
            // textCmFt
            // 
            this.textCmFt.Location = new System.Drawing.Point(130, 76);
            this.textCmFt.Name = "textCmFt";
            this.textCmFt.Size = new System.Drawing.Size(55, 23);
            this.textCmFt.TabIndex = 4;
            this.textCmFt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(88, 28);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(209, 23);
            this.textName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textYear);
            this.groupBox2.Controls.Add(this.textMonth);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(514, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saving plan";
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(153, 80);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(100, 23);
            this.textYear.TabIndex = 3;
            // 
            // textMonth
            // 
            this.textMonth.Location = new System.Drawing.Point(153, 32);
            this.textMonth.Name = "textMonth";
            this.textMonth.Size = new System.Drawing.Size(100, 23);
            this.textMonth.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Period (years)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Monthly deposit";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioImperial);
            this.groupBox3.Controls.Add(this.radioMetric);
            this.groupBox3.Location = new System.Drawing.Point(315, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Units";
            // 
            // radioImperial
            // 
            this.radioImperial.AutoSize = true;
            this.radioImperial.Location = new System.Drawing.Point(14, 50);
            this.radioImperial.Name = "radioImperial";
            this.radioImperial.Size = new System.Drawing.Size(108, 19);
            this.radioImperial.TabIndex = 1;
            this.radioImperial.TabStop = true;
            this.radioImperial.Text = "Imperial (ft, lbs)";
            this.radioImperial.UseVisualStyleBackColor = true;
            this.radioImperial.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioMetric
            // 
            this.radioMetric.AutoSize = true;
            this.radioMetric.Location = new System.Drawing.Point(14, 21);
            this.radioMetric.Name = "radioMetric";
            this.radioMetric.Size = new System.Drawing.Size(100, 19);
            this.radioMetric.TabIndex = 0;
            this.radioMetric.TabStop = true;
            this.radioMetric.Text = "Metric (m, kg)";
            this.radioMetric.UseVisualStyleBackColor = true;
            this.radioMetric.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelCathegory);
            this.groupBox4.Controls.Add(this.labelBMI);
            this.groupBox4.Controls.Add(this.labelNormalWeight);
            this.groupBox4.Controls.Add(this.labelNormalBMI);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(12, 260);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(369, 178);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BMI results";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // labelCathegory
            // 
            this.labelCathegory.AutoSize = true;
            this.labelCathegory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCathegory.Location = new System.Drawing.Point(162, 64);
            this.labelCathegory.Name = "labelCathegory";
            this.labelCathegory.Size = new System.Drawing.Size(63, 17);
            this.labelCathegory.TabIndex = 5;
            this.labelCathegory.Text = "                  ";
            this.labelCathegory.Click += new System.EventHandler(this.label13_Click);
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBMI.Location = new System.Drawing.Point(162, 34);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(63, 17);
            this.labelBMI.TabIndex = 4;
            this.labelBMI.Text = "                  ";
            this.labelBMI.Click += new System.EventHandler(this.label12_Click);
            // 
            // labelNormalWeight
            // 
            this.labelNormalWeight.AutoSize = true;
            this.labelNormalWeight.Location = new System.Drawing.Point(18, 151);
            this.labelNormalWeight.Name = "labelNormalWeight";
            this.labelNormalWeight.Size = new System.Drawing.Size(258, 15);
            this.labelNormalWeight.TabIndex = 3;
            this.labelNormalWeight.Text = "Normal weight should be between 50 and 68 kg";
            this.labelNormalWeight.Click += new System.EventHandler(this.label11_Click);
            // 
            // labelNormalBMI
            // 
            this.labelNormalBMI.AutoSize = true;
            this.labelNormalBMI.ForeColor = System.Drawing.Color.Green;
            this.labelNormalBMI.Location = new System.Drawing.Point(43, 110);
            this.labelNormalBMI.Name = "labelNormalBMI";
            this.labelNormalBMI.Size = new System.Drawing.Size(207, 15);
            this.labelNormalBMI.TabIndex = 2;
            this.labelNormalBMI.Text = "Normal BMI is between 18.50 and 24.9";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Weight cathegory";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "BMI";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelBalance);
            this.groupBox5.Controls.Add(this.labelPaid);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(514, 260);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(285, 178);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Future value";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBalance.Location = new System.Drawing.Point(153, 102);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(93, 17);
            this.labelBalance.TabIndex = 3;
            this.labelBalance.Text = "                            ";
            // 
            // labelPaid
            // 
            this.labelPaid.AutoSize = true;
            this.labelPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPaid.Location = new System.Drawing.Point(153, 64);
            this.labelPaid.Name = "labelPaid";
            this.labelPaid.Size = new System.Drawing.Size(93, 17);
            this.labelPaid.TabIndex = 2;
            this.labelPaid.Text = "                            ";
            this.labelPaid.Click += new System.EventHandler(this.labelPaid_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Final balance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ammount paid";
            // 
            // buttonBMI
            // 
            this.buttonBMI.Location = new System.Drawing.Point(76, 205);
            this.buttonBMI.Name = "buttonBMI";
            this.buttonBMI.Size = new System.Drawing.Size(121, 39);
            this.buttonBMI.TabIndex = 5;
            this.buttonBMI.Text = "Calculate BMI";
            this.buttonBMI.UseVisualStyleBackColor = true;
            this.buttonBMI.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Calculate savings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonBMI);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator <Razvan Petcu>";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private GroupBox groupBox3;
        private RadioButton radioImperial;
        private RadioButton radioMetric;
        private GroupBox groupBox4;
        private Label label5;
        private Label label4;
        private GroupBox groupBox5;
        private Label label9;
        private Label label8;
        private Button buttonBMI;
        private Button button2;
        private Label labelNormalWeight;
        private Label labelNormalBMI;
        private TextBox textWeight;
        private TextBox textCmFt;
        private TextBox textName;
        private TextBox textInch;
        private TextBox textYear;
        private TextBox textMonth;
        private Label labelCathegory;
        private Label labelBMI;
        private Label labelBalance;
        private Label labelPaid;
    }
}