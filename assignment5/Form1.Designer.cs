namespace assignment5
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
            txtGuess = new TextBox();
            btnGuess = new Button();
            lblFeedback = new Label();
            SuspendLayout();
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(80, 76);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(100, 23);
            txtGuess.TabIndex = 1;
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(97, 117);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(75, 23);
            btnGuess.TabIndex = 2;
            btnGuess.Text = "Enter";
            btnGuess.UseVisualStyleBackColor = true;
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Location = new Point(35, 42);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(196, 15);
            lblFeedback.TabIndex = 3;
            lblFeedback.Text = "Guess a number between 1 and 100!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 250);
            Controls.Add(lblFeedback);
            Controls.Add(btnGuess);
            Controls.Add(txtGuess);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtGuess;
        private Button btnGuess;
        private Label lblFeedback;
    }
}
