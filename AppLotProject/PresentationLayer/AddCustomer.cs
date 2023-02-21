using BusinessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AddCustomer : Form
    {
        public static CustomerBusiness customerBusiness = new CustomerBusiness();
        public static SaleBusiness saleBusiness = new SaleBusiness();
        public static int carID;
        public static int employeeID;
        public AddCustomer(int carID, int employeeID)
        {
            InitializeComponent();
            carID = carID;
            employeeID = employeeID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxJMBG.Text != "" && textBoxFirstName.Text != "" &&
               textBoxLastName.Text != "" && textBoxPhoneNumber.Text != "")
            { 
                Customer customer = new Customer
                {
                    JMBG = textBoxJMBG.Text,
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    PhoneNumber = textBoxPhoneNumber.Text
                };
                customerBusiness.InsertCustomer(customer);
                Sale sale = new Sale
                {
                    SaleDate = DateTime.Now.ToString(),
                    Employee = employeeID,
                    Car = carID,
                    Customer = textBoxJMBG.Text
                };
                saleBusiness.InsertSale(sale);
            }
            else
            {
                MessageBox.Show("All fields must be filled. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
