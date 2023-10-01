using BusinessLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace PresentationLayer
{
    public partial class CarLotApp : Form
    {
        public static Employee loggedUser;
        public static BindingList<Car> cars;

        public static ICarBusiness carBusiness;
        public static IEmployeeBusiness employeeBusiness;
        public static ISaleBusiness saleBusiness;
        public static ICustomerBusiness customerBusiness;

        DataGridViewRow selectedRow=null;
        public CarLotApp(Employee emp, ICarBusiness _carBusiness,IEmployeeBusiness _employeeBusiness
            , ISaleBusiness _saleBusiness, ICustomerBusiness _customerBusiness)
        {
            carBusiness = _carBusiness;
            employeeBusiness = _employeeBusiness;
            saleBusiness = _saleBusiness;
            customerBusiness = _customerBusiness;

            cars = new BindingList<Car>(_carBusiness.GetAvailableCars());
            loggedUser = emp;
            InitializeComponent();
            buttonLoanCar.Enabled = false;
            buttonSellCar.Enabled = false;
            dataGridViewAvailableCars.DataSource= cars;
            menuStrip1.Width = this.Width;
            //calling function to check a role of the user
            userMode(emp.Role.ToLower());
            
        }
        public void userMode(string role)
        {
            switch(role)
            {
                case "administrator":
                    buttonSellCar.Visible = true;
                    buttonLoanCar.Visible = true;
                    addCarToolStripMenuItem.Visible = true; 
                    break;
                case "car sales":
                    buttonSellCar.Visible = true;
                    buttonLoanCar.Visible = true;
                    addCarToolStripMenuItem.Visible = true;
                    break;
                case "admin":
                    buttonSellCar.Visible = true;
                    buttonLoanCar.Visible = true;
                    addCarToolStripMenuItem.Visible = true;
                    break;
                    //more roles to be defined... 
            }
            
        }

        private void CarLotApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //TO-DO implement search to take more arguments
            dataGridViewAvailableCars.DataSource = carBusiness.FindCars(textBoxSearch.Text.ToLower());
        }

        private void radioButtonYear_Click(object sender, EventArgs e)
        {
            dataGridViewAvailableCars.DataSource = cars.OrderBy(car => car.Year).ToList();
        }

        private void radioButtonMileage_Click(object sender, EventArgs e)
        {
            dataGridViewAvailableCars.DataSource = cars.OrderBy(car => car.Mileage.ToString()).ToList();
        }

        private void radioButtonModel_Click(object sender, EventArgs e)
        {
            dataGridViewAvailableCars.DataSource = cars.OrderBy(car => car.Model).ToList();
        }

        private void radioButtonPrice_Click(object sender, EventArgs e)
        {
            dataGridViewAvailableCars.DataSource = cars.OrderBy(car => car.Price).ToList();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm(carBusiness, employeeBusiness,saleBusiness,customerBusiness);
            this.Hide();
            logInForm.ShowDialog();
        }
        private void dataGridViewAvailableCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //getting selected rows
            if (dataGridViewAvailableCars.SelectedRows.Count > 0)
            {
                //saving index of selected row and selected row in variables
                int selectedRowIndex = dataGridViewAvailableCars.SelectedRows[0].Index;
                selectedRow = dataGridViewAvailableCars.Rows[selectedRowIndex];
                buttonLoanCar.Enabled = true;
                buttonSellCar.Enabled = true;
            }
            else
            {
                buttonLoanCar.Enabled = false;
                buttonSellCar.Enabled = false;
            }
        }
        private void buttonSellCar_Click(object sender, EventArgs e)
        {
            try
            {
                int carID = Convert.ToInt32(selectedRow.Cells["CarID"].Value.ToString().Trim());
                string model = selectedRow.Cells["Model"].Value.ToString();
                string year = selectedRow.Cells["Year"].Value.ToString();
                DialogResult result = MessageBox.Show($"Are you sure you want to sell {model} {year} ?"
                    , "Confirm"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    new AddCustomer(carID, loggedUser.EmployeeID,saleBusiness,customerBusiness,carBusiness)
                        .ShowDialog();
                    
                    refreshDataGrid();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("You must select car you want to sell!"
                    ,"Error"
                    ,MessageBoxButtons.OK
                    ,MessageBoxIcon.Error);
            }

        }
        private void buttonLoanCar_Click(object sender, EventArgs e)
        {
            try
            {
                int carID = Convert.ToInt32(selectedRow
                    .Cells["CarID"]
                    .Value
                    .ToString()
                    .Trim());
                string model = selectedRow.Cells["Model"].Value.ToString();
                string year = selectedRow.Cells["Year"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you loan {model} {year}?"
                 ,"Confirm"
                 ,MessageBoxButtons.YesNo
                 ,MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    carBusiness.LoanCar(carID);
                    refreshDataGrid();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("You must select car you want to loan!"
                    ,"Error"
                    ,MessageBoxButtons.OK
                    ,MessageBoxIcon.Error);
            }

        }
        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Registration(employeeBusiness).Show();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DeleteEmployee(employeeBusiness).Show();
        }

        private void addCarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AddCar(carBusiness).Show();
        }

        private void CarLotApp_MouseClick(object sender, MouseEventArgs e)
        {
            refreshDataGrid();
        }
        private void refreshDataGrid()
        {
            cars = new BindingList<Car>(carBusiness.GetAvailableCars());
            dataGridViewAvailableCars.DataSource = cars;
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Sales(saleBusiness).ShowDialog();
        }

        private void CarLotApp_Load(object sender, EventArgs e)
        {

        }
    }
}
