using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_CustomerProductsOrders
{
    public partial class Form1 : Form
    {
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        DataTable dt = null;


        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnString"].ConnectionString);
            OrdersFill();
        }

        private void OrdersFill()
        {
            da = new SqlDataAdapter("Select * From Orders", conn);
            ds = new DataSet();
            da.Fill(ds);

            dt = ds.Tables[0];

            foreach (DataRow dr in dt.Rows)
            {
                cmb_Orders.Items.Add(dr["OrderID"]);
            }
        }

        private void cmb_Orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter(@"Select Customers.* 
From Orders INNER JOIN Customers 
ON Orders.CustomerID = Customers.CustomerID
Where Orders.OrderID = @pOrderId; Select Orders.OrderID, Customers.CustomerID, Products.* From Orders INNER JOIN Customers
ON Orders.CustomerID = Customers.CustomerID
INNER JOIN [Order Details] 
ON [Order Details].OrderID = Orders.OrderID
INNER JOIN Products ON [Order Details].ProductID = Products.ProductID
Where Orders.OrderID = @pOrderId", conn);
            da.SelectCommand.Parameters.AddWithValue("@pOrderID", cmb_Orders.SelectedItem.ToString());

            ds = new DataSet();
            da.Fill(ds);


            dataGridViewCustomer.DataSource = ds?.Tables[0];
            dataGridViewProduct.DataSource = ds?.Tables[1];


        }

        private void btn_OrderDetails_Click(object sender, EventArgs e)
        {
            if (cmb_Orders.SelectedIndex != -1)
            {
                da = new SqlDataAdapter(@"Select [Order Details].* From Orders INNER JOIN Customers
ON Orders.CustomerID = Customers.CustomerID
INNER JOIN [Order Details] 
ON [Order Details].OrderID = Orders.OrderID
INNER JOIN Products ON [Order Details].ProductID = Products.ProductID
Where Orders.OrderID = @pOrderId", conn);
                da.SelectCommand.Parameters.AddWithValue("@pOrderID", cmb_Orders.SelectedItem.ToString());

                ds = new DataSet();
                da.Fill(ds);

                dataGridViewOrderDeatils.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Orders not selected!");
            }
        }
    }
}
