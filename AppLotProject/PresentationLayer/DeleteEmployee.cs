using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class DeleteEmployee : Form
    {
        public static IEmployeeBusiness employeeBusiness;
        public static List<Employee> employees;
        DataGridViewRow selectedRow = null; 
        public DeleteEmployee(IEmployeeBusiness _employeeBusiness)
        {
            InitializeComponent();
            employeeBusiness = _employeeBusiness;
            RefreshEmployeeGrid();
            buttonDeleteEmp.Enabled = false;
        }

        private void buttonDeleteEmp_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeID;
                if (selectedRow != null)
                {
                    employeeID = Convert.ToInt32(selectedRow
                    .Cells["EmployeeID"]
                    .Value
                    .ToString()
                    .Trim());
                    
                    DeleteEmployeeByID(employeeID);
                }
                else 
                {
                    employeeID = Convert.ToInt32(textBoxEmployeeIDForDeletion.Text);
                    selectedRow.Cells.Clear();
                    DeleteEmployeeByID(employeeID);
                    
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("" + exc.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        private void RefreshEmployeeGrid()
        {
            employees = employeeBusiness.GetAllEmployees();
            dataGridViewEmployees.DataSource = employees;
        }
        private void DeleteEmployeeByID(int employeeID)
        {
            try
            {
                Employee employee = employeeBusiness.GetEmployee(employeeID);
                string fullName = $"{employee.Name} {employee.LastName}";

                DialogResult result = MessageBox.Show($"Are you sure you want to delete employee {fullName} with ID: {employeeID} ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    employeeBusiness.DeleteEmployee(employeeID);
                    MessageBox.Show("Employee successfuly deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshEmployeeGrid();
                    textBoxEmployeeIDForDeletion.Text = "";

                }
            }
            catch(Exception e)
            {
                MessageBox.Show($"Employee with id {employeeID} doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBoxEmployeeIDForDeletion_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxEmployeeIDForDeletion.Text.Equals(""))
            {
                buttonDeleteEmp.Enabled = true;
            }
            else
            {
                buttonDeleteEmp.Enabled = false;
            }
        }

        private void dataGridViewEmployees_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewEmployees.SelectedRows[0].Index;
                selectedRow = dataGridViewEmployees.Rows[selectedRowIndex];
                buttonDeleteEmp.Enabled = true;
                textBoxEmployeeIDForDeletion.Text = (selectedRowIndex+1).ToString();
            }
            else
            {
                buttonDeleteEmp.Enabled = false;
            }
        }
    }
}
