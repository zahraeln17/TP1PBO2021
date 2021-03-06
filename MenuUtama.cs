using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEPEEE
{
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nama_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            //LoginPage.Show();
            this.Close();
        }

        private void home_Click(object sender, EventArgs e)
        {

        }

        private void cari_Click(object sender, EventArgs e)
        {
            panelBarang.Controls.Clear();
            int a = 1000;
            int bBawah = 0, bAtas = 100 * a * a;

            if (Convert.ToString(harga.Text) == "100rb - 200rb")
            {
                bBawah = 100 * a;
                bAtas = 200 * a;
            }
            else if (Convert.ToString(harga.Text) == "200rb - 500rb")
            {
                bBawah = 200 * a;
                bAtas = 500 * a;
            }
            else if (Convert.ToString(harga.Text) == "500rb - 1jt")
            {
                bBawah = 500 * a;
                bAtas = 1000 * a;
            }
            
        }
    }
}
