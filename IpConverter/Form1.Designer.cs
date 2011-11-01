namespace IpConverter
{
    partial class Form1
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
            this.w_txtBox = new System.Windows.Forms.TextBox();
            this.x_txtBox = new System.Windows.Forms.TextBox();
            this.y_txtBox = new System.Windows.Forms.TextBox();
            this.z_txtBox = new System.Windows.Forms.TextBox();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_Decimal = new System.Windows.Forms.TextBox();
            this.test_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // w_txtBox
            // 
            this.w_txtBox.Location = new System.Drawing.Point(68, 33);
            this.w_txtBox.Name = "w_txtBox";
            this.w_txtBox.Size = new System.Drawing.Size(40, 20);
            this.w_txtBox.TabIndex = 0;
            // 
            // x_txtBox
            // 
            this.x_txtBox.Location = new System.Drawing.Point(121, 33);
            this.x_txtBox.Name = "x_txtBox";
            this.x_txtBox.Size = new System.Drawing.Size(40, 20);
            this.x_txtBox.TabIndex = 1;
            // 
            // y_txtBox
            // 
            this.y_txtBox.Location = new System.Drawing.Point(176, 33);
            this.y_txtBox.Name = "y_txtBox";
            this.y_txtBox.Size = new System.Drawing.Size(40, 20);
            this.y_txtBox.TabIndex = 2;
            // 
            // z_txtBox
            // 
            this.z_txtBox.Location = new System.Drawing.Point(232, 33);
            this.z_txtBox.Name = "z_txtBox";
            this.z_txtBox.Size = new System.Drawing.Size(40, 20);
            this.z_txtBox.TabIndex = 3;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(197, 115);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(75, 23);
            this.btn_Convert.TabIndex = 4;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Decimal";
            // 
            // txtBox_Decimal
            // 
            this.txtBox_Decimal.Location = new System.Drawing.Point(68, 74);
            this.txtBox_Decimal.Name = "txtBox_Decimal";
            this.txtBox_Decimal.ReadOnly = true;
            this.txtBox_Decimal.Size = new System.Drawing.Size(148, 20);
            this.txtBox_Decimal.TabIndex = 10;
            // 
            // test_Btn
            // 
            this.test_Btn.Enabled = false;
            this.test_Btn.Location = new System.Drawing.Point(216, 72);
            this.test_Btn.Name = "test_Btn";
            this.test_Btn.Size = new System.Drawing.Size(50, 23);
            this.test_Btn.TabIndex = 11;
            this.test_Btn.Text = "Test";
            this.test_Btn.UseVisualStyleBackColor = true;
            this.test_Btn.Click += new System.EventHandler(this.test_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 145);
            this.Controls.Add(this.test_Btn);
            this.Controls.Add(this.txtBox_Decimal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.z_txtBox);
            this.Controls.Add(this.y_txtBox);
            this.Controls.Add(this.x_txtBox);
            this.Controls.Add(this.w_txtBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "IP to Decimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox w_txtBox;
        private System.Windows.Forms.TextBox x_txtBox;
        private System.Windows.Forms.TextBox y_txtBox;
        private System.Windows.Forms.TextBox z_txtBox;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_Decimal;
        private System.Windows.Forms.Button test_Btn;
    }
}

