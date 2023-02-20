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
        public AddCar()
        {
            InitializeComponent();
            dateTimePickerYear.CustomFormat = "yyyy";
            dateTimePickerYear.ShowUpDown = true;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Model = textBoxModel.Text;
            car.Type = textBoxType.Text;
            car.Year = Convert.ToInt32(dateTimePickerYear.Value.ToString());
            car.CarBody = comboBoxCarBody.Text;
            car.Fuel = comboBoxFuel.Text;
            car.Description= textBoxDescription.Text;  
            
        }
    }
}
