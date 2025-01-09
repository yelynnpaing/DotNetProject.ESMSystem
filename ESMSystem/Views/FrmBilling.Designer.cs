namespace ESMSystem.Views
{
    partial class FrmBilling
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboItems = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.AddToBillBtn = new System.Windows.Forms.Button();
            this.InvoiceNoBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoiceNum = new System.Windows.Forms.TextBox();
            this.lvOrderList = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgItemList = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PrintBillBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBillInvoiceNum = new System.Windows.Forms.TextBox();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.SaveBillBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPaymentType = new System.Windows.Forms.Label();
            this.radioEMoney = new System.Windows.Forms.RadioButton();
            this.radioCard = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.InvoicedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cboOrderStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboPaymentStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.cboCustomers = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTotalCost);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboItems);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.ResetBtn);
            this.groupBox1.Controls.Add(this.AddToBillBtn);
            this.groupBox1.Controls.Add(this.InvoiceNoBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSerialNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtInvoiceNum);
            this.groupBox1.Location = new System.Drawing.Point(246, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 251);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(303, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Total Cost";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTotalCost.Location = new System.Drawing.Point(306, 146);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(210, 24);
            this.txtTotalCost.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(40, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Item Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtQuantity.Location = new System.Drawing.Point(44, 146);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(210, 24);
            this.txtQuantity.TabIndex = 16;
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(303, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Item Price";
            // 
            // cboItems
            // 
            this.cboItems.FormattingEnabled = true;
            this.cboItems.Location = new System.Drawing.Point(43, 96);
            this.cboItems.Name = "cboItems";
            this.cboItems.Size = new System.Drawing.Size(210, 24);
            this.cboItems.TabIndex = 14;
            this.cboItems.Leave += new System.EventHandler(this.cboItems_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(40, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Item Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPrice.Location = new System.Drawing.Point(306, 94);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(210, 24);
            this.txtPrice.TabIndex = 12;
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.Red;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(378, 190);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(138, 41);
            this.ResetBtn.TabIndex = 11;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // AddToBillBtn
            // 
            this.AddToBillBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddToBillBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.AddToBillBtn.ForeColor = System.Drawing.Color.White;
            this.AddToBillBtn.Location = new System.Drawing.Point(222, 192);
            this.AddToBillBtn.Name = "AddToBillBtn";
            this.AddToBillBtn.Size = new System.Drawing.Size(138, 41);
            this.AddToBillBtn.TabIndex = 9;
            this.AddToBillBtn.Text = "Add to Bill";
            this.AddToBillBtn.UseVisualStyleBackColor = false;
            this.AddToBillBtn.Click += new System.EventHandler(this.AddToBillBtn_Click);
            // 
            // InvoiceNoBtn
            // 
            this.InvoiceNoBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.InvoiceNoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.InvoiceNoBtn.ForeColor = System.Drawing.Color.White;
            this.InvoiceNoBtn.Location = new System.Drawing.Point(44, 192);
            this.InvoiceNoBtn.Name = "InvoiceNoBtn";
            this.InvoiceNoBtn.Size = new System.Drawing.Size(148, 41);
            this.InvoiceNoBtn.TabIndex = 8;
            this.InvoiceNoBtn.Text = "Invoice Nubmer";
            this.InvoiceNoBtn.UseVisualStyleBackColor = false;
            this.InvoiceNoBtn.Click += new System.EventHandler(this.InvoiceNoBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(303, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Serial No.";
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSerialNo.Location = new System.Drawing.Point(306, 43);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(210, 24);
            this.txtSerialNo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(40, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Invoice Number";
            // 
            // txtInvoiceNum
            // 
            this.txtInvoiceNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtInvoiceNum.Location = new System.Drawing.Point(43, 45);
            this.txtInvoiceNum.Name = "txtInvoiceNum";
            this.txtInvoiceNum.Size = new System.Drawing.Size(210, 24);
            this.txtInvoiceNum.TabIndex = 0;
            // 
            // lvOrderList
            // 
            this.lvOrderList.FullRowSelect = true;
            this.lvOrderList.GridLines = true;
            this.lvOrderList.HideSelection = false;
            this.lvOrderList.HoverSelection = true;
            this.lvOrderList.Location = new System.Drawing.Point(19, 279);
            this.lvOrderList.Name = "lvOrderList";
            this.lvOrderList.Size = new System.Drawing.Size(652, 329);
            this.lvOrderList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvOrderList.TabIndex = 21;
            this.lvOrderList.UseCompatibleStateImageBehavior = false;
            this.lvOrderList.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Billing Management";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgItemList);
            this.groupBox2.Location = new System.Drawing.Point(247, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 406);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);
            this.label5.Location = new System.Drawing.Point(7, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Available Item LIst";
            // 
            // dgItemList
            // 
            this.dgItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItemList.Location = new System.Drawing.Point(12, 52);
            this.dgItemList.Name = "dgItemList";
            this.dgItemList.RowHeadersWidth = 51;
            this.dgItemList.RowTemplate.Height = 24;
            this.dgItemList.Size = new System.Drawing.Size(537, 338);
            this.dgItemList.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PrintBillBtn);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtBillInvoiceNum);
            this.groupBox3.Controls.Add(this.txtTotalBill);
            this.groupBox3.Controls.Add(this.SaveBillBtn);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.DeleteBtn);
            this.groupBox3.Controls.Add(this.cboCustomers);
            this.groupBox3.Controls.Add(this.lvOrderList);
            this.groupBox3.Location = new System.Drawing.Point(833, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(686, 661);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // PrintBillBtn
            // 
            this.PrintBillBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PrintBillBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.PrintBillBtn.ForeColor = System.Drawing.Color.White;
            this.PrintBillBtn.Location = new System.Drawing.Point(533, 16);
            this.PrintBillBtn.Name = "PrintBillBtn";
            this.PrintBillBtn.Size = new System.Drawing.Size(138, 41);
            this.PrintBillBtn.TabIndex = 23;
            this.PrintBillBtn.Text = "Print Bill";
            this.PrintBillBtn.UseVisualStyleBackColor = false;
            this.PrintBillBtn.Click += new System.EventHandler(this.PrintBillBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 22);
            this.label15.TabIndex = 21;
            this.label15.Text = "Invoice Number - ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(319, 627);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Total Bill - ";
            // 
            // txtBillInvoiceNum
            // 
            this.txtBillInvoiceNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillInvoiceNum.Location = new System.Drawing.Point(192, 36);
            this.txtBillInvoiceNum.Name = "txtBillInvoiceNum";
            this.txtBillInvoiceNum.Size = new System.Drawing.Size(239, 28);
            this.txtBillInvoiceNum.TabIndex = 20;
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBill.Location = new System.Drawing.Point(461, 621);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.Size = new System.Drawing.Size(210, 27);
            this.txtTotalBill.TabIndex = 20;
            this.txtTotalBill.Text = "0";
            this.txtTotalBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaveBillBtn
            // 
            this.SaveBillBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.SaveBillBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SaveBillBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBillBtn.Location = new System.Drawing.Point(19, 614);
            this.SaveBillBtn.Name = "SaveBillBtn";
            this.SaveBillBtn.Size = new System.Drawing.Size(125, 38);
            this.SaveBillBtn.TabIndex = 20;
            this.SaveBillBtn.Text = "Save Bill";
            this.SaveBillBtn.UseVisualStyleBackColor = false;
            this.SaveBillBtn.Click += new System.EventHandler(this.SaveBillBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPaymentType);
            this.groupBox4.Controls.Add(this.radioEMoney);
            this.groupBox4.Controls.Add(this.radioCard);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.radioCash);
            this.groupBox4.Controls.Add(this.InvoicedateTimePicker);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.cboOrderStatus);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.cboPaymentStatus);
            this.groupBox4.Location = new System.Drawing.Point(19, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(652, 156);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            // 
            // txtPaymentType
            // 
            this.txtPaymentType.AutoSize = true;
            this.txtPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentType.Location = new System.Drawing.Point(188, 18);
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.Size = new System.Drawing.Size(101, 20);
            this.txtPaymentType.TabIndex = 29;
            this.txtPaymentType.Text = "No Choose";
            // 
            // radioEMoney
            // 
            this.radioEMoney.AutoSize = true;
            this.radioEMoney.Location = new System.Drawing.Point(278, 48);
            this.radioEMoney.Name = "radioEMoney";
            this.radioEMoney.Size = new System.Drawing.Size(78, 20);
            this.radioEMoney.TabIndex = 28;
            this.radioEMoney.TabStop = true;
            this.radioEMoney.Text = "Emoney";
            this.radioEMoney.UseVisualStyleBackColor = true;
            this.radioEMoney.CheckedChanged += new System.EventHandler(this.radioEMoney_CheckedChanged);
            // 
            // radioCard
            // 
            this.radioCard.AutoSize = true;
            this.radioCard.Location = new System.Drawing.Point(145, 50);
            this.radioCard.Name = "radioCard";
            this.radioCard.Size = new System.Drawing.Size(57, 20);
            this.radioCard.TabIndex = 27;
            this.radioCard.TabStop = true;
            this.radioCard.Text = "Card";
            this.radioCard.UseVisualStyleBackColor = true;
            this.radioCard.CheckedChanged += new System.EventHandler(this.radioCard_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Paymemt Method - ";
            // 
            // radioCash
            // 
            this.radioCash.AutoSize = true;
            this.radioCash.Location = new System.Drawing.Point(22, 52);
            this.radioCash.Name = "radioCash";
            this.radioCash.Size = new System.Drawing.Size(59, 20);
            this.radioCash.TabIndex = 25;
            this.radioCash.TabStop = true;
            this.radioCash.Text = "Cash";
            this.radioCash.UseVisualStyleBackColor = true;
            this.radioCash.CheckedChanged += new System.EventHandler(this.radioCash_CheckedChanged);
            // 
            // InvoicedateTimePicker
            // 
            this.InvoicedateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoicedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InvoicedateTimePicker.Location = new System.Drawing.Point(429, 18);
            this.InvoicedateTimePicker.Name = "InvoicedateTimePicker";
            this.InvoicedateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.InvoicedateTimePicker.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.Location = new System.Drawing.Point(241, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "Order Status";
            // 
            // cboOrderStatus
            // 
            this.cboOrderStatus.FormattingEnabled = true;
            this.cboOrderStatus.Location = new System.Drawing.Point(244, 117);
            this.cboOrderStatus.Name = "cboOrderStatus";
            this.cboOrderStatus.Size = new System.Drawing.Size(210, 24);
            this.cboOrderStatus.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.Location = new System.Drawing.Point(13, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Payment Status";
            // 
            // cboPaymentStatus
            // 
            this.cboPaymentStatus.FormattingEnabled = true;
            this.cboPaymentStatus.Location = new System.Drawing.Point(16, 117);
            this.cboPaymentStatus.Name = "cboPaymentStatus";
            this.cboPaymentStatus.Size = new System.Drawing.Size(210, 24);
            this.cboPaymentStatus.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(16, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Customer Name";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(533, 229);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(138, 41);
            this.DeleteBtn.TabIndex = 21;
            this.DeleteBtn.Text = "Delete Item";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // cboCustomers
            // 
            this.cboCustomers.FormattingEnabled = true;
            this.cboCustomers.Location = new System.Drawing.Point(19, 249);
            this.cboCustomers.Name = "cboCustomers";
            this.cboCustomers.Size = new System.Drawing.Size(210, 24);
            this.cboCustomers.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(828, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(154, 25);
            this.label16.TabIndex = 25;
            this.label16.Text = "Billing Process";
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 878);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBilling";
            this.Text = "FrmBilling";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button AddToBillBtn;
        private System.Windows.Forms.Button InvoiceNoBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvoiceNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ListView lvOrderList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgItemList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.ComboBox cboCustomers;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioCash;
        private System.Windows.Forms.DateTimePicker InvoicedateTimePicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboOrderStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboPaymentStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Button SaveBillBtn;
        private System.Windows.Forms.RadioButton radioEMoney;
        private System.Windows.Forms.RadioButton radioCard;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button PrintBillBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBillInvoiceNum;
        private System.Windows.Forms.Label txtPaymentType;
        private System.Windows.Forms.Label label16;
    }
}