using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BillManagement
{
    public partial class Form2 : Form
    {
        SqlConnection con;

        public Form2()
        {
            InitializeComponent();
            lblGH.Visible = false;
            cmbSVal.Text = "Vehicle Number";

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            //con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.Combine(Application.StartupPath, "Data\\Database.mdf") + "; Integrated Security=True");

        }

        private void loadData()
        {
            try
            {
                con.Open();
                string query = "Select * From dbo.[Order]";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    dgvSResult.DataSource = ds.Tables[0];
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No Oder Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void searchData(string column, string value)
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM dbo.[Order] WHERE " + column + " = '" + value + "';";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    dgvSResult.DataSource = ds.Tables[0];
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No Oder Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtSearch.Text == "")
                {
                    MessageBox.Show("Please enter Vehicle Number or Invoice Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (dgvOrderItems.RowCount >= 0)
                    {
                        dgvOrderItems.DataSource = null;
                    }

                    string str = txtSearch.Text;

                    if (cmbSVal.Text == "Vehicle Number")
                    {
                        searchData("VehicleNo", str);
                    }
                    else if (cmbSVal.Text == "Invoice Number")
                    {
                        searchData("InvoiceNo", str);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSVal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSVal.Text == "Vehicle Number")
                {
                    lblGH.Visible = false;
                }
                else if (cmbSVal.Text == "Invoice Number")
                {
                    lblGH.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {
                loadData();

                if (dgvOrderItems.RowCount >= 0)
                {
                    dgvOrderItems.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSResult_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvSResult.Rows[e.RowIndex];
                    String invoiceNo = row.Cells[0].Value.ToString();
                    
                    if(invoiceNo != "")
                    {
                        con.Open();
                        string query = "Select * From dbo.[OrderItem] Where InvoiceNo = " + invoiceNo;
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                        SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                        var ds = new DataSet();
                        sda.Fill(ds);
                        dgvOrderItems.DataSource = ds.Tables[0];
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("No data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
