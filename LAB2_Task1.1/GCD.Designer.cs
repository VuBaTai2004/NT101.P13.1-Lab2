namespace LAB2_Task1._1
{
    partial class GCD
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
            label1 = new Label();
            label2 = new Label();
            txtB_First = new TextBox();
            txtB_Second = new TextBox();
            btn_GCD = new Button();
            txtB_Result = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "First Number: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 1;
            label2.Text = "Second Number: ";
            // 
            // txtB_First
            // 
            txtB_First.Location = new Point(117, 6);
            txtB_First.Name = "txtB_First";
            txtB_First.Size = new Size(341, 23);
            txtB_First.TabIndex = 2;
            // 
            // txtB_Second
            // 
            txtB_Second.Location = new Point(117, 40);
            txtB_Second.Name = "txtB_Second";
            txtB_Second.Size = new Size(341, 23);
            txtB_Second.TabIndex = 3;
            // 
            // btn_GCD
            // 
            btn_GCD.Location = new Point(464, 6);
            btn_GCD.Name = "btn_GCD";
            btn_GCD.Size = new Size(75, 23);
            btn_GCD.TabIndex = 4;
            btn_GCD.Text = "GCD";
            btn_GCD.UseVisualStyleBackColor = true;
            btn_GCD.Click += btn_GCD_Click;
            // 
            // txtB_Result
            // 
            txtB_Result.Location = new Point(117, 69);
            txtB_Result.Name = "txtB_Result";
            txtB_Result.Size = new Size(341, 23);
            txtB_Result.TabIndex = 5;
            // 
            // GCD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 450);
            Controls.Add(txtB_Result);
            Controls.Add(btn_GCD);
            Controls.Add(txtB_Second);
            Controls.Add(txtB_First);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GCD";
            Text = "GCD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtB_First;
        private TextBox txtB_Second;
        private Button btn_GCD;
        private TextBox txtB_Result;
    }
}