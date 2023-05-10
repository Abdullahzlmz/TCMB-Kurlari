namespace DovizKuru
{
    partial class Kurlar
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
            this.lblTarih = new System.Windows.Forms.Label();
            this.txtDovAlis = new System.Windows.Forms.TextBox();
            this.txtDovSatis = new System.Windows.Forms.TextBox();
            this.txtEfektifAlis = new System.Windows.Forms.TextBox();
            this.txtEfektifSatis = new System.Windows.Forms.TextBox();
            this.lblDovAlis = new System.Windows.Forms.Label();
            this.lblDovSatis = new System.Windows.Forms.Label();
            this.lblEfektifAlis = new System.Windows.Forms.Label();
            this.lblEfektifSatis = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.MaskedTextBox();
            this.comboTCMBDovIsmi = new System.Windows.Forms.ComboBox();
            this.lblTCMBDovIsmi = new System.Windows.Forms.Label();
            this.btnKurGetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDovizAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(36, 4);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(44, 16);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "Tarih :";
            // 
            // txtDovAlis
            // 
            this.txtDovAlis.Location = new System.Drawing.Point(48, 98);
            this.txtDovAlis.MaxLength = 15;
            this.txtDovAlis.Name = "txtDovAlis";
            this.txtDovAlis.Size = new System.Drawing.Size(100, 22);
            this.txtDovAlis.TabIndex = 2;
            // 
            // txtDovSatis
            // 
            this.txtDovSatis.Location = new System.Drawing.Point(154, 98);
            this.txtDovSatis.MaxLength = 15;
            this.txtDovSatis.Name = "txtDovSatis";
            this.txtDovSatis.Size = new System.Drawing.Size(100, 22);
            this.txtDovSatis.TabIndex = 3;
            // 
            // txtEfektifAlis
            // 
            this.txtEfektifAlis.Location = new System.Drawing.Point(260, 98);
            this.txtEfektifAlis.MaxLength = 15;
            this.txtEfektifAlis.Name = "txtEfektifAlis";
            this.txtEfektifAlis.Size = new System.Drawing.Size(100, 22);
            this.txtEfektifAlis.TabIndex = 4;
            // 
            // txtEfektifSatis
            // 
            this.txtEfektifSatis.Location = new System.Drawing.Point(366, 98);
            this.txtEfektifSatis.MaxLength = 15;
            this.txtEfektifSatis.Name = "txtEfektifSatis";
            this.txtEfektifSatis.Size = new System.Drawing.Size(100, 22);
            this.txtEfektifSatis.TabIndex = 5;
            // 
            // lblDovAlis
            // 
            this.lblDovAlis.AutoSize = true;
            this.lblDovAlis.Location = new System.Drawing.Point(59, 79);
            this.lblDovAlis.Name = "lblDovAlis";
            this.lblDovAlis.Size = new System.Drawing.Size(66, 16);
            this.lblDovAlis.TabIndex = 6;
            this.lblDovAlis.Text = "Döviz Alış";
            // 
            // lblDovSatis
            // 
            this.lblDovSatis.AutoSize = true;
            this.lblDovSatis.Location = new System.Drawing.Point(165, 79);
            this.lblDovSatis.Name = "lblDovSatis";
            this.lblDovSatis.Size = new System.Drawing.Size(74, 16);
            this.lblDovSatis.TabIndex = 7;
            this.lblDovSatis.Text = "Döviz Satış";
            // 
            // lblEfektifAlis
            // 
            this.lblEfektifAlis.AutoSize = true;
            this.lblEfektifAlis.Location = new System.Drawing.Point(277, 79);
            this.lblEfektifAlis.Name = "lblEfektifAlis";
            this.lblEfektifAlis.Size = new System.Drawing.Size(68, 16);
            this.lblEfektifAlis.TabIndex = 8;
            this.lblEfektifAlis.Text = "Efektif Alış";
            // 
            // lblEfektifSatis
            // 
            this.lblEfektifSatis.AutoSize = true;
            this.lblEfektifSatis.Location = new System.Drawing.Point(375, 79);
            this.lblEfektifSatis.Name = "lblEfektifSatis";
            this.lblEfektifSatis.Size = new System.Drawing.Size(76, 16);
            this.lblEfektifSatis.TabIndex = 9;
            this.lblEfektifSatis.Text = "Efektif Satış";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(12, 23);
            this.txtTarih.Mask = "00,00,0000";
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(100, 22);
            this.txtTarih.TabIndex = 10;
            this.txtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // comboTCMBDovIsmi
            // 
            this.comboTCMBDovIsmi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTCMBDovIsmi.FormattingEnabled = true;
            this.comboTCMBDovIsmi.Location = new System.Drawing.Point(154, 21);
            this.comboTCMBDovIsmi.Name = "comboTCMBDovIsmi";
            this.comboTCMBDovIsmi.Size = new System.Drawing.Size(61, 24);
            this.comboTCMBDovIsmi.TabIndex = 11;
            this.comboTCMBDovIsmi.SelectedIndexChanged += new System.EventHandler(this.comboTCMBDovIsmi_SelectedIndexChanged);
            // 
            // lblTCMBDovIsmi
            // 
            this.lblTCMBDovIsmi.AutoSize = true;
            this.lblTCMBDovIsmi.Location = new System.Drawing.Point(132, 2);
            this.lblTCMBDovIsmi.Name = "lblTCMBDovIsmi";
            this.lblTCMBDovIsmi.Size = new System.Drawing.Size(122, 16);
            this.lblTCMBDovIsmi.TabIndex = 12;
            this.lblTCMBDovIsmi.Text = "TCMB Döviz Kodu :";
            // 
            // btnKurGetir
            // 
            this.btnKurGetir.Location = new System.Drawing.Point(12, 142);
            this.btnKurGetir.Name = "btnKurGetir";
            this.btnKurGetir.Size = new System.Drawing.Size(500, 29);
            this.btnKurGetir.TabIndex = 13;
            this.btnKurGetir.Text = "Kurları Getir";
            this.btnKurGetir.UseVisualStyleBackColor = true;
            this.btnKurGetir.Click += new System.EventHandler(this.btnKurGetir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "TCMB Döviz Adı :";
            // 
            // txtDovizAdi
            // 
            this.txtDovizAdi.Location = new System.Drawing.Point(260, 23);
            this.txtDovizAdi.MaxLength = 50;
            this.txtDovizAdi.Name = "txtDovizAdi";
            this.txtDovizAdi.Size = new System.Drawing.Size(254, 22);
            this.txtDovizAdi.TabIndex = 15;
            // 
            // Kurlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 176);
            this.Controls.Add(this.txtDovizAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKurGetir);
            this.Controls.Add(this.lblTCMBDovIsmi);
            this.Controls.Add(this.comboTCMBDovIsmi);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.lblEfektifSatis);
            this.Controls.Add(this.lblEfektifAlis);
            this.Controls.Add(this.lblDovSatis);
            this.Controls.Add(this.lblDovAlis);
            this.Controls.Add(this.txtEfektifSatis);
            this.Controls.Add(this.txtEfektifAlis);
            this.Controls.Add(this.txtDovSatis);
            this.Controls.Add(this.txtDovAlis);
            this.Controls.Add(this.lblTarih);
            this.Name = "Kurlar";
            this.Text = "Kurlar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox txtDovAlis;
        private System.Windows.Forms.TextBox txtDovSatis;
        private System.Windows.Forms.TextBox txtEfektifAlis;
        private System.Windows.Forms.TextBox txtEfektifSatis;
        private System.Windows.Forms.Label lblDovAlis;
        private System.Windows.Forms.Label lblDovSatis;
        private System.Windows.Forms.Label lblEfektifAlis;
        private System.Windows.Forms.Label lblEfektifSatis;
        private System.Windows.Forms.MaskedTextBox txtTarih;
        private System.Windows.Forms.ComboBox comboTCMBDovIsmi;
        private System.Windows.Forms.Label lblTCMBDovIsmi;
        private System.Windows.Forms.Button btnKurGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDovizAdi;
    }
}

