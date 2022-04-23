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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static public string regName;

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void login_Click(object sender, EventArgs e)
        {
            fdsfsd newform = new fdsfsd();
            regName = textBox1.Text;
            try
            {
                if (regName == "admin")
                {
                    Form4 adm = new Form4();
                    adm.Show();
                    this.Hide();
                }
                else
                {
                    Form3.Book Found = Form3.UsersBook.Find(item => item.Name == regName);
                    Console.WriteLine(Found.Name);
                    this.Hide();
                    newform.Show();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ошибка в имени пользователя");
            }
        }
        public void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createacc_Click(object sender, EventArgs e)
        {
            Form3 newform = new Form3();
            newform.Show();
            this.Hide();
        }
    }
}