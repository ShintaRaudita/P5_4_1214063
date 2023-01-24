using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_1214063
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbJK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btTampil_Click(object sender, EventArgs e)
        {
            string kelas = "";
            string jadwal = "";

            if (rbJadwal1.Checked)
            {
                jadwal = "senin & Rabu, 14.00 - 16.00";
            }
            else if (rbJadwal2.Checked)
            {
                jadwal = "selasa & Kamis, 14.00 - 16.00";
            }
            else if (rbJadwal3.Checked)
            {
                jadwal = "sabtu & Minggu, 09.00 - 11.00";
            }
            else if (rbJadwal4.Checked)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }
            else if (jadwal == "")
            {
                MessageBox.Show("Harus memiliki salah satu dari pilihan jadwal", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (cbBiola.Checked)
            {
                kelas = kelas + "Biola, ";
            }
            if (cbGitar.Checked)
            {
                kelas = kelas + "Gitar, ";
            }
            if (cbSaxophone.Checked)
            {
                kelas = kelas + "Saxophone, ";
            }
            if (cbKonduktor.Checked)
            {
                kelas = kelas + "Konduktor, ";
            }
            if (cbPiano.Checked)
            {
                kelas = kelas + "Piano, ";
            }
            if (cbDrum.Checked)
            {
                kelas = kelas + "Drum, ";
            }
            if (cbVokal.Checked)
            {
                kelas = kelas + "Vokal, ";
            }
            if (cbKomposer.Checked)
            {
                kelas = kelas + "Komposer, ";
            }
            if (kelas == "")
            {
                MessageBox.Show("Wajib memilih salah satu dari pilihan kelas", "Warning!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show
                ("Nama\t\t: " + tbNama.Text +
                "\nJenis Kelamin\t: " + cbJK.Text +
                "\nTanggal Lahir\t: " + dtpTL.Text +
                "\nPilihan Kelas\t: " + kelas +
                "\nPilihan Jadwal\t: " + jadwal,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }// end private void btTampil_Click(object sender, EventArgs e)

        private void btSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
