using System;
using Microsoft.Data.SqlClient; // Yeni kütüphane

namespace TechCheck // Proje adınla uyumlu olmalı
{
    internal class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            // Buradaki Data Source kısmına SSMS'den kopyaladığın ismi yazdığından emin ol
            string yol = @"Data Source=KEREMKLKS\SQLEXPRESS;Initial Catalog=TechCheckDB;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";

            SqlConnection baglan = new SqlConnection(yol);

            // Eğer kapalıysa kapıyı açıyoruz
            if (baglan.State == System.Data.ConnectionState.Closed)
            {
                baglan.Open();
            }

            return baglan;
        }
    }
}