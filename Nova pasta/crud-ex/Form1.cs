namespace crud_ex
{
    public partial class Form1 : Form
    {
        string nome, sobrenome, curso, RM;
        int ano, idade;
 
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            nome = textBoxNome.Text;
            sobrenome = textBoxSobrenome.Text;
            curso = textBoxCurso.Text;
            RM = textBoxRM.Text;
        }
    }
}
