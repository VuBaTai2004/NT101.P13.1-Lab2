namespace LAB2_Task1._1
{
    partial class ModularExponentiation
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
            txtB_Value = new TextBox();
            txtB_Exponent = new TextBox();
            txtB_Modulus = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtB_Result = new TextBox();
            btn_Compute = new Button();
            SuspendLayout();
            // 
            // txtB_Value
            // 
            txtB_Value.Location = new Point(81, 6);
            txtB_Value.Name = "txtB_Value";
            txtB_Value.Size = new Size(320, 23);
            txtB_Value.TabIndex = 0;
            // 
            // txtB_Exponent
            // 
            txtB_Exponent.Location = new Point(81, 38);
            txtB_Exponent.Name = "txtB_Exponent";
            txtB_Exponent.Size = new Size(320, 23);
            txtB_Exponent.TabIndex = 1;
            // 
            // txtB_Modulus
            // 
            txtB_Modulus.Location = new Point(81, 67);
            txtB_Modulus.Name = "txtB_Modulus";
            txtB_Modulus.Size = new Size(320, 23);
            txtB_Modulus.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "Value:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Exponent: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Modulus: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 128);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Result: ";
            // 
            // txtB_Result
            // 
            txtB_Result.Location = new Point(81, 125);
            txtB_Result.Name = "txtB_Result";
            txtB_Result.Size = new Size(320, 23);
            txtB_Result.TabIndex = 7;
            // 
            // btn_Compute
            // 
            btn_Compute.Location = new Point(290, 96);
            btn_Compute.Name = "btn_Compute";
            btn_Compute.Size = new Size(111, 23);
            btn_Compute.TabIndex = 8;
            btn_Compute.Text = "Compute";
            btn_Compute.UseVisualStyleBackColor = true;
            btn_Compute.Click += btn_Compute_Click;
            // 
            // ModularExponentiation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 450);
            Controls.Add(btn_Compute);
            Controls.Add(txtB_Result);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtB_Modulus);
            Controls.Add(txtB_Exponent);
            Controls.Add(txtB_Value);
            Name = "ModularExponentiation";
            Text = "ModularExponentiation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtB_Value;
        private TextBox txtB_Exponent;
        private TextBox txtB_Modulus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtB_Result;
        private Button btn_Compute;
    }
}