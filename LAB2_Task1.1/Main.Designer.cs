namespace LAB2_Task1._1
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_PrimeNum = new Button();
            btn_GCD = new Button();
            ModulusExponent = new Button();
            SuspendLayout();
            // 
            // btn_PrimeNum
            // 
            btn_PrimeNum.Location = new Point(12, 12);
            btn_PrimeNum.Name = "btn_PrimeNum";
            btn_PrimeNum.Size = new Size(120, 23);
            btn_PrimeNum.TabIndex = 0;
            btn_PrimeNum.Text = "Prime Number";
            btn_PrimeNum.UseVisualStyleBackColor = true;
            btn_PrimeNum.Click += btn_PrimeNum_Click;
            // 
            // btn_GCD
            // 
            btn_GCD.Location = new Point(12, 41);
            btn_GCD.Name = "btn_GCD";
            btn_GCD.Size = new Size(120, 23);
            btn_GCD.TabIndex = 1;
            btn_GCD.Text = "GCD";
            btn_GCD.UseVisualStyleBackColor = true;
            btn_GCD.Click += btn_GCD_Click;
            // 
            // ModulusExponent
            // 
            ModulusExponent.Location = new Point(12, 70);
            ModulusExponent.Name = "ModulusExponent";
            ModulusExponent.Size = new Size(120, 23);
            ModulusExponent.TabIndex = 2;
            ModulusExponent.Text = "Modulus";
            ModulusExponent.UseVisualStyleBackColor = true;
            ModulusExponent.Click += ModulusExponent_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ModulusExponent);
            Controls.Add(btn_GCD);
            Controls.Add(btn_PrimeNum);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_PrimeNum;
        private Button btn_GCD;
        private Button ModulusExponent;
    }
}