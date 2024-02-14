namespace Calculator
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
            numoneLbl = new Label();
            numtwoLbl = new Label();
            outputLbl = new Label();
            numone = new TextBox();
            numtwo = new TextBox();
            outputbox = new TextBox();
            plus = new Button();
            minus = new Button();
            multiply = new Button();
            divide = new Button();
            modulus = new Button();
            power = new Button();
            SuspendLayout();
            // 
            // numoneLbl
            // 
            numoneLbl.AutoSize = true;
            numoneLbl.Location = new Point(34, 24);
            numoneLbl.Name = "numoneLbl";
            numoneLbl.Size = new Size(115, 25);
            numoneLbl.TabIndex = 0;
            numoneLbl.Text = "First Number";
            // 
            // numtwoLbl
            // 
            numtwoLbl.AutoSize = true;
            numtwoLbl.Location = new Point(34, 61);
            numtwoLbl.Name = "numtwoLbl";
            numtwoLbl.Size = new Size(141, 25);
            numtwoLbl.TabIndex = 1;
            numtwoLbl.Text = "Second Number";
            // 
            // outputLbl
            // 
            outputLbl.AutoSize = true;
            outputLbl.Location = new Point(34, 98);
            outputLbl.Name = "outputLbl";
            outputLbl.Size = new Size(69, 25);
            outputLbl.TabIndex = 2;
            outputLbl.Text = "Output";
            // 
            // numone
            // 
            numone.BorderStyle = BorderStyle.FixedSingle;
            numone.Location = new Point(181, 21);
            numone.Name = "numone";
            numone.Size = new Size(150, 31);
            numone.TabIndex = 3;
            // 
            // numtwo
            // 
            numtwo.BorderStyle = BorderStyle.FixedSingle;
            numtwo.Location = new Point(181, 58);
            numtwo.Name = "numtwo";
            numtwo.Size = new Size(150, 31);
            numtwo.TabIndex = 4;
            // 
            // outputbox
            // 
            outputbox.BorderStyle = BorderStyle.FixedSingle;
            outputbox.Location = new Point(181, 95);
            outputbox.Name = "outputbox";
            outputbox.ReadOnly = true;
            outputbox.Size = new Size(150, 31);
            outputbox.TabIndex = 5;
            // 
            // plus
            // 
            plus.Location = new Point(40, 153);
            plus.Name = "plus";
            plus.Size = new Size(41, 34);
            plus.TabIndex = 6;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += button1_Click;
            // 
            // minus
            // 
            minus.Location = new Point(87, 153);
            minus.Name = "minus";
            minus.Size = new Size(41, 34);
            minus.TabIndex = 7;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // multiply
            // 
            multiply.Location = new Point(134, 153);
            multiply.Name = "multiply";
            multiply.Size = new Size(41, 34);
            multiply.TabIndex = 8;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += button3_Click;
            // 
            // divide
            // 
            divide.Location = new Point(181, 153);
            divide.Name = "divide";
            divide.Size = new Size(41, 34);
            divide.TabIndex = 9;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // modulus
            // 
            modulus.Location = new Point(228, 153);
            modulus.Name = "modulus";
            modulus.Size = new Size(41, 34);
            modulus.TabIndex = 10;
            modulus.Text = "%";
            modulus.UseVisualStyleBackColor = true;
            modulus.Click += modulus_Click;
            // 
            // power
            // 
            power.Location = new Point(275, 153);
            power.Name = "power";
            power.Size = new Size(41, 34);
            power.TabIndex = 11;
            power.Text = "^";
            power.UseVisualStyleBackColor = true;
            power.Click += power_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 227);
            Controls.Add(power);
            Controls.Add(modulus);
            Controls.Add(divide);
            Controls.Add(multiply);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(outputbox);
            Controls.Add(numtwo);
            Controls.Add(numone);
            Controls.Add(outputLbl);
            Controls.Add(numtwoLbl);
            Controls.Add(numoneLbl);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numoneLbl;
        private Label numtwoLbl;
        private Label outputLbl;
        private TextBox numone;
        private TextBox numtwo;
        private TextBox outputbox;
        private Button plus;
        private Button minus;
        private Button multiply;
        private Button divide;
        private Button modulus;
        private Button power;
    }
}
