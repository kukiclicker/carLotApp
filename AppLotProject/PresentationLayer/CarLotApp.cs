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
    public partial class CarLotApp : Form
    {
        public static CarBusiness carBusiness = new CarBusiness();
        public static BindingList<Car> cars = new BindingList<Car>(carBusiness.GetAllCars());

        public CarLotApp()
        {
            InitializeComponent();
            dataGridViewAvailableCars.DataSource= cars;
        }

        private void CarLotApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void radioButtonModel_CheckedChanged(object sender, EventArgs e)
        {
            //TO-DO implement sorting for each radiobutton checked
            if(radioButtonModel.Checked)
            {
                
            }
            else if(radioButtonMileage.Checked)
            {

            }
            else if (radioButtonPrice.Checked)
            {

            }
            //year checked
            else
            {

            }

        }

       
    }
}
