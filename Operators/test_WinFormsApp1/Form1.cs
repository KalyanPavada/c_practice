namespace test_WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Account a;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //private void Form1_Load(object sender, System.EventArgs e)
        //{
        //    // Do whatever
        //}

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            a = new Account();
            Account a1 = new Account(1, "asc", 122);
            Account a2 = new Account(a1);

        }

        
        private void btnSet_Click(object sender, EventArgs e)
        {
            a.id = int.Parse(txtId.Text);
            a.name = txtName.Text;
            a.Deposite(decimal.Parse(txtBalancce.Text));
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            txtId.Text = a.id.ToString();
            txtName.Text = a.name;
            txtBalancce.Text = a.Balance.ToString();

        }

       

        private void bntDestroy_Click(object sender, EventArgs e)
        {
            a = null;
        }

        private void btnGC_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtBalancce.Clear();
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            Account a1 = new Account();

            a = a1;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeposite_Click(object sender, EventArgs e)
        {
            a.Deposite(decimal.Parse(txtEnteramount.Text));
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            a.Withdraw(decimal.Parse(txtEnteramount.Text));
        }

        private void btnSetMB_Click(object sender, EventArgs e)
        {
            Account.MinBal = int.Parse(txtMB.Text);
        }

        private void btnGetMB_Click(object sender, EventArgs e)
        {
            txtMB.Text = Account.MinBal.ToString();
        }
    }
}