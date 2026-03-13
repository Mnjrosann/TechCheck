using Microsoft.Data.SqlClient;
using System.Data;

namespace TechCheck
{
    public partial class Dashboard : Form
    {
        // Veritabanı bağlantı adresin
        string connString = @"Server=KEREMKLKS\SQLEXPRESS;Database=TechCheckDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;";

        public Dashboard()
        {
            try
            {
                InitializeComponent();

                // Form açıldığında ekranın ortasında ve görünür olması için ayarlar
                this.StartPosition = FormStartPosition.CenterScreen;
                this.Opacity = 1.0;

                // Uygulama açılır açılmaz verileri SQL'den çekip tabloya doldurur
                VerileriGetir();

                // Başlangıçta hangi panellerin görüneceğini netleştirelim
                if (pnlYeniKayit != null) pnlYeniKayit.Visible = false;
                if (guna2DataGridView1 != null)
                {
                    guna2DataGridView1.Visible = true;
                    guna2DataGridView1.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard yüklenirken bir sorun oluştu: " + ex.Message);
            }
        }

        // --- TRAFİK POLİSİ: VERİLERİ LİSTELEME METODU ---
        private void VerileriGetir()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT CustomerName, DeviceName, Issue, Status, Price FROM Devices";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Tabloya verileri bağla
                    guna2DataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Eğer tablo henüz oluşturulmadıysa veya isim yanlışsa hata verir
                MessageBox.Show("Liste güncellenirken hata: " + ex.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            pnlYeniKayit.Visible = true;
            pnlYeniKayit.BringToFront();
            guna2DataGridView1.Visible = false;
        }

        private void btnCihazlar_Click(object sender, EventArgs e)
        {
            pnlYeniKayit.Visible = false;
            guna2DataGridView1.Visible = true;
            guna2DataGridView1.BringToFront();

            // Cihaz listesi butonuna her basıldığında listeyi tazele
            VerileriGetir();
        }

        // --- TRAFİK POLİSİ: YENİ KAYIT EKLEME ---
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMusteri.Text) || string.IsNullOrWhiteSpace(txtCihaz.Text))
            {
                MessageBox.Show("Lütfen müşteri ve cihaz bilgilerini boş bırakmayın!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "INSERT INTO Devices (CustomerName, DeviceName, Issue, Status, Price) VALUES (@must, @cihaz, @ariza, @durum, @fiyat)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@must", txtMusteri.Text);
                        cmd.Parameters.AddWithValue("@cihaz", txtCihaz.Text);
                        cmd.Parameters.AddWithValue("@ariza", txtAriza.Text);
                        cmd.Parameters.AddWithValue("@durum", "Beklemede");
                        cmd.Parameters.AddWithValue("@fiyat", "Belirlenmedi");

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cihaz başarıyla sisteme eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kutuları temizle
                txtMusteri.Clear();
                txtCihaz.Clear();
                txtAriza.Clear();

                // Listeyi otomatik güncelle ki yeni kaydı görelim
                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu: " + ex.Message);
            }
        }

        private void pnlYeniKayit_Paint(object sender, PaintEventArgs e) { }
    }
}