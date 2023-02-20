using BusinessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        public static Employee loggedUser;
        public static CarBusiness carBusiness = new CarBusiness();
        public static BindingList<Car> cars = new BindingList<Car>(carBusiness.GetAvailableCars());
        DataGridViewRow selectedRow;
        public CarLotApp(Employee emp)
        {
            loggedUser = emp;
            InitializeComponent();
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
                //more roles to be defined... 
            }
            
        }

        private void CarLotApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            LogInForm logInForm = new LogInForm();
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
            }

        }

        private void buttonSellCar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to sell " + selectedRow.Cells["Model"].Value.ToString() +" "+ selectedRow.Cells["Year"].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                carBusiness.SellCar(Convert.ToInt32(selectedRow.Cells["CarID"].Value));
                cars = new BindingList<Car>(carBusiness.GetAvailableCars());
                dataGridViewAvailableCars.DataSource = cars;
            }
        }

        private void buttonLoanCar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you loan " + selectedRow.Cells["Model"].Value.ToString() +" "+ selectedRow.Cells["Year"].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                carBusiness.LoanCar(Convert.ToInt32(selectedRow.Cells["CarID"].Value));
                cars = new BindingList<Car>(carBusiness.GetAvailableCars());
                dataGridViewAvailableCars.DataSource = cars;
            }
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Registration().Show();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DeleteEmployee().Show();
        }
    }
}
