using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
            SqlConnection DB = new SqlConnection("server=MOHAMMED-FADIL; DataBase=Mofa_Connect; Integrated Security=true");
            SqlDataAdapter data = new SqlDataAdapter("select * from Data_Entery",DB);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource=dt;
        }

        private void B_save_Click(object sender, EventArgs e)
        {
            SqlConnection DB = new SqlConnection("server=MOHAMMED-FADIL; DataBase=Mofa_Connect; Integrated Security=true");

            if (text_description.Text == "")
            {
                MessageBox.Show("please Enter the Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (text_data.Text == "")
            {
                MessageBox.Show("please Enter the Data ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (text_bond.Text == "")
            {
                MessageBox.Show("please Enter the Bond Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (text_certify.Text == "")
            {
                MessageBox.Show("please Enter the The certifying body", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (text_name_person.Text == "")
            {
                MessageBox.Show("please Enter the Name Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // if   (text_notice.Text == "")
            //{
            //MessageBox.Show("please Enter the Name Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            if (text_amount.Text == "")
            {
                MessageBox.Show("please Enter the Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (text_createby.Text == "")
            {
                MessageBox.Show("please Enter the create By", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dtp1.Value == null)
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
                    SqlCommand DR = new SqlCommand(sql, DB);
                    DR.Parameters.AddWithValue("@1", text_description.Text);
                    DR.Parameters.AddWithValue("@2", text_data.Text);
                    DR.Parameters.AddWithValue("@3", Convert.ToDouble(text_amount.Text));
                    DR.Parameters.AddWithValue("@4", Convert.ToInt32(text_bond.Text));
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

        private void b_delet_Click(object sender, EventArgs e)
        {
            SqlConnection DB = new SqlConnection("server=MOHAMMED-FADIL; DataBase=Mofa_Connect; Integrated Security=true");
            DB.Open();
            SqlCommand up = new SqlCommand("Update Data_Entery", DB);
            SqlDataAdapter data = new SqlDataAdapter("select * from Data_Entery", DB);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            DB.Close();
            MessageBox.Show("Successfully Update");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection DB = new SqlConnection("server=MOHAMMED-FADIL; DataBase=Mofa_Connect; Integrated Security=true");
            DB.Open();
            string qr = "select * from Data_Entery";
            if (textBox1.Text != "")
                qr += "where name || id like '%" + textBox1.Text + "'%";
            SqlCommand down = new SqlCommand(qr, DB);
            SqlDataAdapter con = new SqlDataAdapter(down);
            DataTable dt = new DataTable();
            con.Fill(dt);
            dataGridView1.DataSource=dt;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void b_update_Click(object sender, EventArgs e)
        {

        }
    }
}
