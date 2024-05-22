namespace aplikasi_berat_badan_nia
{
    partial class Form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBerat = new System.Windows.Forms.TextBox();
            this.textBoxTinggi = new System.Windows.Forms.TextBox();
            this.rbKg = new System.Windows.Forms.RadioButton();
            this.rbPon = new System.Windows.Forms.RadioButton();
            this.closeBtn = new System.Windows.Forms.Button();
            this.labelKeterangan = new System.Windows.Forms.Label();
            this.keterangan = new System.Windows.Forms.TextBox();
            this.buttonHitung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Menghitung Berat Ideal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Berat Badan (Kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tinggi Badan (Cm)";
            // 
            // textBoxBerat
            // 
            this.textBoxBerat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBerat.Location = new System.Drawing.Point(172, 73);
            this.textBoxBerat.Name = "textBoxBerat";
            this.textBoxBerat.Size = new System.Drawing.Size(132, 20);
            this.textBoxBerat.TabIndex = 12;
            // 
            // textBoxTinggi
            // 
            this.textBoxTinggi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTinggi.Location = new System.Drawing.Point(174, 122);
            this.textBoxTinggi.Name = "textBoxTinggi";
            this.textBoxTinggi.Size = new System.Drawing.Size(132, 20);
            this.textBoxTinggi.TabIndex = 13;
            // 
            // rbKg
            // 
            this.rbKg.AutoSize = true;
            this.rbKg.Location = new System.Drawing.Point(172, 99);
            this.rbKg.Name = "rbKg";
            this.rbKg.Size = new System.Drawing.Size(65, 17);
            this.rbKg.TabIndex = 14;
            this.rbKg.TabStop = true;
            this.rbKg.Text = "Kilogram";
            this.rbKg.UseVisualStyleBackColor = true;
            // 
            // rbPon
            // 
            this.rbPon.AutoSize = true;
            this.rbPon.Location = new System.Drawing.Point(243, 99);
            this.rbPon.Name = "rbPon";
            this.rbPon.Size = new System.Drawing.Size(44, 17);
            this.rbPon.TabIndex = 15;
            this.rbPon.TabStop = true;
            this.rbPon.Text = "Pon";
            this.rbPon.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(357, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 24);
            this.closeBtn.TabIndex = 16;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // labelKeterangan
            // 
            this.labelKeterangan.AutoSize = true;
            this.labelKeterangan.Location = new System.Drawing.Point(78, 159);
            this.labelKeterangan.Name = "labelKeterangan";
            this.labelKeterangan.Size = new System.Drawing.Size(62, 13);
            this.labelKeterangan.TabIndex = 17;
            this.labelKeterangan.Text = "Keterangan";
            // 
            // keterangan
            // 
            this.keterangan.Location = new System.Drawing.Point(174, 156);
            this.keterangan.Multiline = true;
            this.keterangan.Name = "keterangan";
            this.keterangan.ReadOnly = true;
            this.keterangan.Size = new System.Drawing.Size(134, 86);
            this.keterangan.TabIndex = 18;
            // 
            // buttonHitung
            // 
            this.buttonHitung.Location = new System.Drawing.Point(248, 248);
            this.buttonHitung.Name = "buttonHitung";
            this.buttonHitung.Size = new System.Drawing.Size(60, 25);
            this.buttonHitung.TabIndex = 19;
            this.buttonHitung.Text = "Hitung BMI";
            this.buttonHitung.UseVisualStyleBackColor = true;
            this.buttonHitung.Click += new System.EventHandler(this.buttonHitung_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(385, 319);
            this.Controls.Add(this.buttonHitung);
            this.Controls.Add(this.keterangan);
            this.Controls.Add(this.labelKeterangan);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.rbPon);
            this.Controls.Add(this.rbKg);
            this.Controls.Add(this.textBoxTinggi);
            this.Controls.Add(this.textBoxBerat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBerat;
        private System.Windows.Forms.TextBox textBoxTinggi;
        private System.Windows.Forms.RadioButton rbKg;
        private System.Windows.Forms.RadioButton rbPon;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label labelKeterangan;
        private System.Windows.Forms.TextBox keterangan;
        private System.Windows.Forms.Button buttonHitung;
    }
}