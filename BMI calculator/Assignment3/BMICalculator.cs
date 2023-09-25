using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class BMICalculator
    {

        //variables
        private string name = "No Name";
        private double height = 0.0;
        private double weight = 0.0;
        private UnitType unit;
        
        //sets the default unit as metric
        public BMICalculator()
        {
            unit = UnitType.Metric;
        }
        #region Setter and getter
        //setters and getters are used to set the above variables from the main form/GUI
        //and return them at the end so they can be displayed
        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double value)
        {
            if (value >= 0)
            {
                height = value;
            }
        }
        public double GetWeight()
        {
            return weight;
        }
        public void SetWeight(double value)
        {
            if (value >= 0)
            {
                weight = value;
            }
        }
        public UnitType GetUnit()
        {
            return unit;
        }
        //checks if the unit type has been changed and if so updates it
        public void SetUnit(UnitType value)
        {
            unit = value;
        }
        #endregion
        //method to calculate BMI where the BMI is equal to weight / height^2 * factor
        //example (metric) 90kg / (1.80m^2) * factor of 1.0 = 27.78 BMI
        //example (imperial) 200lb / (71 inch ^2) * facor of 703 = 27.89 BMI
        // where factor is decided by the type of unit selected in the radio buttons (exacmple units = imperial will give factor = 703.0)
        public double CalculateBMI()
        {
            // metric values
            double bmi = 0.0;
            double factor = 1.0;

            if(unit == UnitType.Imperial)
            {
                //factor for imperial units
                factor = 703.0;
            }
            // calculation of the BMI value using the below formula
            bmi = weight / (height * height) * factor;
            //retuns bmi value
            return bmi;
        }
        // method that sets weight cathegory based on bmi value
        public string WeightCathegory()
        {
            double bmi = CalculateBMI(); //gets bmi value from calculateBMI method
            string cathegory = string.Empty;
            //strings the weight cathegory based on the BMI and outputs the current weight cathegory
            // example, both the example BMIs from above (27.78 and 27.89) will give out the cathrgory "Overweight (Pre-Obesity)"
            if (bmi < 18.5)
            {
                cathegory = "Underweight";
            }
            else if (bmi <= 24.9)
            {
                cathegory = "Normal weight";
            }
            else if (bmi <= 29.9)
            {
                cathegory = "Overweight (Pre-Obesity)";
            }
            else if (bmi <= 34.9)
            {
                cathegory = "Overweight (Obesity class I";
            }
            else if (bmi <= 39.9)
            {
                cathegory = "Overweight (Obesity class II";
            }
            else if (bmi > 40)
            {
                cathegory = "Overweight (Obesity class III";
            }
             return cathegory;
        }
    }
}
