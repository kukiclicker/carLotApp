using BusinessLayer;
using Shared.Interfaces;
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
    public partial class DeleteEmployee : Form
    {
        public static IEmployeeBusiness employeeBusiness;
        public static List<Employee> employees;
        DataGridViewRow selectedRow = null; 
        public DeleteEmployee(IEmployeeBusiness _employeeBusiness)
        {
            InitializeComponent();
            employeeBusiness = _employeeBusiness;
            employees = employeeBusiness.GetAllEmployees();
            dataGridViewEmployees.DataSource = employees;
            buttonDeleteEmp.Enabled = false;
        }

        private void buttonDeleteEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow != null)
                {
                    int employeeID = Convert.ToInt32(selectedRow
                    .Cells["EmployeeID"]
                    .Value
                    .ToString()
                    .Trim());
                    employeeBusiness.DeleteEmployee(employeeID);
                }
                else
                {
                    Employee empToBeDeleted = employees.Where(x => x.EmployeeID == Convert.ToInt32(textBoxEmployeeIDForDeletion.Text)).FirstOrDefault();
                    //cheking if employee with given ID exists in db
                    if (empToBeDeleted != null)
                    {
                        
                        DialogResult result = MessageBox.Show("Are you sure you want to delete employee " + empToBeDeleted.Name + " " + empToBeDeleted.LastName + " with ID: " + empToBeDeleted.EmployeeID + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            employeeBusiness.DeleteEmployee(empToBeDeleted.EmployeeID);
                            MessageBox.Show("Employee successfuly deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        MessageBox.Show("You didn't select any employee or you provided Employee with non existent ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("" + exc.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            
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
            }
            else
            {
                buttonDeleteEmp.Enabled = false;
            }
        }

        
    }
}
