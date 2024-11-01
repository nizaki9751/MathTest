namespace MathTest
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
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            label1 = new Label();
            plusLeftLabel = new Label();
            plusSign = new Label();
            equalSign = new Label();
            plusRightLabel = new Label();
            sum = new NumericUpDown();
            difference = new NumericUpDown();
            minusRightLabel = new Label();
            label3 = new Label();
            minusSign = new Label();
            minusLeftLabel = new Label();
            product = new NumericUpDown();
            timesRightLabel = new Label();
            label7 = new Label();
            timesSign = new Label();
            timesLeftLabel = new Label();
            quotient = new NumericUpDown();
            dividedRightLabel = new Label();
            label11 = new Label();
            divisionSign = new Label();
            dividedLeftLabel = new Label();
            startButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 15.75F);
            timeLabel.Location = new Point(272, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(105, 10);
            label1.Name = "label1";
            label1.Size = new Size(161, 30);
            label1.TabIndex = 1;
            label1.Text = "Tempo Restante";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI", 18F);
            plusLeftLabel.Location = new Point(50, 75);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(60, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusSign
            // 
            plusSign.Font = new Font("Segoe UI", 18F);
            plusSign.Location = new Point(125, 75);
            plusSign.Name = "plusSign";
            plusSign.Size = new Size(60, 50);
            plusSign.TabIndex = 3;
            plusSign.Text = "+";
            plusSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // equalSign
            // 
            equalSign.Font = new Font("Segoe UI", 18F);
            equalSign.Location = new Point(272, 75);
            equalSign.Name = "equalSign";
            equalSign.Size = new Size(60, 50);
            equalSign.TabIndex = 4;
            equalSign.Text = "=";
            equalSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 18F);
            plusRightLabel.Location = new Point(206, 75);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 50);
            plusRightLabel.TabIndex = 5;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI", 18F);
            sum.Location = new Point(338, 82);
            sum.Name = "sum";
            sum.Size = new Size(100, 39);
            sum.TabIndex = 6;
            sum.Enter += answer_Enter;
            // 
            // difference
            // 
            difference.Font = new Font("Segoe UI", 18F);
            difference.Location = new Point(336, 162);
            difference.Name = "difference";
            difference.Size = new Size(100, 39);
            difference.TabIndex = 11;
            difference.Enter += answer_Enter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font = new Font("Segoe UI", 18F);
            minusRightLabel.Location = new Point(204, 155);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(60, 50);
            minusRightLabel.TabIndex = 10;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(270, 155);
            label3.Name = "label3";
            label3.Size = new Size(60, 50);
            label3.TabIndex = 9;
            label3.Text = "=";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusSign
            // 
            minusSign.Font = new Font("Segoe UI", 18F);
            minusSign.Location = new Point(123, 155);
            minusSign.Name = "minusSign";
            minusSign.Size = new Size(60, 50);
            minusSign.TabIndex = 8;
            minusSign.Text = "-";
            minusSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Segoe UI", 18F);
            minusLeftLabel.Location = new Point(48, 155);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(60, 50);
            minusLeftLabel.TabIndex = 7;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            product.Font = new Font("Segoe UI", 18F);
            product.Location = new Point(338, 233);
            product.Name = "product";
            product.Size = new Size(100, 39);
            product.TabIndex = 16;
            product.Enter += answer_Enter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI", 18F);
            timesRightLabel.Location = new Point(206, 226);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(60, 50);
            timesRightLabel.TabIndex = 15;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(272, 226);
            label7.Name = "label7";
            label7.Size = new Size(60, 50);
            label7.TabIndex = 14;
            label7.Text = "=";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesSign
            // 
            timesSign.Font = new Font("Segoe UI", 18F);
            timesSign.Location = new Point(125, 226);
            timesSign.Name = "timesSign";
            timesSign.Size = new Size(60, 50);
            timesSign.TabIndex = 13;
            timesSign.Text = "x";
            timesSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI", 18F);
            timesLeftLabel.Location = new Point(50, 226);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(60, 50);
            timesLeftLabel.TabIndex = 12;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            quotient.Font = new Font("Segoe UI", 18F);
            quotient.Location = new Point(338, 310);
            quotient.Name = "quotient";
            quotient.Size = new Size(100, 39);
            quotient.TabIndex = 21;
            quotient.Enter += answer_Enter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("Segoe UI", 18F);
            dividedRightLabel.Location = new Point(206, 303);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(60, 50);
            dividedRightLabel.TabIndex = 20;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 18F);
            label11.Location = new Point(272, 303);
            label11.Name = "label11";
            label11.Size = new Size(60, 50);
            label11.TabIndex = 19;
            label11.Text = "=";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divisionSign
            // 
            divisionSign.Font = new Font("Segoe UI", 18F);
            divisionSign.Location = new Point(125, 303);
            divisionSign.Name = "divisionSign";
            divisionSign.Size = new Size(60, 50);
            divisionSign.TabIndex = 18;
            divisionSign.Text = "/";
            divisionSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Segoe UI", 18F);
            dividedLeftLabel.Location = new Point(50, 303);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(60, 50);
            dividedLeftLabel.TabIndex = 17;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.Location = new Point(154, 405);
            startButton.Name = "startButton";
            startButton.Size = new Size(156, 46);
            startButton.TabIndex = 22;
            startButton.Text = "Iniciar o Teste";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 506);
            Controls.Add(startButton);
            Controls.Add(quotient);
            Controls.Add(dividedRightLabel);
            Controls.Add(label11);
            Controls.Add(divisionSign);
            Controls.Add(dividedLeftLabel);
            Controls.Add(product);
            Controls.Add(timesRightLabel);
            Controls.Add(label7);
            Controls.Add(timesSign);
            Controls.Add(timesLeftLabel);
            Controls.Add(difference);
            Controls.Add(minusRightLabel);
            Controls.Add(label3);
            Controls.Add(minusSign);
            Controls.Add(minusLeftLabel);
            Controls.Add(sum);
            Controls.Add(plusRightLabel);
            Controls.Add(equalSign);
            Controls.Add(plusSign);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Teste de Matemática";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label plusLeftLabel;
        private Label plusSign;
        private Label equalSign;
        private Label plusRightLabel;
        private NumericUpDown sum;
        private NumericUpDown difference;
        private Label minusRightLabel;
        private Label label3;
        private Label minusSign;
        private Label minusLeftLabel;
        private NumericUpDown product;
        private Label timesRightLabel;
        private Label label7;
        private Label timesSign;
        private Label timesLeftLabel;
        private NumericUpDown quotient;
        private Label dividedRightLabel;
        private Label label11;
        private Label divisionSign;
        private Label dividedLeftLabel;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}
