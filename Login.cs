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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if(String.Equals(Convert.ToString(TxtPassword.Text), "pbo123") && Convert.ToString(TxtUsername.Text) != "")
            {
                MenuUtama Menut = new MenuUtama();
                
                Menut.ShowDialog();
                this.Show();
                MessageBox.Show("Kamu berhasil login");
            }
            else if(TxtUsername.Text == "" && TxtPassword.Text == "")
            {
                MessageBox.Show("Kamu belum mengisi form login");
            }
            else
            {
                MessageBox.Show("Username atau Password Salah");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
