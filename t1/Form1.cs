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

namespace t1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=JEEWANTHA-I5\JEEWANTHASQL;Initial Catalog=Test;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO tbl_insertion(Id,FName,LName,Age,Gender,Address) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Insert Success!!!");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM tbl_insertion";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = " UPDATE tbl_insertion SET FName ='" + textBox1.Text + "',LName = '" + textBox2.Text + "',Age = '" + textBox3.Text + "',Gender = '" + comboBox1.Text + "',Address ='" + textBox5.Text + "'    WHERE Id = '" + textBox1.Text + "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Success!!!");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "DELETE FROM tbl_insertion WHERE Id ='" + textBox1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete Success!!!");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
