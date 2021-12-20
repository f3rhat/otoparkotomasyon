
namespace Otopark_Otomasyonu
{
    partial class frmSeri
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
            this.txtMarkaEkle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkleSeri = new System.Windows.Forms.Button();
            this.cmbSeriEkle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMarkaEkle
            // 
            this.txtMarkaEkle.Location = new System.Drawing.Point(114, 93);
            this.txtMarkaEkle.Name = "txtMarkaEkle";
            this.txtMarkaEkle.Size = new System.Drawing.Size(100, 23);
            this.txtMarkaEkle.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marka :";
            // 
            // btnEkleSeri
            // 
            this.btnEkleSeri.Location = new System.Drawing.Point(127, 177);
            this.btnEkleSeri.Name = "btnEkleSeri";
            this.btnEkleSeri.Size = new System.Drawing.Size(75, 23);
            this.btnEkleSeri.TabIndex = 3;
            this.btnEkleSeri.Text = "Ekle";
            this.btnEkleSeri.UseVisualStyleBackColor = true;
            this.btnEkleSeri.Click += new System.EventHandler(this.btnEkleSeri_Click);
            // 
            // cmbSeriEkle
            // 
            this.cmbSeriEkle.FormattingEnabled = true;
            this.cmbSeriEkle.Location = new System.Drawing.Point(114, 43);
            this.cmbSeriEkle.Name = "cmbSeriEkle";
            this.cmbSeriEkle.Size = new System.Drawing.Size(121, 23);
            this.cmbSeriEkle.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seri:";
            // 
            // frmSeri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(369, 263);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSeriEkle);
            this.Controls.Add(this.txtMarkaEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkleSeri);
            this.Name = "frmSeri";
            this.Text = "Seri";
            this.Load += new System.EventHandler(this.frmSeri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarkaEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkleSeri;
        private System.Windows.Forms.ComboBox cmbSeriEkle;
        private System.Windows.Forms.Label label2;
    }
}