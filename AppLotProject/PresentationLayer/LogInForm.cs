using BusinessLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class LogInForm : Form
    {

       
        public static List<Employee> employees;

        public static IEmployeeBusiness employeeBusiness;
        public static ICarBusiness carBusiness;
        public static ISaleBusiness saleBusiness;
        public static ICustomerBusiness customerBusiness;
        public LogInForm(ICarBusiness _carBusiness,IEmployeeBusiness _employeeBusiness
            ,ISaleBusiness _saleBusiness, ICustomerBusiness _customerBusiness)
        {
            carBusiness = _carBusiness;
            employeeBusiness = _employeeBusiness;
            saleBusiness = _saleBusiness;
            customerBusiness = _customerBusiness;

            InitializeComponent();
            this.AcceptButton = btnLogIn;
        }
        //X button for closing application
        private void btnX_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void btnX_MouseEnter(object sender, EventArgs e)
        {
            btnX.ForeColor = Color.OrangeRed;
        }

        private void btnX_MouseLeave(object sender, EventArgs e)
        {
            btnX.ForeColor = Color.Black;
        }
        private void btnLogIn_MouseClick(object sender, MouseEventArgs e)
        {
            employees = employeeBusiness.GetAllEmployees();
            if (textBoxUsername.Text =="" || textBoxPassword.Text == "" 
                || textBoxUsername.Text =="Enter your username:" || textBoxPassword.Text =="Enter the password")
            {
                MessageBox.Show("All fields must be filled. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //checking if employee with inserted credentials exists in database
                if(employees.Where(emp => emp.UserName.Equals(textBoxUsername.Text) && emp.Password.Equals(textBoxPassword.Text)).Count()==0)
                {
                    MessageBox.Show("Incorrect username or password.Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Login successful!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Employee loggedEmployee = (Employee)employees.Where(emp => emp.UserName.Equals(textBoxUsername.Text)).FirstOrDefault();
                    //running main application form
                    new CarLotApp(loggedEmployee, carBusiness,employeeBusiness,saleBusiness,customerBusiness).Show();
                }

            }
        }
        //running register form on click of the button 
        private void btnRegister_MouseClick(object sender, MouseEventArgs e)
        {
            new Registration(employeeBusiness).Show();
        }

        //making password visible/invisible
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = checkBoxShowPassword.Checked ? false : true;
        }
    }
}
