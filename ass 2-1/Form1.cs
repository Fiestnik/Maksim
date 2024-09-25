namespace ass_2_1
{
    public partial class Form1 : Form
    {
        private const decimal ClassA_Price = 15m;
        private const decimal ClassB_Price = 12m;
        private const decimal ClassC_Price = 9m;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение количества проданных билетов
                int ticketsA = int.Parse(txtClassA.Text);
                int ticketsB = int.Parse(txtClassB.Text);
                int ticketsC = int.Parse(txtClassC.Text);

                // Расчет доходов
                decimal revenueA = ticketsA * ClassA_Price;
                decimal revenueB = ticketsB * ClassB_Price;
                decimal revenueC = ticketsC * ClassC_Price;
                decimal totalRevenue = revenueA + revenueB + revenueC;

                // Отображение результатов
                txtRevenueA.Text = revenueA.ToString("C");
                txtRevenueB.Text = revenueB.ToString("C");
                txtRevenueC.Text = revenueC.ToString("C");
                txtTotalRevenue.Text = totalRevenue.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers for ticket quantities.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtClassA.Clear();
            txtClassB.Clear();
            txtClassC.Clear();
            txtRevenueA.Text = "";
            txtRevenueB.Text = "";
            txtRevenueC.Text = "";
            txtTotalRevenue.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
