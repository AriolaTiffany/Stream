namespace CreateTxtFile
{
    partial class FrmFileName
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
            txtFileName = new TextBox();
            label1 = new Label();
            btnOkay = new Button();
            SuspendLayout();
            // 
            // txtFileName
            // 
            txtFileName.BorderStyle = BorderStyle.FixedSingle;
            txtFileName.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileName.Location = new Point(34, 53);
            txtFileName.Margin = new Padding(3, 2, 3, 2);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(258, 23);
            txtFileName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(31, 24);
            label1.Name = "label1";
            label1.Size = new Size(129, 19);
            label1.TabIndex = 1;
            label1.Text = "Enter File Name";
            // 
            // btnOkay
            // 
            btnOkay.BackColor = Color.Maroon;
            btnOkay.FlatStyle = FlatStyle.Flat;
            btnOkay.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOkay.ForeColor = Color.White;
            btnOkay.Location = new Point(118, 89);
            btnOkay.Margin = new Padding(3, 2, 3, 2);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(82, 32);
            btnOkay.TabIndex = 2;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = false;
            btnOkay.Click += btnOkay_Click;
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 141);
            Controls.Add(btnOkay);
            Controls.Add(label1);
            Controls.Add(txtFileName);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmFileName";
            Text = "FrmFileName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFileName;
        private Label label1;
        private Button btnOkay;
    }
}