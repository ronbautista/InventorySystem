using System.Data.SqlClient;

namespace InventorySystem
{
    public partial class frmLogin : Form
    {
        private delegate void mainPanel(Control ctrl);
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        public frmLogin()
        {
            InitializeComponent();
            cn = new SqlConnection(Utility.dbConnection);
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            switch (validate(txtUsername.Text, txtPassword.Text))
            {
                case EMPTY:
                    MessageBox.Show("Username and password should not be empty!", Utility.frmTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ACCOUNTNOTFOUND:
                    MessageBox.Show("Account not found lmao gitgud!", Utility.frmTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ACCOUNTFOUND:
                    //proceed to main interface
                    frmDashboard2 dashboard = new frmDashboard2();
                    dashboard.TopLevel = false;
                    mainInterface.MI.replacePanelContent(dashboard);
                    break;
            };

            txtUsername.Clear();
            txtPassword.Clear();
        }

        private const int EMPTY = -1;
        private const int ACCOUNTNOTFOUND = 0;
        private const int ACCOUNTFOUND = 1;
        private const int SUPERUSER = 2;
        private int validate(string username, string password)
        {
            if (username.Equals(String.Empty) || password.Equals(String.Empty))
            {
                return EMPTY;
            }
            try
            {
                cn.Open();
                cm = new SqlCommand("select top 1 * from tbl_Accounts where username = @user and password = @pass", cn);
                cm.Parameters.AddWithValue("@user", username);
                cm.Parameters.AddWithValue("@pass", password);
                dr = cm.ExecuteReader();

                int accountFound = dr.Read() ? ACCOUNTFOUND : ACCOUNTNOTFOUND;
                //the superuser account should not be allowed to log in, but is allowed when going to reset password
                accountFound = (dr["username"].Equals("superuser") && dr["password"].Equals("superuser")) ? SUPERUSER : accountFound;
                dr.Close();
                cn.Close();
                return accountFound;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utility.frmTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cn.Close();
                return ACCOUNTNOTFOUND;
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            switch (validate(txtUsername.Text, txtPassword.Text))
            {
                case EMPTY:
                    MessageBox.Show("Username and password should not be empty!", Utility.frmTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case SUPERUSER:
                    //proceed to reset
                    break;
            };

            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}