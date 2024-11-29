namespace assignment6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            lblComputerChoice = new Label();
            lblResult = new Label();
            btnRestart = new Button();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.Location = new Point(36, 229);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(75, 23);
            btnRock.TabIndex = 0;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(154, 229);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(75, 23);
            btnPaper.TabIndex = 1;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            // 
            // btnScissors
            // 
            btnScissors.Location = new Point(267, 229);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(75, 23);
            btnScissors.TabIndex = 2;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            // 
            // lblComputerChoice
            // 
            lblComputerChoice.AutoSize = true;
            lblComputerChoice.Location = new Point(145, 81);
            lblComputerChoice.Name = "lblComputerChoice";
            lblComputerChoice.Size = new Size(98, 15);
            lblComputerChoice.TabIndex = 3;
            lblComputerChoice.Text = "ComputerChoice";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(178, 153);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(39, 15);
            lblResult.TabIndex = 4;
            lblResult.Text = "Result";
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(154, 294);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(75, 23);
            btnRestart.TabIndex = 5;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 428);
            Controls.Add(btnRestart);
            Controls.Add(lblResult);
            Controls.Add(lblComputerChoice);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Label lblComputerChoice;
        private Label lblResult;
        private Button btnRestart;
    }
}
