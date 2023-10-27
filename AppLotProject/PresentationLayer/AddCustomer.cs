using BusinessLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AddCustomer : Form
    {
        public static ICustomerBusiness customerBusiness;
        public static ISaleBusiness saleBusiness;
        public static ICarBusiness carBusiness;

        public static int carId;
        public static int loggedEmployee;
        public DataGridViewRow selectedRow;
        public AddCustomer(int carID, int employeeID,ISaleBusiness _saleBusiness
            ,ICustomerBusiness _customerBusiness, ICarBusiness _carBusiness)
        {
            InitializeComponent();
            saleBusiness = _saleBusiness;
            customerBusiness = _customerBusiness;
            carBusiness = _carBusiness;
            carId = carID;
            loggedEmployee = employeeID;
            dataGridViewExistingCustomers.DataSource = customerBusiness.GetAllCustomers();
        }

        private void btnSellToNewCustomer_click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxJMBG.Text == "" || textBoxFirstName.Text == "" ||
                   textBoxLastName.Text == "" || textBoxPhoneNumber.Text == "")
                {
                    MessageBox.Show("All fields must be filled. Try again!"
                        ,"Error"
                        ,MessageBoxButtons.OK
                        ,MessageBoxIcon.Error);
                }
                else if (textBoxJMBG.Text.Length != 13)
                {
                    MessageBox.Show("Error! JMBG must consist of 13 numbers!"
                        ,"Error"
                        ,MessageBoxButtons.OK
                        ,MessageBoxIcon.Error);
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
                    sale.SaleDate = DateTime.Now;
                    sale.Employee = loggedEmployee;
                    sale.Car = carId;
                    sale.Customer = textBoxJMBG.Text;

                    saleBusiness.InsertSale(sale);
                    carBusiness.SellCar(carId);
                    MessageBox.Show("Car sold!"
                        ,"Info"
                        ,MessageBoxButtons.OK
                        ,MessageBoxIcon.Information);
                    this.Close();
                    
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(""+exc.Message
                    ,"Error"
                    ,MessageBoxButtons.OK
                    ,MessageBoxIcon.Error);
            }

        }
        private void btnSellToExistingCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = customerBusiness
                    .GetAllCustomers()
                    .Where(x => x.JMBG == selectedRow.Cells["JMBG"].Value.ToString().Trim())
                    .FirstOrDefault();
                Sale sale = new Sale();
                sale.SaleDate = DateTime.Now;
                sale.Employee = loggedEmployee;
                sale.Car = carId;
                sale.Customer = customer.JMBG;
                saleBusiness.InsertSale(sale);
                carBusiness.SellCar(carId);
                MessageBox.Show("Car sold!"
                    ,"Info"
                    ,MessageBoxButtons.OK
                    ,MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("" + exc.Message
                    ,"Error"
                    ,MessageBoxButtons.OK
                    ,MessageBoxIcon.Error);
            }

        }

        private void dataGridViewExistingCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewExistingCustomers.SelectedRows.Count > 0)
            {
                //saving index of selected row and selected row in variables
                int selectedRowIndex = dataGridViewExistingCustomers
                    .SelectedRows[0]
                    .Index;
                selectedRow = dataGridViewExistingCustomers.Rows[selectedRowIndex];
            }

        }

    }
    }

