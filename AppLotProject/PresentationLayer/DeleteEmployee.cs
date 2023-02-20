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
    public partial class DeleteEmployee : Form
    {
        public static EmployeeBusiness employeeBusiness = new EmployeeBusiness();
        public static List<Employee> employees = employeeBusiness.GetAllEmployees();
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void buttonDeleteEmp_Click(object sender, EventArgs e)
        {
            try
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
                    MessageBox.Show("Employee with provided ID doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch(Exception exc)
            {
                MessageBox.Show("" + exc.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
