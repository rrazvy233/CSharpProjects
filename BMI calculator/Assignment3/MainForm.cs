using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        //enpty string for name input
        private string name = string.Empty;

        //create instance for BMI calculcator
        private BMICalculator bmiCalc = new BMICalculator();
        private SavingCalculator savePlan = new SavingCalculator();
        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
        }
        private void InitializeGui()
        {
            this.Text = "The Super Calculator <Razvan Petcu>";
            //input controls
            radioMetric.Checked = true;
            label2.Text = "Height (cm)";
            label3.Text = "Weight (kg)";

            //output controls
            labelBMI.Text = string.Empty;
            labelCathegory.Text = string.Empty;
        }
        //updates text labels from metric to imperial if the corresponding radio button is checked
        private void UpdateText()
        {
            if (radioMetric.Checked)
            {
                label2.Text = "Height (cm)";
                label3.Text = "Weight (kg)";
                labelNormalWeight.Text = "Normal weight should be between 50 and 68 kg";

            }
            else if (radioImperial.Checked)
            {
                label2.Text = "Height (ft, in)";
                label3.Text = "Weight (lbs)";
                labelNormalWeight.Text = "Normal weight should be between 110 and 149 lbs";
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateText();
            VisibleTextbox();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateText();
            VisibleTextbox();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //read input
            bool ok = ReadInputBMI();
            // this validates the input from the called method (above) and runs the below method
            if (ok)
            {
                CalculateAndDisplayInfo();
            }
            

        }
        //method for displaying the BMI calculator information to the coresponding labels
        private void CalculateAndDisplayInfo()
        {
            double bmi = bmiCalc.CalculateBMI();
            labelBMI.Text = bmi.ToString("f2");
            labelCathegory.Text = bmiCalc.WeightCathegory();

        }
        //method for running all read data methods for the BMI calculator
        private bool ReadInputBMI()
        {
            ReadName();
            bool readHeight = ReadHeight();//reads input for metric
            bool readWeight = ReadWeight();//reads input for imperial
            ReadUnit();
            return readHeight && readWeight;
        }
        //looks for what unit is selected (default to metric)
        private void ReadUnit()
        {
            if (radioMetric.Checked)
            {
                bmiCalc.SetUnit(UnitType.Metric);
            } else
            {
                bmiCalc.SetUnit(UnitType.Imperial);
            }
        }
        private void ReadName()
        {
            name = textName.Text.Trim();
            groupBox4.Text = " BMI results for " + name;
        }
        // method that reads height (default metric) and converts it to int, otherwise if Imperial is selected it adds an inch value
        // and sets the new unit value in the BMI calculator class aswell
        //this also converts centimeters to meters and feet and inches to inches
        private bool ReadHeight()
        {
            double height = 0.0;
            double inch = 0.0;
            bool readHeight = double.TryParse(textCmFt.Text, out height);
            bmiCalc.SetUnit(UnitType.Metric);
            if (!readHeight || height <= 0)
            {
                MessageBox.Show("Invalid height value");
            }
            if (radioImperial.Checked)
            {
                bmiCalc.SetUnit(UnitType.Imperial);
                readHeight = readHeight && double.TryParse(textInch.Text, out inch); // adds feet and inches to the same string
                if (inch <= 0)
                {
                    MessageBox.Show("Invalid Inch value");
                }
            }
            if (bmiCalc.GetUnit() == UnitType.Metric)
            {
                height = height / 100; //cm to meters
            } else if (bmiCalc.GetUnit() == UnitType.Imperial)
            {
                height = height * 12 + inch; //convert feet to inches and add inches value
            }
            bmiCalc.SetHeight(height);
            return readHeight;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        // reads weight and converts to int
        private bool ReadWeight()
        {
            double weight = 0.0;
            bool readWeight = double.TryParse(textWeight.Text, out weight);
            if (!readWeight || weight <= 0)
            {
                MessageBox.Show("Invalid weight value");
            }
            bmiCalc.SetWeight(weight);
            return readWeight;
        }
        //method that changes the weight, height and normal BMI text based on what unit is selected
        public void VisibleTextbox()
        {
            if (radioImperial.Checked)
            {
                textInch.Visible = true;
            }
            else if (radioMetric.Checked)
            {
                textInch.Visible = false;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void labelPaid_Click(object sender, EventArgs e)
        {

        }
        //method for reading and converting string to int
        public bool ReadMoney()
        {
            double money = 0.0;
            bool readMoney = double.TryParse(textMonth.Text, out money);
            if (!readMoney)
            {
                MessageBox.Show("Input (Monthly deposit) must be a number");
            } else if (money <= 0)
            {
                MessageBox.Show("Input (Monthly deposit) must be bigger than 0");
            }
            savePlan.SetMoney(money);
            return readMoney;
        }
        // this method is used to read and convert the ammount of years to int
        public bool ReadYears()
        {
            double months;
            double years = 0.0;
            bool readYears = double.TryParse(textYear.Text, out years);
            if (!readYears)
            {
                MessageBox.Show("Input (years) must be a number");
            }
            else if (years <= 0)
            {
                MessageBox.Show("Input (years) must be bigger than 0");
            }
            months = years * 12;
            savePlan.SetMonths(months);
            return readYears;
        }
        public bool ReadInputSavings()
        {
            bool readMoney = ReadMoney();
            bool readYears = ReadYears();
            return readMoney && readYears;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputSavings();
            //reads above data and checks if everything is valid, if it is it will run the below methods
            if (ok)
            {
                CalculateSavings();
                CalculateWithInterest();
            }
        }
        //runs and siplays the Ammount paid (in GUI) or the money without interest
        public void CalculateSavings()
        {
            double paid = savePlan.CalculateSavings();
            labelPaid.Text = paid.ToString("f2");
        }
        //calculates Final Balance (in GUI) or ammount of money with interest
        public void CalculateWithInterest()
        {
            double withInterest = savePlan.CalculateInterest();
            labelBalance.Text = withInterest.ToString("f2");
        }
    }
}