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
    public partial class frmSeri : Form
    {
        public frmSeri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MSI;Initial Catalog=Otopark_ Otomasyonu;Integrated Security=True");
        private void marka() 
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select marka from arac_marka_bilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbSeriEkle.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }
        private void frmSeri_Load(object sender, EventArgs e)
        {
            marka();
        }

        private void btnEkleSeri_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into arac_seri_bilgileri(A_Marka,A_Seri) values('"+cmbSeriEkle.Text+"','" + txtMarkaEkle.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Markaya Bağlı Araç Serisi Eklendi");
            txtMarkaEkle.Clear();
            cmbSeriEkle.Text = "";
            cmbSeriEkle.Items.Clear();
            marka();
        }
    }
}
