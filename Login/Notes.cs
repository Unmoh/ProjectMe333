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
using System.Data.SqlClient;
//using WindowsFormsApplication4;


namespace WindowsFormsApplication3
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
            SqlConnection DB = new SqlConnection("server=MOHAMMED-FADIL; DataBase=Mofa_Connect; Integrated Security=true");
            SqlDataAdapter data = new SqlDataAdapter("select * from notes", DB);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView2.DataSource = dt;

        }
        SqlConnection DB = new SqlConnection("Data source=MOHAMMED-FADIL; Initial Catalog=Mofa_Connect;  Integrated Security=true");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login.Home home = new Login.Home();
            home.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            label1.Visible = false;

            if (textBox1.Text == "")
            {
                label1.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panel7.Visible == false)
            {
                panel7.Visible = true;
            }
            else
            {
                panel7.Visible = false;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Login.Home home = new Login.Home();
            home.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Login.DataEntry dataEntry = new Login.DataEntry();
            dataEntry.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Financial financial = new Financial();
            financial.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Login.Attendance attendance = new Login.Attendance();
            attendance.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Notes notes = new Notes();
            notes.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Login.Account account = new Login.Account();
            account.Show();
            this.Hide();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login.Account account = new Login.Account();
            account.Show();
            this.Hide();
        }

        private void Notes_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DB.Open();
            SqlCommand cd = new SqlCommand("insert into notes(lable=" + text_lable.Text + "date=" + dtp1.Value + "description=" + richtxt.Text + "", DB);
            SqlDataAdapter adapter = new SqlDataAdapter(cd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGridView2.DataSource = tb;

            //if (richtxt.Text == null)
            //{
            //    MessageBox.Show("Please Enter This Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    try
            //    {
            //        DB.Open();
            //        //string sql = "$insert into notes(lable="+text_lable.Text+"date"+dtp1.Value+"description"+richtxt.Text+")" +

            //        SqlCommand cd = new SqlCommand("insert into notes(lable=" + text_lable.Text + "date=" + dtp1.Value + "description=" + richtxt.Text + "", DB);
            //        // Not.Parameters.AddWithValue("@1", text_lable.Text);
            //        // Not.Parameters.AddWithValue("@2",dtp1.Value);
            //        //Not.Parameters.AddWithValue("@3", richtxt.Text);
            //        // Not.ExecuteNonQuery();
            //        MessageBox.Show("تمت اضافه الملاحظة");

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    finally
            //    {
            //        DB.Close();
            //    }


            //}
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            SqlConnection DB = new SqlConnection("server=MOHAMMED-FADIL; DataBase=Mofa_Connect; Integrated Security=true");
            DB.Open();
            SqlCommand up = new SqlCommand("Update notes", DB);
            SqlDataAdapter data = new SqlDataAdapter("select * from notes", DB);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            DB.Close();
            MessageBox.Show("Successfully Update");
        }
    }
}
