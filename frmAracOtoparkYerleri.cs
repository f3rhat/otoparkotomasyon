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
    public partial class frmAracOtoparkYerleri : Form
    {
        public frmAracOtoparkYerleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MSI;Initial Catalog=Otopark_ Otomasyonu;Integrated Security=True");


        private void frmAracOtoparkYerleri_Load(object sender, EventArgs e)
        {
            BoşParkYerleri();
            DoluParkYerleri();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select*from arac_otopark_kaydı", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == read["ParkYeri"].ToString())
                        {
                            item.Text = read["Plaka"].ToString();
                        }
                    }
                }
            }
            baglanti.Close();
        }

        private void DoluParkYerleri()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select*from arac_durumu", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == read["ParkYeri"].ToString() && read["ParkDurumu"].ToString() == "DOLU")
                        {
                            item.BackColor = Color.Red;
                        }
                    }
                }
            }
            baglanti.Close();
        }

        private void BoşParkYerleri()
        {
            int sayac = 1;
            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.Text = "P-" + sayac;
                    item.Name = "P-" + sayac;
                    sayac++;
                }

            }
        }
    }
}
