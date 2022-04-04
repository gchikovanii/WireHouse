
namespace CompanyFullProject
{
    partial class addOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addOrderForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clearBtn = new System.Windows.Forms.Button();
            this.makeOrderBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.orderDateDtm = new System.Windows.Forms.DateTimePicker();
            this.orderQtyTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.productPriceTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.productNameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productidTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customerAddressTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerIdTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addd = new System.Windows.Forms.Label();
            this.dataGridViewOrderCustomers = new System.Windows.Forms.DataGridView();
            this.custId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewOrderProduct = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderProduct)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.White;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Italic);
            this.clearBtn.Location = new System.Drawing.Point(754, 493);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(107, 28);
            this.clearBtn.TabIndex = 25;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // makeOrderBtn
            // 
            this.makeOrderBtn.BackColor = System.Drawing.Color.White;
            this.makeOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.makeOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.makeOrderBtn.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Italic);
            this.makeOrderBtn.Location = new System.Drawing.Point(867, 493);
            this.makeOrderBtn.Name = "makeOrderBtn";
            this.makeOrderBtn.Size = new System.Drawing.Size(107, 28);
            this.makeOrderBtn.TabIndex = 24;
            this.makeOrderBtn.Text = "Make Order";
            this.makeOrderBtn.UseVisualStyleBackColor = false;
            this.makeOrderBtn.Click += new System.EventHandler(this.makeOrderBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(468, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Order date";
            // 
            // orderDateDtm
            // 
            this.orderDateDtm.Location = new System.Drawing.Point(472, 446);
            this.orderDateDtm.Name = "orderDateDtm";
            this.orderDateDtm.Size = new System.Drawing.Size(174, 20);
            this.orderDateDtm.TabIndex = 21;
            // 
            // orderQtyTb
            // 
            this.orderQtyTb.Location = new System.Drawing.Point(472, 400);
            this.orderQtyTb.Name = "orderQtyTb";
            this.orderQtyTb.Size = new System.Drawing.Size(175, 20);
            this.orderQtyTb.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(469, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Qty";
            // 
            // productPriceTb
            // 
            this.productPriceTb.Location = new System.Drawing.Point(242, 501);
            this.productPriceTb.Name = "productPriceTb";
            this.productPriceTb.Size = new System.Drawing.Size(167, 20);
            this.productPriceTb.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(239, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Price";
            // 
            // productNameTb
            // 
            this.productNameTb.Location = new System.Drawing.Point(243, 446);
            this.productNameTb.Name = "productNameTb";
            this.productNameTb.Size = new System.Drawing.Size(166, 20);
            this.productNameTb.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(240, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Product Name";
            // 
            // productidTb
            // 
            this.productidTb.Location = new System.Drawing.Point(243, 400);
            this.productidTb.Name = "productidTb";
            this.productidTb.Size = new System.Drawing.Size(166, 20);
            this.productidTb.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(240, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Product ID";
            // 
            // customerAddressTb
            // 
            this.customerAddressTb.Location = new System.Drawing.Point(12, 501);
            this.customerAddressTb.Name = "customerAddressTb";
            this.customerAddressTb.Size = new System.Drawing.Size(170, 20);
            this.customerAddressTb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(9, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer Address";
            // 
            // customerNameTb
            // 
            this.customerNameTb.Location = new System.Drawing.Point(13, 453);
            this.customerNameTb.Name = "customerNameTb";
            this.customerNameTb.Size = new System.Drawing.Size(170, 20);
            this.customerNameTb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(9, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer Name";
            // 
            // customerIdTb
            // 
            this.customerIdTb.Location = new System.Drawing.Point(12, 401);
            this.customerIdTb.Name = "customerIdTb";
            this.customerIdTb.Size = new System.Drawing.Size(170, 20);
            this.customerIdTb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(8, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer ID";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.clearBtn);
            this.panel4.Controls.Add(this.makeOrderBtn);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.orderDateDtm);
            this.panel4.Controls.Add(this.orderQtyTb);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.productPriceTb);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.productNameTb);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.productidTb);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.customerAddressTb);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.customerNameTb);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.customerIdTb);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(977, 533);
            this.panel4.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 100);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.addd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 100);
            this.panel2.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(934, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addd
            // 
            this.addd.AutoSize = true;
            this.addd.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addd.Location = new System.Drawing.Point(366, 28);
            this.addd.Name = "addd";
            this.addd.Size = new System.Drawing.Size(86, 33);
            this.addd.TabIndex = 0;
            this.addd.Text = "ORDER";
            // 
            // dataGridViewOrderCustomers
            // 
            this.dataGridViewOrderCustomers.AllowUserToAddRows = false;
            this.dataGridViewOrderCustomers.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewOrderCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOrderCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOrderCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custId,
            this.NameCust,
            this.Address});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrderCustomers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewOrderCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrderCustomers.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewOrderCustomers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrderCustomers.Name = "dataGridViewOrderCustomers";
            this.dataGridViewOrderCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewOrderCustomers.RowHeadersVisible = false;
            this.dataGridViewOrderCustomers.Size = new System.Drawing.Size(466, 276);
            this.dataGridViewOrderCustomers.TabIndex = 27;
            this.dataGridViewOrderCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellContentClick);
            // 
            // custId
            // 
            this.custId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.custId.HeaderText = "ID";
            this.custId.Name = "custId";
            this.custId.Width = 43;
            // 
            // NameCust
            // 
            this.NameCust.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NameCust.HeaderText = "Name";
            this.NameCust.Name = "NameCust";
            this.NameCust.Width = 60;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // dataGridViewOrderProduct
            // 
            this.dataGridViewOrderProduct.AllowUserToAddRows = false;
            this.dataGridViewOrderProduct.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewOrderProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOrderProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrderProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Pname,
            this.Price,
            this.Qty});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrderProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrderProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrderProduct.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewOrderProduct.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrderProduct.Name = "dataGridViewOrderProduct";
            this.dataGridViewOrderProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOrderProduct.RowHeadersVisible = false;
            this.dataGridViewOrderProduct.Size = new System.Drawing.Size(505, 276);
            this.dataGridViewOrderProduct.TabIndex = 28;
            this.dataGridViewOrderProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewOrderCustomers);
            this.panel3.Location = new System.Drawing.Point(0, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(466, 276);
            this.panel3.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridViewOrderProduct);
            this.panel5.Location = new System.Drawing.Point(472, 98);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(505, 276);
            this.panel5.TabIndex = 30;
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            // 
            // Pname
            // 
            this.Pname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pname.HeaderText = "Name";
            this.Pname.Name = "Pname";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // addOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 533);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addOrderForm";
            this.Text = "addOrderForm";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderProduct)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button clearBtn;
        public System.Windows.Forms.Button makeOrderBtn;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DateTimePicker orderDateDtm;
        public System.Windows.Forms.TextBox orderQtyTb;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox productPriceTb;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox productNameTb;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox productidTb;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox customerAddressTb;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox customerNameTb;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox customerIdTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label addd;
        private System.Windows.Forms.DataGridView dataGridViewOrderCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn custId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridView dataGridViewOrderProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
    }
}