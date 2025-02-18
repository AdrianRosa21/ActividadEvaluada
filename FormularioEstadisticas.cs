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

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
