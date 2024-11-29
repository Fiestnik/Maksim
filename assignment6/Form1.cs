namespace assignment6
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            btnRock.Click += new EventHandler(btnRock_Click);
            btnPaper.Click += new EventHandler(btnPaper_Click);
            btnScissors.Click += new EventHandler(btnScissors_Click);
            btnRestart.Click += new EventHandler(btnRestart_Click);
        }
        private void btnRock_Click(object sender, EventArgs e)
        {
            PlayGame("Rock");
        }
        private void btnPaper_Click(object sender, EventArgs e)
        {
            PlayGame("Paper");
        }
        private void btnScissors_Click(object sender, EventArgs e)
        {
            PlayGame("Scissors");
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            lblComputerChoice.Text = "Компьютер еще не сделал выбор.";
            lblResult.Text = "Выберите ход, чтобы начать игру.";
        }
        private void PlayGame(string playerChoice)
        {
            // Генерация случайного выбора компьютера
            string[] choices = { "Rock", "Paper", "Scissors" };
            string computerChoice = choices[random.Next(choices.Length)];

            lblComputerChoice.Text = $"Компьютер выбрал: {computerChoice}";

            // Определение победителя
            string result;
            if (playerChoice == computerChoice)
            {
                result = "Ничья! Сыграйте ещё раз.";
            }
            else if ((playerChoice == "Rock" && computerChoice == "Scissors") ||
                     (playerChoice == "Scissors" && computerChoice == "Paper") ||
                     (playerChoice == "Paper" && computerChoice == "Rock"))
            {
                result = "Вы победили!";
            }
            else
            {
                result = "Компьютер победил!";
            }

            lblResult.Text = result;
        }
    }
}
