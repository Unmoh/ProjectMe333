using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3;
//using WindowsFormsApplication4;


namespace Login
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //label1.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Entry dt = new Entry();
            dt.Show();
            this.Close();
        } 

        private void button3_Click(object sender, EventArgs e)
        {
            Attendance adden = new Attendance();
            adden.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Financial finamcial = new Financial();
            finamcial.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Notes notices = new Notes();
            notices.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
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

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            label1.Visible = false;

            if (textBox1.Text == "")
            {
                label1.Visible = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            
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

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Hide();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Hide();
        }
    }
}
