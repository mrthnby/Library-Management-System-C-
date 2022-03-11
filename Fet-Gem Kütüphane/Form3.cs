using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        void listele1()
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
            dtr = new OleDbDataAdapter("SElect *from kitaplar", bag);
            ds = new DataSet();
            bag.Open();
            dtr.Fill(ds, "kitaplar");
            dataGridView1.DataSource = ds.Tables["kitaplar"];
            bag.Close();
        }
        void listele()
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
            dtr = new OleDbDataAdapter("SElect *from kitaplar", bag);
            ds = new DataSet();
            bag.Open();
            dtr.Fill(ds, "kitaplar");
            dataGridView2.DataSource = ds.Tables["kitaplar"];
            bag.Close();

        }
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection bag;
        OleDbCommand kmt;
        OleDbDataAdapter dtr;
        DataSet ds;
        private void button1_Click(object sender, EventArgs e)
        {
            //Admin username and password
            string kadi = "admin";
            string şif = "admin";
            if (textBox1.Text == kadi && textBox2.Text == şif)
            {
                panel2.Visible = true;
                textBox1.Text = "";
                textBox2.Text = "";


            }
            else
            {
                MessageBox.Show("Kulanıcı adı veya şifre hatalı!", "HATA");
                textBox2.Text = "";
            }
        }



        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            panel6.Visible = true;
            panel10.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox11.Text != "")
            {
                bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
                kmt = new OleDbCommand();
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "insert into kitaplar (kitap_adi,kitaplik_no,raf_no,sira_no,yazar) values ('" + textBox3.Text + "','" + textBox11.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                kmt.ExecuteNonQuery();
                bag.Close();
                listele1();
                listele();
                textBox6.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                textBox3.Text = "";
                textBox11.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayın!");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
            dtr = new OleDbDataAdapter("SElect *from kitaplar where kitap_adi like '" + textBox7.Text + "%'", bag);
            ds = new DataSet();
            bag.Open();
            dtr.Fill(ds, "kitaplar");
            dataGridView1.DataSource = ds.Tables["kitaplar"];
            bag.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
            bag.Open();
            kmt = new OleDbCommand();
            kmt.Connection = bag;
            kmt.CommandText = "delete from kitaplar where kimlik=" + textBox8.Text + "";
            kmt.ExecuteNonQuery();
            bag.Close();
            listele1();
            listele();
            textBox7.Text = "";
            textBox8.Text = "";


        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
            dtr = new OleDbDataAdapter("SElect *from kitaplar where kitap_adi like '" + textBox10.Text + "%'", bag);
            ds = new DataSet();
            bag.Open();
            dtr.Fill(ds, "kitaplar");
            dataGridView2.DataSource = ds.Tables["kitaplar"];
            bag.Close();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
            dtr = new OleDbDataAdapter("SElect *from kitaplar where yazar like '" + textBox9.Text + "%'", bag);
            ds = new DataSet();
            bag.Open();
            dtr.Fill(ds, "kitaplar");
            dataGridView2.DataSource = ds.Tables["kitaplar"];
            bag.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            panel6.Visible = false;
            panel10.Visible = false;
            listele();
            listele1();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("SELECT COUNT(*) FROM erkek_istatistik", bag);
            label15.Text = kmt.ExecuteScalar().ToString();
            OleDbCommand kmt1 = new OleDbCommand("SELECT COUNT(*) FROM kiz_istatistik", bag);
            label14.Text = kmt1.ExecuteScalar().ToString();
            bag.Close();
            listele1();
            listele();

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = true;
            panel8.Visible = false;
            panel9.Visible = false;
            panel6.Visible = false;
            panel10.Visible = false;
            listele();
            listele1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = false;
            panel6.Visible = false;
            panel10.Visible = false;
            listele();
            listele1();
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            panel6.Visible = true;
            panel10.Visible = true;
            listele1();
            listele();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            panel6.Visible = true;
            panel10.Visible = true;
            listele1();
            listele();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "9")
            {
                panel11.Visible = true;
                panel12.Visible = false;
                panel13.Visible = false;
                panel14.Visible = false;
            }
            if (comboBox1.Text == "10")
            {
                panel12.Visible = true;
                panel11.Visible = false;
                panel13.Visible = false;
                panel14.Visible = false;
            }
            if (comboBox1.Text == "11")
            {
                panel13.Visible = true;
                panel12.Visible = false;
                panel11.Visible = false;
                panel14.Visible = false;
            }
            if (comboBox1.Text == "12")
            {
                panel14.Visible = true;
                panel11.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;
            }
        }

        private void panel11_VisibleChanged(object sender, EventArgs e)
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("SELECT COUNT(*) FROM dokuz_kiz", bag);
            label19.Text = kmt.ExecuteScalar().ToString();
            OleDbCommand kmt1 = new OleDbCommand("SELECT COUNT(*) FROM dokuz_erkek", bag);
            label20.Text = kmt1.ExecuteScalar().ToString();
            bag.Close();



        }

        private void panel12_VisibleChanged(object sender, EventArgs e)
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("SELECT COUNT(*) FROM on_erkek", bag);
            label21.Text = kmt.ExecuteScalar().ToString();
            OleDbCommand kmt1 = new OleDbCommand("SELECT COUNT(*) FROM on_kiz", bag);
            label22.Text = kmt1.ExecuteScalar().ToString();
            bag.Close();
        }

        private void panel13_VisibleChanged(object sender, EventArgs e)
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("SELECT COUNT(*) FROM onbir_kiz", bag);
            label26.Text = kmt.ExecuteScalar().ToString();
            OleDbCommand kmt1 = new OleDbCommand("SELECT COUNT(*) FROM onbir_erkek", bag);
            label25.Text = kmt1.ExecuteScalar().ToString();
            bag.Close();
        }

        private void panel14_VisibleChanged(object sender, EventArgs e)
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("SELECT COUNT(*) FROM oniki_kiz", bag);
            label30.Text = kmt.ExecuteScalar().ToString();
            OleDbCommand kmt1 = new OleDbCommand("SELECT COUNT(*) FROM oniki_erkek", bag);
            label29.Text = kmt1.ExecuteScalar().ToString();
            bag.Close();
        }
    }
}
