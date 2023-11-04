using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoCard
{
    public partial class BingoCard : Form
    {
        int a = 0;
        int[] card = new int[26];
        int check = 1;
        int i = 1;
        Random ransu = new Random();

        private void NumberSet(int x,int y)
        {
            for (i = x; i <= y; i++)
            {
                if (i == 13) check = 0;
                while (check == 1)
                {
                    a = ransu.Next(1, 16) + 15 * (y / 5 - 1);
                    for (int j = x; j <= i; j++)
                    {
                        if (card[j] == a) break;
                        else if (j == i)
                        {
                            card[i] = a;
                            check = 0;
                        }
                    }
                }
                check = 1;
            }
        }

        public BingoCard()
        {
            InitializeComponent();
        }

        private void BingoCard_Load(object sender, EventArgs e)
        {
            NumberSet(1, 5);
            NumberSet(6, 10);
            NumberSet(11, 15);
            NumberSet(16, 20);
            NumberSet(21, 25);
            this.B1.Text = string.Format("{0,2}", card[1]);
            this.B2.Text = string.Format("{0,2}", card[2]);
            this.B3.Text = string.Format("{0,2}", card[3]);
            this.B4.Text = string.Format("{0,2}", card[4]);
            this.B5.Text = string.Format("{0,2}", card[5]);
            this.I1.Text = string.Format("{0}", card[6]);
            this.I2.Text = string.Format("{0}", card[7]);
            this.I3.Text = string.Format("{0}", card[8]);
            this.I4.Text = string.Format("{0}", card[9]);
            this.I5.Text = string.Format("{0}", card[10]);
            this.N1.Text = string.Format("{0}", card[11]);
            this.N2.Text = string.Format("{0}", card[12]);
            this.N4.Text = string.Format("{0}", card[14]);
            this.N5.Text = string.Format("{0}", card[15]);
            this.G1.Text = string.Format("{0}", card[16]);
            this.G2.Text = string.Format("{0}", card[17]);
            this.G3.Text = string.Format("{0}", card[18]);
            this.G4.Text = string.Format("{0}", card[19]);
            this.G5.Text = string.Format("{0}", card[20]);
            this.O1.Text = string.Format("{0}", card[21]);
            this.O2.Text = string.Format("{0}", card[22]);
            this.O3.Text = string.Format("{0}", card[23]);
            this.O4.Text = string.Format("{0}", card[24]);
            this.O5.Text = string.Format("{0}", card[25]);
        }

        private void B1_Click(object sender, EventArgs e)
        {

        }

        private void B2_Click(object sender, EventArgs e)
        {

        }

        private void B3_Click(object sender, EventArgs e)
        {

        }

        private void B4_Click(object sender, EventArgs e)
        {

        }

        private void B5_Click(object sender, EventArgs e)
        {

        }

        private void I1_Click(object sender, EventArgs e)
        {

        }

        private void I2_Click(object sender, EventArgs e)
        {

        }

        private void I3_Click(object sender, EventArgs e)
        {

        }

        private void I4_Click(object sender, EventArgs e)
        {

        }

        private void I5_Click(object sender, EventArgs e)
        {

        }

        private void N1_Click(object sender, EventArgs e)
        {

        }

        private void N2_Click(object sender, EventArgs e)
        {

        }

        private void N4_Click(object sender, EventArgs e)
        {

        }

        private void N5_Click(object sender, EventArgs e)
        {

        }

        private void G1_Click(object sender, EventArgs e)
        {

        }

        private void G2_Click(object sender, EventArgs e)
        {

        }

        private void G3_Click(object sender, EventArgs e)
        {

        }

        private void G4_Click(object sender, EventArgs e)
        {

        }

        private void G5_Click(object sender, EventArgs e)
        {

        }

        private void O1_Click(object sender, EventArgs e)
        {

        }

        private void O2_Click(object sender, EventArgs e)
        {

        }

        private void O3_Click(object sender, EventArgs e)
        {

        }

        private void O4_Click(object sender, EventArgs e)
        {

        }

        private void O5_Click(object sender, EventArgs e)
        {

        }
    }
}
