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
    public partial class mainInterface : Form
    {
        public static mainInterface MI;
        public mainInterface()
        {
            InitializeComponent();
            MI = this;
        }

        private void mainInterface_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.TopLevel = false;
            replacePanelContent(login);

        }

        public void replacePanelContent(Control ctrl)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(ctrl);
            mainPanel.Tag = ctrl;
            ctrl.BringToFront();
            ctrl.Show();
        }

        private void mainPanel_Resize(object sender, EventArgs e)
        {
            foreach (Control item in mainPanel.Controls)
            {
                Form form = (Form) item;
                form.Width = mainPanel.Width;
                form.Height = mainPanel.Height;
            }
        }
    }
}
