using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace BillManagement
{
    public partial class Form1 : Form
    {
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false; 
        bool bNewPage = false;
        int iHeaderHeight = 0;
        SqlConnection con;

        int ID;

        public Form1()
        {
            InitializeComponent();
            
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            //con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.Combine(Application.StartupPath, "Data\\Database.mdf") + "; Integrated Security=True");
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            initialize();
            createInvoiceNo();
        }

        private void createInvoiceNo()
        {
            try
            {
                con.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("SELECT TOP(1) InvoiceNo FROM dbo.[Order] ORDER BY InvoiceNo DESC", con);
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        ID = Int32.Parse(myReader["InvoiceNo"].ToString());
                        ID += 1;
                    }
                }
                else
                {
                    ID = 1;
                }

                lblInvoiceNo.Text = ID.ToString();
                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void insertData()
        {
            try
            {
                int itemcount = dgvItemList.Rows.Count - 1;

                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO  dbo.[Order](Cus_Name, VehicleNo, Mileage, Remark, TotalPrice, ItemCount, IssueDate) " + " VALUES ('" + txtCName.Text + "','" + txtVNo.Text + "','" + txtMilage.Text + "','" + txtRemark.Text + "','" + txtTotal.Text + "','" + itemcount + "','" + txtDate.Text + "')", con);

                int i = command.ExecuteNonQuery();

                if (i != 0)
                {
                    con.Close();
                    insertOrderItemsData();
                    //MessageBox.Show("Order Saved");
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Order not Saved", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertOrderItemsData()
        {
            try
            {
                con.Open();
                for (int r = 0; r < dgvItemList.Rows.Count; r++)
                {
                    if (dgvItemList.Rows[r].Cells["ItemCode"].Value != null)
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO  dbo.[OrderItem](InvoiceNo, ItemCode, Description, Quantity, UnitPrice) " + " VALUES ('" + lblInvoiceNo.Text + "','" + dgvItemList.Rows[r].Cells["ItemCode"].Value + "','" + dgvItemList.Rows[r].Cells["Description"].Value + "','" + dgvItemList.Rows[r].Cells["Quantity"].Value + "','" + dgvItemList.Rows[r].Cells["Price"].Value + "')", con);
                        int i = command.ExecuteNonQuery();

                        if (i != 0)
                        {
                            //MessageBox.Show("Item Saved " + dgvItemList.Rows[r].Cells["ItemCode"].Value, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            con.Close();
                            MessageBox.Show("Item not Saved", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void initialize()
        {
            try
            {
                txtDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
                dgvItemList.ReadOnly = true;
                this.dgvItemList.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.dgvItemList.Columns["SubT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(txtVNo.Text != "" && txtCName.Text != "")
            {
                
                if (txtMilage.Text != "")
                {
                    
                    if (txtTotal.Text != "")
                    {

                        int itemcount = dgvItemList.Rows.Count - 1;

                        if(itemcount != 0)
                        {
                            insertData();
                            printData();
                            MessageBox.Show("Order Saved and Printed Successfully", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();
                        }
                        else
                        {
                            MessageBox.Show("Please add items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please add items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Milage", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter Customer's Name and Vehicle No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItemCode.Text != "")
            {

                if (txtQuantity.Text != "")
                {

                    if (txtPrice.Text != "")
                    {
                        if (txtIDesc.Text != "")
                        {
                            dgvItemList.Rows.Add(txtItemCode.Text, txtIDesc.Text, txtQuantity.Text, txtPrice.Text);
                            updateBalance();
                            clearItem();
                        }
                        else
                        {
                            dgvItemList.Rows.Add(txtItemCode.Text, " - ", txtQuantity.Text, txtPrice.Text);
                            updateBalance();
                            clearItem();
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Please enter Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter Item Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(dgvItemList.Rows.Count > 1 && dgvItemList.Rows != null)
            {
                int rowIndex = dgvItemList.CurrentCell.RowIndex;
                dgvItemList.Rows.RemoveAt(rowIndex);
                updateBalance();
            }
            else
            {
                MessageBox.Show("Please select a row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void updateBalance()
        {
            try
            {
                int counter;
                double balance = 0;
                int quantity;
                double price;
                
                for (counter = 0; counter < (dgvItemList.Rows.Count -1 ); counter++)
                {
                    quantity = 0;
                    price = 0;
                    
                    if (dgvItemList.Rows[counter].Cells["Quantity"].Value.ToString().Length != 0)
                    {
                        quantity = int.Parse(dgvItemList.Rows[counter].Cells["Quantity"].Value.ToString());
                    }
                    
                    if (dgvItemList.Rows[counter].Cells["Price"].Value.ToString().Length != 0)
                    {
                        price = double.Parse(dgvItemList.Rows[counter].Cells["Price"].Value.ToString());
                    }

                    double subT = quantity * price;

                    dgvItemList.Rows[counter].Cells["SubT"].Value = subT;

                    balance += subT;
                    txtTotal.Text =(balance).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clearItem()
        {
            txtItemCode.ResetText();
            txtQuantity.ResetText();
            txtPrice.ResetText();
            txtIDesc.ResetText();
        }

        private void clear()
        {
            clearItem();
            txtVNo.ResetText();
            txtMilage.ResetText();
            txtRemark.ResetText();
            txtTotal.ResetText();
            dgvItemList.Rows.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            try
            {
                e.Graphics.DrawString("Galle Hybrid", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(85, 30));
                //e.Graphics.DrawString("Tel", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 70));
                //e.Graphics.DrawString(": 0772945510/ 0753331279/ 0763331279", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(140, 70));
                e.Graphics.DrawString("Address: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(90, 70));
                //e.Graphics.DrawString("Email", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 90));
                //e.Graphics.DrawString(": Pdsghd@gmail.com", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(140, 90));
                e.Graphics.DrawString("Tel: 0772945510/ 0753331279/ 0763331279 / Email: Pdsghd@gmail.com", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(90, 90));
                e.Graphics.DrawString("INVOICE", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(e.MarginBounds.Left + 280, 120));


                e.Graphics.DrawString("_______________________________________________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 130));

                e.Graphics.DrawString("Customer", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(100, 160));
                e.Graphics.DrawString(": " + txtCName.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(180, 160));
                e.Graphics.DrawString("Remark", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(100, 180));
                e.Graphics.DrawString(": " + txtRemark.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(180, 180));
                e.Graphics.DrawString("Vehicle No", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(450, 160));
                e.Graphics.DrawString(": " + txtVNo.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(580, 160));
                e.Graphics.DrawString("Mileage (Km)", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(450, 180));
                e.Graphics.DrawString(": " + txtMilage.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(580, 180));
                e.Graphics.DrawString("Invoice Number", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(450, 200));
                e.Graphics.DrawString(": GH" + lblInvoiceNo.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(580, 200));


                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dgvItemList.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= dgvItemList.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dgvItemList.Rows[iRow];
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            e.Graphics.DrawString("Bill Summary", new Font(dgvItemList.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, 250 -
                                    e.Graphics.MeasureString("Bill Summary", new Font(dgvItemList.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new Font("Arial", 10, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(dgvItemList.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), 80 -
                                    e.Graphics.MeasureString("Bill Summary", new Font(new Font(dgvItemList.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            iTopMargin = 245;
                            foreach (DataGridViewColumn GridCol in dgvItemList.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], 550));

                                if(GridCol.HeaderText == "Amount (Rs)")
                                {
                                    e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin + 550,
                                    (int)arrColumnWidths[iCount], iHeaderHeight + 5));
                                }
                                

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        if(dgvItemList.Rows.Count - 1 > 0)
                        {
                            foreach (DataGridViewCell Cel in GridRow.Cells)
                            {
                                if (Cel.Value != null)
                                {
                                    e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                                new SolidBrush(Cel.InheritedStyle.ForeColor),
                                                new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                                (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                                }

                                //e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                                iCount++;
                            }
                        }
                                       
                        
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;

                e.Graphics.DrawString("Total (Rs)", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(520,798));

                e.Graphics.DrawString(txtTotal.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black,
                                                new RectangleF(619, 798,
                                                130, (float)iCellHeight), strFormat);

                //e.Graphics.DrawRectangle(Pens.Black, new Rectangle(619, 795, 130, iCellHeight));
                
                e.Graphics.DrawString("Customer :- ..........................", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(e.MarginBounds.Left, e.MarginBounds.Bottom - 20));
                e.Graphics.DrawString("Issued by :- ..........................", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(e.MarginBounds.Right - 200, e.MarginBounds.Bottom - 20));

                e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(0, e.MarginBounds.Bottom + 10));

                e.Graphics.DrawString("Thank you!", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(e.MarginBounds.Left + 275, e.MarginBounds.Bottom + 30));

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void printData()
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;

            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Bill-" + lblInvoiceNo.Text;
                printDocument1.Print();
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Center;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dgvItemList.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Panel panel = new Panel();
                this.Controls.Add(panel);
                Graphics grp = panel.CreateGraphics();
                Size formSize = this.ClientSize;
                Point panelLocation = PointToScreen(panel.Location);
                grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnViewOders_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 frm1 = new Form2();
                frm1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
