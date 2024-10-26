namespace Search
{
    public partial class Form1 : Form
    {
        public static string[] usernames = new string[128];
        public static string[] passwords = new string[128];
        public static int userIndex=0;

        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username=textBox1.Text;
            string password=textBox2.Text;

            if (textBox1.Text == string.Empty)
            {
                errorProvider1.SetError(textBox1, "Username Empty");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (textBox2.Text == string.Empty)
            {
                errorProvider2.SetError(textBox2, "Password Empty");
            }
            else
            {
                errorProvider2.Clear();
            }

            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                dataGridView1.Rows.Add(username, password, DateTime.Now);

                MessageBox.Show("Added");

                usernames[userIndex] = username;
                passwords[userIndex] = password;

                userIndex++;

            }


        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
