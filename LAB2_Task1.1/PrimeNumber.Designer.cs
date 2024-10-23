namespace LAB2_Task1._1
{
    partial class PrimeNumber
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
            txtB_8bits = new TextBox();
            txtB_16bits = new TextBox();
            txtB_64bits = new TextBox();
            btn_Generate = new Button();
            rtb_Mersenne = new RichTextBox();
            label1 = new Label();
            txtB_ArInteger = new TextBox();
            btn_CkArInteger = new Button();
            SuspendLayout();
            // 
            // txtB_8bits
            // 
            txtB_8bits.Location = new Point(12, 12);
            txtB_8bits.Name = "txtB_8bits";
            txtB_8bits.Size = new Size(100, 23);
            txtB_8bits.TabIndex = 0;
            // 
            // txtB_16bits
            // 
            txtB_16bits.Location = new Point(118, 11);
            txtB_16bits.Name = "txtB_16bits";
            txtB_16bits.Size = new Size(213, 23);
            txtB_16bits.TabIndex = 1;
            // 
            // txtB_64bits
            // 
            txtB_64bits.Location = new Point(337, 12);
            txtB_64bits.Name = "txtB_64bits";
            txtB_64bits.Size = new Size(278, 23);
            txtB_64bits.TabIndex = 2;
            // 
            // btn_Generate
            // 
            btn_Generate.Location = new Point(621, 12);
            btn_Generate.Name = "btn_Generate";
            btn_Generate.Size = new Size(75, 23);
            btn_Generate.TabIndex = 3;
            btn_Generate.Text = "Generate";
            btn_Generate.UseVisualStyleBackColor = true;
            btn_Generate.Click += btn_Generate_Click;
            // 
            // rtb_Mersenne
            // 
            rtb_Mersenne.Location = new Point(12, 41);
            rtb_Mersenne.Name = "rtb_Mersenne";
            rtb_Mersenne.Size = new Size(684, 265);
            rtb_Mersenne.TabIndex = 4;
            rtb_Mersenne.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 315);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 5;
            label1.Text = "Arbitrary Integer:";
            // 
            // txtB_ArInteger
            // 
            txtB_ArInteger.Location = new Point(114, 312);
            txtB_ArInteger.Name = "txtB_ArInteger";
            txtB_ArInteger.Size = new Size(501, 23);
            txtB_ArInteger.TabIndex = 6;
            // 
            // btn_CkArInteger
            // 
            btn_CkArInteger.Location = new Point(621, 312);
            btn_CkArInteger.Name = "btn_CkArInteger";
            btn_CkArInteger.Size = new Size(75, 23);
            btn_CkArInteger.TabIndex = 7;
            btn_CkArInteger.Text = "Check";
            btn_CkArInteger.UseVisualStyleBackColor = true;
            btn_CkArInteger.Click += btn_CkArInteger_Click;
            // 
            // PrimeNumber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 450);
            Controls.Add(btn_CkArInteger);
            Controls.Add(txtB_ArInteger);
            Controls.Add(label1);
            Controls.Add(rtb_Mersenne);
            Controls.Add(btn_Generate);
            Controls.Add(txtB_64bits);
            Controls.Add(txtB_16bits);
            Controls.Add(txtB_8bits);
            Name = "PrimeNumber";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtB_8bits;
        private TextBox txtB_16bits;
        private TextBox txtB_64bits;
        private Button btn_Generate;
        private RichTextBox rtb_Mersenne;
        private Label label1;
        private TextBox txtB_ArInteger;
        private Button btn_CkArInteger;
    }
}
