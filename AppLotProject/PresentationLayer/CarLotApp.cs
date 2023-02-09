﻿using BusinessLayer;
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
    public partial class CarLotApp : Form
    {
        public static CarBusiness carBusiness = new CarBusiness();
        public static List<Car> cars = carBusiness.GetAllCars();
        public CarLotApp()
        {
            InitializeComponent();
            dataGridViewAvailableCars.DataSource= cars;
        }

        private void CarLotApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
