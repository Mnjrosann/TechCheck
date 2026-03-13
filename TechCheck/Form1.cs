using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System.Data;

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
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Lütfen alanları doldurun.");
                return;
            }

            const string connString = @"Server=KEREMKLKS\SQLEXPRESS;Database=TechCheckDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;";

            try
            {
                using var conn = new SqlConnection(connString);
                conn.Open();

                const string query = "SELECT Role FROM Users WHERE Username=@user AND Password=@pass";
                using var cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@user", txtUser.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txtPass.Text.Trim());

                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string role = result.ToString() ?? "User";
                    MessageBox.Show($"Hoş geldin! Rolün: {role}");
                    Dashboard dash = new();
                    dash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    }
}