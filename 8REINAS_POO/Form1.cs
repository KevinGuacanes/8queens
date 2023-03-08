namespace _8REINAS_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            FormularioTablero VentanaTablero = new FormularioTablero();
            VentanaTablero.Show();

        }
       
    }
}