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
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class Financial : Form
    {
        public Financial()
        {
            InitializeComponent();
        }
        SqlConnection DB = new SqlConnection("server=MOHAMMED-FADIL; DataBase=Mofa_Connect; Integrated Security=true");
        //public static String  conString = "Data source=MOHAMMED-FADIL; Initial Catalog=Mofa_Connect;  Integrated Security=true";
        //public static SqlConnection DB = new SqlConnection(conString);
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection DB = new SqlConnection("server=MOHAMMED-FADIL; DataBase=Mofa_Connect; Integrated Security=true");

            string query = "select amount,date from Data_Entry";
            SqlConnection connection = new SqlConnection("server=MOHAMMED-FADIL; DataBase=Mofa_Connect; Integrated Security=true");
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DateTime tody = DateTime.Today;
            //command.Parameters.AddWithValue("@startdate", tody);
            //command.Parameters.AddWithValue("@Enddate", tody.AddYears(1));
            DataTable table = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter(command);
            data.Fill(table);
            dataGridView1.DataSource = table;
            
            
            
            
            //// SqlDataAdapter sq = new SqlDataAdapter("select amount,data from Data_Entery",DB);
            
            
           ////// SqlCommand dat = new SqlCommand(sql, DB);
           //// DataTable dt = new DataTable();
           //// sq.Fill(dt);
           //// dataGridView1.DataSource=dt;
            

            
            
           
            
            
            //String date = DateTime.Today.ToString("yyyy-MM-dd");
            //label4.Text = date;
            //try
            //{
            //    DB.Open();
            //    String sql = $"SELECT SUM(amount) from Data_Entery where date = @1";
            //    SqlCommand cmd = new SqlCommand(sql, DB);
            //    cmd.Parameters.AddWithValue("@1", date);


            //    Object results = cmd.ExecuteScalar();
            //    if (results != null && results != DBNull.Value && results is IConvertible)
            //    {
            //        Double sum = Convert.ToDouble(results);
            //        label5.Text = "in convert process";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    DB.Close();
            //}

        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            dataGridView1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login.Home home = new Login.Home();
            home.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Login.Home home = new Login.Home();
            home.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login.DataEntry dataEntry = new Login.DataEntry();
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
            Login.Attendance attendance = new Login.Attendance();
            attendance.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            Notes notes = new Notes();
            notes.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
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
    }
}
