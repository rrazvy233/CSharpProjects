namespace Assignment4C
{
    public partial class MainForm : Form
    {
        private string firstName;
        private string lastName;

        PartyManager organiser;
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        private void InitializeGUI()
        {
            //clears input and disables the add member groupbox
            ClearInput();
            ClearOutput();
            groupBoxAdd.Enabled = false;
            groupBoxCreate.Enabled = true;
        }
        private void ClearInput()
        {
            textBoxCost.Text = string.Empty;
            textBoxGuest.Text = string.Empty;
            textBoxFee.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxFirstName.Text = string.Empty;
        }
        private void ClearOutput()
        {
            labelGuestOut.Text = "0";
            labelFeeOut.Text = "0.00";
            labelCostOut.Text = "0.00";
            labelSurplusOut.Text = "0.00";
            listBoxParticipants.Items.Clear();
        }
        private bool ReadFee()
        {
            //reads fee and sends it to the Party manager class aswell as displaying an error if
            //its not a number or smaller or equal to 0
            double fee = 0;

            bool readData1 = double.TryParse(textBoxFee.Text, out fee);
            if (!readData1 || fee <= 0)
            {
                MessageBox.Show("Invalid, fee must be a number and be higher than 0");
            }
            organiser.SetFee(fee);
            return readData1;

        }
        private bool ReadCost()
        {
            //reads cost and sends to Party manager, displays error if not number of <= 0
            double cost = 0;
            bool readData2 = double.TryParse(textBoxCost.Text, out cost);
            if (!readData2 || cost <= 0)
            {
                MessageBox.Show("Invalid, cost must be a number and be higher than 0");
            }
            organiser.SetCost(cost);
            return readData2;
        }
        private void UpdateGui()
        {
            // clears listbox
            listBoxParticipants.Items.Clear();
            //adds item to listbox until limit is reached
            string[] guestList = organiser.GuestList();
            if (guestList != null)
            {
                for (int i = 0; i < guestList.Length; i++)
                {
                    string str = $"{i + 1,4} {guestList[i],-20}";
                    listBoxParticipants.Items.Add(str);
                }
            }
            else { return; }
            double totalCost = organiser.CalculateCost();
            labelCostOut.Text = totalCost.ToString();
            double totalFee = organiser.CalcFee();
            labelFeeOut.Text = totalFee.ToString();
            double surplus = organiser.CalcSurplus();
            labelSurplusOut.Text = surplus.ToString();

        }
        private bool CreateParty()
        {
            // creates a party/array list in Party manager
            // reads and sends the maximum number of participants / the array length to party manager
            // number of guests must be bigger than 0 else error will be returned and party will not be created
            int maxNumber = 0;
            bool ok = true;
            if (int.TryParse(textBoxGuest.Text, out maxNumber) && (maxNumber > 0))
            {
                organiser = new PartyManager(maxNumber);
                MessageBox.Show($"Party List with space for {maxNumber} created!", "Success");
                double guestNumber = organiser.ReturnGuestNr();
                labelGuestOut.Text = guestNumber.ToString();
            }
            else
            {
                MessageBox.Show("There must be at least a guest", "Error");
                ok = false;
            }
            return ok;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            //uses the create party and sends the guest number to PartyManager
            bool ok = CreateParty();
            if (!ok)
            {
                return;
            }
            //checks if fee and cost are valid and sends them to PartyManager
            bool ammount = ReadFee() && ReadCost();
            if (ok && ammount)
            {
                //enables groupbox for adding guests and updates GUI
                groupBoxAdd.Enabled = true;
                UpdateGui();
            }
        }
        private bool ReadName()
        {
            //reads complete name or give error is string is empty
            firstName = textBoxFirstName.Text.Trim();
            lastName = textBoxLastName.Text.Trim();
            if (string.IsNullOrEmpty(textBoxFirstName.Text))
            {
                MessageBox.Show("Please enter a first name", "Error");
                return false;
            }
            else if (string.IsNullOrEmpty(textBoxLastName.Text))
            {
                MessageBox.Show("Please enter a last name", "Error");
                return false;
            }
            return true;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //checks if name is true
            bool nameok = ReadName();
            //checks if array has empty sports
            int spaceok = organiser.CheckListForParticipants();
            //checks if guests go over array max length
            double guestNumber = organiser.ReturnGuestNr();
            
            if (nameok)
            {
                bool ok = organiser.AddNewGuest(firstName, lastName);
                if (ok)
                {
                    //updates GUI and empties the textboxes for first and last name
                    UpdateGui();
                    textBoxLastName.Text = string.Empty;
                    textBoxFirstName.Text = string.Empty;
                } 
                //error if there is no more free space left in array
                else if (spaceok >= guestNumber)
                {
                    MessageBox.Show("The list is full", "Error");
                }
            }
        }
        private void listBoxParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gets selected index and converts it to int
            int item = Convert.ToInt32(listBoxParticipants.SelectedIndex.ToString());
            // if the item selected has an index smaller or equal to 0
            if (item >= 0)
            {
                //the index is sendt to the array in party manager and gets the corresponding string
                //displaying it in the textboxes for first and last name in order to be edited by the change button
                string name = organiser.GetItemAt(item);
                //splits the first and last name at the comma
                string[] names = name.Split(",");
                textBoxFirstName.Text = names[1].Trim();
                textBoxLastName.Text = names[0].Trim();
            }

        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            //reads the new name in the textboxses
            ReadName();
            //reads index position
            int position = Convert.ToInt32(listBoxParticipants.SelectedIndex.ToString());
            //sends the name and position to the partry manager where the name will be replaced in the given position
            bool ok = organiser.ChangeGuest(firstName, lastName, position);
            if (ok)
            {
                UpdateGui();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //gets index
            int itemDel = Convert.ToInt32(listBoxParticipants.SelectedIndex.ToString());
            //sends number to DeleteAt in party manager and deletes it
            organiser.DeleteAt(itemDel);
            //updates GUI for deleted item
            UpdateGui();
            //empries the textboxes
            textBoxLastName.Text = string.Empty;
            textBoxFirstName.Text = string.Empty;
        }
    }
}