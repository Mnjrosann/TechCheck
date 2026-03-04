using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // 1. EKSİK: Bunu eklemezsen SqlConnection hata verir!

namespace TeknikServisOtomasyon
{
    internal class SqlBaglantisi
    {
        // 2. EKSİK: Bunu bir metot (fonksiyon) içine almalısın
        public SqlConnection baglanti()
        {


            // Arkadaşının verdiği adresi buraya tırnak içine yaz
            SqlConnection baglan = new SqlConnection(@"Data Source=KEREMKLKS\SQLEXPRESS;Initial Catalog=TechCheckDB;Integrated Security=True");

            baglan.Open(); // Bağlantıyı açıyoruz
            return baglan; // Açtığımız bu bağlantıyı kullanacak olan yere gönderiyoruz
        }
    }
}