using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadEvaluada
{
    public partial class FormularioEstadisticas : Form
    {
        private double[,] matrizTemperaturas;
        private double[,] matrizPrecipitaciones;
        public FormularioEstadisticas(double[,] matrizTemperaturas, double[,] matrizPrecipitaciones)
        {
            InitializeComponent();
            this.matrizPrecipitaciones = matrizPrecipitaciones;
            this.matrizTemperaturas = matrizTemperaturas;
        }

        private void FormularioEstadisticas_Load(object sender, EventArgs e)
        {
            DeclararBotonSalir();
            DeclararBotonCalcular();
            // Configurar las columnas del DataGridView
            dgDatos.ReadOnly = true;
            dgDatos.Columns.Add("Region", "Región");
            dgDatos.Columns.Add("Mes", "Mes");
            dgDatos.Columns.Add("Temperatura", "Temperatura (°C)");
            dgDatos.Columns.Add("Precipitacion", "Precipitación (mm)");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void DeclararBotonCalcular()
        {
            btnCalcular.BackColor = Color.FromArgb(173, 216, 230); // Color pastel azul
            btnRegresar.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 112);
            btnCalcular.ForeColor = Color.Black;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.FlatAppearance.BorderSize = 0;
        }

        private void DeclararBotonSalir()
        {
            btnRegresar.BackColor = Color.FromArgb(255, 204, 204); // Color pastel para
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.FlatAppearance.BorderColor = Color.FromArgb(255, 150, 150);
            btnRegresar.FlatAppearance.BorderSize = 2;
            btnRegresar.ForeColor = Color.Black;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dgDatos.Rows.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear(); // Limpiar el ListBox de promedios

            // Obtener la región seleccionada en el ComboBox
            int regionSeleccionada = cmbRegion.SelectedIndex;

            // Verificar si se seleccionó una región válida
            if (regionSeleccionada < 0 || regionSeleccionada >= matrizTemperaturas.GetLength(0))
            {
                MessageBox.Show("Selecciona una región válida.");
                return;
            }

            // Obtener el nombre de la región seleccionada
            string nombreRegion = ObtenerNombreRegion(regionSeleccionada);

            // Lista para almacenar temperaturas de la región seleccionada
            List<Tuple<string, string, double>> temperaturas = new List<Tuple<string, string, double>>();

            // Recorrer los meses para la región seleccionada
            for (int mes = 0; mes < matrizTemperaturas.GetLength(1); mes++)
            {
                double temperatura = matrizTemperaturas[regionSeleccionada, mes];
                double precipitacion = matrizPrecipitaciones[regionSeleccionada, mes];

                // Agregar una fila al DataGridView para cada mes
                int indice = dgDatos.Rows.Add(
                    nombreRegion,
                    ObtenerNombreMes(mes),
                    temperatura,
                    precipitacion
                );

                // Resaltar temperaturas altas
                if (temperatura > 30)
                {
                    dgDatos.Rows[indice].Cells["Temperatura"].Style.BackColor = Color.Red;
                    dgDatos.Rows[indice].Cells["Temperatura"].Style.ForeColor = Color.White;
                }

                // Resaltar precipitaciones altas
                if (precipitacion > 50)
                {
                    dgDatos.Rows[indice].Cells["Precipitacion"].Style.BackColor = Color.Blue;
                    dgDatos.Rows[indice].Cells["Precipitacion"].Style.ForeColor = Color.White;
                }

                // Agregar a la lista de temperaturas para ordenar después
                temperaturas.Add(new Tuple<string, string, double>(nombreRegion, ObtenerNombreMes(mes), temperatura));
            }

            // Ordenar temperaturas de menor a mayor
            temperaturas.Sort((x, y) => x.Item3.CompareTo(y.Item3));

            // Llenar ListBox de menor a mayor
            foreach (var temp in temperaturas)
            {
                listBox1.Items.Add($"{temp.Item1} - {temp.Item2}: {temp.Item3}°C");
            }

            // Llenar ListBox de mayor a menor
            for (int i = temperaturas.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Add($"{temperaturas[i].Item1} - {temperaturas[i].Item2}: {temperaturas[i].Item3}°C");
            }

            // Calcular promedios para la región seleccionada
            double sumaTemperatura = 0;
            double sumaPrecipitacion = 0;
            int contadorTemperatura = 0; // Contador para temperaturas válidas
            int contadorPrecipitacion = 0; // Contador para precipitaciones válidas

            for (int mes = 0; mes < matrizTemperaturas.GetLength(1); mes++)
            {
                double temperatura = matrizTemperaturas[regionSeleccionada, mes];
                double precipitacion = matrizPrecipitaciones[regionSeleccionada, mes];

                // Sumar para el promedio solo si la temperatura no es 0
                if (temperatura != 0)
                {
                    sumaTemperatura += temperatura;
                    contadorTemperatura++;
                }

                // Sumar para el promedio solo si la precipitación no es 0
                if (precipitacion != 0)
                {
                    sumaPrecipitacion += precipitacion;
                    contadorPrecipitacion++;
                }
            }

            // Calcular promedios (solo si hay valores válidos)
            double promedioTemperatura = 0;
            double promedioPrecipitacion = 0;

            if (contadorTemperatura > 0)
            {
                promedioTemperatura = sumaTemperatura / contadorTemperatura;
            }

            if (contadorPrecipitacion > 0)
            {
                promedioPrecipitacion = sumaPrecipitacion / contadorPrecipitacion;
            }

            // Mostrar promedios en listBox3
            listBox3.Items.Add($"Promedios para la región {nombreRegion}:");
            listBox3.Items.Add($"Temperatura Promedio = {promedioTemperatura:F2}°C");
            listBox3.Items.Add($"Precipitación Promedio = {promedioPrecipitacion:F2}mm");

            // Decorar los ListBox
            DecorarListBox(listBox1, Color.LightBlue);
            DecorarListBox(listBox2, Color.LightCoral);
            DecorarListBox(listBox3, Color.LightGreen); // Color para el ListBox de promedios
        }

        
        private void DecorarListBox(ListBox listBox, Color color)
        {
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                listBox.Items[i] = listBox.Items[i].ToString();
            }
            listBox.BackColor = color;
        }

        // Método para obtener el nombre de la región por el índice
        private string ObtenerNombreRegion(int indice)
        {
            string[] regiones = { "Norte", "Sur", "Este", "Oeste", "Centro", "Costa", "Montaña", "Selva", "Desierto", "Valle" };
            return regiones[indice];
        }

        // Método para obtener el nombre del mes según el índice
        private string ObtenerNombreMes(int indice)
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            return meses[indice];
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         reciclar este codigo
        
            // Llenar ListBox de menor a mayor
            for (int i = 0; i < temperaturas.Count; i++)
            {
                listBox1.Items.Add($"{temperaturas[i].Item1} - {temperaturas[i].Item2}: {temperaturas[i].Item3}°C");
            }

            // Llenar ListBox de mayor a menor
            for (int i = temperaturas.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Add($"{temperaturas[i].Item1} - {temperaturas[i].Item2}: {temperaturas[i].Item3}°C");
            }

         */
    }
}