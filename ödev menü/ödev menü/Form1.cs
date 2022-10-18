using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev_menü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void programdanÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult basilantus;
            basilantus = MessageBox.Show("Programdan Çıkmak mı istiyorsunuz?",
                "Çıkış Ekranı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (basilantus == DialogResult.Yes) Application.Exit();
        }

        private void öğrenciKimlikBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ogrenciKimlik = new Form2();
            ogrenciKimlik.ShowDialog();
        }

        private void ogrenciSicilBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ogrenciKimlik = new Form2();
            ogrenciKimlik.ShowDialog();
        }

        private void aksiyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
