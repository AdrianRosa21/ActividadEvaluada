namespace ActividadEvaluada
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRedirigirIngresar.Text = "Ingresar Datos";
            btnRedirigirEstadistica.Text = "Ver Estad�sticas";
            btnRedirigirGraficos.Text = "Ver Gr�ficos";
            btnSalir.Text = "Salir";
        }


        private void salir()
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void btnRedirigirIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}
