using System.CodeDom;

namespace Assignment5
{
    public partial class MainForm : Form
    {
        EventManager eventManager;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        private void InitializeGUI()
        {
            ClearInput();
            ClearOutput();
            comboBoxCountry.Items.AddRange(Enum.GetNames(typeof(Countries)));
            comboBoxCountry.SelectedIndex = (int)Countries.Sverige;
            groupBoxNewEvent.Enabled = true;
            groupBoxAdd.Enabled = false;
        }
        private void ClearInput()
        {
            textBoxTitle.Text = string.Empty;
            textBoxCost.Text = string.Empty;
            textBoxFee.Text = string.Empty;
            textBoxFirstName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxCity.Text = string.Empty;
            textBoxStreet.Text = string.Empty;
            textBoxZip.Text = string.Empty;
        }
        private void ClearOutput()
        {
            labelParticipantsOut.Text = "0";
            labelFeeOut.Text = "0.00";
            labelCostOut.Text = "0.00";
            labelSurplusOut.Text = "0.00";

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CreateEvent()
        {
            eventManager = new EventManager();
            if (string.IsNullOrEmpty(textBoxTitle.Text))
            {
                textBoxTitle.Text = "Untitled event";
            }
            eventManager.Title = textBoxTitle.Text + " By <Razvan Petcu>";
            this.Text = eventManager.Title;
            bool costOK = ReadCost();
            bool feeOK = ReadFee();
            if (costOK && feeOK)
            {
                groupBoxAdd.Enabled = true;
                MessageBox.Show("Event Created");
                UpdateGUI();
            }
        }
        private void buttonCreateEvent_Click(object sender, EventArgs e)
        {
            listBoxParticipants.Items.Clear();
            CreateEvent();
            UpdateGUI();
        }
        private bool ReadCost()
        {
            double cost = 0.0;
            bool ok = true;

            if (double.TryParse(textBoxCost.Text, out cost) && (cost > 0))
            {
                eventManager.CostPerPerson = cost;
            }
            else
            {
                MessageBox.Show("Invalid input for cost", "Error");
                ok = false;
            }
            return ok;
        }
        private bool ReadFee()
        {
            double fee = 0.0;
            bool ok = true;

            if (double.TryParse(textBoxFee.Text, out fee) && (fee > 0))
            {
                eventManager.FeePerPerson = fee;
            }
            else
            {
                MessageBox.Show("Invalid input for cost", "Error");
                ok = false;
            }
            return ok;
        }
        private void UpdateGUI()
        {
            string[] stringInfo = eventManager.Participants.GetParticipantsInfo();
            if (stringInfo != null)
            {
                listBoxParticipants.Items.Clear();
                listBoxParticipants.Items.AddRange(stringInfo);
                labelParticipantsOut.Text = listBoxParticipants.Items.Count.ToString();
            }

            labelParticipantsOut.Text = eventManager.Participants.Count.ToString();

            double costOut = eventManager.CalculateCost();
            labelCostOut.Text = costOut.ToString("0.00");


            double feeOut = eventManager.CalculateFee();
            labelFeeOut.Text = feeOut.ToString("0.00");

            labelSurplusOut.Text = (feeOut - costOut).ToString("0.00");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Participants participants = new Participants();
            if(ReadInput(ref participants))
            {
                UpdateGUI();
            }
        }
        private bool ReadInput(ref Participants participants)
        {
            bool ok = ReadData(ref participants);
            if (ok)
            {
                eventManager.Participants.AddParticipant(participants);
            } else
            {
                MessageBox.Show("Name and city are required inputs");
            }
            return ok;
        }
        private bool ReadData(ref Participants participants)
        {
            participants.FirstName = textBoxFirstName.Text;
            participants.LastName = textBoxLastName.Text;
            Address address = ReadAddress();

            participants.Address = address;
            bool ok = address.Validation();
            return ok;
        }
        private Address ReadAddress()
        {
            Address address = new Address();
            address.Street = textBoxStreet.Text;
            address.City = textBoxCity.Text;
            address.ZipCode = textBoxZip.Text;

            address.Country = (Countries)comboBoxCountry.SelectedIndex;

            return address;
        }
        bool ReadNames(ref Participants participants)
        {
            bool ok = false;
            if (TrimNames())
            {
                participants.FirstName = textBoxFirstName.Text;
                participants.LastName = textBoxLastName.Text;
                ok = true;
            }
            else
            {
                MessageBox.Show("Please enter a name");
            }
            return ok;
        }

        private void listBoxParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxParticipants.SelectedIndex;
            if(index >= 0)
            {
                Participants participants = eventManager.Participants.GetParticipant(index);
                textBoxFirstName.Text = participants.FirstName;
                textBoxLastName.Text = participants.LastName;
                textBoxCity.Text = participants.Address.City;
                textBoxZip.Text = participants.Address.ZipCode;

                comboBoxCountry.SelectedIndex = (int)participants.Address.Country;
            } 
        }
        private int ListBoxSelecteItem()
        {
            int index = listBoxParticipants.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Select an item in the list");
                return -1;
            }
            return index;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = ListBoxSelecteItem();
            if (index < 0)
            {
                return;
            }

                eventManager.Participants.DeleteAt(index);
                UpdateGUI();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            int index = ListBoxSelecteItem();
            if (index < 0)
            {
                return;
            }
                Participants participants = eventManager.Participants.GetParticipant(index);
            if (ReadData(ref participants))
            {
                eventManager.Participants.ChangeAt(participants, index);
                UpdateGUI();
            }
        }

        private bool TrimNames()
        {
            bool ok = false;
            if(textBoxFirstName != null && textBoxLastName != null)
            {
                textBoxFirstName.Text = textBoxFirstName.Text.Trim();
                textBoxLastName.Text = textBoxLastName.Text.Trim();
                ok = true;
            }
            return ok;
        }

        private void textBoxFee_TextChanged(object sender, EventArgs e)
        {

        }
    }
}