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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        Pripojeni connect = new Pripojeni();
        Form1 form1 = new Form1();

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            connect.ShowDialog();
            this.Show();
        }
    }
}
