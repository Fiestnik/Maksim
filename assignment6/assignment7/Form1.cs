using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DriversLicenseExam
{
    public partial class Form1 : Form
    {
        private readonly char[] correctAnswers = { 'B', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D',
                                                   'B', 'C', 'D', 'A', 'D', 'C', 'C', 'B', 'D', 'A' };
        private char[] studentAnswers = new char[20];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Select a file with student answers"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var lines = File.ReadAllLines(openFileDialog.FileName);
                    for (int i = 0; i < lines.Length && i < 20; i++)
                    {
                        studentAnswers[i] = char.ToUpper(lines[i][0]);
                    }

                    MessageBox.Show("File loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int correctCount = 0;
            int incorrectCount = 0;
            var incorrectQuestions = new System.Collections.Generic.List<int>();

            for (int i = 0; i < correctAnswers.Length; i++)
            {
                if (studentAnswers[i] == correctAnswers[i])
                {
                    correctCount++;
                }
                else
                {
                    incorrectCount++;
                    incorrectQuestions.Add(i + 1);
                }
            }

            lblCorrect.Text = $"Correct Answers: {correctCount}";
            lblIncorrect.Text = $"Incorrect Answers: {incorrectCount}";
            lblResult.Text = correctCount >= 15 ? "The student passed the exam!" : "The student failed the exam.";
            txtIncorrectQuestions.Text = incorrectQuestions.Count > 0
                ? string.Join(", ", incorrectQuestions)
                : "No mistakes";
        }
    }
}
