namespace ActividadEvaluada
{
    public partial class Main : Form
    {
        // Matriz para temperaturas: [regiones, meses]
        public double[,] matrizTemperaturas = new double[10, 12]; // 10 regiones, 12 meses
        public double[,] matrizPrecipitaciones = new double[10, 12];
        public Main()
        {
            InitializeComponent();
            // Establecer la imagen de fondo del formulario
            this.BackgroundImage = Image.FromFile("C:\\Users\\dell.ARRUPE\\source\\repos\\ActividadEvaluada\\Imagenes\\fondo.jpg"); // Cambia la ruta
            this.BackgroundImageLayout = ImageLayout.Stretch;
            // Hacer el fondo del GroupBox transparente
            groupBox1.BackColor = Color.Transparent;

            label1.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRedirigirIngresar.Text = "Ingresar Datos";

            btnRedirigirEstadistica.Text = "Ver Estadísticas";
            btnRedirigirGraficos.Text = "Ver Gráficos";
            btnSalir.Text = "Salir";
            label1.ForeColor = Color.White;
            // Llamamos a la función para habilitar los botones si hay datos en la matriz
            ActualizarEstadoBotones();
            DeclararBotonSalir();
        }
        //
        //Apartado Visual
        //
        private void DeclararBotonSalir()
        {
            btnSalir.BackColor = Color.FromArgb(255, 204, 204); // Color pastel para
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(255, 150, 150);
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.ForeColor = Color.Black;
        }
        //
        //Fin del apartado visual
        //
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRedirigirIngresar_Click(object sender, EventArgs e)
        {
            FormularioEntradaDatos form1 = new FormularioEntradaDatos(matrizTemperaturas, matrizPrecipitaciones);
            form1.ShowDialog(); // Espera a que se cierre antes de continuar por eso invoco este metodo en vez del otro
            ActualizarEstadoBotones(); // Verifica si la matriz cambió
        }

        private void ActualizarEstadoBotones()
        {
            bool tieneElementos = ContieneElementos(matrizTemperaturas);
            btnRedirigirEstadistica.Enabled = tieneElementos;
            btnRedirigirGraficos.Enabled = tieneElementos;
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            // Cada vez que la ventana principal vuelva a activarse, se verifican los datos
            ActualizarEstadoBotones();
        }

        public bool ContieneElementos(double[,] matriz)
        {
            foreach (double temp in matriz)
            {
                if (temp != 0)
                {
                    return true; // La matriz tiene al menos un valor distinto de 0
                }
            }
            return false; // Todos los valores son 0
        }
        //redirigir a estadistica
        private void btnRedirigirEstadistica_Click(object sender, EventArgs e)
        {
            FormularioEstadisticas form2 = new FormularioEstadisticas(matrizTemperaturas, matrizPrecipitaciones);
            form2.ShowDialog(); // Espera a que se cierre antes de continuar por eso invoco este metodo en vez del otro
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRedirigirGraficos_Click(object sender, EventArgs e)
        {
            FormularioDeGraficos form3 = new FormularioDeGraficos(matrizTemperaturas, matrizPrecipitaciones);
            form3.ShowDialog();
        }
    }
}
