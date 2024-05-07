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



namespace Login
{
    public partial class DataEntry : Form
    {
        
        public DataEntry()
        {
            InitializeComponent();
        }
       static SqlConnection DB= new SqlConnection("servere=MOHAMMED-FADIL; DataBase=Mofa_Connect;  Integrated Security=true");
        
            
          
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           // SqlConnection con = new SqlConnection("Data source=MOHAMMED-FADIL; Initial Catalog=Mofa_Connect;  Integrated Security=true");
           //con.Open();

           // //استدعاء البيانات من الجدول 
           // string qr = "select * from Data_Entery";
           // if (textBox1.Text != "")
           // {
           //     qr += "where name like '%" + textBox1.Text + "%'";
           // }
           // SqlCommand cmd = new SqlCommand(qr, con);
            
           // label1.Visible = false;

           // if (textBox1.Text == "")
           // {
           //     label1.Visible = true;
           // }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you admin?", "Admin or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you admin?", "Admin or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you admin?", "Admin or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void bunifuCustomDataGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter ad = new SqlDataAdapter("select from Mofa_Connect", DB);
            //DataTable dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt;
            {
              
            }
            //if (text_id.Text == "")
            //{
              //  MessageBox.Show("Please Enter Th", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
            if (text_description.Text == "")
            {
                MessageBox.Show("please Enter the Description","Error" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if(text_data.Text == "")
            {
                MessageBox.Show("please Enter the Data ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(text_bond.Text == "")
            {
                MessageBox.Show("please Enter the Bond Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (text_certify.Text == "")
            {
                MessageBox.Show("please Enter the The certifying body", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(text_name_person.Text == "")
            {
                MessageBox.Show("please Enter the Name Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
               
            // if   (text_notice.Text == "")
            //{
                //MessageBox.Show("please Enter the Name Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
               
           if (text_amount .Text == "")
            {
                MessageBox.Show("please Enter the Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
                
                
            if (text_createby.Text == "")
            {
                MessageBox.Show("please Enter the create By", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
           if(dtp1.Value == null)
           {
             MessageBox.Show("Please Enter This Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           else
            {
                try
                {
                    DB.Open();
                    String sql = $"insert into Data_Entery(description,create_data,amount,bond_number,certifying_body,notice,name_person,create_by,date)" +
                    $"values (@1,@2,@3,@4,@5,@6,@7,@8,@9)";
                    SqlCommand DR = new SqlCommand(sql,DB);
                    DR.Parameters.AddWithValue("@1", text_description.Text);
                    DR.Parameters.AddWithValue("@2", text_data.Text);
                    DR.Parameters.AddWithValue("@3", Convert.ToDouble( text_amount.Text));
                    DR.Parameters.AddWithValue("@4", Convert.ToInt32( text_bond.Text));
                    DR.Parameters.AddWithValue("@5", text_certify.Text);
                    DR.Parameters.AddWithValue("@6", text_notice.Text);
                    DR.Parameters.AddWithValue("@7", text_name_person.Text);
                    DR.Parameters.AddWithValue("@8", text_createby.Text);
                    DR.Parameters.AddWithValue("@9", dtp1.Value);



                    // $"values('{text_description.Text}','{text_data.Text}','{text_amount.Text}','{text_bond.Text}','{text_certify.Text}','{text_notice.Text}','{text_name_person.Text}','{text_createby.Text}','{text_date.Text}')",DB);
                    DR.ExecuteNonQuery();
                    MessageBox.Show("Inserted");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DB.Close();
                }


            }
        
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            text_id.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].ToString();
            text_bond.Text= dataGridView1.Rows[e.RowIndex].Cells["bond_number"].ToString();
            text_name_person.Text = dataGridView1.Rows[e.RowIndex].Cells["name_person"].ToString();
        }
    }
}
