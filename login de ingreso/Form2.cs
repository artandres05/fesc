using WinFormsApp3;

namespace login_de_ingreso
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, contraseña;
            usuario = textBox1.Text;
            contraseña = textBox2.Text;
            if (usuario == "hola10" && contraseña == "12345")
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.FormClosed += (s, args) => this.Close();
                form1.Show();
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecta");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }
    }
}