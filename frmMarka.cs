using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MSI;Initial Catalog=Otopark_ Otomasyonu;Integrated Security=True");

        private void btnEkleMarka_Click(object sender, EventArgs e)
        {
            
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into arac_marka_bilgileri(marka) values('" + txtMrkEkle.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Marka Eklendi");
                txtMrkEkle.Clear();

            }
        }

        
    }
}
