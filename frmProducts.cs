using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class frmProducts : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        public frmProducts()
        {
            InitializeComponent();
            cn = new SqlConnection(Utility.dbConnection);
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("select * from vw_Products", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvProducts.Rows.Add(dr["id"].ToString(), dr["ProductName"].ToString(), dr["CategoryName"].ToString(), dr["quantity"].ToString(), dr["SupplierName"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void delete(int id)
        {
            cn.Open();
            cm = new SqlCommand("DELETE FROM tbl_Products WHERE id = "+id);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        int currentSelectedRow;
        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDeleteProduct.Enabled = true;
            btnEditProduct.Enabled = true;
            currentSelectedRow = e.RowIndex;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmProducts2 add = new frmProducts2();
            add.ShowDialog();
        }

        
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dgvProducts.Rows[currentSelectedRow].Cells[0].Value.ToString());
            delete(id);
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            frmProducts2 edit = new frmProducts2();
            edit.ShowDialog();
        }
    }
}
