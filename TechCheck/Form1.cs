using System.Data.SqlClient;
namespace TechCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connString = "Server=MNJROSAN\\SQLEXPRESS;Database=TechCheckDB;Trusted_Connection=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT UserRole FROM Users WHERE Username=@user AND Password=@pass";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                    object result = cmd.ExecuteScalar(); // Rolü getirir

                    if (result != null)
                    {
                        string role = result.ToString();
                        MessageBox.Show($"Hoş geldin! Rolün: {role}", "Giriş Başarılı");

                        // ROLE GÖRE EKRAN AÇMA (Madde 5.2)
                        if (role == "Admin")
                        {
                            AdminPanel adminEkran = new AdminPanel();
                            adminEkran.Show();
                        }
                        else if (role == "Technician")
                        {
                            TeknikerPaneli tekEkran = new TeknikerPaneli();
                            tekEkran.Show();
                        }
                        this.Hide(); // Login formunu gizle
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Hata");
                    }
                }
            }
            catch (Exception ex)
            {
                // Madde 5.4: Hata Yönetimi
                MessageBox.Show("Veritabanına bağlanırken bir sorun oluştu: " + ex.Message, "Sistem Hatası");
            }
        }
    }

    }

