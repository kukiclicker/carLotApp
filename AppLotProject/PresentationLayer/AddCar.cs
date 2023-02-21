using BusinessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AddCar : Form
    {
        public CarBusiness carBusiness = new CarBusiness();
        public AddCar()
        {
            InitializeComponent();
            //setting datetimepicker to be only for years 
            dateTimePickerYear.CustomFormat = "yyyy";
            dateTimePickerYear.ShowUpDown = true;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            try
            {
                if(textBoxModel.Text == "" || textBoxType.Text == "" || comboBoxCarBody.Text == "" ||
                   comboBoxFuel.Text == "" || textBoxEngine.Text == "" || comboBoxTransmission.Text == ""||
                   textBoxMileage.Text == "" || textBoxColor.Text == "" || textBoxPrice.Text == "" ||
                   comboBoxCondition.Text == "")
                {
                    MessageBox.Show("All fields except description must be filled. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    car.Model = textBoxModel.Text;
                    car.Type = textBoxType.Text;
                    car.Year = Convert.ToInt32(dateTimePickerYear.Value.Year.ToString());
                    car.CarBody = comboBoxCarBody.Text;
                    car.Fuel = comboBoxFuel.Text;
                    car.Engine = textBoxEngine.Text;
                    car.Transmission = comboBoxTransmission.Text;
                    car.Mileage = textBoxMileage.Text;
                    car.Color = textBoxColor.Text;
                    car.Price = Convert.ToDouble(textBoxPrice.Text);
                    car.Description = textBoxDescription.Text;
                    car.Condition = comboBoxCondition.Text;
                    car.Status = "AVAILABLE";
                    carBusiness.InsertCar(car);
                    //calling function to clear fields for the next addition
                    clearFields();
                    MessageBox.Show("Car added successfuly", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch(Exception exc)
            {
                //TO-DO Exception handling
            }
        }

        private void clearFields()
        {
            textBoxModel.Text="";
            textBoxType.Text ="";
            comboBoxCarBody.Text="";
            comboBoxFuel.Text = "";
            textBoxEngine.Text = "";
            comboBoxTransmission.Text = "";
            textBoxMileage.Text = "";
            textBoxColor.Text = "";
            textBoxPrice.Text = "";
            textBoxDescription.Text = "";
            comboBoxCondition.Text = "";
        }
    }
}
