using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lovapp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        new public int Id_button = 1;

        private void button12_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            this.Hide();
            newform.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int i;
        void Form4_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
            for (i = 1; i <= Form3.UsersBook.Count(); i++)
            {
                comboBox1.Items.Add(i);
            }
        }
        void Switch(int idsh)
        {
            Form3.Book Found = Form3.UsersBook.Find(item => item.Id == idsh);
            string id = Convert.ToString(Found.Id);
            textBox2.Text = Found.Name;
            textBox1.Text = Found.Age;
            textBox3.Text = Found.Gender;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Index = comboBox1.SelectedItem.ToString();
            int Index_int = Convert.ToInt32(Index);
            Switch(Index_int);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(comboBox1.Text);
            Form3.Book Found = Form3.UsersBook.Find(item => item.Id == x);
            Found.Name = textBox2.Text;
            Found.Age = textBox1.Text;
            Found.Gender = textBox3.Text;
        }
    }
}
