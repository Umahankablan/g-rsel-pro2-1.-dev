using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puan_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

             
                double vize, final;
            double ortalama, vizeyuzde, finalyuzde, yuzdetoplami;
            
            { 
               vize = Convert.ToDouble(numericUpDown1.Value);
               final = Convert.ToDouble(numericUpDown2.Value);

              vizeyuzde = Convert.ToDouble(numericUpDown3.Value);
              finalyuzde = Convert.ToDouble(numericUpDown4.Value);

               yuzdetoplami = (vizeyuzde + finalyuzde);

            }

            
             
                if  (vize < 0 || vize > 100)
                    {
                    MessageBox.Show("Vize Notunuz Hatalıdır. Lütfen 0 - 100 Arasında Değer Giriniz...");
                }
                else if (final < 0 || final > 100)
                {
                    MessageBox.Show(" Final Notunuz Hatalıdır. Lütfen 0 - 100 Arasında Değer Giriniz...");
                }
                else if (finalyuzde < 50 || vizeyuzde > 100)
                    {
                        MessageBox.Show("Final değeri 50'den Küçük, Vize değeri 100'den Büyük olamaz...");
                    }
                else
                {
                    vizeyuzde = Convert.ToDouble(numericUpDown3.Value);
                    vizeyuzde = vizeyuzde / 100;

                    finalyuzde = Convert.ToDouble(numericUpDown4.Value);
                    finalyuzde = finalyuzde / 100;

                    ortalama = vize *vizeyuzde + final * finalyuzde;
                    label9.Text = ortalama.ToString();

                if (ortalama >= 49.5 && final >= 49.5)
                {
                    label7.Text = "Geçtiniz :)";
                    label7.ForeColor = Color.Green;
                }

                else
                {
                    label7.Text = "Kaldınız :(";
                    label7.ForeColor = Color.Red;
                }

                if (yuzdetoplami != 100)
                    {
                        MessageBox.Show("Yüzdeliklerin toplamı 100 olmaldır...");  
                    }

                }



            }

        }
    }

