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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            btnX.ForeColor = Color.Snow;
        }
    }
}
