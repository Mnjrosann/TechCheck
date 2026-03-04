using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyon
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        // 1. Yeni Kayıt Butonu (Sidebar'daki buton)
        private void btnEkle_Click(object sender, EventArgs e)
        {
            pnlYeniKayit.Visible = true;
            pnlYeniKayit.BringToFront();
            guna2DataGridView1.Visible = false;
        }

        // 2. Cihaz Listesi Butonu (Sidebar'daki buton)
        private void btnCihazlar_Click(object sender, EventArgs e)
        {
            pnlYeniKayit.Visible = false;
            guna2DataGridView1.Visible = true;
        }

        // 3. Kaydet Butonu (Kayıt panelinin içindeki yeşil buton)
        //test
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Tabloya verileri ekler
            guna2DataGridView1.Rows.Add(txtMusteri.Text, txtCihaz.Text, txtAriza.Text, "Beklemede", "0 TL");

            MessageBox.Show("Cihaz başarıyla eklendi!", "Bilgi");

            // İşlem bitince kutuları temizle
            txtMusteri.Clear();
            txtCihaz.Clear();
            txtAriza.Clear();
        }
    } // Dashboard sınıfının kapanış parantezi
}