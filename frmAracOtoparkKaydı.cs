using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otopark_Otomasyonu
{
    public partial class frmAracOtoparkKaydı : Form
    {
        public frmAracOtoparkKaydı()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MSI;Initial Catalog=Otopark_ Otomasyonu;Integrated Security=True");
        private void frmAracOtoparkKaydı_Load(object sender, EventArgs e)
        {
            BoşAraçlar();
        }

        private void BoşAraçlar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select* from arac_durumu WHERE ParkDurumu='BOŞ'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbPark.Items.Add(read["ParkYeri"].ToString());
            }
            baglanti.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into arac_otopark_kaydı(TC,Ad,Soyad,Telefon,Email,Plaka,Marka,SeriNo,Renk,ParkYeri,Tarih) values(@TC,@Ad,@Soyad,@Telefon,@Email,@Plaka,@Marka,@SeriNo,@Renk,@ParkYeri,@Tarih)", baglanti);
            komut.Parameters.AddWithValue("@TC", txtTC.Text);
            komut.Parameters.AddWithValue("@Ad", txtAd.Text);
            komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", txtEmail.Text);
            komut.Parameters.AddWithValue("@Email", txtEmail.Text);
            komut.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("@Marka", cmbMarka.Text);
            komut.Parameters.AddWithValue("@SeriNo", cmbSeri.Text);
            komut.Parameters.AddWithValue("@Renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@ParkYeri", cmbPark.Text);
            komut.Parameters.AddWithValue("@Tarih",DateTime.Now.ToString());
            komut.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand("uptade arac_durumu set ParkDurumu = 'DOLU' where ParkYeri = '"+cmbPark.SelectedItem+"'",baglanti);
            komut2.ExecuteNonQuery(); 
            baglanti.Close();
            MessageBox.Show("Araç Kaydı Oluşturuldu","Kayıt");
            cmbPark.Items.Clear();
            BoşAraçlar();
        }
    }
}
