using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class frmDashboard2 : Form
    {
        public static frmDashboard2 dashboard;
        private frmProducts products;
        public frmDashboard2()
        {
            InitializeComponent();
            dashboard = this;
            products = new frmProducts();
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            products.TopLevel = false;
            replacePanelContent(products);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            replacePanelContent(products);
        }

        public void replacePanelContent(Control ctrl)
        {
            scDashboard.Panel2.Controls.Clear();
            scDashboard.Panel2.Controls.Add(ctrl);
            ctrl.BringToFront();
            ctrl.Show();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {

        }
    }
}
