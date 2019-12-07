using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.KitapBankosu.Models;
using Vektorel.KtapBankosu.BLL;

namespace Vektorel.Windows.FormDB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            YazarBL y = new YazarBL();
            Yazar yazar = new Yazar();
            yazar.Ad = txtAd.Text;
            yazar.Soyad = txtSoyad.Text;
            yazar.DTar = dtDogumTar.Value;
            if (!chYasiyor.Checked)
            {
                yazar.OlumTarih = Convert.ToDateTime(dtOlumTar.Value);
            }

            MessageBox.Show(y.YazarEkle(yazar) ? "Ekleme Başarılı" : "Ekleme Başarısız");
        }

        private void ChYasiyor_CheckedChanged(object sender, EventArgs e)
        {
            if (chYasiyor.Checked)
            {
                dtOlumTar.Enabled = false;
            }
            else
            {
                dtOlumTar.Enabled = true;
            }
        }
    }
}
