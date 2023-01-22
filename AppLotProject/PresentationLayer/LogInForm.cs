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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            
        }

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

        private void textBoxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPassword.Text = "";
            textBoxPassword.ForeColor = Color.Snow;

        }

        private void textBoxUsername_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxUsername.ForeColor = Color.Snow;
        }
    }
}
