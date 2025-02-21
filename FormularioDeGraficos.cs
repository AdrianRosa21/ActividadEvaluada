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
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ActividadEvaluada
{
    public partial class FormularioDeGraficos : Form
    {

        private double[,] matrizTemperaturas;

        private double[,] matrizPrecipitaciones;

        public FormularioDeGraficos(double[,] matrizTemperaturas, double[,] matrizPrecipitaciones)
        {
            InitializeComponent();
            this.matrizPrecipitaciones = matrizPrecipitaciones;
            this.matrizTemperaturas = matrizTemperaturas;
            ConfigurarGrafico();


        }

        private void FormularioDeGraficos_Load(object sender, EventArgs e)
        {
            cmbRegiones.DropDownStyle = ComboBoxStyle.DropDownList;
            DeclararBoton(btnCalcular, Color.FromArgb(173, 216, 230)); // Azul pastel
            DeclararBoton(btnRegresar, Color.FromArgb(255, 204, 204)); // Rosa pastel
            cmbRegiones.SelectedIndex = 0;
            logo.Image = Image.FromFile("C:\\Users\\dell.ARRUPE\\source\\repos\\ActividadEvaluada\\Imagenes\\grafico.png");
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void DeclararBoton(Button boton, Color colorFondo)
        {
            boton.BackColor = colorFondo;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.ForeColor = Color.Black;
        }

        // Configuración del gráfico
        private void ConfigurarGrafico()
        {
            chartTemperatura.BackColor = Color.Transparent;
            chartTemperatura.BorderlineColor = Color.FromArgb(255, 182, 193);
            chartTemperatura.BorderlineDashStyle = ChartDashStyle.Solid;

            // Ejes
            var area = chartTemperatura.ChartAreas[0];
            area.AxisX.LineColor = Color.FromArgb(204, 204, 204);
            area.AxisY.LineColor = Color.FromArgb(204, 204, 204);
            area.AxisX.LabelStyle.ForeColor = Color.DarkSlateGray;
            area.AxisY.Minimum = -25;
            area.AxisY.Maximum = 40;
            area.AxisY.Interval = 5;

            // Leyenda
            chartTemperatura.Legends[0].BackColor = Color.FromArgb(255, 240, 240);
            chartTemperatura.Legends[0].Font = new Font("Arial", 8, FontStyle.Italic);
        }





        private void cmbRegiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbRegiones.SelectedIndex < 0) return;

            int regionSeleccionada = cmbRegiones.SelectedIndex;

            // GRÁFICO DE TEMPERATURAS
            chartTemperatura.Series.Clear();
            var areaTemp = chartTemperatura.ChartAreas[0];
            areaTemp.AxisX.Interval = 1;
            areaTemp.AxisX.IsMarginVisible = false;
            areaTemp.AxisX.LabelStyle.Angle = -45;
            areaTemp.AxisY.Minimum = -25;
            areaTemp.AxisY.Maximum = 40;
            areaTemp.AxisY.Interval = 5;
            areaTemp.AxisX.Title = "Meses";
            areaTemp.AxisY.Title = "Temperatura (°C)";

            Series serieTemperatura = new Series("Temperatura")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(255, 153, 153), // Rojo claro pastel (#FF9999)
                IsValueShownAsLabel = true,
                BorderWidth = 1,
                BorderColor = Color.Black
            };
            serieTemperatura["PointWidth"] = "0.4";

            for (int mes = 0; mes < 12; mes++)
            {
                serieTemperatura.Points.AddXY(mes + 1, matrizTemperaturas[regionSeleccionada, mes]);
            }

            chartTemperatura.Series.Add(serieTemperatura);

            // GRÁFICO DE PRECIPITACIONES 
            chartPrecipitaciones.Series.Clear();
            var areaPrec = chartPrecipitaciones.ChartAreas[0];
            areaPrec.AxisX.Interval = 1;
            areaPrec.AxisX.IsMarginVisible = false;
            areaPrec.AxisX.LabelStyle.Angle = -45;
            areaPrec.AxisY.Minimum = 0;
            areaPrec.AxisY.Maximum = 100;
            areaPrec.AxisY.Interval = 10;
            areaPrec.AxisX.Title = "Meses";
            areaPrec.AxisY.Title = "Precipitación (mm)";

            Series seriePrecipitacion = new Series("Precipitación")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(0, 51, 102), // Azul oscuro (#003366)
                IsValueShownAsLabel = true,
                BorderWidth = 1,
                BorderColor = Color.Black
            };
            seriePrecipitacion["PointWidth"] = "0.4";

            for (int mes = 0; mes < 12; mes++)
            {
                seriePrecipitacion.Points.AddXY(mes + 1, matrizPrecipitaciones[regionSeleccionada, mes]);
            }

            chartPrecipitaciones.Series.Add(seriePrecipitacion);
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
