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
    public partial class fdsfsd : Form
    {
        public fdsfsd()
        {
            InitializeComponent();
        }

        static public int ilike1;
        static public int ilike2;
        static public int ilike3;
        static public int ilike4;
        static public int pos1;
        static public int pos2;
        static public int pos3;
        static public int pos4;

        private void Form2_Load(object sender, EventArgs e)
        {
            Form3.Book Found = Form3.UsersBook.Find(item => item.Name == Form1.regName);
            this.BackColor = Color.Purple;
            this.StartPosition = FormStartPosition.CenterScreen;
            string id = Convert.ToString(Found.Id);
            string lk = Convert.ToString(Found.Likes);
            label8.Text = id;
            label4.Text = Found.Name;
            label5.Text = Found.Age;
            label6.Text = Found.Gender;
            label9.Text = lk;

            for (int i = 1; i <= Form3.UsersBook.Count(); i++)
            {
                Form3.Book Found2 = Form3.UsersBook.Find(item => item.Id == i);
                string z = Convert.ToString(i);
                string x = Convert.ToString(Found2.Likes);
                if (Found.Id == 1)
                {
                    if (i == Found.Id)
                    {
                        continue;
                    }
                    if (i == Found.Id + 1)
                    {
                        id1.Text = z;
                        name1.Text = Found2.Name;
                        age1.Text = Found2.Age;
                        gender1.Text = Found2.Gender;
                        likes1.Text = x;
                        pos1 = i;

                    }
                    if (i == Found.Id + 2)
                    {
                        id2.Text = z;
                        name2.Text = Found2.Name;
                        age2.Text = Found2.Age;
                        gender2.Text = Found2.Gender;
                        likes2.Text = x;
                        pos2 = i;
                    }
                    if (i == Found.Id + 3)
                    {
                        id3.Text = z;
                        name3.Text = Found2.Name;
                        age3.Text = Found2.Age;
                        gender3.Text = Found2.Gender;
                        likes3.Text = x;
                        pos3 = i;
                    }
                    if (i == Found.Id + 4)
                    {
                        id4.Text = z;
                        name4.Text = Found2.Name;
                        age4.Text = Found2.Age;
                        gender4.Text = Found2.Gender;
                        likes4.Text = x;
                        pos4 = i;
                    }
                }
                else if (Found.Id == 2)
                {
                    if (i == Found.Id)
                    {
                        continue;
                    }
                    if (i == Found.Id - 1)
                    {
                        id1.Text = z;
                        name1.Text = Found2.Name;
                        age1.Text = Found2.Age;
                        gender1.Text = Found2.Gender;
                        likes1.Text = x;
                        pos1 = i;
                    }
                    if (i == Found.Id + 1)
                    {
                        id2.Text = z;
                        name2.Text = Found2.Name;
                        age2.Text = Found2.Age;
                        gender2.Text = Found2.Gender;
                        likes2.Text = x;
                        pos2 = i;
                    }
                    if (i == Found.Id + 2)
                    {
                        id3.Text = z;
                        name3.Text = Found2.Name;
                        age3.Text = Found2.Age;
                        gender3.Text = Found2.Gender;
                        likes3.Text = x;
                        pos3 = i;
                    }
                    if (i == Found.Id + 3)
                    {
                        id4.Text = z;
                        name4.Text = Found2.Name;
                        age4.Text = Found2.Age;
                        gender4.Text = Found2.Gender;
                        likes4.Text = x;
                        pos4 = i;
                    }
                }
                else if (Found.Id == 3)
                {
                    if (i == Found.Id)
                    {
                        continue;
                    }
                    if (i == Found.Id - 2)
                    {
                        id1.Text = z;
                        name1.Text = Found2.Name;
                        age1.Text = Found2.Age;
                        gender1.Text = Found2.Gender;
                        likes1.Text = x;
                        pos1 = i;
                    }
                    if (i == Found.Id - 1)
                    {
                        id2.Text = z;
                        name2.Text = Found2.Name;
                        age2.Text = Found2.Age;
                        gender2.Text = Found2.Gender;
                        likes2.Text = x;
                        pos2 = i;
                    }
                    if (i == Found.Id + 1)
                    {
                        id3.Text = z;
                        name3.Text = Found2.Name;
                        age3.Text = Found2.Age;
                        gender3.Text = Found2.Gender;
                        likes3.Text = x;
                        pos3 = i;
                    }
                    if (i == Found.Id + 2)
                    {
                        id4.Text = z;
                        name4.Text = Found2.Name;
                        age4.Text = Found2.Age;
                        gender4.Text = Found2.Gender;
                        likes4.Text = x;
                        pos4 = i;
                    }
                }
                else if (Found.Id == 4)
                {
                    if (i == Found.Id)
                    {
                        continue;
                    }
                    if (i == Found.Id - 3)
                    {
                        id1.Text = z;
                        name1.Text = Found2.Name;
                        age1.Text = Found2.Age;
                        gender1.Text = Found2.Gender;
                        likes1.Text = x;
                        pos1 = i;
                    }
                    if (i == Found.Id - 2)
                    {
                        id2.Text = z;
                        name2.Text = Found2.Name;
                        age2.Text = Found2.Age;
                        gender2.Text = Found2.Gender;
                        likes2.Text = x;
                        pos2 = i;
                    }
                    if (i == Found.Id - 1)
                    {
                        id3.Text = z;
                        name3.Text = Found2.Name;
                        age3.Text = Found2.Age;
                        gender3.Text = Found2.Gender;
                        likes3.Text = x;
                        pos3 = i;
                    }
                    if (i == Found.Id + 1)
                    {
                        id4.Text = z;
                        name4.Text = Found2.Name;
                        age4.Text = Found2.Age;
                        gender4.Text = Found2.Gender;
                        likes4.Text = x;
                        pos4 = i;
                    }
                }
                else if (Found.Id == 5)
                {
                    if (i == Found.Id)
                    {
                        continue;
                    }
                    if (i == Found.Id - 4)
                    {
                        id1.Text = z;
                        name1.Text = Found2.Name;
                        age1.Text = Found2.Age;
                        gender1.Text = Found2.Gender;
                        likes1.Text = x;
                        pos1 = i;
                    }
                    if (i == Found.Id - 3)
                    {
                        id2.Text = z;
                        name2.Text = Found2.Name;
                        age2.Text = Found2.Age;
                        gender2.Text = Found2.Gender;
                        likes2.Text = x;
                        pos2 = i;
                    }
                    if (i == Found.Id - 2)
                    {
                        id3.Text = z;
                        name3.Text = Found2.Name;
                        age3.Text = Found2.Age;
                        gender3.Text = Found2.Gender;
                        likes3.Text = x;
                        pos3 = i;
                    }
                    if (i == Found.Id - 1)
                    {
                        id4.Text = z;
                        name4.Text = Found2.Name;
                        age4.Text = Found2.Age;
                        gender4.Text = Found2.Gender;
                        likes4.Text = x;
                        pos4 = i;
                    }
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
            this.Hide();
            this.Update();
        }

        private void Like1_Click(object sender, EventArgs e)
        {
            Form3.Book Found3 = Form3.UsersBook.Find(item => item.Id == pos1);
            Found3.Likes++;
            string l1 = Convert.ToString(Found3.Likes);
            likes1.Text = l1;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3.Book Found3 = Form3.UsersBook.Find(item => item.Id == pos2);
            Found3.Likes++;
            string l1 = Convert.ToString(Found3.Likes);
            likes2.Text = l1;
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3.Book Found3 = Form3.UsersBook.Find(item => item.Id == pos3);
            Found3.Likes++;
            string l1 = Convert.ToString(Found3.Likes);
            likes3.Text = l1;
            button3.Enabled = false;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            Form3.Book Found3 = Form3.UsersBook.Find(item => item.Id == pos4);
            Found3.Likes++;
            string l1 = Convert.ToString(Found3.Likes);
            likes4.Text = l1;
            button4.Enabled = false;
        }
    }
}
