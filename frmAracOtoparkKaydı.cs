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
            Marka();
            
        }

        private void Marka()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select marka from arac_marka_bilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
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

            var sqlKomut = "update arac_durumu set ParkDurumu = 'DOLU' where ParkYeri = '" + cmbPark.SelectedItem + "'";

            SqlCommand komut2 = new SqlCommand(sqlKomut,baglanti);
            komut2.ExecuteNonQuery(); 
            baglanti.Close();
            MessageBox.Show("Araç Kaydı Oluşturuldu","Kayıt");
            cmbPark.Items.Clear();
            BoşAraçlar();
            cmbMarka.Items.Clear();
            Marka();
            cmbSeri.Items.Clear();
            foreach (Control item in grpKişi.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in grpArac.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in grpArac.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void btnSeri_Click(object sender, EventArgs e)
        {
            frmSeri seri = new frmSeri();
            seri.ShowDialog();

        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSeri.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select A_seri from arac_seri_bilgileri where A_Marka='"+cmbMarka.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbSeri.Items.Add(read["A_Seri"].ToString());
            }
            baglanti.Close();
        }
    }
}
