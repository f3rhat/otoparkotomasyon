
namespace Otopark_Otomasyonu
{
    partial class frmAnaSayfa
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
            this.btnAracKayıt = new System.Windows.Forms.Button();
            this.btnAracYer = new System.Windows.Forms.Button();
            this.btnAracCıkıs = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAracKayıt
            // 
            this.btnAracKayıt.Location = new System.Drawing.Point(235, 78);
            this.btnAracKayıt.Name = "btnAracKayıt";
            this.btnAracKayıt.Size = new System.Drawing.Size(270, 23);
            this.btnAracKayıt.TabIndex = 0;
            this.btnAracKayıt.Text = "Araç Otopark Kaydı Sayfası";
            this.btnAracKayıt.UseVisualStyleBackColor = true;
            this.btnAracKayıt.Click += new System.EventHandler(this.btnAracKayıt_Click);
            // 
            // btnAracYer
            // 
            this.btnAracYer.Location = new System.Drawing.Point(235, 139);
            this.btnAracYer.Name = "btnAracYer";
            this.btnAracYer.Size = new System.Drawing.Size(270, 23);
            this.btnAracYer.TabIndex = 1;
            this.btnAracYer.Text = "Araç Otopark Yerleri";
            this.btnAracYer.UseVisualStyleBackColor = true;
            this.btnAracYer.Click += new System.EventHandler(this.btnAracYer_Click);
            // 
            // btnAracCıkıs
            // 
            this.btnAracCıkıs.Location = new System.Drawing.Point(235, 196);
            this.btnAracCıkıs.Name = "btnAracCıkıs";
            this.btnAracCıkıs.Size = new System.Drawing.Size(270, 23);
            this.btnAracCıkıs.TabIndex = 2;
            this.btnAracCıkıs.Text = "Araç Otopark Çıkış Sayfası";
            this.btnAracCıkıs.UseVisualStyleBackColor = true;
            this.btnAracCıkıs.Click += new System.EventHandler(this.btnAracCıkıs_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Location = new System.Drawing.Point(235, 258);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(270, 23);
            this.btnCıkıs.TabIndex = 3;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnAracCıkıs);
            this.Controls.Add(this.btnAracYer);
            this.Controls.Add(this.btnAracKayıt);
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAracKayıt;
        private System.Windows.Forms.Button btnAracYer;
        private System.Windows.Forms.Button btnAracCıkıs;
        private System.Windows.Forms.Button btnCıkıs;
    }
}

