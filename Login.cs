﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection DB = new SqlConnection("Data source=MOHAMMED-FADIL; Initial Catalog=Mofa_Connect;  Integrated Security=true");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //SqlConnection cmd = new SqlConnection("server=MOHAMMED-FADIL; DataBase=Mofa_Connect; Integrated Security=true");
            DB.Open();
            SqlCommand con = new SqlCommand("select from users where (name,paa)"+
            $"values('{(textBox1.Text)}','{(textBox3.Text)}')",DB);
            SqlDataAdapter da = new SqlDataAdapter(con);
            DataTable Mo = new DataTable();
            da.Fill(Mo);

            if(Mo.Rows.Count > 0)
            {
                Home ho = new Home();
                ho.ShowDialog();
            }
            else
            {
                MessageBox.Show("خطأ");
                DB.Close();
            }
            
            //String sql = $"select * from users(name,pass)" +
            //    $"values (@1,@2)";
            //SqlCommand d = new SqlCommand(sql, DB);
            //d.Parameters.AddWithValue("@1", textBox1);
            //d.Parameters.AddWithValue("@2", textBox3);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}