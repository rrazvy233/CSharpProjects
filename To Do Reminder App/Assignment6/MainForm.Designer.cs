namespace Assignment6
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelPriority = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.groupBoxToDo = new System.Windows.Forms.GroupBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPriorityList = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.listBoxEvent = new System.Windows.Forms.ListBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelClock = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelToDo = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.toolTipTimeAndDate = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxToDo.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(464, 57);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(45, 15);
            this.labelPriority.TabIndex = 1;
            this.labelPriority.Text = "Priority";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(519, 54);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPriority.TabIndex = 2;
            // 
            // groupBoxToDo
            // 
            this.groupBoxToDo.Controls.Add(this.labelDescription);
            this.groupBoxToDo.Controls.Add(this.labelPriorityList);
            this.groupBoxToDo.Controls.Add(this.labelTime);
            this.groupBoxToDo.Controls.Add(this.labelDate);
            this.groupBoxToDo.Controls.Add(this.listBoxEvent);
            this.groupBoxToDo.Location = new System.Drawing.Point(12, 190);
            this.groupBoxToDo.Name = "groupBoxToDo";
            this.groupBoxToDo.Size = new System.Drawing.Size(998, 261);
            this.groupBoxToDo.TabIndex = 4;
            this.groupBoxToDo.TabStop = false;
            this.groupBoxToDo.Text = "To Do";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(666, 30);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(67, 15);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description";
            // 
            // labelPriorityList
            // 
            this.labelPriorityList.AutoSize = true;
            this.labelPriorityList.Location = new System.Drawing.Point(517, 30);
            this.labelPriorityList.Name = "labelPriorityList";
            this.labelPriorityList.Size = new System.Drawing.Size(45, 15);
            this.labelPriorityList.TabIndex = 3;
            this.labelPriorityList.Text = "Priority";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(380, 30);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(33, 15);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Time";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(93, 30);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(31, 15);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date";
            // 
            // listBoxEvent
            // 
            this.listBoxEvent.FormattingEnabled = true;
            this.listBoxEvent.ItemHeight = 15;
            this.listBoxEvent.Location = new System.Drawing.Point(16, 56);
            this.listBoxEvent.Name = "listBoxEvent";
            this.listBoxEvent.Size = new System.Drawing.Size(954, 184);
            this.listBoxEvent.TabIndex = 0;
            this.listBoxEvent.SelectedIndexChanged += new System.EventHandler(this.listBoxEvent_SelectedIndexChanged);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(61, 468);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(121, 41);
            this.buttonChange.TabIndex = 5;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(287, 468);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 43);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelClock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelClock.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClock.Location = new System.Drawing.Point(840, 470);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(121, 39);
            this.labelClock.TabIndex = 7;
            this.labelClock.Text = "00:00:00";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCtrlNToolStripMenuItem,
            this.openDataFileToolStripMenuItem,
            this.saveDataFileToolStripMenuItem,
            this.exitAltF4ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCtrlNToolStripMenuItem
            // 
            this.newCtrlNToolStripMenuItem.Name = "newCtrlNToolStripMenuItem";
            this.newCtrlNToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newCtrlNToolStripMenuItem.Text = "New      Ctrl+N";
            this.newCtrlNToolStripMenuItem.Click += new System.EventHandler(this.newCtrlNToolStripMenuItem_Click);
            // 
            // openDataFileToolStripMenuItem
            // 
            this.openDataFileToolStripMenuItem.Name = "openDataFileToolStripMenuItem";
            this.openDataFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openDataFileToolStripMenuItem.Text = "Open data file";
            this.openDataFileToolStripMenuItem.Click += new System.EventHandler(this.openDataFileToolStripMenuItem_Click);
            // 
            // saveDataFileToolStripMenuItem
            // 
            this.saveDataFileToolStripMenuItem.Name = "saveDataFileToolStripMenuItem";
            this.saveDataFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveDataFileToolStripMenuItem.Text = "Save data file";
            this.saveDataFileToolStripMenuItem.Click += new System.EventHandler(this.saveDataFileToolStripMenuItem_Click);
            // 
            // exitAltF4ToolStripMenuItem
            // 
            this.exitAltF4ToolStripMenuItem.Name = "exitAltF4ToolStripMenuItem";
            this.exitAltF4ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitAltF4ToolStripMenuItem.Text = "Exit   Alt+F4";
            this.exitAltF4ToolStripMenuItem.Click += new System.EventHandler(this.exitAltF4ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(12, 51);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(81, 15);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Date and time";
            // 
            // labelToDo
            // 
            this.labelToDo.AutoSize = true;
            this.labelToDo.Location = new System.Drawing.Point(12, 95);
            this.labelToDo.Name = "labelToDo";
            this.labelToDo.Size = new System.Drawing.Size(36, 15);
            this.labelToDo.TabIndex = 11;
            this.labelToDo.Text = "To do";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(79, 92);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(561, 23);
            this.textBoxDescription.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(669, 92);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 533);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelToDo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.labelClock);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.groupBoxToDo);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxToDo.ResumeLayout(false);
            this.groupBoxToDo.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label labelPriority;
        private ComboBox comboBoxPriority;
        private GroupBox groupBoxToDo;
        private Label labelDescription;
        private Label labelPriorityList;
        private Label labelTime;
        private Label labelDate;
        private ListBox listBoxEvent;
        private Button buttonChange;
        private Button buttonDelete;
        private Label labelClock;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newCtrlNToolStripMenuItem;
        private ToolStripMenuItem openDataFileToolStripMenuItem;
        private ToolStripMenuItem saveDataFileToolStripMenuItem;
        private ToolStripMenuItem exitAltF4ToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label labelDateTime;
        private Label labelToDo;
        private TextBox textBoxDescription;
        private Button buttonAdd;
        private ToolTip toolTipTimeAndDate;
        private System.Windows.Forms.Timer timer1;
    }
}