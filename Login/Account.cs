using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            label4.Visible = false;

            if (textBox2.Text == "")
            {
                label4.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == false)
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label5.Visible = false;

            if (textBox3.Text == "")
            {
                label5.Visible = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label6.Visible = false;

            if (textBox4.Text == "")
            {
                label6.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (textBox1.Text == "")
            {
                label1.Visible = true;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Account account = new Account();
            account.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
