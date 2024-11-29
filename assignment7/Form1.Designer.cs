namespace DriversLicenseExam
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtIncorrectQuestions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(30, 30);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(150, 30);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(200, 30);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(150, 30);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check Answers";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(30, 80);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(131, 15);
            this.lblCorrect.TabIndex = 2;
            this.lblCorrect.Text = "Correct Answers: 0";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Location = new System.Drawing.Point(30, 110);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(140, 15);
            this.lblIncorrect.TabIndex = 3;
            this.lblIncorrect.Text = "Incorrect Answers: 0";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(30, 140);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(51, 15);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result:";
            // 
            // txtIncorrectQuestions
            // 
            this.txtIncorrectQuestions.Location = new System.Drawing.Point(30, 170);
            this.txtIncorrectQuestions.Multiline = true;
            this.txtIncorrectQuestions.Name = "txtIncorrectQuestions";
            this.txtIncorrectQuestions.ReadOnly = true;
            this.txtIncorrectQuestions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIncorrectQuestions.Size = new System.Drawing.Size(320, 100);
            this.txtIncorrectQuestions.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.txtIncorrectQuestions);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnLoadFile);
            this.Name = "Form1";
            this.Text = "Driver's License Exam";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtIncorrectQuestions;
    }
}
