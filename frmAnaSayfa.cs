using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnAracKayıt_Click(object sender, EventArgs e)
        {
            frmAracOtoparkKaydı kayit = new frmAracOtoparkKaydı();
            kayit.ShowDialog();
        }

        private void btnAracYer_Click(object sender, EventArgs e)
        {
            frmAracOtoparkYerleri yer = new frmAracOtoparkYerleri();
            yer.ShowDialog();
        }

        private void btnAracCıkıs_Click(object sender, EventArgs e)
        {
            frmAracOtoparkCıkısı cıkıs = new frmAracOtoparkCıkısı();
            cıkıs.ShowDialog();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
