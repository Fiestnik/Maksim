namespace assigment3._1
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
            label1 = new Label();
            label2 = new Label();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            button1 = new Button();
            lblBMIResult = new Label();
            lblStatus = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 41);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Weight(pounds)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 88);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Height(inches)";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(153, 38);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(153, 23);
            txtWeight.TabIndex = 4;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(153, 80);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(153, 23);
            txtHeight.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(196, 130);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblBMIResult
            // 
            lblBMIResult.AutoSize = true;
            lblBMIResult.Location = new Point(18, 28);
            lblBMIResult.Name = "lblBMIResult";
            lblBMIResult.Size = new Size(31, 15);
            lblBMIResult.TabIndex = 7;
            lblBMIResult.Text = "BMI:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(18, 56);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblBMIResult);
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Location = new Point(28, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(162, 91);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 246);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private Button button1;
        private Label lblBMIResult;
        private Label lblStatus;
        private GroupBox groupBox1;
    }
}
