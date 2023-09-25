namespace Assignment4C
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
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxGuest = new System.Windows.Forms.TextBox();
            this.labelFee = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelGuest = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.listBoxParticipants = new System.Windows.Forms.ListBox();
            this.labelMaxGuest = new System.Windows.Forms.Label();
            this.labelCost2 = new System.Windows.Forms.Label();
            this.labelFee2 = new System.Windows.Forms.Label();
            this.labelSurplus = new System.Windows.Forms.Label();
            this.labelGuestOut = new System.Windows.Forms.Label();
            this.labelCostOut = new System.Windows.Forms.Label();
            this.labelFeeOut = new System.Windows.Forms.Label();
            this.labelSurplusOut = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.groupBoxCreate.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCreate
            // 
            this.groupBoxCreate.Controls.Add(this.buttonCreate);
            this.groupBoxCreate.Controls.Add(this.textBoxFee);
            this.groupBoxCreate.Controls.Add(this.textBoxCost);
            this.groupBoxCreate.Controls.Add(this.textBoxGuest);
            this.groupBoxCreate.Controls.Add(this.labelFee);
            this.groupBoxCreate.Controls.Add(this.labelCost);
            this.groupBoxCreate.Controls.Add(this.labelGuest);
            this.groupBoxCreate.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Size = new System.Drawing.Size(251, 158);
            this.groupBoxCreate.TabIndex = 0;
            this.groupBoxCreate.TabStop = false;
            this.groupBoxCreate.Text = "Create Party";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(82, 129);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 6;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBoxFee
            // 
            this.textBoxFee.Location = new System.Drawing.Point(145, 86);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.Size = new System.Drawing.Size(100, 23);
            this.textBoxFee.TabIndex = 5;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(145, 58);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 23);
            this.textBoxCost.TabIndex = 4;
            // 
            // textBoxGuest
            // 
            this.textBoxGuest.Location = new System.Drawing.Point(145, 28);
            this.textBoxGuest.Name = "textBoxGuest";
            this.textBoxGuest.Size = new System.Drawing.Size(100, 23);
            this.textBoxGuest.TabIndex = 3;
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Location = new System.Drawing.Point(6, 86);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(84, 15);
            this.labelFee.TabIndex = 2;
            this.labelFee.Text = "Fee per person";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(6, 61);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(90, 15);
            this.labelCost.TabIndex = 1;
            this.labelCost.Text = "Cost per person";
            // 
            // labelGuest
            // 
            this.labelGuest.AutoSize = true;
            this.labelGuest.Location = new System.Drawing.Point(6, 31);
            this.labelGuest.Name = "labelGuest";
            this.labelGuest.Size = new System.Drawing.Size(126, 15);
            this.labelGuest.TabIndex = 0;
            this.labelGuest.Text = "Max number of guests";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.buttonAdd);
            this.groupBoxAdd.Controls.Add(this.textBoxLastName);
            this.groupBoxAdd.Controls.Add(this.textBoxFirstName);
            this.groupBoxAdd.Controls.Add(this.labelLastName);
            this.groupBoxAdd.Controls.Add(this.labelFirstName);
            this.groupBoxAdd.Location = new System.Drawing.Point(12, 176);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(251, 139);
            this.groupBoxAdd.TabIndex = 1;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Invite Guest";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(82, 110);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(109, 67);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(136, 23);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(109, 36);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(136, 23);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(10, 70);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(63, 15);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(11, 39);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(64, 15);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            // 
            // listBoxParticipants
            // 
            this.listBoxParticipants.FormattingEnabled = true;
            this.listBoxParticipants.ItemHeight = 15;
            this.listBoxParticipants.Location = new System.Drawing.Point(286, 18);
            this.listBoxParticipants.Name = "listBoxParticipants";
            this.listBoxParticipants.Size = new System.Drawing.Size(258, 304);
            this.listBoxParticipants.TabIndex = 2;
            this.listBoxParticipants.SelectedIndexChanged += new System.EventHandler(this.listBoxParticipants_SelectedIndexChanged);
            // 
            // labelMaxGuest
            // 
            this.labelMaxGuest.AutoSize = true;
            this.labelMaxGuest.Location = new System.Drawing.Point(17, 361);
            this.labelMaxGuest.Name = "labelMaxGuest";
            this.labelMaxGuest.Size = new System.Drawing.Size(128, 15);
            this.labelMaxGuest.TabIndex = 3;
            this.labelMaxGuest.Text = "Total number of guests";
            // 
            // labelCost2
            // 
            this.labelCost2.AutoSize = true;
            this.labelCost2.Location = new System.Drawing.Point(17, 390);
            this.labelCost2.Name = "labelCost2";
            this.labelCost2.Size = new System.Drawing.Size(57, 15);
            this.labelCost2.TabIndex = 4;
            this.labelCost2.Text = "Total cost";
            // 
            // labelFee2
            // 
            this.labelFee2.AutoSize = true;
            this.labelFee2.Location = new System.Drawing.Point(17, 423);
            this.labelFee2.Name = "labelFee2";
            this.labelFee2.Size = new System.Drawing.Size(53, 15);
            this.labelFee2.TabIndex = 5;
            this.labelFee2.Text = "Total Fee";
            // 
            // labelSurplus
            // 
            this.labelSurplus.AutoSize = true;
            this.labelSurplus.Location = new System.Drawing.Point(17, 454);
            this.labelSurplus.Name = "labelSurplus";
            this.labelSurplus.Size = new System.Drawing.Size(84, 15);
            this.labelSurplus.TabIndex = 6;
            this.labelSurplus.Text = "Surplus/deficit";
            // 
            // labelGuestOut
            // 
            this.labelGuestOut.AutoSize = true;
            this.labelGuestOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGuestOut.Location = new System.Drawing.Point(173, 361);
            this.labelGuestOut.Name = "labelGuestOut";
            this.labelGuestOut.Size = new System.Drawing.Size(2, 17);
            this.labelGuestOut.TabIndex = 7;
            // 
            // labelCostOut
            // 
            this.labelCostOut.AutoSize = true;
            this.labelCostOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCostOut.Location = new System.Drawing.Point(173, 390);
            this.labelCostOut.Name = "labelCostOut";
            this.labelCostOut.Size = new System.Drawing.Size(2, 17);
            this.labelCostOut.TabIndex = 8;
            // 
            // labelFeeOut
            // 
            this.labelFeeOut.AutoSize = true;
            this.labelFeeOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFeeOut.Location = new System.Drawing.Point(173, 423);
            this.labelFeeOut.Name = "labelFeeOut";
            this.labelFeeOut.Size = new System.Drawing.Size(2, 17);
            this.labelFeeOut.TabIndex = 9;
            // 
            // labelSurplusOut
            // 
            this.labelSurplusOut.AutoSize = true;
            this.labelSurplusOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSurplusOut.Location = new System.Drawing.Point(173, 454);
            this.labelSurplusOut.Name = "labelSurplusOut";
            this.labelSurplusOut.Size = new System.Drawing.Size(2, 17);
            this.labelSurplusOut.TabIndex = 10;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(453, 348);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(310, 348);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 12;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 508);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelSurplusOut);
            this.Controls.Add(this.labelFeeOut);
            this.Controls.Add(this.labelCostOut);
            this.Controls.Add(this.labelGuestOut);
            this.Controls.Add(this.labelSurplus);
            this.Controls.Add(this.labelFee2);
            this.Controls.Add(this.labelCost2);
            this.Controls.Add(this.labelMaxGuest);
            this.Controls.Add(this.listBoxParticipants);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.groupBoxCreate);
            this.Name = "MainForm";
            this.Text = "Party organizer by Razvan Petcu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxCreate.ResumeLayout(false);
            this.groupBoxCreate.PerformLayout();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxCreate;
        private GroupBox groupBoxAdd;
        private ListBox listBoxParticipants;
        private TextBox textBoxFee;
        private TextBox textBoxCost;
        private TextBox textBoxGuest;
        private Label labelFee;
        private Label labelCost;
        private Label labelGuest;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Label labelLastName;
        private Label labelFirstName;
        private Label labelMaxGuest;
        private Label labelCost2;
        private Label labelFee2;
        private Label labelSurplus;
        private Label labelGuestOut;
        private Label labelCostOut;
        private Label labelFeeOut;
        private Label labelSurplusOut;
        private Button buttonCreate;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonChange;
    }
}