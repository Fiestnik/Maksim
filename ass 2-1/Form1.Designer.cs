namespace ass_2_1
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
            txtClassA = new TextBox();
            txtClassB = new TextBox();
            txtClassC = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            fontDialog1 = new FontDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtRevenueA = new TextBox();
            txtRevenueB = new TextBox();
            txtRevenueC = new TextBox();
            txtTotalRevenue = new TextBox();
            label6 = new Label();
            R = new GroupBox();
            groupBox1 = new GroupBox();
            R.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtClassA
            // 
            txtClassA.Location = new Point(73, 89);
            txtClassA.Name = "txtClassA";
            txtClassA.Size = new Size(145, 23);
            txtClassA.TabIndex = 3;
            // 
            // txtClassB
            // 
            txtClassB.Location = new Point(72, 118);
            txtClassB.Name = "txtClassB";
            txtClassB.Size = new Size(145, 23);
            txtClassB.TabIndex = 4;
            // 
            // txtClassC
            // 
            txtClassC.Location = new Point(72, 147);
            txtClassC.Name = "txtClassC";
            txtClassC.Size = new Size(145, 23);
            txtClassC.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(124, 268);
            button1.Name = "button1";
            button1.Size = new Size(101, 44);
            button1.TabIndex = 6;
            button1.Text = "Calculate Revenue";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(265, 268);
            button2.Name = "button2";
            button2.Size = new Size(101, 44);
            button2.TabIndex = 7;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(401, 268);
            button3.Name = "button3";
            button3.Size = new Size(101, 44);
            button3.TabIndex = 8;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 92);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 9;
            label1.Text = "Class A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 126);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 10;
            label2.Text = "Class B:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 155);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 11;
            label3.Text = "Class C:";
            // 
            // label4
            // 
            label4.Location = new Point(19, 42);
            label4.Name = "label4";
            label4.Size = new Size(200, 50);
            label4.TabIndex = 12;
            label4.Text = "Enter the numver of tickets sold for each class of seats.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 7);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 100);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 16;
            label8.Text = "Class A:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 129);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 17;
            label9.Text = "Class B:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 158);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 18;
            label10.Text = "Class C:";
            // 
            // txtRevenueA
            // 
            txtRevenueA.Location = new Point(62, 95);
            txtRevenueA.Name = "txtRevenueA";
            txtRevenueA.ReadOnly = true;
            txtRevenueA.Size = new Size(145, 23);
            txtRevenueA.TabIndex = 20;
            // 
            // txtRevenueB
            // 
            txtRevenueB.Location = new Point(62, 124);
            txtRevenueB.Name = "txtRevenueB";
            txtRevenueB.ReadOnly = true;
            txtRevenueB.Size = new Size(145, 23);
            txtRevenueB.TabIndex = 21;
            // 
            // txtRevenueC
            // 
            txtRevenueC.Location = new Point(62, 153);
            txtRevenueC.Name = "txtRevenueC";
            txtRevenueC.ReadOnly = true;
            txtRevenueC.Size = new Size(145, 23);
            txtRevenueC.TabIndex = 22;
            // 
            // txtTotalRevenue
            // 
            txtTotalRevenue.Location = new Point(62, 179);
            txtTotalRevenue.Name = "txtTotalRevenue";
            txtTotalRevenue.ReadOnly = true;
            txtTotalRevenue.Size = new Size(145, 23);
            txtTotalRevenue.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 182);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 24;
            label6.Text = "Total:";
            // 
            // R
            // 
            R.Controls.Add(label6);
            R.Controls.Add(txtTotalRevenue);
            R.Controls.Add(txtRevenueC);
            R.Controls.Add(txtRevenueB);
            R.Controls.Add(txtRevenueA);
            R.Controls.Add(label10);
            R.Controls.Add(label9);
            R.Controls.Add(label8);
            R.Location = new Point(292, 48);
            R.Name = "R";
            R.Size = new Size(258, 212);
            R.TabIndex = 25;
            R.TabStop = false;
            R.Text = "Revenue Generated";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtClassC);
            groupBox1.Controls.Add(txtClassB);
            groupBox1.Controls.Add(txtClassA);
            groupBox1.Location = new Point(22, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 214);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ticket Sold";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(groupBox1);
            Controls.Add(R);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            R.ResumeLayout(false);
            R.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtClassA;
        private TextBox txtClassB;
        private TextBox txtClassC;
        private Button button1;
        private Button button2;
        private Button button3;
        private FontDialog fontDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtRevenueA;
        private TextBox txtRevenueB;
        private TextBox txtRevenueC;
        private TextBox txtTotalRevenue;
        private Label label6;
        private GroupBox R;
        private GroupBox groupBox1;
    }
}
