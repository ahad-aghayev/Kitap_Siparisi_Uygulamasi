namespace KitapKiralama
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKitap = new System.Windows.Forms.ComboBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtGunSayi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBxIndirim = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Seçiniz";
            // 
            // cmbKitap
            // 
            this.cmbKitap.FormattingEnabled = true;
            this.cmbKitap.Location = new System.Drawing.Point(59, 65);
            this.cmbKitap.Name = "cmbKitap";
            this.cmbKitap.Size = new System.Drawing.Size(377, 24);
            this.cmbKitap.TabIndex = 1;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnHesapla.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(280, 342);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(281, 87);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtGunSayi
            // 
            this.txtGunSayi.Location = new System.Drawing.Point(59, 152);
            this.txtGunSayi.Name = "txtGunSayi";
            this.txtGunSayi.Size = new System.Drawing.Size(377, 24);
            this.txtGunSayi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kiralanacak Gün Sayı";
            // 
            // checkBxIndirim
            // 
            this.checkBxIndirim.AutoSize = true;
            this.checkBxIndirim.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBxIndirim.Location = new System.Drawing.Point(50, 218);
            this.checkBxIndirim.Name = "checkBxIndirim";
            this.checkBxIndirim.Size = new System.Drawing.Size(275, 29);
            this.checkBxIndirim.TabIndex = 6;
            this.checkBxIndirim.Text = "Öğrenci İndirimi Uygula";
            this.checkBxIndirim.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBxIndirim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGunSayi);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.cmbKitap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Kitap Seçimi ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKitap;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtGunSayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBxIndirim;
    }
}

