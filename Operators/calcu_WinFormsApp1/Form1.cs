namespace calcu_WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Claculator res;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //res.Add(int.Parse(txtResult.Text));
            res.Add();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            res.sub();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            res = new Claculator();
            res.Operand1 = int.Parse(txtNum1.Text);
            res.Operand2 = int.Parse(txtNum2.Text);
            //res.Result = int.Parse(txtResult.Text);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            //txtNum1.Text = res.Operand1.ToString();
           // txtNum2.Text = res.Operand2.ToString();
            txtResult.Text = res.Result.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            res.Mul();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            res.Div();
        }

        

        
    }
}