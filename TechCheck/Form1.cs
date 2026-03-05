using Microsoft.Data.SqlClient; // SQL işlemleri için
using System;
using System.Windows.Forms;
using TechCheck;

namespace TechCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hata almamak için bu metodun burada durması gerekiyor.
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Senin bilgisayar adın (KEREMKLKS) ve veritabanı adın
            string connString = @"Server=KEREMKLKS\SQLEXPRESS;Database=TechCheckDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    // Tablo adının SQL'de 'Users' olduğundan emin ol
                    string query = "SELECT UserRole FROM Users WHERE Username=@user AND Password=@pass";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Tasarımdaki kutuların Name özellikleri txtUsername ve txtPassword olmalı
                        cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string role = result.ToString();
                            MessageBox.Show($"Hoş geldin! Rolün: {role}", "Giriş Başarılı");

                            if (role == "Admin")
                            {
                                // Çözüm gezgininde gördüğüm Dashboard formunu açar
                                Dashboard adminEkran = new Dashboard();
                                adminEkran.Show();
                            }
                            else if (role == "Technician")
                            {
                                // Çözüm gezgininde gördüğüm TeknikerPaneli formunu açar
                                TeknikerPaneli tekEkran = new TeknikerPaneli();
                                tekEkran.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Paylaştığın ekran görüntüsündeki hatayı yakalar
                MessageBox.Show("Sistem Hatası: " + ex.Message, "Bağlantı Sorunu");
            }
        }
    }
}