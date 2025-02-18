namespace ActividadEvaluada
{
    public partial class Main : Form
    {
        // Matriz para temperaturas: [regiones, meses]
        public double[,] matrizTemperaturas = new double[9, 11]; // 10 regiones, 12 meses

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRedirigirIngresar.Text = "Ingresar Datos";
            btnRedirigirEstadistica.Text = "Ver Estadísticas";
            btnRedirigirGraficos.Text = "Ver Gráficos";
            btnSalir.Text = "Salir";

            // Llamamos a la función para habilitar los botones si hay datos en la matriz
            ActualizarEstadoBotones();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRedirigirIngresar_Click(object sender, EventArgs e)
        {
            FormularioEntradaDatos form1 = new FormularioEntradaDatos(matrizTemperaturas);
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

    }
}
