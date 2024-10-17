namespace assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCalculate.Click += new EventHandler(btnCalculate_Click);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int number) && number >= 0)
            {
                long factorial = CalculateFactorial(number);
                lblResult.Text = $"Factorial of {number} is {factorial}";
            }
            else
            {
                MessageBox.Show("Please enter a valid nonnegative integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private long CalculateFactorial(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}