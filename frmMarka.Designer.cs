
namespace Otopark_Otomasyonu
{
    partial class frmMarka
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
            this.btnEkleMarka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMrkEkle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEkleMarka
            // 
            this.btnEkleMarka.Location = new System.Drawing.Point(103, 126);
            this.btnEkleMarka.Name = "btnEkleMarka";
            this.btnEkleMarka.Size = new System.Drawing.Size(75, 23);
            this.btnEkleMarka.TabIndex = 0;
            this.btnEkleMarka.Text = "Ekle";
            this.btnEkleMarka.UseVisualStyleBackColor = true;
            this.btnEkleMarka.Click += new System.EventHandler(this.btnEkleMarka_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka :";
            // 
            // txtMrkEkle
            // 
            this.txtMrkEkle.Location = new System.Drawing.Point(94, 60);
            this.txtMrkEkle.Name = "txtMrkEkle";
            this.txtMrkEkle.Size = new System.Drawing.Size(100, 23);
            this.txtMrkEkle.TabIndex = 2;
            
            // 
            // frmMarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(307, 225);
            this.Controls.Add(this.txtMrkEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkleMarka);
            this.Name = "frmMarka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marka";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkleMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMrkEkle;
    }
}