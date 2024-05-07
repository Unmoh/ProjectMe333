using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using WindowsFormsApplication3;
//using WindowsFormsApplication4;


namespace Login
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Visible = false;

            if (textBox1.Text == "")
            {
                label1.Visible = true;
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you admin?","Admin or No", MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login1 = new Login();
                login1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sorry, You aren't admin");
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           Home home = new Home();
           home.Show();
           this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == false)
            {
                panel4.Visible = true;
            }
            else
            {
                panel4.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataEntry dataEntry = new DataEntry();
            dataEntry.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Financial financial = new Financial();
            financial.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            attendance.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Notes notes = new Notes();
            notes.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Account account = new Account();
            account.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            Account account = new Account();
            account.Show();
            this.Hide();
        }
    }
}
