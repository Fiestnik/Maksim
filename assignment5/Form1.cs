namespace assignment5
{
    public partial class Form1 : Form
    {
        private int randomNumber;
        private int guessCount;

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
            btnGuess.Click += new EventHandler(btnGuess_Click);
        }

        // Start or restart the game by generating a new random number
        private void StartNewGame()
        {
            Random rand = new Random();
            randomNumber = rand.Next(1, 101); // Random number between 1 and 100
            guessCount = 0;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int userGuess;

            // Check if the input is a valid number
            if (int.TryParse(txtGuess.Text, out userGuess))
            {
                guessCount++;
                if (userGuess < randomNumber)
                {
                    lblFeedback.Text = "Too low, try again!";
                }
                else if (userGuess > randomNumber)
                {
                    lblFeedback.Text = "Too high, try again!";
                }
                else
                {
                    lblFeedback.Text = $"Correct! You guessed it in {guessCount} attempts.";
                    StartNewGame(); // Start a new game after a correct guess
                }
            }
            else
            {
                lblFeedback.Text = "Please enter a valid number!";
            }
        }
    }
}