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
    public partial class Registration : Form
    {
        public static EmployeeBusiness employeeBusiness = new EmployeeBusiness();
        public Registration()
        {
            InitializeComponent();
        }
        private void btnRegisterX_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void btnRegisterX_MouseEnter(object sender, EventArgs e)
        {
            btnRegisterX.ForeColor= Color.OrangeRed;
        }
        private void btnRegisterX_MouseLeave(object sender, EventArgs e)
        {
            btnRegisterX.ForeColor = Color.Snow;
        }
        //exiting registration form
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
            btnX.ForeColor = Color.Snow;
        }
        

        private void btnAddEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            //creating a new employee from the form
            Employee emp = new Employee
            {
                Name = textBoxName.Text,
                LastName = textBoxLastName.Text,
                Email = textBoxEmail.Text,
                Address = textBoxAddress.Text,
                Gender = radioButtonMale.Checked ? "male" : radioButtonFemale.Checked ? "female" : "",
                Password = textBoxPassword.Text,
                Role = comboBoxRole.Text,
                PhoneNumber = textBoxPhone.Text,
                UserName = textBoxUsername.Text
            };
            //checking if all fields are filled
            if(textBoxName.Text == "" || textBoxLastName.Text == "" || textBoxEmail.Text == ""
                || textBoxPhone.Text == "" || textBoxPassword.Text == "" || textBoxUsername.Text == ""
                || comboBoxRole.Text == "")
            {
                MessageBox.Show("All fields must be filled!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //checking if passwords match
            else if(!textBoxPassword.Text.Equals(textBoxConfirmPassword))
            {
                MessageBox.Show("Passwords doesnt match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.ForeColor = Color.Red;
                textBoxConfirmPassword.ForeColor = Color.Red;
            }
            //finally creating new employee in database
            else
            {
                //TO-DO: Admin password dialog; not all users are allowed to add new employees
                MessageBox.Show("New employee added successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                employeeBusiness.InsertEmployee(emp); //to be checked!
            }
        }

        private void textBoxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPassword.ForeColor = Color.SaddleBrown;
        }

        private void textBoxConfirmPassword_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxConfirmPassword.ForeColor = Color.SaddleBrown;
        }

        private void textBoxConfirmPassword_Enter(object sender, EventArgs e)
        {
            textBoxConfirmPassword.ForeColor = Color.SaddleBrown;

        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.ForeColor = Color.SaddleBrown;
        }
    }
}
