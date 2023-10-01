
using Shared.Interfaces;
using Shared.Models;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Sales : Form
    {
        public static ISaleBusiness saleBusiness;
        public static BindingList<Sale> sales;
        public static DataGridViewRow selectedRow;
        public static int saleID;
        public Sales(ISaleBusiness _saleBusiness)
        {
            saleBusiness = _saleBusiness;
            InitializeComponent();
            refreshDataGrid();
        }

        private void dataGridViewSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSale.SelectedRows.Count > 0)
            {
                selectedRow= dataGridViewSale.SelectedRows[0];
                saleID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                Sale sale = saleBusiness
                    .GetAllSales()
                    .Where(x => x.SaleID.Equals(saleID))
                    .FirstOrDefault();
                textBoxCarID.Text = sale.Car.ToString();
                textBoxCustomerID.Text = sale.Customer;
                textBoxEmployeeID.Text = sale.Employee.ToString();
                dateTimePicker1.Value = sale.SaleDate;

            }

        }
        private void buttonDeleteSale_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete sale with ID: "
                    +saleID
                    ,"Confirm"
                    ,MessageBoxButtons.YesNo
                    ,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    saleBusiness.DeleteSale(saleID);
                    MessageBox.Show("Sale deleted successfully!"
                        ,"Info"
                        ,MessageBoxButtons.OK
                        ,MessageBoxIcon.Information);
                    refreshDataGrid();
                    clearFields();
                }
            }
            catch(Exception exc)
            {

            }
        }

        private void refreshDataGrid()
        {
           sales = new BindingList<Sale>(saleBusiness
               .GetAllSales());
           dataGridViewSale.DataSource = sales;
        }
        private void clearFields()
        {
            textBoxCarID.Text = "";
            textBoxCustomerID.Text = "";
            textBoxEmployeeID.Text = "";
         
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            if (isFieldsEmpty())
            {
                try
                {

                    saleBusiness.InsertSale(getSale());
                    MessageBox.Show("New sale added successfully!"
                        , "Info"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    refreshDataGrid();
                    clearFields();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error occured while inserting the sale! " +
                        "Check if you've entered existing car, employee and customer jmbg!" 
                        + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool isFieldsEmpty()
        {
            if (textBoxCarID.Text == "" 
                || textBoxCustomerID.Text == "" 
                || textBoxEmployeeID.Text == "")
            {
                MessageBox.Show("All fields must be filled!"
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return false; 
            }
            return true;    
        }

        private void buttonUpdateSale_Click(object sender, EventArgs e)
        {
            if (isFieldsEmpty())
            {
                try
                {
                    Sale saleToUpdate = getSale();
                    saleToUpdate.SaleID = Convert.ToInt32(selectedRow
                        .Cells[0]
                        .Value
                        .ToString());
                    saleBusiness.UpdateSale(saleToUpdate);
                    refreshDataGrid();
                    clearFields();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error occured while updating the sale! " +
                        "Check if you've entered existing car, employee and customer jmbg!"
                        + exc.Message
                        , "Error"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
            }
        }
        private Sale getSale()
        {
            Sale sale = new Sale
            {
                SaleDate = dateTimePicker1.Value,
                Car = Convert.ToInt32(textBoxCarID.Text),
                Employee = Convert.ToInt32(textBoxEmployeeID.Text),
                Customer = textBoxCustomerID.Text
            };
            return sale;
        }
    }
}

