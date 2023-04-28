namespace PrimerParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //imagen mostrar la mandamos al frente
            pictureMostrar.BringToFront();  
            // mostramos la contraseña
            textBox1.PasswordChar = '*';

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            pictureOcultar.BringToFront();
            //
            textBox1.PasswordChar = '\0';
        }
    }
}