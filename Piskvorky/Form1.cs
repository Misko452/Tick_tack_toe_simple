using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piskvorky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool hrac1 = true;

        string hrac1obsazeno = "";
        string hrac2obsazeno = "";


        int skore1 = 0;
        int skore2 = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;

            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;

            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;

            A1.Image = Properties.Resources.stahování;
            A2.Image = Properties.Resources.stahování;
            A3.Image = Properties.Resources.stahování;

            B1.Image = Properties.Resources.stahování;
            B2.Image = Properties.Resources.stahování;
            B3.Image = Properties.Resources.stahování;

            C1.Image = Properties.Resources.stahování;
            C2.Image = Properties.Resources.stahování;
            C3.Image = Properties.Resources.stahování;

            hrac1obsazeno = "";
            hrac2obsazeno = "";

            Button1.Text = "Hrát";

            ZapisKdoHraje();
        }

        public void ZapisKdoHraje()
        {
            if (hrac1 == true)
            {
                string hrac = "Hráč 1";
                label2.Text = "Na řadě: " + hrac;
                
            }
            else
            {
                string hrac = "Hráč 2";
                label2.Text = "Na řadě: " + hrac;
            }
        }

        public void VypniPicture()
        {
            A1.Enabled = false;
            A2.Enabled = false;
            A3.Enabled = false;

            B1.Enabled = false;
            B2.Enabled = false;
            B3.Enabled = false;

            C1.Enabled = false;
            C2.Enabled = false;
            C3.Enabled = false;
        }


        public void CheckWin1()
        {
            if (hrac1obsazeno.Contains("A1") == true && hrac1obsazeno.Contains("A2") == true && hrac1obsazeno.Contains("A3") == true)
            {
                VypniPicture();
                MessageBox.Show("Hráč 1 vyhrál");
                skore1++;
                label3.Text = "Hráč 1: " + skore1;
                Button1.Text = "Restart";
                return;
            }
            else if (hrac1obsazeno.Contains("B1") == true && hrac1obsazeno.Contains("B2") == true && hrac1obsazeno.Contains("B3") == true)
            {
                VypniPicture();
                MessageBox.Show("Hráč 1 vyhrál");
                skore1++;
                label3.Text = "Hráč 1: " + skore1;
                Button1.Text = "Restart";
                return;
            }
            else if (hrac1obsazeno.Contains("C1") == true && hrac1obsazeno.Contains("C2") == true && hrac1obsazeno.Contains("C3") == true)
            {
                VypniPicture();
                MessageBox.Show("Hráč 1 vyhrál");
                skore1++;
                label3.Text = "Hráč 1: " + skore1;
                Button1.Text = "Restart";
                return;
            }
            else if (hrac1obsazeno.Contains("A1") == true && hrac1obsazeno.Contains("B1") == true && hrac1obsazeno.Contains("C1") == true)
            {
                VypniPicture();
                MessageBox.Show("Hráč 1 vyhrál");
                skore1++;
                label3.Text = "Hráč 1: " + skore1;
                Button1.Text = "Restart";
                return;
            }
            else if (hrac1obsazeno.Contains("A2") == true && hrac1obsazeno.Contains("B2") == true && hrac1obsazeno.Contains("C2") == true)
            {
                VypniPicture();
                MessageBox.Show("Hráč 1 vyhrál");
                skore1++;
                label3.Text = "Hráč 1: " + skore1;
                Button1.Text = "Restart";
                return;
            }
            else if (hrac1obsazeno.Contains("A3") == true && hrac1obsazeno.Contains("B3") == true && hrac1obsazeno.Contains("C3") == true)
            {
                VypniPicture();
                MessageBox.Show("Hráč 1 vyhrál");
                skore1++;
                label3.Text = "Hráč 1: " + skore1;
                Button1.Text = "Restart";
                return;
            }
            else if (hrac1obsazeno.Contains("A1") == true && hrac1obsazeno.Contains("B2") == true && hrac1obsazeno.Contains("C3") == true)
            {
                VypniPicture();
                MessageBox.Show("Hráč 1 vyhrál");
                skore1++;
                label3.Text = "Hráč 1: " + skore1;
                Button1.Text = "Restart";
                return;
            }
            else if (hrac1obsazeno.Contains("A3") == true && hrac1obsazeno.Contains("B2") == true && hrac1obsazeno.Contains("C1") == true)
            {
                VypniPicture();
                MessageBox.Show("Hráč 1 vyhrál");
                skore1++;
                label3.Text = "Hráč 1: " + skore1;
                Button1.Text = "Restart";
                return;
            }

        }

        public void CheckWin2()
        {
                if (hrac2obsazeno.Contains("A1") == true && hrac2obsazeno.Contains("A2") == true && hrac2obsazeno.Contains("A3") == true)
                {
                    VypniPicture();
                    MessageBox.Show("Hráč 2 vyhrál");
                    skore2++;
                    label4.Text = "Hráč 2: " + skore2;
                    Button1.Text = "Restart";
                    return;
                }
                else if (hrac2obsazeno.Contains("B1") == true && hrac2obsazeno.Contains("B2") == true && hrac2obsazeno.Contains("B3") == true)
                {
                    VypniPicture();
                    MessageBox.Show("Hráč 2 vyhrál");
                    skore2++;
                    label4.Text = "Hráč 2: " + skore2;
                    Button1.Text = "Restart";
                    return;
                }
                else if (hrac2obsazeno.Contains("C1") == true && hrac2obsazeno.Contains("C2") == true && hrac2obsazeno.Contains("C3") == true)
                {
                    VypniPicture();
                    MessageBox.Show("Hráč 2 vyhrál");
                    skore2++;
                    label4.Text = "Hráč 2: " + skore2;
                    Button1.Text = "Restart";
                    return;

                }
                else if (hrac2obsazeno.Contains("A1") == true && hrac2obsazeno.Contains("B1") == true && hrac2obsazeno.Contains("C1") == true)
                {
                    VypniPicture();
                    MessageBox.Show("Hráč 2 vyhrál");
                    skore2++;
                    label4.Text = "Hráč 2: " + skore2;
                    Button1.Text = "Restart";
                    return;
                }
                else if (hrac2obsazeno.Contains("A2") == true && hrac2obsazeno.Contains("B2") == true && hrac2obsazeno.Contains("C2") == true)
                {
                    VypniPicture();
                    MessageBox.Show("Hráč 2 vyhrál");
                    skore2++;
                    label4.Text = "Hráč 2: " + skore2;
                    Button1.Text = "Restart";
                    return;
                }
                else if (hrac2obsazeno.Contains("A3") == true && hrac2obsazeno.Contains("B3") == true && hrac2obsazeno.Contains("B3") == true)
                {
                    VypniPicture();
                    MessageBox.Show("Hráč 2 vyhrál");
                    skore2++;
                    label4.Text = "Hráč 2: " + skore2;
                    Button1.Text = "Restart";
                    return;
                }
                else if (hrac2obsazeno.Contains("A1") == true && hrac2obsazeno.Contains("B2") == true && hrac2obsazeno.Contains("C3") == true)
                {
                    VypniPicture();
                    MessageBox.Show("Hráč 2 vyhrál");
                    skore2++;
                    label4.Text = "Hráč 2: " + skore2;
                    Button1.Text = "Restart";
                    return;
                }
                else if (hrac2obsazeno.Contains("A3") == true && hrac2obsazeno.Contains("B2") == true && hrac2obsazeno.Contains("C1") == true)
                {
                    VypniPicture();
                    MessageBox.Show("Hráč 2 vyhrál");
                    skore2++;
                    label4.Text = "Hráč 2: " + skore2;
                    Button1.Text = "Restart";
                    return;
                }    
        }

        private void A1_Click(object sender, EventArgs e)
        {
            if (hrac1 == true)
            {
                hrac1obsazeno = hrac1obsazeno + "A1 ";
                A1.Image = Properties.Resources.Krizek1;
                A1.Enabled = false;
                hrac1 = false;
                CheckWin1();

            }
            else
            {
                hrac2obsazeno = hrac2obsazeno + "A1 ";
                A1.Image = Properties.Resources.krouzek;
                A1.Enabled = false;
                hrac1 = true;
                CheckWin2();

            }
            ZapisKdoHraje();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (hrac1 == true)
            {
                hrac1obsazeno = hrac1obsazeno + "B1 ";
                B1.Image = Properties.Resources.Krizek1;
                B1.Enabled = false;
                hrac1 = false;
                CheckWin1();

            }
            else
            {
                hrac2obsazeno = hrac2obsazeno + "B1 ";
                B1.Image = Properties.Resources.krouzek;
                B1.Enabled = false;
                hrac1 = true;
                CheckWin2();

            }
            ZapisKdoHraje();
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (hrac1 == true)
            {
                hrac1obsazeno = hrac1obsazeno + "C1 ";
                C1.Image = Properties.Resources.Krizek1;
                C1.Enabled = false;
                hrac1 = false;
                CheckWin1();

            }
            else
            {
                hrac2obsazeno = hrac2obsazeno + "C1 ";
                C1.Image = Properties.Resources.krouzek;
                C1.Enabled = false;
                hrac1 = true;
                CheckWin2();
            }
            ZapisKdoHraje();
        }

        private void A2_Click(object sender, EventArgs e)
        {
            if (hrac1 == true)
            {
                hrac1obsazeno = hrac1obsazeno + "A2 ";
                A2.Image = Properties.Resources.Krizek1;
                A2.Enabled = false;
                hrac1 = false;
                CheckWin1();
            }
            else
            {
                hrac2obsazeno = hrac2obsazeno + "A2 ";
                A2.Image = Properties.Resources.krouzek;
                A2.Enabled = false;
                hrac1 = true;
                CheckWin2();
            }
            ZapisKdoHraje();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (hrac1 == true)
            {
                hrac1obsazeno = hrac1obsazeno + "B2 ";
                B2.Image = Properties.Resources.Krizek1;
                B2.Enabled = false;
                hrac1 = false;
                CheckWin1();
            }
            else
            {
                hrac2obsazeno = hrac2obsazeno + "B2 ";
                B2.Image = Properties.Resources.krouzek;
                B2.Enabled = false;
                hrac1 = true;
                CheckWin2();
            }
            ZapisKdoHraje();
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (hrac1 == true)
            {
                hrac1obsazeno = hrac1obsazeno + "C2 ";
                C2.Image = Properties.Resources.Krizek1;
                C2.Enabled = false;
                hrac1 = false;
                CheckWin1();
            }
            else
            {
                hrac2obsazeno = hrac2obsazeno + "C2 ";
                C2.Image = Properties.Resources.krouzek;
                C2.Enabled = false;
                hrac1 = true;
                CheckWin2();
            }
            ZapisKdoHraje();
        }

        private void A3_Click(object sender, EventArgs e)
        {
            if (hrac1 == true)
            {
                hrac1obsazeno = hrac1obsazeno + "A3 ";
                A3.Image = Properties.Resources.Krizek1;
                A3.Enabled = false;
                hrac1 = false;
                CheckWin1();
            }
            else
            {
                hrac2obsazeno = hrac2obsazeno + "A3 ";
                A3.Image = Properties.Resources.krouzek;
                A3.Enabled = false;
                hrac1 = true;
                CheckWin2();
            }
            ZapisKdoHraje();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (hrac1 == true)
            {
                hrac1obsazeno = hrac1obsazeno + "B3 ";
                B3.Image = Properties.Resources.Krizek1;
                B3.Enabled = false;
                hrac1 = false;
                CheckWin1();
            }
            else
            {
                hrac2obsazeno = hrac2obsazeno + "B3 ";
                B3.Image = Properties.Resources.krouzek;
                B3.Enabled = false;
                hrac1 = true;
                CheckWin2();
            }
            ZapisKdoHraje();
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (hrac1 == true)
            {
                hrac1obsazeno = hrac1obsazeno + "C3 ";
                C3.Image = Properties.Resources.Krizek1;
                C3.Enabled = false;
                hrac1 = false;
                CheckWin1();
            }
            else
            {
                hrac2obsazeno = hrac2obsazeno + "C3 ";
                C3.Image = Properties.Resources.krouzek;
                C3.Enabled = false;
                hrac1 = true;
                CheckWin2();
            }
            ZapisKdoHraje();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            skore1 = 0;
            skore2 = 0;
            label3.Text = "Hráč 1: " + skore1;
            label4.Text = "Hráč 2: " + skore2;

            A1.Image = Properties.Resources.stahování;
            A2.Image = Properties.Resources.stahování;
            A3.Image = Properties.Resources.stahování;

            B1.Image = Properties.Resources.stahování;
            B2.Image = Properties.Resources.stahování;
            B3.Image = Properties.Resources.stahování;

            C1.Image = Properties.Resources.stahování;
            C2.Image = Properties.Resources.stahování;
            C3.Image = Properties.Resources.stahování;

            hrac1obsazeno = "";
            hrac2obsazeno = "";

            Button1.Text = "Hrát";

            ZapisKdoHraje();

        }
    }
}