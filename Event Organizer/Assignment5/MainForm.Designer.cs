namespace Assignment5
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
            this.groupBoxNewEvent = new System.Windows.Forms.GroupBox();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonCreateEvent = new System.Windows.Forms.Button();
            this.labelFee = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelEventTitle = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.groupBoxEconomy = new System.Windows.Forms.GroupBox();
            this.labelSurplusOut = new System.Windows.Forms.Label();
            this.labelFeeOut = new System.Windows.Forms.Label();
            this.labelCostOut = new System.Windows.Forms.Label();
            this.labelSurplus = new System.Windows.Forms.Label();
            this.labelFee2 = new System.Windows.Forms.Label();
            this.labelCost2 = new System.Windows.Forms.Label();
            this.labelParticipantsOut = new System.Windows.Forms.Label();
            this.labelParticipants2 = new System.Windows.Forms.Label();
            this.listBoxParticipants = new System.Windows.Forms.ListBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxNewEvent.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxEconomy.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNewEvent
            // 
            this.groupBoxNewEvent.Controls.Add(this.textBoxFee);
            this.groupBoxNewEvent.Controls.Add(this.textBoxCost);
            this.groupBoxNewEvent.Controls.Add(this.textBoxTitle);
            this.groupBoxNewEvent.Controls.Add(this.buttonCreateEvent);
            this.groupBoxNewEvent.Controls.Add(this.labelFee);
            this.groupBoxNewEvent.Controls.Add(this.labelCost);
            this.groupBoxNewEvent.Controls.Add(this.labelEventTitle);
            this.groupBoxNewEvent.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNewEvent.Name = "groupBoxNewEvent";
            this.groupBoxNewEvent.Size = new System.Drawing.Size(258, 175);
            this.groupBoxNewEvent.TabIndex = 0;
            this.groupBoxNewEvent.TabStop = false;
            this.groupBoxNewEvent.Text = "NewEvent";
            this.groupBoxNewEvent.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxFee
            // 
            this.textBoxFee.Location = new System.Drawing.Point(133, 91);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.Size = new System.Drawing.Size(100, 23);
            this.textBoxFee.TabIndex = 6;
            this.textBoxFee.TextChanged += new System.EventHandler(this.textBoxFee_TextChanged);
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(133, 57);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 23);
            this.textBoxCost.TabIndex = 5;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(88, 28);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(164, 23);
            this.textBoxTitle.TabIndex = 4;
            // 
            // buttonCreateEvent
            // 
            this.buttonCreateEvent.Location = new System.Drawing.Point(72, 136);
            this.buttonCreateEvent.Name = "buttonCreateEvent";
            this.buttonCreateEvent.Size = new System.Drawing.Size(91, 23);
            this.buttonCreateEvent.TabIndex = 3;
            this.buttonCreateEvent.Text = "Create Event";
            this.buttonCreateEvent.UseVisualStyleBackColor = true;
            this.buttonCreateEvent.Click += new System.EventHandler(this.buttonCreateEvent_Click);
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Location = new System.Drawing.Point(16, 94);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(105, 15);
            this.labelFee.TabIndex = 2;
            this.labelFee.Text = "Fee Per Participant";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(16, 63);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(111, 15);
            this.labelCost.TabIndex = 1;
            this.labelCost.Text = "Cost Per Participant";
            // 
            // labelEventTitle
            // 
            this.labelEventTitle.AutoSize = true;
            this.labelEventTitle.Location = new System.Drawing.Point(16, 31);
            this.labelEventTitle.Name = "labelEventTitle";
            this.labelEventTitle.Size = new System.Drawing.Size(61, 15);
            this.labelEventTitle.TabIndex = 0;
            this.labelEventTitle.Text = "Event Title";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.comboBoxCountry);
            this.groupBoxAdd.Controls.Add(this.textBoxZip);
            this.groupBoxAdd.Controls.Add(this.textBoxCity);
            this.groupBoxAdd.Controls.Add(this.textBoxStreet);
            this.groupBoxAdd.Controls.Add(this.textBoxLastName);
            this.groupBoxAdd.Controls.Add(this.textBoxFirstName);
            this.groupBoxAdd.Controls.Add(this.buttonAdd);
            this.groupBoxAdd.Controls.Add(this.labelCountry);
            this.groupBoxAdd.Controls.Add(this.labelZipCode);
            this.groupBoxAdd.Controls.Add(this.labelCity);
            this.groupBoxAdd.Controls.Add(this.labelStreet);
            this.groupBoxAdd.Controls.Add(this.labelLastName);
            this.groupBoxAdd.Controls.Add(this.labelFirstName);
            this.groupBoxAdd.Location = new System.Drawing.Point(12, 193);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(258, 336);
            this.groupBoxAdd.TabIndex = 1;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Add Participants";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(106, 230);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(103, 23);
            this.comboBoxCountry.TabIndex = 12;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // textBoxZip
            // 
            this.textBoxZip.Location = new System.Drawing.Point(109, 188);
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(100, 23);
            this.textBoxZip.TabIndex = 11;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(109, 154);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 23);
            this.textBoxCity.TabIndex = 10;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(109, 116);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(100, 23);
            this.textBoxStreet.TabIndex = 9;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(109, 80);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 23);
            this.textBoxLastName.TabIndex = 8;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(109, 44);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 23);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(88, 298);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(16, 233);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(50, 15);
            this.labelCountry.TabIndex = 5;
            this.labelCountry.Text = "Country";
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(16, 191);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(55, 15);
            this.labelZipCode.TabIndex = 4;
            this.labelZipCode.Text = "Zip Code";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(16, 157);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(28, 15);
            this.labelCity.TabIndex = 3;
            this.labelCity.Text = "City";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(16, 119);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(37, 15);
            this.labelStreet.TabIndex = 2;
            this.labelStreet.Text = "Street";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(16, 83);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(63, 15);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(16, 47);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(64, 15);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            this.labelFirstName.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBoxEconomy
            // 
            this.groupBoxEconomy.Controls.Add(this.labelSurplusOut);
            this.groupBoxEconomy.Controls.Add(this.labelFeeOut);
            this.groupBoxEconomy.Controls.Add(this.labelCostOut);
            this.groupBoxEconomy.Controls.Add(this.labelSurplus);
            this.groupBoxEconomy.Controls.Add(this.labelFee2);
            this.groupBoxEconomy.Controls.Add(this.labelCost2);
            this.groupBoxEconomy.Controls.Add(this.labelParticipantsOut);
            this.groupBoxEconomy.Controls.Add(this.labelParticipants2);
            this.groupBoxEconomy.Location = new System.Drawing.Point(449, 350);
            this.groupBoxEconomy.Name = "groupBoxEconomy";
            this.groupBoxEconomy.Size = new System.Drawing.Size(281, 179);
            this.groupBoxEconomy.TabIndex = 2;
            this.groupBoxEconomy.TabStop = false;
            this.groupBoxEconomy.Text = "Event economy";
            // 
            // labelSurplusOut
            // 
            this.labelSurplusOut.AutoSize = true;
            this.labelSurplusOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSurplusOut.Location = new System.Drawing.Point(187, 149);
            this.labelSurplusOut.Name = "labelSurplusOut";
            this.labelSurplusOut.Size = new System.Drawing.Size(18, 17);
            this.labelSurplusOut.TabIndex = 7;
            this.labelSurplusOut.Text = "   ";
            // 
            // labelFeeOut
            // 
            this.labelFeeOut.AutoSize = true;
            this.labelFeeOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFeeOut.Location = new System.Drawing.Point(187, 110);
            this.labelFeeOut.Name = "labelFeeOut";
            this.labelFeeOut.Size = new System.Drawing.Size(18, 17);
            this.labelFeeOut.TabIndex = 6;
            this.labelFeeOut.Text = "   ";
            // 
            // labelCostOut
            // 
            this.labelCostOut.AutoSize = true;
            this.labelCostOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCostOut.Location = new System.Drawing.Point(187, 73);
            this.labelCostOut.Name = "labelCostOut";
            this.labelCostOut.Size = new System.Drawing.Size(18, 17);
            this.labelCostOut.TabIndex = 5;
            this.labelCostOut.Text = "   ";
            // 
            // labelSurplus
            // 
            this.labelSurplus.AutoSize = true;
            this.labelSurplus.Location = new System.Drawing.Point(31, 145);
            this.labelSurplus.Name = "labelSurplus";
            this.labelSurplus.Size = new System.Drawing.Size(85, 15);
            this.labelSurplus.TabIndex = 4;
            this.labelSurplus.Text = "Surplus/Deficit";
            // 
            // labelFee2
            // 
            this.labelFee2.AutoSize = true;
            this.labelFee2.Location = new System.Drawing.Point(31, 110);
            this.labelFee2.Name = "labelFee2";
            this.labelFee2.Size = new System.Drawing.Size(53, 15);
            this.labelFee2.TabIndex = 3;
            this.labelFee2.Text = "Total Fee";
            // 
            // labelCost2
            // 
            this.labelCost2.AutoSize = true;
            this.labelCost2.Location = new System.Drawing.Point(31, 73);
            this.labelCost2.Name = "labelCost2";
            this.labelCost2.Size = new System.Drawing.Size(59, 15);
            this.labelCost2.TabIndex = 2;
            this.labelCost2.Text = "Total Cost";
            // 
            // labelParticipantsOut
            // 
            this.labelParticipantsOut.AutoSize = true;
            this.labelParticipantsOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelParticipantsOut.Location = new System.Drawing.Point(187, 39);
            this.labelParticipantsOut.Name = "labelParticipantsOut";
            this.labelParticipantsOut.Size = new System.Drawing.Size(18, 17);
            this.labelParticipantsOut.TabIndex = 1;
            this.labelParticipantsOut.Text = "   ";
            // 
            // labelParticipants2
            // 
            this.labelParticipants2.AutoSize = true;
            this.labelParticipants2.Location = new System.Drawing.Point(31, 39);
            this.labelParticipants2.Name = "labelParticipants2";
            this.labelParticipants2.Size = new System.Drawing.Size(130, 15);
            this.labelParticipants2.TabIndex = 0;
            this.labelParticipants2.Text = "Number of Participants";
            // 
            // listBoxParticipants
            // 
            this.listBoxParticipants.FormattingEnabled = true;
            this.listBoxParticipants.ItemHeight = 15;
            this.listBoxParticipants.Location = new System.Drawing.Point(288, 43);
            this.listBoxParticipants.Name = "listBoxParticipants";
            this.listBoxParticipants.Size = new System.Drawing.Size(597, 274);
            this.listBoxParticipants.TabIndex = 3;
            this.listBoxParticipants.SelectedIndexChanged += new System.EventHandler(this.listBoxParticipants_SelectedIndexChanged);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(449, 323);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 4;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(655, 323);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 551);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.listBoxParticipants);
            this.Controls.Add(this.groupBoxEconomy);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.groupBoxNewEvent);
            this.Name = "MainForm";
            this.Text = "Event organiser by <Razvan Petcu>";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxNewEvent.ResumeLayout(false);
            this.groupBoxNewEvent.PerformLayout();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBoxEconomy.ResumeLayout(false);
            this.groupBoxEconomy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxNewEvent;
        private GroupBox groupBoxAdd;
        private GroupBox groupBoxEconomy;
        private ListBox listBoxParticipants;
        private TextBox textBoxFee;
        private TextBox textBoxCost;
        private TextBox textBoxTitle;
        private Button buttonCreateEvent;
        private Label labelFee;
        private Label labelCost;
        private Label labelEventTitle;
        private Label labelCountry;
        private Label labelZipCode;
        private Label labelCity;
        private Label labelStreet;
        private Label labelLastName;
        private Label labelFirstName;
        private ComboBox comboBoxCountry;
        private TextBox textBoxZip;
        private TextBox textBoxCity;
        private TextBox textBoxStreet;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Button buttonAdd;
        private Label labelSurplusOut;
        private Label labelFeeOut;
        private Label labelCostOut;
        private Label labelSurplus;
        private Label labelFee2;
        private Label labelCost2;
        private Label labelParticipantsOut;
        private Label labelParticipants2;
        private Button buttonChange;
        private Button buttonDelete;
    }
}