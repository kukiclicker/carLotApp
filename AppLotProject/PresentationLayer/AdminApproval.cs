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
    public partial class AdminApproval : Form
    {
        public static EmployeeBusiness employeeBusiness = new EmployeeBusiness();
        public List<Employee> employees = employeeBusiness.GetAllEmployees();
        public Employee newEmployee;
        public AdminApproval(Employee newEmployee)
        {

            InitializeComponent();
            this.newEmployee = newEmployee; 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AdminApproval_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_MouseClick(object sender, MouseEventArgs e)
        {
            Employee admin = (Employee)employees.Where(x => x.UserName == textBoxUsername.Text).First();
            if(admin.Password == textBoxPassword.Text && admin.Role.ToLower() =="admin"|| admin.Role.ToLower() == "administrator")
            {
                employeeBusiness.InsertEmployee(newEmployee);
                MessageBox.Show("New employee added successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Either user is not admin or you have entered a wrong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
