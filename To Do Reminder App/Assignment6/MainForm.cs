using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Text;

namespace Assignment6
{
   
    public partial class MainForm : Form
    {
        private TaskManager taskManager;
        Task task = new Task();
        private string fileName = Application.StartupPath + "\\Tasks.txt";
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        private void InitializeGUI()
        {
            this.Text = "ToDo reminder by <Razvan Petcu>";

            taskManager = new TaskManager();
            comboBoxPriority.Items.Clear();
            comboBoxPriority.Items.AddRange(Enum.GetNames(typeof(PriorityTypes)));
            comboBoxPriority.SelectedIndex = (int)PriorityTypes.Normal;
            listBoxEvent.Items.Clear();
            labelClock.Text = string.Empty;
            // need to start clock time here somehow
            textBoxDescription.Text = string.Empty;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd  HH:mm";
            buttonChange.Enabled = false;
            buttonDelete.Enabled = false;
            toolTipTimeAndDate.SetToolTip(dateTimePicker1, "Click to select the date");


        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxEvent.SelectedIndex;
            if (index >= 0)
            {
                Task task = ReadInput();
                bool ok = taskManager.DeleteTask(index);
                if (ok)
                {
                    UpdateGUI();
                }
            }
            else
            {
                MessageBox.Show("Select an item", "Error");
            }
        }
        private Task ReadInput()
        {
            
            if (string.IsNullOrEmpty(textBoxDescription.Text))
            {
                MessageBox.Show("Please Write a description", "Error");
                return null;
            }
            task.Description = textBoxDescription.Text;
            task.TaskDate = dateTimePicker1.Value;
            task.Priority = (PriorityTypes)comboBoxPriority.SelectedIndex;

            return task;
        }
        private void UpdateGUI()
        {
            listBoxEvent.Items.Clear();
            string[] info = taskManager.InfoString();
            if (info != null)
            {
                listBoxEvent.Items.AddRange(info);
            }
            textBoxDescription.Text = string.Empty;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Task task = ReadInput();
            if (taskManager.AddNewTask(task))
            {
                UpdateGUI();
            }

        }

        private void openDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ok = taskManager.ReadDataFromFile(fileName);
            if (!ok)
            {
                MessageBox.Show("Could not open file", "Error");
            }
            else
            {
                UpdateGUI();
            }
        }

        private void saveDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ok = taskManager.SaveDataToFile(fileName);
            if (!ok)
            {
                MessageBox.Show("Something went wrong, try again", "Error");
            } else
            {
                MessageBox.Show("Data saved to file: " + Environment.NewLine + fileName);
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            int index = listBoxEvent.SelectedIndex;
            if (index >= 0)
            {
                Task task = ReadInput();
                bool ok = taskManager.ChangeTask(task, index);
                if (ok)
                {
                    UpdateGUI();
                }
            } else
            {
                MessageBox.Show("Select an item", "Error");
            }
        }

        private void listBoxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxEvent.SelectedIndex;
            
            textBoxDescription.Text = task.Description;


            if (listBoxEvent.SelectedIndex >= 0 && listBoxEvent.SelectedIndex < listBoxEvent.Items.Count)
            {
                buttonChange.Enabled = true;
                buttonDelete.Enabled = true;
            }
            else if (listBoxEvent.SelectedIndex == -1)
            {
                buttonChange.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        private void newCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the app?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
            }
            else
            {
                e.Cancel = true;
                this.Activate();
            }

        }

        private void exitAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}