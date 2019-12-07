using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.KitapBankosu.Models;
using Vektorel.KtapBankosu.BLL;

namespace Vektorel.Windows.FormDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
           
            try
            {
                TurBL t = new TurBL();
                Tur tur = new Tur();
                tur.Turad = txtTurAd.Text;
                MessageBox.Show(t.TurEkle(tur)?"Ekleme Başarılı":"Ekleme Başarısız");
                
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        if (ex.Message.Contains("UK_tblTurler_TurAd"))
                        {
                            MessageBox.Show(ex.Number +" "+"Daha önce kaydedilmiş bir tür girdiniz.");
                        }
                        break;
                    default:
                        MessageBox.Show(ex.Number + "Numaralı veri tabanı hatası.");
                        break;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen hata");
            }

           
        }
    }
}
