using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EslestirmeGercekSolmaz
{
    public partial class Form1 : Form
    {
        List<string> emojiler = new List<string>()
        {
            "🍎", "🍌", "🍒", "🍇", "🍉", "🍓", "🥑", "🥥",
                "🍎", "🍌", "🍒", "🍇", "🍉", "🍓", "🥑", "🥥",
        };

        Label ilkTıklanan = null;
        Label ikinciTıklanan = null;
        int kalanSure = 60;
        bool oyunDevamEdiyor = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oyunuBaslatDugmesi.Enabled = true;
        }

        private void oyunuBaslatDugmesi_Click(object sender, EventArgs e)
        {
            // Oyunu başlat düğmesini devre dışı bırak
            oyunuBaslatDugmesi.Enabled = false;

            // Oyunu başlat
            KarelereEmojileriAta();
            KarelereEmojileriAta();
            oyunZamanlayici.Start();

            oyunDevamEdiyor = true;
        }

        private void KarelereEmojileriAta()
        {
            Random rastgele = new Random();

            foreach (Control kontrol in tabloPaneli.Controls)
            {
                Label emojiEtiketi = kontrol as Label;
                if (emojiEtiketi != null)
                {
                    if (emojiler.Count == 0)
                        return;

                    int rastgeleSayi = rastgele.Next(emojiler.Count);
                    string seçilenEmoji = emojiler[rastgeleSayi];
                    emojiEtiketi.Text = seçilenEmoji;
                    emojiEtiketi.ForeColor = emojiEtiketi.BackColor;
                    emojiler.RemoveAt(rastgeleSayi);
                }
            }
        }

        private void Etiket_Click(object sender, EventArgs e)
        {
            if (!oyunDevamEdiyor)
                return;
            if (zamanlayici.Enabled == true)
                return;

            Label tıklananEtiket = sender as Label;

            if (tıklananEtiket != null)
            {
                if (tıklananEtiket.ForeColor == Color.Black)
                    return;

                if (ilkTıklanan == null)
                {
                    ilkTıklanan = tıklananEtiket;
                    ilkTıklanan.ForeColor = Color.Black;
                    return;
                }

                ikinciTıklanan = tıklananEtiket;
                ikinciTıklanan.ForeColor = Color.Black;

                KazananıKontrolEt();

                if (ilkTıklanan.Text == ikinciTıklanan.Text)
                {
                    ilkTıklanan = null;
                    ikinciTıklanan = null;
                    return;
                }

                zamanlayici.Start();
            }
        }

        private void zamanlayici_Tick(object sender, EventArgs e)
        {
            zamanlayici.Stop();

            ilkTıklanan.ForeColor = ilkTıklanan.BackColor;
            ikinciTıklanan.ForeColor = ikinciTıklanan.BackColor;

            ilkTıklanan = null;
            ikinciTıklanan = null;
        }

        private void oyunZamanlayici_Tick(object sender, EventArgs e)
        {
            kalanSure--;
            sureLabel.Text = kalanSure.ToString();

            if (kalanSure <= 0)
            {
                oyunZamanlayici.Stop();
                MessageBox.Show("Süre doldu! Kaybettiniz.", "Oyun Bitti");
                OyunuSifirla();
            }
        }

        private void KazananıKontrolEt()
        {
            foreach (Control kontrol in tabloPaneli.Controls)
            {
                Label emojiEtiketi = kontrol as Label;

                if (emojiEtiketi != null && emojiEtiketi.ForeColor == emojiEtiketi.BackColor)
                    return;
            }

            oyunZamanlayici.Stop();
            MessageBox.Show("Tebrikler! Tüm eşleşmeleri buldunuz.", "Oyun Bitti");
            OyunuSifirla();
        }

        private void OyunuSifirla()
        {
            emojiler = new List<string>()
            {
                "🍎", "🍌", "🍒", "🍇", "🍉", "🍓", "🥑", "🥥",
                "🍎", "🍌", "🍒", "🍇", "🍉", "🍓", "🥑", "🥥",
            };

            foreach (Control kontrol in tabloPaneli.Controls)
            {
                Label emojiEtiketi = kontrol as Label;
                if (emojiEtiketi != null)
                {
                    emojiEtiketi.Text = "";
                    emojiEtiketi.ForeColor = Color.Black;
                }
            }

            kalanSure = 60;
            sureLabel.Text = kalanSure.ToString();

            oyunDevamEdiyor = false;
            oyunuBaslatDugmesi.Enabled = true;
        }
    }
}
