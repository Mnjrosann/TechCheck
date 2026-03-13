using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechCheck
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void formGetir(Form frm)
        {
            pnlAna.Controls.Clear(); // Önce panelin içindeki eski sayfayı temizle
            frm.MdiParent = null; // Bağımsız form olduğunu belirt
            frm.FormBorderStyle = FormBorderStyle.None; // Kenarlıkları kaldır ki panelin içine tam sığsın
            frm.TopLevel = false;
            pnlAna.Controls.Add(frm); // Formu panele ekle
            frm.Dock = DockStyle.Fill; // Paneli tamamen kapla
            frm.Show(); // Formu göster
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {

        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Butona basıldı, form yükleniyor...");
            formGetir(new YeniKayit());
        }

        private void pnlAna_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
