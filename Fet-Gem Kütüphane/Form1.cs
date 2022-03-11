using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        OleDbConnection bag;
        OleDbCommand kmt;
        OleDbCommand kmt1;
        OleDbCommand kmt2;
        OleDbCommand kmt3;
        OleDbCommand kmt4;
        OleDbDataAdapter dtr;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }
        void listeleemanet()
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
            dtr = new OleDbDataAdapter("SElect *from emanet", bag);
            ds = new DataSet();
            bag.Open();
            dtr.Fill(ds, "emanet");
            dataGridView1.DataSource = ds.Tables["emanet"];
            bag.Close();
        }
        void listeleiade()
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
            dtr = new OleDbDataAdapter("SElect *from emanet", bag);
            ds = new DataSet();
            bag.Open();
            dtr.Fill(ds, "emanet");
            dataGridView2.DataSource = ds.Tables["emanet"];
            bag.Close();
        }
        void kitaplistele()
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
            dtr = new OleDbDataAdapter("SElect *from kitaplar", bag);
            ds = new DataSet();
            bag.Open();
            dtr.Fill(ds, "kitaplar");
            dataGridView3.DataSource = ds.Tables["kitaplar"];
            bag.Close();

        }




        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = true;
            panel8.Visible = true;
            panel7.Visible = true;
            button6.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listeleemanet();
            listeleiade();
            kitaplistele();
            button6.Visible = true;

        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            paneliade.Visible = true;
            panel5.Visible = true;
            textBox10.Text = "KK/RR/SS";
            textBox10.ForeColor = Color.Silver;



        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            button6.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox10.Text != "" && textBox11.Text != "")
            {
                bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
                kmt = new OleDbCommand();
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "insert into emanet (ad_soyad,sinif,numara,kitapadi,kitap_yeri,tarih,sube) values ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox1.Text + "','" + textBox10.Text + "','" + textBox2.Text + "','" + textBox11.Text + "')";
                kmt.ExecuteNonQuery();
                bag.Close();
                listeleemanet();
                listeleiade();
                if (checkBox1.Checked)
                {
                    bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
                    kmt = new OleDbCommand();
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "insert into kiz_istatistik (ad_soyad,sinif,numara) values ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                    kmt.ExecuteNonQuery();
                    bag.Close();
                    listeleemanet();
                    if (textBox4.Text == "9")
                    {
                        bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
                        kmt = new OleDbCommand();
                        bag.Open();
                        kmt.Connection = bag;
                        kmt.CommandText = "insert into dokuz_kiz (ad_soyad,sinif,numara) values ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                        kmt.ExecuteNonQuery();
                        bag.Close();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox10.Text = "";
                        textBox11.Text = "";
                    }
                    if (textBox4.Text == "10")
                    {
                        bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
                        kmt = new OleDbCommand();
                        bag.Open();
                        kmt.Connection = bag;
                        kmt.CommandText = "insert into on_kiz (ad_soyad,sinif,numara) values ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                        kmt.ExecuteNonQuery();
                        bag.Close();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox10.Text = "";
                        textBox11.Text = "";
                    }
                    if (textBox4.Text == "11")
                    {
                        bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
                        kmt = new OleDbCommand();
                        bag.Open();
                        kmt.Connection = bag;
                        kmt.CommandText = "insert into onbir_kiz (ad_soyad,sinif,numara) values ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                        kmt.ExecuteNonQuery();
                        bag.Close();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox10.Text = "";
                        textBox11.Text = "";
                    }
                    if (textBox4.Text == "12")
                    {
                        bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
                        kmt = new OleDbCommand();
                        bag.Open();
                        kmt.Connection = bag;
                        kmt.CommandText = "insert into oniki_kiz (ad_soyad,sinif,numara) values ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                        kmt.ExecuteNonQuery();
                        bag.Close();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox10.Text = "";
                        textBox11.Text = "";
                    }
                }
                if (checkBox2.Checked)
                {
                    bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
                    kmt = new OleDbCommand();
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "insert into erkek_istatistik (ad_soyad,sinif,numara) values ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                    kmt.ExecuteNonQuery();
                    bag.Close();
                    listeleemanet();
                    if (textBox4.Text == "9")
                    {
                        bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
                        kmt.Connection = bag;
                        bag.Open();
                        kmt.CommandText = "insert into dokuz_erkek (ad_soyad,sinif,numara) values ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                        kmt.ExecuteNonQuery();
                        bag.Close();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox10.Text = "";
                        textBox11.Text = "";
                    }
                    if (textBox4.Text == "10")
                    {
                        bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
                        kmt.Connection = bag;
                        bag.Open();
                        kmt.CommandText = "insert into on_erkek (ad_soyad,sinif,numara) values ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                        kmt.ExecuteNonQuery();
                        bag.Close();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox10.Text = "";
                        textBox11.Text = "";
                    }
                    if (textBox4.Text == "11")
                    {
                        bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
                        kmt.Connection = bag;
                        bag.Open();
                        kmt.CommandText = "insert into onbir_erkek (ad_soyad,sinif,numara) values ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                        kmt.ExecuteNonQuery();
                        bag.Close();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox10.Text = "";
                        textBox11.Text = "";
                    }
                    if (textBox4.Text == "12")
                    {
                        bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
                        kmt.Connection = bag;
                        bag.Open();
                        kmt.CommandText = "insert into oniki_erkek (ad_soyad,sinif,numara) values ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                        kmt.ExecuteNonQuery();
                        bag.Close();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox10.Text = "";
                        textBox11.Text = "";
                    }
                }



            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız");

            }






        }

        private void button4_Click(object sender, EventArgs e)
        {
            listeleiade();
            listeleemanet();
            panel4.Visible = false;
            paneliade.Visible = true;
            panel5.Visible = false;


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
            dtr = new OleDbDataAdapter("SElect *from emanet where numara like '" + textBox6.Text + "%'", bag);
            ds = new DataSet();
            bag.Open();
            dtr.Fill(ds, "emanet");
            dataGridView2.DataSource = ds.Tables["emanet"];
            bag.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kmt = new OleDbCommand();
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "delete from emanet where kimlik=" + textBox7.Text + "";
            kmt.ExecuteNonQuery();
            bag.Close();
            listeleemanet();
            listeleiade();
            textBox7.Text = "";
            textBox6.Text = "";



        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            paneliade.Visible = true;
            panel5.Visible = true;
            kitaplistele();

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
            dtr = new OleDbDataAdapter("SElect *from kitaplar where kitap_adi like '" + textBox8.Text + "%'", bag);
            ds = new DataSet();
            bag.Open();
            dtr.Fill(ds, "kitaplar");
            dataGridView3.DataSource = ds.Tables["kitaplar"];
            bag.Close();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ktp.accdb");
            dtr = new OleDbDataAdapter("SElect *from kitaplar where yazar like '" + textBox9.Text + "%'", bag);
            ds = new DataSet();
            bag.Open();
            dtr.Fill(ds, "kitaplar");
            dataGridView3.DataSource = ds.Tables["kitaplar"];
            bag.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
            textBox10.ForeColor = Color.Black;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mrthnby");
        }
    }
}
