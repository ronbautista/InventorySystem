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
    public partial class frmProducts2 : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        public const int ADD = 1;
        public const int EDIT = 2;
        public frmProducts2()
        {
            InitializeComponent();
            cn = new SqlConnection(Utility.dbConnection);
            cbCategory.Items.AddRange(getCategories().Values.ToArray());
            cbSupplier.Items.AddRange(getSuppliers().Values.ToArray());

            lblProductMod.Text = "Add Product";
        }

        int id, categoryID, supplierID;
        public frmProducts2(int id, string name, int categoryID, string qty, int supplierID) : base()
        {
            this.id = id;
            this.categoryID = categoryID;
            this.supplierID = supplierID;
            lblProductMod.Text = "Edit Product";
            txtName.Text = name;
            txtQty.Text = qty;
            cbCategory.SelectedText = getCategories()[categoryID];
            cbSupplier.SelectedText = getSuppliers()[supplierID];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            edit(id, txtName.Text, categoryID, txtQty.Text, supplierID);
        }

        private void edit(int id, string name, int categoryID, string qty, int supplierID)
        {
            cn.Open();
            cm = new SqlCommand("UPDATE tbl_Products SET name = '" + name + "', category_id = " + categoryID + ", quantity = " + qty + ", supplier_id = " + supplierID + " WHERE id = " + id, cn);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        private void add(string name, int categoryID, string qty, int supplierID)
        {
            cn.Open();
            cm = new SqlCommand("INSERT INTO tbl_Products VALUES('" + name + "', " + categoryID + ", " + qty + ", " + supplierID, cn);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        private Dictionary<int, string> getCategories()
        {
            Dictionary<int, String> categories = new Dictionary<int, string>();
            cn.Open();
            cm = new SqlCommand("select * from tbl_categories", cn);
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                int id = Int32.Parse(dr["id"].ToString());
                categories[id] = dr["name"].ToString();
            }
            cn.Close();

            return categories;
        }

        private Dictionary<int, string> getSuppliers()
        {
            Dictionary<int, String> categories = new Dictionary<int, string>();
            cn.Open();
            cm = new SqlCommand("select * from tbl_suppliers", cn);
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                int id = Int32.Parse(dr["id"].ToString());
                categories[id] = dr["name"].ToString();
            }
            cn.Close();

            return categories;
        }
    }
}
