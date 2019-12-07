using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.DAL;
using Vektorel.KitapBankosu.Models;

namespace Vektorel.KtapBankosu.BLL
{
    public class YazarBL
    {
       
        public bool YazarEkle(Yazar yazar)
        {

            try
            {
                Helper hlp = new Helper();
                SqlParameter[] p = {
                new SqlParameter("@Ad", yazar.Ad), new SqlParameter("@Soyad", yazar.Soyad), new SqlParameter("@Dtar", yazar.DTar),new SqlParameter("@OlumTarih",yazar.OlumTarih)
            };

                if (yazar.OlumTarih == DateTime.MinValue)
                {
                    p[3].Value = DBNull.Value;
                }

                return hlp.ExcuteNonQuery("Insert into tblYazarlar values (@Ad,@Soyad,@Dtar,@OlumTarih)", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
