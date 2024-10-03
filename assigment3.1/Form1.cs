namespace assigment3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double weight = double.Parse(txtWeight.Text);
                double height = double.Parse(txtHeight.Text);

                double bmi = (weight * 703) / (height * height);

                lblBMIResult.Text = $"BMI: {bmi:F2}";

                if (bmi < 18.5)
                {
                    lblStatus.Text = "Status: underweight";
                }
                else if (bmi >= 18.5 && bmi <= 25)
                {
                    lblStatus.Text = "Status: optimal";
                }
                else
                {
                    lblStatus.Text = "Status: overweight";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }
    }
}
