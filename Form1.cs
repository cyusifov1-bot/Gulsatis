
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace GulSatisi
{
    public partial class Form1 : Form
    {
        private decimal toplamGelir = 0;

        public Form1()
        {
            InitializeComponent();

            // PNG şəkillərini yüklə
            string qovluq = Application.StartupPath;

            string flowerPath = Path.Combine(
                qovluq, "flower.png");

            string dibcekPath = Path.Combine(
                qovluq, "dibçək.png");

            if (File.Exists(flowerPath))
            {
                picFlower.Image = Image.FromFile(flowerPath);
            }

            if (File.Exists(dibcekPath))
            {
                picDibcek.Image = Image.FromFile(dibcekPath);
            }

            lblToplamGelir.Text = "0.00";
            errorProvider1.ContainerControl = this;
        }

        private void BtnSatis_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            // Boş xanaları yoxla
            bool xeta = false;

            if (string.IsNullOrWhiteSpace(txtGulNovu.Text))
            {
                errorProvider1.SetError(
                    txtGulNovu, "Gül növünü daxil edin!");
                xeta = true;
            }

            if (string.IsNullOrWhiteSpace(txtSay.Text))
            {
                errorProvider1.SetError(
                    txtSay, "Satış sayını daxil edin!");
                xeta = true;
            }

            if (string.IsNullOrWhiteSpace(txtQiymet.Text))
            {
                errorProvider1.SetError(
                    txtQiymet, "Qiyməti daxil edin!");
                xeta = true;
            }

            if (xeta)
                return;

            // Sayı yoxla
            int say;

            if (!int.TryParse(txtSay.Text.Trim(), out say)
                || say <= 0)
            {
                errorProvider1.SetError(
                    txtSay,
                    "Say müsbət tam ədəd olmalıdır!");
                return;
            }

            // Qiyməti yoxla (vergül və nöqtə qəbul edilir)
            decimal qiymet;

            string qiymetMetni = txtQiymet.Text.Trim()
                .Replace(',', '.');

            if (!decimal.TryParse(
                qiymetMetni,
                NumberStyles.AllowDecimalPoint |
                NumberStyles.AllowLeadingSign,
                CultureInfo.InvariantCulture,
                out qiymet) || qiymet <= 0)
            {
                errorProvider1.SetError(
                    txtQiymet,
                    "Qiymət sıfırdan böyük olmalıdır!");
                return;
            }

            // Yekun qiyməti hesabla
            decimal yekun = say * qiymet;

            // Cədvələ əlavə et
            dataGridView1.Rows.Add(
                txtGulNovu.Text.Trim(),
                say.ToString(),
                qiymet.ToString("F2", CultureInfo.InvariantCulture),
                yekun.ToString("F2", CultureInfo.InvariantCulture)
            );

            // Toplam gəliri yenilə
            toplamGelir += yekun;

            lblToplamGelir.Text =
                toplamGelir.ToString(
                    "F2", CultureInfo.InvariantCulture);

            // Xanaları təmizlə
            txtGulNovu.Clear();
            txtSay.Clear();
            txtQiymet.Clear();

            errorProvider1.Clear();
            txtGulNovu.Focus();
        }

        private void BtnCixis_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show(
                "Proqramdan çıxmaq istəyirsinizmi?",
                "Çıxış təsdiqi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (cavab == DialogResult.Yes)
            {
                this.Close();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Yüklənmiş şəkillərin yaddaşını boşalt
            if (picFlower.Image != null)
            {
                picFlower.Image.Dispose();
                picFlower.Image = null;
            }

            if (picDibcek.Image != null)
            {
                picDibcek.Image.Dispose();
                picDibcek.Image = null;
            }

            base.OnFormClosed(e);
        }
    }
}
