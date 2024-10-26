using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool user_correct = false;
            string username = textBox1.Text;
            string password = textBox2.Text;
            for (int i = 0; i < Form1.userIndex; i++)
            {
                if (username == Form1.usernames[i] &&
                    password == Form1.passwords[i])
                {
                    user_correct = true;
                    break;
                }
            }
            if (user_correct == false)
            {
                richTextBox1.Text = "User is not found";
            }
            else
            {
                richTextBox1.Text = "User is found";
                notifyIcon1.BalloonTipTitle = "New message!";
                notifyIcon1.BalloonTipText = "User is found";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(3000);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
