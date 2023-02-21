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
        public static int carId;
        public static int loggedEmployee;
        public AddCustomer(int carID, int employeeID)
        {
            InitializeComponent();
            carId = carID;
            loggedEmployee = employeeID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxJMBG.Text == "" || textBoxFirstName.Text == "" ||
                   textBoxLastName.Text == "" || textBoxPhoneNumber.Text == "")
                {
                    MessageBox.Show("All fields must be filled. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxJMBG.Text.Length != 13)
                {
                    MessageBox.Show("Error! JMBG must consist of 13 numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Customer customer = new Customer
                    {
                        JMBG = textBoxJMBG.Text,
                        FirstName = textBoxFirstName.Text,
                        LastName = textBoxLastName.Text,
                        PhoneNumber = textBoxPhoneNumber.Text
                    };
                    customerBusiness.InsertCustomer(customer);
                    Sale sale = new Sale();
                    sale.SaleDate = DateTime.Now.ToString();
                    sale.Employee = loggedEmployee;
                    sale.Car = carId;
                    sale.Customer = textBoxJMBG.Text;

                    saleBusiness.InsertSale(sale);
                    MessageBox.Show("Car sold!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception exc)
            {

            }

        }
            
        }
    }

