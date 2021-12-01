
namespace ADO.NET_CustomerProductsOrders
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
            this.cmb_Orders = new System.Windows.Forms.ComboBox();
            this.lbl_Orders = new System.Windows.Forms.Label();
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.lbl_Products = new System.Windows.Forms.Label();
            this.btn_OrderDetails = new System.Windows.Forms.Button();
            this.dataGridViewOrderDeatils = new System.Windows.Forms.DataGridView();
            this.lbl_OrderDetails = new System.Windows.Forms.Label();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDeatils)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Orders
            // 
            this.cmb_Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Orders.FormattingEnabled = true;
            this.cmb_Orders.Location = new System.Drawing.Point(12, 41);
            this.cmb_Orders.Name = "cmb_Orders";
            this.cmb_Orders.Size = new System.Drawing.Size(403, 33);
            this.cmb_Orders.TabIndex = 0;
            this.cmb_Orders.SelectedIndexChanged += new System.EventHandler(this.cmb_Orders_SelectedIndexChanged);
            // 
            // lbl_Orders
            // 
            this.lbl_Orders.AutoSize = true;
            this.lbl_Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Orders.Location = new System.Drawing.Point(12, 9);
            this.lbl_Orders.Name = "lbl_Orders";
            this.lbl_Orders.Size = new System.Drawing.Size(88, 29);
            this.lbl_Orders.TabIndex = 1;
            this.lbl_Orders.Text = "Orders";
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.AutoSize = true;
            this.lbl_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer.Location = new System.Drawing.Point(7, 96);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(117, 29);
            this.lbl_Customer.TabIndex = 2;
            this.lbl_Customer.Text = "Customer";
            // 
            // lbl_Products
            // 
            this.lbl_Products.AutoSize = true;
            this.lbl_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Products.Location = new System.Drawing.Point(12, 320);
            this.lbl_Products.Name = "lbl_Products";
            this.lbl_Products.Size = new System.Drawing.Size(96, 29);
            this.lbl_Products.TabIndex = 4;
            this.lbl_Products.Text = "Product";
            // 
            // btn_OrderDetails
            // 
            this.btn_OrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrderDetails.Location = new System.Drawing.Point(714, 41);
            this.btn_OrderDetails.Name = "btn_OrderDetails";
            this.btn_OrderDetails.Size = new System.Drawing.Size(237, 33);
            this.btn_OrderDetails.TabIndex = 6;
            this.btn_OrderDetails.Text = "Order deatils";
            this.btn_OrderDetails.UseVisualStyleBackColor = true;
            this.btn_OrderDetails.Click += new System.EventHandler(this.btn_OrderDetails_Click);
            // 
            // dataGridViewOrderDeatils
            // 
            this.dataGridViewOrderDeatils.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrderDeatils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDeatils.Location = new System.Drawing.Point(12, 589);
            this.dataGridViewOrderDeatils.Name = "dataGridViewOrderDeatils";
            this.dataGridViewOrderDeatils.RowHeadersWidth = 51;
            this.dataGridViewOrderDeatils.RowTemplate.Height = 24;
            this.dataGridViewOrderDeatils.Size = new System.Drawing.Size(939, 193);
            this.dataGridViewOrderDeatils.TabIndex = 10;
            // 
            // lbl_OrderDetails
            // 
            this.lbl_OrderDetails.AutoSize = true;
            this.lbl_OrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderDetails.Location = new System.Drawing.Point(7, 557);
            this.lbl_OrderDetails.Name = "lbl_OrderDetails";
            this.lbl_OrderDetails.Size = new System.Drawing.Size(153, 29);
            this.lbl_OrderDetails.TabIndex = 9;
            this.lbl_OrderDetails.Text = "Order details";
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(12, 352);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(939, 186);
            this.dataGridViewProduct.TabIndex = 11;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(12, 128);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 24;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(939, 175);
            this.dataGridViewCustomer.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 794);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.dataGridViewOrderDeatils);
            this.Controls.Add(this.lbl_OrderDetails);
            this.Controls.Add(this.btn_OrderDetails);
            this.Controls.Add(this.lbl_Products);
            this.Controls.Add(this.lbl_Customer);
            this.Controls.Add(this.lbl_Orders);
            this.Controls.Add(this.cmb_Orders);
            this.MinimumSize = new System.Drawing.Size(981, 841);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDeatils)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Orders;
        private System.Windows.Forms.Label lbl_Orders;
        private System.Windows.Forms.Label lbl_Customer;
        private System.Windows.Forms.Label lbl_Products;
        private System.Windows.Forms.Button btn_OrderDetails;
        private System.Windows.Forms.DataGridView dataGridViewOrderDeatils;
        private System.Windows.Forms.Label lbl_OrderDetails;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
    }
}

