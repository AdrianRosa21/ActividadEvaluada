using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ActividadEvaluada
{
    public partial class FormularioDeGraficos : Form
    {

        private double[,] matrizTemperaturas;
        private int totalMeses;
        private double[,] matrizPrecipitaciones;

        public FormularioDeGraficos(double[,] matrizTemperaturas, double[,] matrizPrecipitaciones)
        {
            InitializeComponent();
            this.matrizPrecipitaciones = matrizPrecipitaciones;
            this.matrizTemperaturas = matrizTemperaturas;
            graficos();

        }

        private void FormularioDeGraficos_Load(object sender, EventArgs e)
        {
            cmbRegiones.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRegiones.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRegiones.Text = "Norte";
        }

        private void graficos()
        {
            // Gráfico
            chartTemperatura.BackColor = Color.Transparent; // Fondo transparente para el gráfico
            chartTemperatura.BorderlineColor = Color.FromArgb(255, 182, 193); // Borde suave

            chartTemperatura.BorderlineDashStyle = ChartDashStyle.Solid; // Borde continuo
                                                                         // Configuración de Ejes
            chartTemperatura.ChartAreas[0].AxisX.LineColor = Color.FromArgb(204, 204, 204); //
            chartTemperatura.ChartAreas[0].AxisY.LineColor = Color.FromArgb(204, 204, 204); //
            chartTemperatura.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.DarkSlateGray; //
            chartTemperatura.Legends[0].BackColor = Color.FromArgb(255, 240, 240); // Fondo suave
            chartTemperatura.Legends[0].Font = new Font("Arial", 8, FontStyle.Italic); // Estilo

        }




        private void cmbRegiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Esto pedirle ayuda a la seño porque estoy bien perdido

        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            // Obtener el nombre del estudiante seleccionado
            string regionSeleccionada = cmbRegiones.SelectedItem.ToString();
            // Limpiar series anteriores
            chartTemperatura.Series.Clear();

            // Crear una nueva serie para las materias
            Series serie = new Series(regionSeleccionada)
            {
                ChartType = SeriesChartType.Column, // Tipo de gráfico: barras
                Color = System.Drawing.Color.LightBlue, // Color de la serie
                IsValueShownAsLabel = true, // Mostrar las notas como etiquetas
                BorderWidth = 2 // Ancho de la barra
            };

            // Configurar el eje X para evitar superposiciones
            chartTemperatura.ChartAreas[0].AxisX.Interval = 1; // Espacio entre las barras
            chartTemperatura.ChartAreas[0].AxisX.IsMarginVisible = false; // Evitar márgenes innecesarios
            
        
        }
    }
}
