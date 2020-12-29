using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.Odbc;
using Npgsql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        NpgsqlConnection c1 = new NpgsqlConnection("server=localHost; port=5432; Database=Universite; user ID=postgres; password=Hasan.2901");
        public Form2()
        {
            InitializeComponent();
            string q1 = "Select id,ad from \"Bolum\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(q1, c1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        
        private void ekleButton_Click(object sender, EventArgs e)
        {
            c1.Open();
            NpgsqlCommand ekleme = new NpgsqlCommand("insert into \"Ogrenci\"(id, ad, soyad, TCKNo, ogrenciNo, \"bolumNo\") values(@p1,@p2,@p3,@p4,@p5,@p6)", c1);
            ekleme.Parameters.AddWithValue("@p1", int.Parse(textBox6.Text));
            ekleme.Parameters.AddWithValue("@p2", textBox1.Text);
            ekleme.Parameters.AddWithValue("@p3", textBox2.Text);
            ekleme.Parameters.AddWithValue("@p4", textBox3.Text);
            ekleme.Parameters.AddWithValue("@p5", textBox4.Text);
            ekleme.Parameters.AddWithValue("@p6", int.Parse(textBox5.Text));
            ekleme.ExecuteNonQuery();
            c1.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            c1.Open();
            NpgsqlCommand silme = new NpgsqlCommand("Delete from \"Ogrenci\" where id=@p1", c1);
            silme.Parameters.AddWithValue("@p1", int.Parse(textBox6.Text));
            silme.ExecuteNonQuery();
            c1.Close();
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void ListeleButton_Click(object sender, EventArgs e)
        {
            string q2 = "Select id,ad,soyad,tckno,ogrencino,\"bolumNo\" from \"Ogrenci\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(q2, c1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c1.Open();
            NpgsqlCommand guncelle = new NpgsqlCommand("update \"Ogrenci\" set ad=@p1, soyad=@p2, \"bolumNo\"=@p3 where id=@p4", c1);
            guncelle.Parameters.AddWithValue("@p1", textBox1.Text);
            guncelle.Parameters.AddWithValue("@p2", textBox2.Text);
            guncelle.Parameters.AddWithValue("@p3", int.Parse(textBox5.Text));
            guncelle.Parameters.AddWithValue("@p4", int.Parse(textBox6.Text));
            guncelle.ExecuteNonQuery();
            c1.Close();
        }
    }
}
