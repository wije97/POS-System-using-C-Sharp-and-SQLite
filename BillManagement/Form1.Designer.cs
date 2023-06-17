namespace BillManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtIDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnViewOders = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMilage = new System.Windows.Forms.TextBox();
            this.txtVNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtCName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.btnViewOders);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.dgvItemList);
            this.groupBox1.Controls.Add(this.lblInvoiceNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMilage);
            this.groupBox1.Controls.Add(this.txtVNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1385, 674);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Details";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.txtIDesc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtItemCode);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Location = new System.Drawing.Point(34, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 269);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Details";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(222, 82);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(397, 28);
            this.txtQuantity.TabIndex = 14;
            // 
            // txtIDesc
            // 
            this.txtIDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDesc.Location = new System.Drawing.Point(222, 174);
            this.txtIDesc.Name = "txtIDesc";
            this.txtIDesc.Size = new System.Drawing.Size(397, 28);
            this.txtIDesc.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(36, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Item Code";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 25);
            this.label13.TabIndex = 30;
            this.label13.Text = "Description";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(222, 34);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(397, 28);
            this.txtItemCode.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(494, 213);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 32);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(36, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Unit Price (Rs)";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(222, 129);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(397, 28);
            this.txtPrice.TabIndex = 23;
            // 
            // txtCName
            // 
            this.txtCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCName.Location = new System.Drawing.Point(256, 87);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(397, 28);
            this.txtCName.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(70, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 25);
            this.label12.TabIndex = 28;
            this.label12.Text = "Customer\'s Name";
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtDate.Location = new System.Drawing.Point(1262, 10);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(117, 17);
            this.txtDate.TabIndex = 27;
            this.txtDate.Text = "2021/06/25";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemove.Location = new System.Drawing.Point(1222, 462);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(125, 28);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1150, 522);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(197, 30);
            this.txtTotal.TabIndex = 25;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnViewOders
            // 
            this.btnViewOders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViewOders.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewOders.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOders.Location = new System.Drawing.Point(34, 599);
            this.btnViewOders.Name = "btnViewOders";
            this.btnViewOders.Size = new System.Drawing.Size(169, 53);
            this.btnViewOders.TabIndex = 4;
            this.btnViewOders.Text = "View Oders";
            this.btnViewOders.UseVisualStyleBackColor = false;
            this.btnViewOders.Click += new System.EventHandler(this.btnViewOders_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1013, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(984, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Total Price (Rs)";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(859, 601);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 53);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(1167, 599);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(180, 53);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvItemList
            // 
            this.dgvItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.Description,
            this.Quantity,
            this.Price,
            this.SubT});
            this.dgvItemList.Location = new System.Drawing.Point(725, 91);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvItemList.RowHeadersWidth = 51;
            this.dgvItemList.RowTemplate.Height = 24;
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemList.Size = new System.Drawing.Size(622, 353);
            this.dgvItemList.TabIndex = 21;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceNo.Location = new System.Drawing.Point(1220, 47);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblInvoiceNo.Size = new System.Drawing.Size(21, 24);
            this.lblInvoiceNo.TabIndex = 19;
            this.lblInvoiceNo.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1008, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Invoice Number:  GH";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(256, 514);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(397, 74);
            this.txtRemark.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(70, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Remark";
            // 
            // txtMilage
            // 
            this.txtMilage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMilage.Location = new System.Drawing.Point(256, 178);
            this.txtMilage.Name = "txtMilage";
            this.txtMilage.Size = new System.Drawing.Size(397, 28);
            this.txtMilage.TabIndex = 9;
            // 
            // txtVNo
            // 
            this.txtVNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVNo.Location = new System.Drawing.Point(256, 133);
            this.txtVNo.Name = "txtVNo";
            this.txtVNo.Size = new System.Drawing.Size(397, 28);
            this.txtVNo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(70, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mileage (Km)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vehicle Number";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Minion Pro", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(362, 83);
            this.label8.TabIndex = 21;
            this.label8.Text = "Galle Hybrid";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(298, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "0772945510/ 0753331279/ 0763331279";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Pdsghd@gmail.com";
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Unit Price (Rs)";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // SubT
            // 
            this.SubT.HeaderText = "Amount (Rs)";
            this.SubT.MinimumWidth = 6;
            this.SubT.Name = "SubT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1445, 878);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Bill";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtMilage;
        private System.Windows.Forms.TextBox txtVNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnViewOders;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtIDesc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubT;
    }
}

