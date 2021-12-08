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

        private void frmAracOtoparkYerleri_Load(object sender, EventArgs e)
        {
            int sayac = 1;
            foreach (Control item in Controls) 
            {
                if (item is Button) 
                {
                    item.Text = "P-"+sayac;
                    item.Name = "P-"+ sayac;
                    sayac++;
                }

            }
        }
    }
}
