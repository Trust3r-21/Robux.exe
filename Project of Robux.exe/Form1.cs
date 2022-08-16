namespace robux.exe
{
    public partial class Form1 : Form
    {
        String username;
        String password;
        String robux;
        String path = @"C:\Users\JACOPO\Desktop";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username != null && password != null && robux != null)
            {
                username = "";
                password = "";
                robux = "";

                StreamWriter sw = new StreamWriter(path + @"\useThisLink.txt");
                sw.WriteLine("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                sw.Flush();
                sw.Close();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            robux = richTextBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }
    }
}