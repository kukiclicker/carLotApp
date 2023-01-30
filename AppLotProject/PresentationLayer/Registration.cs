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
    }
}
