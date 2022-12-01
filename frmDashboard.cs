namespace InventorySystem
{
    //size must be 915, 610
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void btnMProducts_Click(object sender, EventArgs e)
        {
            manageProduct MP = new manageProduct();
            if (isOpen(MP)) MP.BringToFront();
            else MP.Show();

        }

        private void btnMCategories_Click(object sender, EventArgs e)
        {
            ManageCategories MC = new ManageCategories();
            if (isOpen(MC)) MC.BringToFront();
            else MC.Show();
        }

        private void btnMSuppliers_Click(object sender, EventArgs e)
        {
            ManageSupplier MS = new ManageSupplier();
            if (isOpen(MS)) MS.BringToFront();
            else MS.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StockReport SR = new StockReport();
            SR.Show();
        }

        private void menuEditAccount_Click(object sender, EventArgs e)
        {
            new EditAccount().Show();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            mainInterface.MI.Dispose();
        }

        private void menuAboutUs_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        //checks if @form is already open
        public bool isOpen(Form form)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == form.Name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}