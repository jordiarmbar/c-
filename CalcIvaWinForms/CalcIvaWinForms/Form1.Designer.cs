namespace CalcIvaWinForms
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
            txtPrice = new TextBox();
            label2 = new Label();
            grpIva = new GroupBox();
            rbIva21 = new RadioButton();
            rbIva0 = new RadioButton();
            rbIva10 = new RadioButton();
            rbIva4 = new RadioButton();
            grpDiscount = new GroupBox();
            rbD20 = new RadioButton();
            rbD0 = new RadioButton();
            rbD10 = new RadioButton();
            rbD5 = new RadioButton();
            chkPartner = new CheckBox();
            btnCalculate = new Button();
            label3 = new Label();
            label4 = new Label();
            txtNoIva = new TextBox();
            label5 = new Label();
            txtWithIva = new TextBox();
            txtQuantity = new TextBox();
            grpIva.SuspendLayout();
            grpDiscount.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 107);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Price:";
            label1.Click += label1_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(190, 99);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(196, 23);
            txtPrice.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 151);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantity:";
            // 
            // grpIva
            // 
            grpIva.Controls.Add(rbIva21);
            grpIva.Controls.Add(rbIva0);
            grpIva.Controls.Add(rbIva10);
            grpIva.Controls.Add(rbIva4);
            grpIva.Location = new Point(126, 184);
            grpIva.Name = "grpIva";
            grpIva.Size = new Size(200, 139);
            grpIva.TabIndex = 3;
            grpIva.TabStop = false;
            grpIva.Text = "IVA";
            grpIva.Enter += groupBox1_Enter_1;
            // 
            // rbIva21
            // 
            rbIva21.AutoSize = true;
            rbIva21.Location = new Point(15, 106);
            rbIva21.Name = "rbIva21";
            rbIva21.Size = new Size(50, 19);
            rbIva21.TabIndex = 7;
            rbIva21.Text = "21 %";
            rbIva21.UseVisualStyleBackColor = true;
            // 
            // rbIva0
            // 
            rbIva0.AutoSize = true;
            rbIva0.Checked = true;
            rbIva0.Location = new Point(15, 32);
            rbIva0.Name = "rbIva0";
            rbIva0.Size = new Size(44, 19);
            rbIva0.TabIndex = 4;
            rbIva0.TabStop = true;
            rbIva0.Text = "0 %";
            rbIva0.UseVisualStyleBackColor = true;
            rbIva0.CheckedChanged += rbD0_CheckedChanged;
            // 
            // rbIva10
            // 
            rbIva10.AutoSize = true;
            rbIva10.Location = new Point(15, 82);
            rbIva10.Name = "rbIva10";
            rbIva10.Size = new Size(50, 19);
            rbIva10.TabIndex = 6;
            rbIva10.Text = "10 %";
            rbIva10.UseVisualStyleBackColor = true;
            // 
            // rbIva4
            // 
            rbIva4.AutoSize = true;
            rbIva4.Location = new Point(15, 57);
            rbIva4.Name = "rbIva4";
            rbIva4.Size = new Size(44, 19);
            rbIva4.TabIndex = 5;
            rbIva4.Text = "4 %";
            rbIva4.UseVisualStyleBackColor = true;
            rbIva4.CheckedChanged += rbIva4_CheckedChanged;
            // 
            // grpDiscount
            // 
            grpDiscount.Controls.Add(rbD20);
            grpDiscount.Controls.Add(rbD0);
            grpDiscount.Controls.Add(rbD10);
            grpDiscount.Controls.Add(rbD5);
            grpDiscount.Location = new Point(403, 184);
            grpDiscount.Name = "grpDiscount";
            grpDiscount.Size = new Size(200, 139);
            grpDiscount.TabIndex = 4;
            grpDiscount.TabStop = false;
            grpDiscount.Text = "Discount";
            // 
            // rbD20
            // 
            rbD20.AutoSize = true;
            rbD20.Location = new Point(15, 106);
            rbD20.Name = "rbD20";
            rbD20.Size = new Size(50, 19);
            rbD20.TabIndex = 7;
            rbD20.Text = "20 %";
            rbD20.UseVisualStyleBackColor = true;
            // 
            // rbD0
            // 
            rbD0.AutoSize = true;
            rbD0.Checked = true;
            rbD0.Location = new Point(15, 32);
            rbD0.Name = "rbD0";
            rbD0.Size = new Size(44, 19);
            rbD0.TabIndex = 4;
            rbD0.TabStop = true;
            rbD0.Text = "0 %";
            rbD0.UseVisualStyleBackColor = true;
            // 
            // rbD10
            // 
            rbD10.AutoSize = true;
            rbD10.Location = new Point(15, 82);
            rbD10.Name = "rbD10";
            rbD10.Size = new Size(50, 19);
            rbD10.TabIndex = 6;
            rbD10.Text = "10 %";
            rbD10.UseVisualStyleBackColor = true;
            // 
            // rbD5
            // 
            rbD5.AutoSize = true;
            rbD5.Location = new Point(15, 57);
            rbD5.Name = "rbD5";
            rbD5.Size = new Size(44, 19);
            rbD5.TabIndex = 5;
            rbD5.Text = "5 %";
            rbD5.UseVisualStyleBackColor = true;
            // 
            // chkPartner
            // 
            chkPartner.AutoSize = true;
            chkPartner.Location = new Point(124, 359);
            chkPartner.Name = "chkPartner";
            chkPartner.Size = new Size(174, 19);
            chkPartner.TabIndex = 5;
            chkPartner.Text = "Partner (applies a fixed 30%)";
            chkPartner.UseVisualStyleBackColor = true;
            chkPartner.CheckedChanged += chkPartner_CheckedChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(223, 427);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(209, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 435);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 102);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 8;
            label4.Text = "NO IVA:";
            label4.Click += label4_Click;
            // 
            // txtNoIva
            // 
            txtNoIva.Location = new Point(572, 94);
            txtNoIva.Name = "txtNoIva";
            txtNoIva.ReadOnly = true;
            txtNoIva.Size = new Size(100, 23);
            txtNoIva.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(484, 141);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 10;
            label5.Text = "WITH IVA:";
            label5.Click += label5_Click;
            // 
            // txtWithIva
            // 
            txtWithIva.Location = new Point(572, 138);
            txtWithIva.Name = "txtWithIva";
            txtWithIva.ReadOnly = true;
            txtWithIva.Size = new Size(100, 23);
            txtWithIva.TabIndex = 11;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(190, 148);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(196, 23);
            txtQuantity.TabIndex = 12;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 512);
            Controls.Add(txtQuantity);
            Controls.Add(txtWithIva);
            Controls.Add(label5);
            Controls.Add(txtNoIva);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCalculate);
            Controls.Add(chkPartner);
            Controls.Add(grpDiscount);
            Controls.Add(grpIva);
            Controls.Add(label2);
            Controls.Add(txtPrice);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpIva.ResumeLayout(false);
            grpIva.PerformLayout();
            grpDiscount.ResumeLayout(false);
            grpDiscount.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPrice;
        private Label label2;
        private GroupBox grpIva;
        private RadioButton rbIva21;
        private RadioButton rbIva0;
        private RadioButton rbIva10;
        private RadioButton rbIva4;
        private GroupBox grpDiscount;
        private RadioButton rbD20;
        private RadioButton rbD0;
        private RadioButton rbD10;
        private RadioButton rbD5;
        private CheckBox chkPartner;
        private Button btnCalculate;
        private Label label3;
        private Label label4;
        private TextBox txtNoIva;
        private Label label5;
        private TextBox txtWithIva;
        private TextBox txtQuantity;
    }
}
