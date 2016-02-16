using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;


namespace Lab5
{
    public partial class frm_Lab5 : Form
    {
        //CLASS VARS
        private string vehicleMake;
        private ushort vehicleYear;
        private string vehicleColor;
        private decimal vehiclePrice;
        private string vehicleInfo;
        bool userInputVerified = false;

        public frm_Lab5()
        {
            InitializeComponent();
            //initialize vehicle display
            Lab5.Car.VehicleInitializer initialVehicle;
            initialVehicle = new Lab5.Car.VehicleInitializer();
            txtInfo.Text = initialVehicle.Show();
            // separator bevel line
            lbl_Bevel.AutoSize = false;
            lbl_Bevel.Height = 2;
            lbl_Bevel.BorderStyle = BorderStyle.Fixed3D;
            lbl_Bevel.Width = 556;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            StatusText = "";//clear status display

            Car PolyMorphCar = new Car(vehicleMake, vehicleYear, vehicleColor, vehiclePrice);

            if(txtMake.Text == "" && txtPrice.Text == "" && txtYear.Text == "" && txtColor.Text == ""){
                SubmitWithNoDataDefault();//if nothing is entered, return default data

                PolyMorphCar = new Car(vehicleMake, vehicleYear, vehicleColor, vehiclePrice);
                txtInfo.Text = PolyMorphCar.GetCarInfo().ToString();
                StatusText = "Default Car: ";
                StatusText += PolyMorphCar.GetCarInfo().ToString();
            }
            else
            {
                SubmitWithUserData(); //get user input, assign to variables
                string horsePower = txtBox_Horsepower.Text;
                
                //Car Poly;
                if (rdbYes.Checked == true)
                {
                    PolyMorphCar = new SportsCar(vehicleMake, vehicleYear, vehicleColor, vehiclePrice, horsePower);
                    txtInfo.Text = PolyMorphCar.GetCarInfo().ToString();
                    StatusText = "Sports Car: " + PolyMorphCar.GetCarInfo().ToString();
                    //StatusText += " " + PolyMorphCar.GetCarInfo();
                }
                else //rdbNo is selected
                {
                    PolyMorphCar = new Car(vehicleMake, vehicleYear, vehicleColor, vehiclePrice);
                    txtInfo.Text = PolyMorphCar.GetCarInfo().ToString();
                    StatusText = "Regular Car: " + PolyMorphCar.GetCarInfo().ToString();
                    //StatusText += " " + PolyMorphCar.GetCarInfo();
                }
            }

            

        }//END btn_Submit

        private void SubmitWithUserData()
        {
            TestUserInputForNumber(txtYear.Text, txtPrice.Text);//test for numeric-only data requirement, set flag

            if (userInputVerified == false)
            {
                StatusText = "WARNING: Please enter numeric data only.";
                FocusSetToYear();
            }
            else if (userInputVerified == true)
            {
                vehicleYear = Convert.ToUInt16(txtYear.Text); vehiclePrice = Convert.ToDecimal(txtPrice.Text);
                vehicleMake = txtMake.Text;
                vehicleColor = txtColor.Text;
                //vehicleInfo = vehicleMake + " | " + vehicleYear + " | " + vehicleColor + " | " + FormatMoney(vehiclePrice);
                //txtInfo.Text = vehicleInfo;
            }   
        }

        private void TestUserInputForNumber(string userTextYear, string userTextPrice)
        {
            int integerTest;
            decimal decimalTest;
            if (!Int32.TryParse(userTextYear, out integerTest) || (!Decimal.TryParse(userTextPrice, out decimalTest)))
            {
                userInputVerified = false;             
            }
            else
            {
                userInputVerified = true;                
            }
        }

        private string StatusText
        {
            get { return toolStripStatusLabel1.Text; }
            set { toolStripStatusLabel1.Text = value; }
        }
        
        private void SubmitWithNoDataDefault()
        { 
            //default txtInfo: Ford, 2004, Red and 30000 // this can also be polymorphism consider creating new class to do this.
            StatusText = "Default data provided. Please enter your own data.";
            vehicleMake = "Ford";
            vehicleYear = 2004;
            vehicleColor = "Red";
            vehiclePrice = 30000;

            txtMake.Text = vehicleMake;
            txtYear.Text = Convert.ToString(vehicleYear);
            txtColor.Text = vehicleColor;
            txtPrice.Text = Convert.ToString(FormatMoney(vehiclePrice));
            //txtInfo.Text = vehicleMake + " | " + vehicleYear + " | " + vehicleColor + " | " + Convert.ToString(FormatMoney(vehiclePrice)); //
        }

        private void FocusSetToYear()
        {
            txtYear.SelectAll();
            txtYear.Focus();
        }

        public static string FormatMoney(Decimal d)
        {
            //http://www.howtogeek.com/howto/programming/format-a-string-as-currency-in-c/
            return String.Format(CultureInfo.CreateSpecificCulture("en-us"), "{0:C}", d);
        }

        private void rdbYes_Click(object sender, EventArgs e)
        {
            lbl_Horsepower.Visible = true;
            txtBox_Horsepower.Visible = true;
        }

    }//END CLASS frm_Lab5



}//END namespace


//Additonal resources
/*
 * //http://stackoverflow.com/questions/5395630/how-to-validate-user-input-for-whether-its-an-integer
 *
 * 
*/